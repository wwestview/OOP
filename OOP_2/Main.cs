using Matrix;
using System;
namespace MyMatrixApp
{
    class MyMatrixApp
    {
        static void Main()
        {
            double[,] initialArray = { { 2, 9, 0 }, { 3, 7, 1 }, { -4, -4, 0 } };
            MyMatrix matrix1 = new MyMatrix(initialArray);
            MyMatrix matrixCopy = new MyMatrix(matrix1);

            Console.WriteLine("First calculation of the determinant:");
            double det1 = matrix1.CalcDeterminant(); 
            Console.WriteLine("Determinant: " + det1);

            Console.WriteLine("\nSecond calculation of the determinant without changes:");
            double det2 = matrix1.CalcDeterminant(); 
            Console.WriteLine("Determinant: " + det2);

            Console.WriteLine("\nModifying an element in the matrix:");
            matrix1[0, 0] = 5; 

            Console.WriteLine("Third calculation of the determinant after modification:");
            double det3 = matrix1.CalcDeterminant(); 
            Console.WriteLine("Determinant: " + det3);

            
                  Console.WriteLine("Adding two matrices:\n" + (matrix1 + matrixCopy));
                  Console.WriteLine("Multiplying two matrices:\n" + (matrix1 * matrixCopy));

                  double[][] jaggedArray = new double[][] { new double[] { 0, 6, 7}, new double[] { 9, 0, 5 }, new double[] { 5, 6, 0 } };
                  MyMatrix matrix3 = new MyMatrix(jaggedArray);
                  Console.WriteLine("Matrix from a jagged array:\n" + matrix3);
                  Console.WriteLine("Determinant: " + matrix3.CalcDeterminant());

                  string[] stringRows = { "65 24 23", "2 15 34", "56 54 13" };
                  MyMatrix matrix4 = new MyMatrix(stringRows);
                  Console.WriteLine("Matrix from an array of strings:\n" + matrix4);

                  string matrixString = "0 1 3\n5 4 5\n7 5 6";
                  MyMatrix matrix5 = new MyMatrix(matrixString);
                  Console.WriteLine("Matrix from a single string:\n" + matrix5);
                  Console.WriteLine("Determinant: " + matrix5.CalcDeterminant());
            

        }
    }
}
