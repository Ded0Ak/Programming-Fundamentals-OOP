using System;

class CharMatrix
{
    private char[,] matrix;

    public CharMatrix(char[,] inputMatrix)
    {
        matrix = inputMatrix;
    }

    public string this[int column]
    {
        get
        {
            if (column < 0 || column >= matrix.GetLength(1))
                throw new IndexOutOfRangeException("Column index is out of bounds.");
                
            string result = "";
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                result += matrix[row, column];
            }
            return result;
        }
    }

    public int DigitCount
    {
        get
        {
            int count = 0;
            foreach (char ch in matrix)
            {
                if (char.IsDigit(ch))
                    count++;
            }
            return count;
        }
    }

    public void PrintMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        char[,] data = {
            { '1', 'A', '3' },
            { 'B', '2', 'C' },
            { '5', '4', 'E' }
        };

        CharMatrix matrix = new CharMatrix(data);

        matrix.PrintMatrix();

        Console.WriteLine("\nString from column 0: " + matrix[0]);
        Console.WriteLine("String from column 1: " + matrix[1]);
        Console.WriteLine("String from column 2: " + matrix[2]);

        Console.WriteLine($"Total number of digits in the matrix: {matrix.DigitCount}");
    }
}
