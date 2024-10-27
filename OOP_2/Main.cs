using Matrix;
using System;
namespace MyMatrixApp
{
    class MyMatrixApp
    {
        static void Main()
        {
            // 1. Constructor: Copying from another instance
            double[,] initialArray = { { 1, 4, 6 }, { 8, 13, 9 }, { 6, 7, 5 } };
            MyMatrix matrix1 = new MyMatrix(initialArray);
            MyMatrix matrixCopy = new MyMatrix(matrix1);
            Console.WriteLine("Matrix created by copying from another instance:");
            Console.WriteLine(matrixCopy);
            Console.WriteLine("Determinant: "+ Math.Floor(matrixCopy.CalcDeterminant()));
            Console.WriteLine("Adding two matrices: \n" + (matrix1+matrixCopy));
            Console.WriteLine("Multiply two matrices: ");
            Console.WriteLine(matrix1*matrixCopy);

            // 2. Constructor: From a 2D array of type double[,]
            double[,] array = { { 44, 12, 4 }, { 6, 6, 5 }, { 12, 3, 10 } };
            MyMatrix matrix2 = new MyMatrix(array);
            Console.WriteLine("Matrix created from a 2D array of type double[,]:");
            Console.WriteLine(matrix2);
            Console.WriteLine("Determinant: " + Math.Floor(matrix2.CalcDeterminant()));

            // 3. Constructor: From a jagged array double[][]
            double[][] jaggedArray = new double[][]
            {
                new double[] { 15, 23, 25 },
                new double[] { 14, 23, 8 },
                new double[] { 17, 16, 19 }
            };
            MyMatrix matrix3 = new MyMatrix(jaggedArray);
            Console.WriteLine("Matrix created from a jagged array double[][]:");
            Console.WriteLine(matrix3);

            // 4. Constructor: From an array of strings (each row of the matrix is a string)
            string[] stringRows = { "65 24 23", "2 15 27", "56 54 13" };
            MyMatrix matrix4 = new MyMatrix(stringRows);
            Console.WriteLine("Matrix created from an array of strings:");
            Console.WriteLine(matrix4);

            // 5. Constructor: From a single string representing the whole matrix
            string matrixString = "0 1 4\n5 4 5\n7 5 6";
            MyMatrix matrix5 = new MyMatrix(matrixString);
            Console.WriteLine("Matrix created from a single string:");
            Console.WriteLine(matrix5);
            Console.WriteLine("Determinant: " + Math.Floor(matrix5.CalcDeterminant()));
        }
    }
}
