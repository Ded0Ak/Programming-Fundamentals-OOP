import { Strings } from "./Strings";

export class Symbols extends Strings {
  constructor(value: string) {
    super(value);
  }

  countSymbol(): number {
    return super.countSymbol("*");
  }
}
