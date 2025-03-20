export class Triangle {
  private x1: number;
  private y1: number;
  private x2: number;
  private y2: number;
  private x3: number;
  private y3: number;

  constructor();
  constructor(
    x1: number,
    y1: number,
    x2: number,
    y2: number,
    x3: number,
    y3: number
  );
  constructor(triangle: Triangle);
  constructor(
    x1?: number | Triangle,
    y1?: number,
    x2?: number,
    y2?: number,
    x3?: number,
    y3?: number
  ) {
    if (x1 instanceof Triangle) {
      this.x1 = x1.x1;
      this.y1 = x1.y1;
      this.x2 = x1.x2;
      this.y2 = x1.y2;
      this.x3 = x1.x3;
      this.y3 = x1.y3;
    } else if (
      x1 !== undefined &&
      y1 !== undefined &&
      x2 !== undefined &&
      y2 !== undefined &&
      x3 !== undefined &&
      y3 !== undefined
    ) {
      this.x1 = x1;
      this.y1 = y1;
      this.x2 = x2;
      this.y2 = y2;
      this.x3 = x3;
      this.y3 = y3;
    } else {
      this.x1 = this.y1 = 0;
      this.x2 = 1;
      this.y2 = 0;
      this.x3 = 0;
      this.y3 = 1;
    }
  }


  perimeter(): number {
    return (
      this.distance(this.x1, this.y1, this.x2, this.y2) +
      this.distance(this.x2, this.y2, this.x3, this.y3) +
      this.distance(this.x3, this.y3, this.x1, this.y1)
    );
  }

  area(): number {
    return Math.abs(
      (this.x1 * (this.y2 - this.y3) +
        this.x2 * (this.y3 - this.y1) +
        this.x3 * (this.y1 - this.y2)) /
        2
    );
  }


  scale(factor: number): Triangle {
    return new Triangle(
      this.x1 * factor,
      this.y1 * factor,
      this.x2 * factor,
      this.y2 * factor,
      this.x3 * factor,
      this.y3 * factor
    );
  }

  add(other: Triangle): Triangle {
    return new Triangle(
      this.x1 + other.x1,
      this.y1 + other.y1,
      this.x2 + other.x2,
      this.y2 + other.y2,
      this.x3 + other.x3,
      this.y3 + other.y3
    );
  }

  toString(): string {
    return `Triangle: P=${this.perimeter().toFixed(2)}, A=${this.area().toFixed(
      2
    )}`;
  }

  private distance(x1: number, y1: number, x2: number, y2: number): number {
    return Math.sqrt((x2 - x1) ** 2 + (y2 - y1) ** 2);
  }
}
