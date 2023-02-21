let Cart = [];

function AddToCart(name, price) {
    let newItem = {
        Name: name,
        Price: price
    };

    //quantity
    let quantity = prompt("How many would you like to purchase?",1);

    //change status
    document.querySelector(".status").innerText = `Added ${quantity} ${name}(s) to the cart`;
    
    for(let i = 0; i < quantity; i++){
        Cart.push(newItem);

        //dom manipulation
        // . for class
        // # for id
        // h1 for element
        document.querySelector(".cart").innerHTML += `<li>${newItem.Name} $${newItem.Price}</li>`;
        // document.querySelector(".cart").innerText += `${newItem.Name} $${newItem.Price}`;
        // document.querySelector(".cart").innerHTML += "</li>";

        let total = 0;

        Cart.forEach((item) => {
            total += item.Price;
        });

        document.querySelector(".total").innerText = total.toFixed(2);
        document.querySelector(".tax").innerText = (total * 0.06).toFixed(2);
        document.querySelector(".Gtotal").innerText = ((total * 0.06) + total).toFixed(2);

        // let currentTotal = Number(document.querySelector(".total").innerText);

        // document.querySelector(".total").innerText = (currentTotal + price).toFixed(2);
    }
    
    
}


DisplayCart = () => {
    let total = 0;

    Cart.forEach((i) => {
        console.log(`${i.Name} $${i.Price}`);
        total += i.Price;
    });
    
    //tax
    let tax = total * 0.06;
    let grandTotal = total + tax;
    console.log(`Total = ${total.toFixed(2)}`);
    console.log(`Tax = ${tax.toFixed(2)}`);
    console.log(`Grand Total = ${grandTotal.toFixed(2)}`);

    document.querySelector(".cart").innerHTML = "";
    document.querySelector(".tax").innerHTML = "0.00";
    document.querySelector(".Gtotal").innerHTML = "0.00";
    document.querySelector(".total").innerText = "0.00";
    Cart = [];
    console.log("The cart has been cleared");
    document.querySelector(".status").innerText = `Cart purchased for $${grandTotal.toFixed(2)}. Cart cleared.`
}