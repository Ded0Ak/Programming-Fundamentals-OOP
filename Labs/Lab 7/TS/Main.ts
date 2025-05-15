class Expression {
    private a: number;
    private b: number;
    private c: number;
    private d: number;

    constructor(a: number, b: number, c: number, d: number) {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    private calculateRoot(value: number): number {
        if (value < 0) {
            throw new Error("Invalid value for square root.");
        }
        return Math.sqrt(value);
    }

    public calculateExpression(): number {
        try {
            const numerator = this.a * this.b / 4 - 1;
            const denominatorExpression = 41 - this.d - this.b * this.a + this.c;
            const denominator = this.calculateRoot(denominatorExpression);
            return numerator / denominator;
        } catch (error) {
            throw new Error(`Error calculating expression: ${(error as Error).message}`);
        }
    }
}

const expressions = [
    new Expression(10, 5, 2, 1),
    new Expression(3, 6, 1, 40), 
    new Expression(4, 4, 3, 10),
];

expressions.forEach(expr => {
    try {
        const result = expr.calculateExpression();
        console.log(`Result: ${result}`);
    } catch (error) {
        console.log(`Exception: ${(error as Error).message}`);
    }
});
