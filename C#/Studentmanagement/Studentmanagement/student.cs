
namespace StudentApp
{
	internal class student
	{
		private string v2;

		public student()
		{
		}

		public student(string v, int v1)
		{
		}

		public student(string v, int v1, string v2) : this(v, v1)
		{
			this.v2 = v2;
		}

		internal void DisplayInfo()
		{
			throw new NotImplementedException();
		}
	}
}