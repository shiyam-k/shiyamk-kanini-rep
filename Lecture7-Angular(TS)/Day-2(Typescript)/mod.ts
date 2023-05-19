
class ProductStructure{
    productName : string 
    ProductPrice : number
    constructor(pName : string, pPrice : number){
       this.productName = pName
       this.ProductPrice = pPrice
    }
}


let shopProduct : ProductStructure[] = [new ProductStructure("product1", 100), new ProductStructure("product2", 200),new ProductStructure("product3", 300)]

export default function MergeName(array : string[]) : string {
    return array.join(".");
}
export function BuyProduct(userProduct : string) : number{
    let isProductAdded : boolean = false
    let price : number = 0
    for(let i : number = 0; i<shopProduct.length; i++){
        if(userProduct.toLowerCase() === shopProduct[i].productName){
            console.log("product Added")
            isProductAdded = true;
            price = shopProduct[i].ProductPrice;
        }
    }    
    if(!isProductAdded){
        console.log("product not found")
    }
    return price;
}

export function RemoveProduct(removeProduct : string ) : number{
    let isProductRemoved : boolean = false
    let price : number = 0
    for(let i : number = 0; i<shopProduct.length; i++){
        if(removeProduct.toLowerCase() === shopProduct[i].productName){
            isProductRemoved = true;
            price = shopProduct[i].ProductPrice;
        }
    }    
    
    return price;
    return;
}

export function CalculatePrice(productList : number[], userMoney : number){
    let totalCost : number = 0
    productList.forEach(product => {
        totalCost += product
    });
    if(userMoney < totalCost){
        console.log("not enough money")
    }
    else{
        console.log(`Total Cost ${totalCost}`)
        console.log(`User Paid ${userMoney}`)
        console.log("paid Successfully!!")
        console.log(`balance change ${userMoney - totalCost}`)
    }

}