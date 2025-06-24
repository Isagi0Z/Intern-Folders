function createcounter(){
    let count=0;

    return function(){
        count++;
        console.log("Current count: ",count);
    };
}

let counter=createcounter();
counter();
counter();
counter();