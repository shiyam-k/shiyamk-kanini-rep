import GetEvenNumbers from "./mod"
import { CheckPalindrome } from "./mod"
import { ReturnUpperCases } from "./mod"
import { ArrayJoin } from "./mod"
import { UniqueNumbers } from "./mod"
import { ReturnMin } from "./mod"
import { StringCut } from "./mod"
import { ToLowerCase } from "./mod"
console.log()
console.log(`1.Sum of even numbers in an array ${GetEvenNumbers()}`)
console.log()
console.log(`2.Is Panindrome ${CheckPalindrome("pipp")}`)
console.log()
console.log(`3.UpperCase Result Array [${ReturnUpperCases(["HI","hi","THIS","this", "IS","is","MAYIHS","mayihs"])}]`)
console.log()
console.log(`4.Join Array [${ArrayJoin(["Hi", "this"], ["is", "shiyam","k"])}]`)
console.log()
console.log(`5.Unique Numbers [${UniqueNumbers([1,1,2,4,4,3,3,5,6,8,9,7,7])}]`)
console.log()
console.log(`6.Min Integer [${ReturnMin([-1,1,2,4,4,3,3,5,6,8,9,7,7])}]`)
console.log()
console.log(`7.String Cut ${StringCut("Hola Amigos", 5)}`)
console.log()
console.log(`8.To LowerCase [${ToLowerCase(["HI, ThIs", "MaYiHs"])}]`)
console.log()