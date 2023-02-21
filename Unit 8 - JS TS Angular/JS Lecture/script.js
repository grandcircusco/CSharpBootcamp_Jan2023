console.log("Hello world!");
let x = "Justin";
let sum = 3 + 8;
console.log(sum);
sum += 10;
console.log(sum);

//JS IS DUMB SECTION
console.log(10 == "10"); //Loose comparison
console.log(10 === "10"); //strict comparison

console.log(7 != "7"); //Loose not equals
console.log(7 !== "7"); //strict not equals

//if
let value = 8;
if(value >= 10){
    console.log("Value is greater than 10");
}
else if(value === 9){
    console.log("Value is 9");
}
else{
    console.log("Value is less than 9");
}

//loops
for(let i = 0; i<=10; i++){
    console.log(i);
}

while(true){
    console.log("spam");
    break;
}

do{

} while(false); //false to prevent infinite loop

//JS Arrays
let names = [ "Justin", "Josh", "Billy"];
console.log(names);
names.push("Laura");
console.log(names);

names.forEach(n => console.log(n));

names.forEach((n) => {
    let result = n + " from GC";
    console.log(result);
});

/*splice(start)
splice(start, deleteCount)
splice(start, deleteCount, item1)
splice(start, deleteCount, item1, item2, itemN) */
// names.splice(2);
// names.splice(2, 1);
let removed = names.splice(2);
console.log(names);
console.log(removed);



//functions

function myFunction(){
    console.log("You called my function");
}

myFunction();

function myFunction2(p){
    return p + " is here";
}

console.log(myFunction2("Justin"));

//arrow function
arrowFunction = () => {
    console.log("This is an arrow function");
}

arrowFunction();

arrowFunction2 = (k) => {
    return k + " used the arrow function";
}

console.log(arrowFunction2("Justin"));

hello = (l) => l + " says Hello World";

console.log(hello("Boo"));

//Objects
let pet = {
    name: "Yumi",
    age: 8,
    species: "Cat"
};

console.log(pet);
pet.name = "Old lady";
console.log(pet);
pet.Anger = true;
console.log(pet);
delete pet.Anger;
console.log(pet);

//EXERCISE
let employees = [];

function AddEmployee(role, salary){
    let newEmployee = {
        Role: role,
        Salary: salary
    };

    employees.push(newEmployee);
}


function DisplayEmployees(){
    //console.log(employees);

    employees.forEach((e) => {
        console.log(`Role: ${e.Role}  Salary: $${e.Salary}`);
    });
}