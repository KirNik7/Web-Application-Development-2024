namespace Lab_1.Models
{
    public class MatrixModel
    {
        public int[,] Matrix { get; set; }
        public int[] MinInColumns { get; set; }
        public int[] MaxInRows { get; set; }

        public void GenerateMatrix(int rows, int columns)
        {
            Random random = new Random();
            Matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Matrix[i, j] = random.Next(1, 101);
                }
            }
        }

        public void AnalyzeMatrix()
        {
            int rows = Matrix.GetLength(0);
            int columns = Matrix.GetLength(1);

            MinInColumns = new int[columns];
            MaxInRows = new int[rows];

            for (int j = 0; j < columns; j++)
            {
                int min = Matrix[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (Matrix[i, j] < min)
                    {
                        min = Matrix[i, j];
                    }
                }
                MinInColumns[j] = min;
            }

            for (int i = 0; i < rows; i++)
            {
                int max = Matrix[i, 0];
                for (int j = 1; j < columns; j++)
                {
                    if (Matrix[i, j] > max)
                    {
                        max = Matrix[i, j];
                    }
                }
                MaxInRows[i] = max;
            }
        }
    }
}
