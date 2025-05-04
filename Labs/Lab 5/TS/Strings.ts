export class Strings {
  protected value: string;

  constructor(value: string) {
    this.value = value;
  }

  getLength(): number {
    return this.value.length;
  }

  countSymbol(symbol: string): number {
    let count = 0;
    for (let c of this.value) {
      if (c === symbol) {
        count++;
      }
    }
    return count;
  }
}
