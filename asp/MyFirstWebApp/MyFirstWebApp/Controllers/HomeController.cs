using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace VoiceBillWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AnalyzeSpeechWithGemini([FromBody] string transcript)
        {
            var apiKey = _configuration["Gemini:ApiKey"];
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new { text = $"From the sentence below, extract all item names and their quantities in JSON format. Text: \"{transcript}\". Format like: [{{\"name\":\"item\",\"quantity\":number}}]" }
                        }
                    }
                }
            };

            var response = await client.PostAsJsonAsync("https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key=" + apiKey, requestBody);
            var result = await response.Content.ReadFromJsonAsync<JsonElement>();

            string output = result.GetProperty("candidates")[0]
                                 .GetProperty("content")
                                 .GetProperty("parts")[0]
                                 .GetProperty("text")
                                 .GetString();

            try
            {
                var json = JsonDocument.Parse(output);
                return Json(json.RootElement);
            }
            catch
            {
                return Json(new { error = "Invalid JSON response from Gemini." });
            }
        }
    }
}
