let obj={
    name: "Rat",
    greet: () => {
        console.log(this.name);
    }
};

obj.greet();