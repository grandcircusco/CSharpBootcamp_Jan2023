export {}
interface Mountain {
    name: string;
    height: number;
}

let mountains:Mountain[] = [
    {
        name: "Kilimanjaro",
        height:19341
    },
    {
        name: "Everst",
        height:29029
    },
    {
        name: "Denali",
        height:20310
    },
];

function findNameOfTallestMountain(values:Mountain[]):string{
    // let tallest:Mountain = values[0];

    // values.forEach((m:Mountain) => {
    //     if(m.height > tallest.height){
    //         tallest = m;
    //     }
    // });

    // return tallest.name;

    let tallest:Mountain = values.reduce((prev, current) => prev.height > current.height ? prev : current);
    return tallest.name;
}

let name:string = findNameOfTallestMountain(mountains);
console.log(name);

//products

interface Product {
    name: string;
    price: number;
}

let products:Product[] = [
    {
        name:"Chewing Tobacco",
        price: 6.50
    },
    {
        name:"Minnows",
        price: 1.50
    },
    {
        name:"Dynamite",
        price: 10.49
    }
];

function calcAverageProductPrice(values:Product[]):number{
    // let total:number = 0;

    // values.forEach((p:Product) => {
    //     total += p.price;
    // });

    // return total / values.length;

    let total:number = values.reduce((total,current) => {
        return total + current.price;
    } ,0);

    return total/ values.length;
}

let avg: number = calcAverageProductPrice(products);
console.log(avg);

//inventory

interface InventoryItem {
    product: Product;
    quantity: number;
}

let Inventory:InventoryItem[] = [
    {
        product: {
            name: "motor",
            price:10.00
        },
        quantity:10
    },
    {
        product: {
            name: "Sensor",
            price:12.50
        },
        quantity:4
    },
    {
        quantity:20,
        product: {
            name: "LED",
            price:1.00
        }
    }
];


function calcInventoryValue(values:InventoryItem[]):number{
    // let total:number = 0;
    // values.forEach((i:InventoryItem) => {
    //     total += i.product.price * i.quantity;
    // });
    // return total;

    let total:number = values.reduce((total, current) => {
        return total + (current.product.price * current.quantity);
    },0);

    return total;
}

let totalValue:number = calcInventoryValue(Inventory);
console.log(totalValue);