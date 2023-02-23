"use strict";
exports.__esModule = true;
var mountains = [
    {
        name: "Kilimanjaro",
        height: 19341
    },
    {
        name: "Everst",
        height: 29029
    },
    {
        name: "Denali",
        height: 20310
    },
];
function findNameOfTallestMountain(values) {
    // let tallest:Mountain = values[0];
    // values.forEach((m:Mountain) => {
    //     if(m.height > tallest.height){
    //         tallest = m;
    //     }
    // });
    // return tallest.name;
    var tallest = values.reduce(function (prev, current) { return prev.height > current.height ? prev : current; });
    return tallest.name;
}
var name = findNameOfTallestMountain(mountains);
console.log(name);
var products = [
    {
        name: "Chewing Tobacco",
        price: 6.50
    },
    {
        name: "Minnows",
        price: 1.50
    },
    {
        name: "Dynamite",
        price: 10.49
    }
];
function calcAverageProductPrice(values) {
    // let total:number = 0;
    // values.forEach((p:Product) => {
    //     total += p.price;
    // });
    // return total / values.length;
    var total = values.reduce(function (total, current) {
        return total + current.price;
    }, 0);
    return total / values.length;
}
var avg = calcAverageProductPrice(products);
console.log(avg);
var Inventory = [
    {
        product: {
            name: "motor",
            price: 10.00
        },
        quantity: 10
    },
    {
        product: {
            name: "Sensor",
            price: 12.50
        },
        quantity: 4
    },
    {
        quantity: 20,
        product: {
            name: "LED",
            price: 1.00
        }
    }
];
function calcInventoryValue(values) {
    // let total:number = 0;
    // values.forEach((i:InventoryItem) => {
    //     total += i.product.price * i.quantity;
    // });
    // return total;
    var total = values.reduce(function (total, current) {
        return total + (current.product.price * current.quantity);
    }, 0);
    return total;
}
var totalValue = calcInventoryValue(Inventory);
console.log(totalValue);
