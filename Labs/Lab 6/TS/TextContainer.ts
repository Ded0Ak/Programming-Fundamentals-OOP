import { StringClass } from "./StringClass";

export class TextContainer {
    private strings: StringClass[];

    constructor() {
        this.strings = [];
    }

    addString(str: StringClass): void {
        this.strings.push(str);
    }

    removeString(str: StringClass): void {
        this.strings = this.strings.filter(s => s !== str);
    }

    clearText(): void {
        this.strings = [];
    }

    countCharacters(): number {
        return this.strings.reduce((acc, str) => acc + str.getContent().length, 0);
    }

    findString(searchStr: string): number {
        return this.strings.filter(str => str.getContent().includes(searchStr)).length;
    }

    replaceCharacterInText(oldChar: string, newChar: string): void {
        this.strings.forEach(str => str.replaceCharacter(oldChar, newChar));
    }
}
