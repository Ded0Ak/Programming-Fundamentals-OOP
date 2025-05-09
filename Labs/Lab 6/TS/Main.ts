import { TextContainer } from "./TextContainer";
import { StringClass } from "./StringClass";

const textContainer = new TextContainer();
const str1 = new StringClass("Hello, world!");
const str2 = new StringClass("TypeScript is cool");

textContainer.addString(str1);
textContainer.addString(str2);

console.log("Total characters:", textContainer.countCharacters());
console.log("Find 'TypeScript':", textContainer.findString("TypeScript"));

textContainer.replaceCharacterInText("o", "0");

console.log("Updated text:", str1.getContent(), str2.getContent());
