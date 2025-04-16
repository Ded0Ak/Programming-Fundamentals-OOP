import { Strings } from "./Strings";
import { Symbols } from "./Symbols";
import { UppercaseLetters } from "./UppercaseLetters";

const str1: Strings = new Symbols("Hell* W*rld");
const str2: Strings = new UppercaseLetters("BeautifulBBb");

console.log(`Length of str1: ${str1.getLength()}`);
console.log(`Count of '*' in str1: ${str1.countSymbol("*")}`);
console.log(`Length of str2: ${str2.getLength()}`);
console.log(`Count of 'B' in str2: ${str2.countSymbol("B")}`);
