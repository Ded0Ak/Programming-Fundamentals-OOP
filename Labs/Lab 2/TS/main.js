"use strict";
/*
 * Done by:
 * Student Name: David Hrytsenok
 * Student Group: B-121-24-1-SE
 * Lab 1.2 TS
 */
Object.defineProperty(exports, "__esModule", { value: true });
var MyStrManip_1 = require("./MyStrManip");
var readline = require("readline").createInterface({
    input: process.stdin,
    output: process.stdout
});
readline.question("Enter a string: ", function (input) {
    var str = new MyStrManip_1.StringManipulator(input);
    console.log("Original string: ".concat(str.getValue()));
    console.log("String length: ".concat(str.getLength()));
    console.log("Sorted string: ".concat(str.sortDescending()));
    readline.close();
});
