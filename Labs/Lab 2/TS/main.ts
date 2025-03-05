/*
 * Done by:
 * Student Name: David Hrytsenok
 * Student Group: B-121-24-1-SE
 * Lab 1.2 TS
 */

import { StringManipulator } from "./MyStrManip";   

const readline = require("readline").createInterface({
    input: process.stdin,
    output: process.stdout
});

readline.question("Enter a string: ", (input: string) => {
    const str = new StringManipulator(input);

    console.log(`Original string: ${str.getValue()}`);
    console.log(`String length: ${str.getLength()}`);
    console.log(`Sorted string: ${str.sortDescending()}`);

    readline.close();
});