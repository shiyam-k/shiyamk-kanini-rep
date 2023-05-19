"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Calc = require("./mod");




console.log("Enter Input 1:");
var n1 = parseInt();
console.log("Enter Input 2:");
var n2 = parseInt(prompt());
console.log("Addition of ".concat(n1, " and ").concat(n2, " is ").concat(Calc.Add(n1, n2)));
console.log("Subtraction of ".concat(n1, " and ").concat(n2, " is ").concat(Calc.Sub(n1, n2)));
console.log("Multiplication of ".concat(n1, " and ").concat(n2, " is ").concat(Calc.Mul(n1, n2)));
console.log("Division of ".concat(n1, " and ").concat(n2, " is ").concat(Calc.Div(n1, n2)));
