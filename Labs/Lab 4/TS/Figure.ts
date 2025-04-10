export class Figure {
    protected A: [number, number];
    protected B: [number, number];
    protected C: [number, number];
    protected D: [number, number];

    constructor(a: [number, number], b: [number, number], c: [number, number], d: [number, number]) {
        this.A = a;
        this.B = b;
        this.C = c;
        this.D = d;
    }

    getSideLength(): number {
        return Math.sqrt(Math.pow(this.B[0] - this.A[0], 2) + Math.pow(this.B[1] - this.A[1], 2));
    }

    getVertices(): { A: [number, number], B: [number, number], C: [number, number], D: [number, number] } {
        return { A: this.A, B: this.B, C: this.C, D: this.D };
    }
}
