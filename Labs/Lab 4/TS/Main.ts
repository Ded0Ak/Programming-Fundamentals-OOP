/*
 * Done by:
 * Student Name: David Hrytsenok
 * Student Group: B-121-24-1-SE
 * Lab 2.1 CS
 */
import { Square } from "./Square";

const square = new Square([0, 0], [0, 3], [3, 3], [3, 0]);

console.log("Vertices:", square.getVertices());
console.log("Side length:", square.getSideLength());
console.log("Perimeter:", square.getPerimeter());
console.log("Area:", square.getArea());
