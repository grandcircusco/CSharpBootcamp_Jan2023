// let run = true;
// while (run) {
//   let name = prompt("Please enter your name");
//   console.log(name);

//   if (name.length < 2) {
//     alert("That name was too short.");
//   } else {
//     alert(`Hello ${name}`);
//     run = false;
//   }
// }

//Alerts/Prompts are annoying. Avoid using

//. = class
//# = id
//div or p or h1 = element
let redNode = document.querySelector(".red");
redNode.style.color = "red";

let blueNode = document.querySelector(".blue");
blueNode.style.color = "blue";

document.querySelector(".yellow").style.color = "yellow";

let loremNode = document.querySelector("#lorem");
loremNode.innerText = "This used to be a lorem";

//targeting multiple elements
let foodNodes = document.querySelectorAll(".food");

//querySelectorAll returns an array
foodNodes.forEach((element) => {
    element.style.fontSize = "50px";
});

//collect all with id="purpleBG" 
//loop through them
//set backgroundColor = "purple"

let purpleNodes = document.querySelectorAll("#purpleBG");
purpleNodes.forEach((element) => {
    element.style.backgroundColor = "purple";
});

//Creating new HTML
document.body.innerHTML += `<p id="purpleBG">Oops</p>`;

//Inner text is much safer when dealing with user input
//document.body.innerText += `Hi my name is ` + prompt("Enter name");


function UpdateBackground(){
    let inputNode = document.querySelector(".bgInput");
    let color = inputNode.value;
    document.body.style.backgroundColor = color;
}