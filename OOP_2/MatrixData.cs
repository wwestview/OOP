﻿namespace MyMatrix
{
   partial class MyMatrix
    {
        protected double[,] matrix;
        public int Height
        {
            get => matrix.GetLength(0);
        }
        public int Width
        {
            get => matrix.GetLength(1);
        }
        public MyMatrix(MyMatrix other)
        {
            int height = other.Height;
            int width = other.Width;
            matrix = new double[height, width];
            Array.Copy(other.matrix, matrix, other.matrix.Length);
        }
        public MyMatrix(double[,] multiDimensionsMatrix)
        {
            int height = multiDimensionsMatrix.GetLength(0);
            int width = multiDimensionsMatrix.GetLength(1);
            matrix = new double[height, width];
            Array.Copy(multiDimensionsMatrix, matrix, multiDimensionsMatrix.Length);
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
                    matrix[i,j] = jaggedMatrix[i][j];
                }
            }
        }
        public MyMatrix(string[] strRow)
        {
            int strRowsLen = strRow.Length;
            string[][] splitStrRow = new string[strRowsLen][];
            int colLen = 0;
            for (int i = 0; i < strRowsLen; i++)
            {
                splitStrRow[i] = strRow[i].Split(new[] {' ','\t'}, StringSplitOptions.RemoveEmptyEntries);
                if (i == 0) { colLen = splitStrRow[i].Length; }
            }
            matrix = new double[strRowsLen,colLen];
            for (int i = 0; i < strRowsLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    matrix[i,j] = Convert.ToDouble(splitStrRow[i][j]);
                }
            }
        }
        public MyMatrix(string matrixSt)
        {
            string[] rows = matrixSt.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            List<string[]> parsedRows = new List<string[]>();
            foreach (string row in rows) { parsedRows.Add(row.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)); }
            int rowLen = parsedRows.Count;
            int colLen = parsedRows[0].Length;
            matrix = new double[rowLen,colLen];
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    matrix[i,j] = Convert.ToDouble(parsedRows[i][j]);
                }
            }
        }
        public int getHeight() => Height;
        public int getWidth() => Width;
        public double this[int row, int col]
        {
            get => matrix[row,col];
            set => matrix[row,col] = value;
        }
        public double GetElement(int row, int col) => matrix[row,col];
        public double SetElement(int row, int col, double value)  => matrix[row,col] = value;
    }

}