using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrix
{
    partial class MyMatrix
    {
        public static MyMatrix operator +(MyMatrix a, MyMatrix b)
        {

            if (a.Height != b.Height || a.Width != b.Width)
            {
                throw new ArgumentException("The matrix must be the same size");
            }

            MyMatrix result = new MyMatrix(a);

            for (int i = 0; i < a.Height; i++)
            {
                for (int j = 0; j < a.Width; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }

            return result;
        }
    
        public static MyMatrix operator *(MyMatrix a, MyMatrix b)
        {
            if (a.Height != b.Height || a.Width != b.Width) 
                    {
                    throw new ArgumentException("The matrix must be the same size"); 
                    }
            MyMatrix result = new MyMatrix(new double[a.Height, b.Width]);

            for (int i = 0; i < a.Height; i++)
            {
                for (int j = 0; j < b.Width; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < a.Width; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
        private double[,] GetTransponedArray()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] transposed = new double[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }
            return transposed;
        }
        public void PrintTranspose()
        {
            double[,] transposedArray = GetTransponedArray();
            for (int i = 0; i < transposedArray.GetLength(0); i++)
            {
                for (int j = 0; j < transposedArray.GetLength(1); j++)
                {
                    Console.Write(transposedArray[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public MyMatrix GetTransponedCopy()
        {
            double[,] transposedArray = GetTransponedArray();
            return new MyMatrix(transposedArray);

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
        static void Main(string[] args)
        {
            /* MyMatrix matrixA = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
             MyMatrix matrixB = new MyMatrix(new double[,] { { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } });
             MyMatrix matrixC = matrixA + matrixB;
             Console.WriteLine("Matrix 1:");
             Console.WriteLine(matrixA);
             Console.WriteLine("Matrix 2:");
             Console.WriteLine(matrixB);
             Console.WriteLine("Result of addition:");
             Console.WriteLine(matrixC);
             */
            double[,] initialMatrix = { { 1, 2, 3 }, { 4, 5, 6 } };
            MyMatrix myMatrix = new MyMatrix(initialMatrix);

            Console.WriteLine("Original Matrix:");
            myMatrix.PrintMatrix();

            MyMatrix transposedMatrix = myMatrix.GetTransponedCopy();
            Console.WriteLine("Transposed Matrix:");
            transposedMatrix.PrintMatrix();
        }
    }
}