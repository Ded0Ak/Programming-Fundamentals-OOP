/*
 * Done by:
 * Student Name: David Hrytsenok
 * Student Group: B-121-24-1-SE
 * Lab 1.3 TS
 */

import { Triangle } from "./Triangle";

let T1 = new Triangle();
let T2 = new Triangle(2, 3, 5, 8, 7, 5);
let T3 = new Triangle(T2); 

T3 = T3.scale(2);
T1 = T3.add(T2);

console.log("Triangle T1:", T1.toString());
console.log("Triangle T2:", T2.toString());
console.log("Triangle T3:", T3.toString());
