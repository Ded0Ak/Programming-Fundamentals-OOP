export class StringManipulator {
    private value: string;

    constructor(value: string = "") {
        this.value = value;
    }

    getValue(): string {
        return this.value;
    }

    getLength(): number {
        return this.value.length;
    }

    sortDescending(): string {
        return this.value.split("").sort().reverse().join("");
    }
}