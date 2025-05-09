import { ICharacterReplacer } from "./ICharacterReplacer";

export class StringClass implements ICharacterReplacer {
    private content: string;

    constructor(content: string) {
        this.content = content;
    }

    getContent(): string {
        return this.content;
    }

    setContent(content: string): void {
        this.content = content;
    }

    replaceCharacter(oldChar: string, newChar: string): void {
        this.content = this.content.split(oldChar).join(newChar);
    }
}
