import { Strings } from "./Strings";

export class UppercaseLetters extends Strings {
  constructor(value: string) {
    super(value);
  }

  countSymbol(): number {
    return super.countSymbol("B");
  }
}
