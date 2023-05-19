"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.ToLowerCase = exports.StringCut = exports.ReturnMin = exports.UniqueNumbers = exports.ArrayJoin = exports.ReturnUpperCases = exports.CheckPalindrome = void 0;
function GetEvenNumbers() {
    var array = [];
    var i;
    for (i = 0; i < 10; i++) {
        array[i] = Math.floor(Math.random() * (10 - 1 + 1)) + 1;
    }
    var x = 0;
    console.log("Array is [".concat(array, "]"));
    array.forEach(function (element) {
        if (element % 2 == 0) {
            x += element;
        }
    });
    return x;
}
exports.default = GetEvenNumbers;
function CheckPalindrome(word) {
    var wordRev = "";
    for (var i = word.length - 1; i > -1; i--) {
        wordRev += word[i];
    }
    if (wordRev === word) {
        return true;
    }
    return false;
}
exports.CheckPalindrome = CheckPalindrome;
function ReturnUpperCases(wordArray) {
    var result = []; // Initialize result as an empty array
    for (var i = 0; i < wordArray.length; i++) {
        if (wordArray[i] === wordArray[i].toUpperCase()) {
            result.push(wordArray[i]);
        }
    }
    return result;
}
exports.ReturnUpperCases = ReturnUpperCases;
function ArrayJoin(array1, array2) {
    var joinArray = array1;
    array2.forEach(function (element) {
        joinArray.push(element);
    });
    return joinArray;
}
exports.ArrayJoin = ArrayJoin;
function UniqueNumbers(array) {
    var result = [];
    for (var i = 0; i < array.length; i++) {
        var count = 0;
        for (var j = 0; j < array.length; j++) {
            if (array[i] == array[j]) {
                count++;
            }
        }
        if (count == 1) {
            result.push(array[i]);
        }
    }
    return result;
}
exports.UniqueNumbers = UniqueNumbers;
function ReturnMin(array) {
    var min = Number.MAX_SAFE_INTEGER;
    for (var i = 0; i < array.length; i++) {
        if (min > array[i]) {
            min = array[i];
        }
    }
    return min;
}
exports.ReturnMin = ReturnMin;
function StringCut(word, index) {
    return word.slice(0, index - 1);
}
exports.StringCut = StringCut;
function ToLowerCase(array) {
    for (var i = 0; i < array.length; i++) {
        array[i] = array[i].toLowerCase();
    }
    return array;
}
exports.ToLowerCase = ToLowerCase;
