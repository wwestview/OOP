using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public partial class MyMatrix
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
                for (int j = 0; j < b.Height; j++)
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
        protected double[,] GetTransponedArray()
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
   
        public MyMatrix GetTransponedCopy()
        {
            return new MyMatrix(GetTransponedArray());
        }
        
        public void TransposeMe()
        {
            matrix = GetTransponedArray();
        }
        public double CalcDeterminant()
        {
            if (Height != Width) { throw new ArgumentException("Matrix must be square matrix."); }
            if (cachedDet.HasValue && !isMod) { return cachedDet.Value; }
            double[,] matrixCopy = (double[,])this.matrix.Clone();
            int n = Height;
            double det = 1;

            for (int i = 0; i < n; i++)
            {
                if (matrixCopy[i, i] == 0)
                {
                    bool swapped = false;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (matrixCopy[j, i] != 0)
                        {
                            SwapRows(matrixCopy, i, j);
                            det *= -1; 
                            swapped = true;
                            break;
                            
                        }
                    }
                    if (!swapped) return 0;
                }

                for (int j = i + 1; j < n; j++)
                {
                    double factor = matrixCopy[j, i] / matrixCopy[i, i];
                    for (int k = i; k < n; k++)
                    {
                        matrixCopy[j, k] -= factor * matrixCopy[i, k];
                    }
                }

                det *= matrixCopy[i, i];
            }

            cachedDet = det;
            isMod = false;
            return Math.Floor(det);
        }
        protected void SwapRows(double[,] array, int row1, int row2)
        {
            int cols = array.GetLength(1);
            for (int i = 0; i < cols; i++)
            {
                double temp = array[row1, i];
                array[row1, i] = array[row2, i];
                array[row2, i] = temp;
            }
        }
    }
}