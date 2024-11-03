using Matrix;
using System;
namespace MyMatrixApp
{
    class MyMatrixApp
    {
        static void Main()
        {
            // 1. Constructor: Copying from another instance
            double[,] initialArray = { { 2, 9, 0 }, { 3, 7, 1 }, { -4, -4, 0 } };
            MyMatrix matrix1 = new MyMatrix(initialArray);
            MyMatrix matrixCopy = new MyMatrix(matrix1);
            Console.WriteLine("Matrix created by copying from another instance:");
            Console.WriteLine(matrixCopy);
            double det = matrixCopy.CalcDeterminant();
            Console.WriteLine("Determinant: " + (det));

            Console.WriteLine("Adding two matrices: \n" + (matrix1 + matrixCopy));
            Console.WriteLine("Multiply two matrices: ");
            Console.WriteLine(matrix1 * matrixCopy);
            // 2. Constructor: From a 2D array of type double[,]
            double[,] array = { { 0, 12, 4 }, { 0, 6, 5 }, { 0, 3, 10 } };
            MyMatrix matrix2 = new MyMatrix(array);
            Console.WriteLine("Matrix created from a 2D array of type double[,]:");
            Console.WriteLine(matrix2);
            Console.WriteLine("Determinant: " + (matrix2.CalcDeterminant()));

            // 3. Constructor: From a jagged array double[][]
            double[][] jaggedArray = new double[][]
            {
                new double[] { 0, 6, 7 },
                new double[] { 9, 0, 5 },
                new double[] { 5, 6, 0 }
            };
            MyMatrix matrix3 = new MyMatrix(jaggedArray);
            Console.WriteLine("Matrix created from a jagged array double[][]:");
            Console.WriteLine(matrix3);
            Console.WriteLine(matrix3.CalcDeterminant());

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
            Console.WriteLine("Determinant: " + (matrix5.CalcDeterminant()));
        }
    }
}
