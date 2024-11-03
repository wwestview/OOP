﻿using System;
using System.Text;

namespace Matrix
{
    public partial class MyMatrix
    {
        protected double[,] matrix;
        protected double? cachedDet = null;
        protected bool isMod = true;
        protected void InvalidateCache()
        {
            isMod = true;
            cachedDet = null;
        }
        public int Height //row
        {
            get => matrix.GetLength(0);
        }
        public int Width // col
        {
            get => matrix.GetLength(1);
        }
        public MyMatrix(MyMatrix other)
        {
            int height = other.Height;
            int width = other.Width;
            this.matrix = new double[height, width];
            matrix = (double[,])other.matrix.Clone();
        }
        public MyMatrix(double[,] multiDimensionsMatrix)
        {
            int height = multiDimensionsMatrix.GetLength(0);
            int width = multiDimensionsMatrix.GetLength(1);
            matrix = new double[height, width];
            matrix = (double[,])multiDimensionsMatrix.Clone();
        }
        public MyMatrix(double[][] jaggedMatrix)
        {
            int height = jaggedMatrix.Length;
            int width = jaggedMatrix[0].Length;
            for (int i = 0; i < height; i++)
            {
                if (jaggedMatrix[i].Length != width)
                {
                    throw new ArgumentException("All subarrays must have the same number of elements.");
                }
            }
            matrix = new double[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = jaggedMatrix[i][j];
                }
            }
        }
        public MyMatrix(string[] str)
        {
            int rows = str.Length;
            int cols = str[0].Length;
            matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] tempArr = Array.ConvertAll(str[i].Trim().Split(), int.Parse);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = tempArr[j];
                }
            }
            InvalidateCache();
        }
        public MyMatrix(string input)
        {
            string[] str = input.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            string[][] strMatrix = new string[str.Length][];

            for (int i = 0; i < str.Length; i++)
            {
                strMatrix[i] = str[i].Split(new[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);
            }
            int rows = strMatrix.Length;
            int cols = strMatrix[0].Length;

            matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = double.Parse(strMatrix[i][j]);
                }
            }
            InvalidateCache();
        }

        public int getHeight() => Height;
        public int getWidth() => Width;
        public double this[int row, int col]
        {
            get => matrix[row, col];
            set
            {
                matrix[row,col] = value;
                InvalidateCache();
            }
        }
        public double getElement(int row, int col)
        {
            return matrix[row, col];
        }
        public void setElement(int row, int col, double value)
        {
           matrix[row, col] = value;
            InvalidateCache();
        }
            
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    sb.Append(matrix[i, j] + "\t");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
      

    }

}