using System.Text;

namespace Matrix
{
   public partial class MyMatrix
    {
        protected double[,] matrixCopy;
        protected double? cachedDet = null;
        protected bool isMod = true;
        protected void InvalidateCache()
        {
            isMod = true;
            cachedDet = null;
        }
        public int Height
        {
            get => matrixCopy.GetLength(0);
        }
        public int Width
        {
            get => matrixCopy.GetLength(1);
        }
        public MyMatrix(MyMatrix other)
        {
            int height = other.Height;
            int width = other.Width;
            matrixCopy = new double[height, width];
            matrixCopy = (double[,])other.matrixCopy.Clone();
            InvalidateCache();
        }
        public MyMatrix(double[,] multiDimensionsMatrix)
        {
            int height = multiDimensionsMatrix.GetLength(0);
            int width = multiDimensionsMatrix.GetLength(1);
            matrixCopy = new double[height, width];
            matrixCopy = (double[,])multiDimensionsMatrix.Clone();
            InvalidateCache();
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
            matrixCopy = new double[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrixCopy[i,j] = jaggedMatrix[i][j];
                }
            }
            InvalidateCache();
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
            matrixCopy = new double[strRowsLen,colLen];
            for (int i = 0; i < strRowsLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    matrixCopy[i,j] = Convert.ToDouble(splitStrRow[i][j]);
                }
            }
            InvalidateCache();
        }
        public MyMatrix(string matrixSt)
        {
            string[] rows = matrixSt.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            List<string[]> parsedRows = new List<string[]>();
            foreach (string i in rows) { parsedRows.Add(i.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)); }
            int rowLen = parsedRows.Count;
            int colLen = parsedRows[0].Length;
            matrixCopy = new double[rowLen,colLen];
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    matrixCopy[i,j] = Convert.ToDouble(parsedRows[i][j]);
                }
            }
            InvalidateCache();
        }
        public int getHeight() => Height;
        public int getWidth() => Width;
        public double this[int row, int col]
        {
            get => matrixCopy[row,col];
            set => matrixCopy[row,col] = value;
        }
        public double GetElement(int row, int col) => matrixCopy[row,col];
        public double SetElement(int row, int col, double value)  => matrixCopy[row,col] = value;
        public void SetMatrix(double[,] newMatrix)
        {
            matrixCopy = (double[,]) newMatrix.Clone();
            InvalidateCache();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    sb.Append(matrixCopy[i, j] + "\t");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }

}