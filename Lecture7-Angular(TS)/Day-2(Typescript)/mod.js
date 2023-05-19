"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.CalculatePrice = exports.RemoveProduct = exports.BuyProduct = void 0;
var ProductStructure = /** @class */ (function () {
    function ProductStructure(pName, pPrice) {
        this.productName = pName;
        this.ProductPrice = pPrice;
    }
    return ProductStructure;
}());
var shopProduct = [new ProductStructure("product1", 100), new ProductStructure("product2", 200), new ProductStructure("product3", 300)];
function MergeName(array) {
    return array.join(".");
}
exports.default = MergeName;
function BuyProduct(userProduct) {
    var isProductAdded = false;
    var price = 0;
    for (var i = 0; i < shopProduct.length; i++) {
        if (userProduct.toLowerCase() === shopProduct[i].productName) {
            console.log("product Added");
            isProductAdded = true;
            price = shopProduct[i].ProductPrice;
        }
    }
    if (!isProductAdded) {
        console.log("product not found");
    }
    return price;
}
exports.BuyProduct = BuyProduct;
function RemoveProduct(removeProduct) {
    var isProductRemoved = false;
    var price = 0;
    for (var i = 0; i < shopProduct.length; i++) {
        if (removeProduct.toLowerCase() === shopProduct[i].productName) {
            isProductRemoved = true;
            price = shopProduct[i].ProductPrice;
        }
    }
    return price;
    return;
}
exports.RemoveProduct = RemoveProduct;
function CalculatePrice(productList, userMoney) {
    var totalCost = 0;
    productList.forEach(function (product) {
        totalCost += product;
    });
    if (userMoney < totalCost) {
        console.log("not enough money");
    }
    else {
        console.log("Total Cost ".concat(totalCost));
        console.log("User Paid ".concat(userMoney));
        console.log("paid Successfully!!");
        console.log("balance change ".concat(userMoney - totalCost));
    }
}
exports.CalculatePrice = CalculatePrice;
