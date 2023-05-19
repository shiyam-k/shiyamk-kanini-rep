
export default function GetEvenNumbers():number{
    var array : number[] = [];
    let i :number;
    for(i = 0; i<10; i++){
        array[i] = Math.floor(Math.random() * (10 - 1 + 1)) + 1;
    }
    var x:number = 0;
    console.log(`Array is [${array}]`);
    array.forEach((element) => {
        if (element % 2 == 0) {
          x += element;
        }
      });
    return x;
}
export function CheckPalindrome(word : string):boolean{
    let wordRev : string = "";
    for(let i : number = word.length-1; i > -1; i--){
        wordRev += word[i];
    }
    if(wordRev === word){
        return true;
    }
    return false;
}

export function ReturnUpperCases(wordArray : string[]):string[]{
    let result: string[] = []; // Initialize result as an empty array
  for (let i: number = 0; i < wordArray.length; i++) {
    if (wordArray[i] === wordArray[i].toUpperCase()) {
      result.push(wordArray[i]);
    }
  }
  return result;
}
export function ArrayJoin(array1 : string[], array2 : string[]) : string[] {
  let joinArray : string[] = array1
  array2.forEach(element => {
    joinArray.push(element)
  });
  return joinArray;
}

export function UniqueNumbers(array : number[]) : number[]{
  let result : number[] = []
  for(let i : number = 0; i<array.length; i++){
    let count  : number = 0;
    for(let j : number = 0; j<array.length; j++){
      if(array[i] == array[j]){
        count++; 
      }
    }
    if(count == 1){
      result.push(array[i])
    }
  }
  return result;
}
export function ReturnMin(array : number[]) : number {
  let min : number = Number.MAX_SAFE_INTEGER
  for(let i : number = 0; i<array.length; i++){
    if(min > array[i]){
      min = array[i]
    }
  }
  return min;
}
export function StringCut(word : string, index : number) : string{
  return word.slice(0, index-1)
}
export function ToLowerCase(array : string[]) : string[]{
  for(let i : number = 0; i<array.length; i++){
    array[i] = array[i].toLowerCase()
  }
  return array;
}