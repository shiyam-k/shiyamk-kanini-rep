import MergeName from "./mod";
import { BuyProduct } from "./mod";
import { RemoveProduct } from "./mod";
import { CalculatePrice } from "./mod";

let userBought : number[] = []


userBought.push(BuyProduct("product1"));
userBought.push(BuyProduct("product1"));
userBought.push(BuyProduct("product2"));
userBought.push(BuyProduct("pro"));
userBought.push(BuyProduct("product3"));

userBought.filter((price) => price == RemoveProduct("product1"))

console.log("================")
console.log(`Customer Name : ${MergeName(["K","Shiyam"])}`)
CalculatePrice(userBought, 1000)
console.log("================")
