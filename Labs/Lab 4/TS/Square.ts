import { Figure } from "./Figure";

export class Square extends Figure {
    constructor(a: [number, number], b: [number, number], c: [number, number], d: [number, number]) {
        super(a, b, c, d);
    }

    getPerimeter(): number {
        return 4 * this.getSideLength();
    }

    getArea(): number {
        return Math.pow(this.getSideLength(), 2);
    }
}
