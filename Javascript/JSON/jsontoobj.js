let user={
    name: "Ratish",
    age: 21,
    isStudent: true 
};

let packed=JSON.stringify(user);
console.log(packed);

let unpacked=JSON.parse(packed);
console.log(unpacked.name);