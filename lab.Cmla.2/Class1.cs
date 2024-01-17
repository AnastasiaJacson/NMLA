namespace decomposition
{
    internal class SystemOfLinearEquations
    {
        public double[] SolveUsingLU(double[,] matrix, double[] rightPart, int n)
        {
            // decomposition of matrix
            double[,] lu = new double[n, n];
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    sum = 0.0;
                    for (int k = 0; k < i; k++)
                        sum += lu[i, k] * lu[k, j];
                    lu[i, j] = matrix[i, j] - sum;
                }
                for (int j = i + 1; j < n; j++)
                {
                    sum = 0.0;
                    for (int k = 0; k < i; k++)
                        sum += lu[j, k] * lu[k, i];
                    lu[j, i] = (1 / lu[i, i]) * (matrix[j, i] - sum);
                }
                //Console.WriteLine(lu);
                //Show(lu);
            }
            Show(lu);
            
            // lu = L+U-I
            // find solution of Ly = b
            double[] y = new double[n];
            for (int i = 0; i < n; i++)
            {
                sum = 0.0;
                for (int k = 0; k < i; k++)
                    sum += lu[i, k] * y[k];
                y[i] = rightPart[i] - sum;
               
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"y[{i}]={y[i]}");
            }
            //Console.WriteLine(y);
            // find solution of Ux = y
            double[] x = new double[n];
            for (int i = n - 1; i >= 0; i--)
            {
                sum = 0.0;
                for (int k = i + 1; k < n; k++)
                    sum += lu[i, k] * x[k];
                x[i] = (1 / lu[i, i]) * (y[i] - sum);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"x[{i}]={x[i]}");
            }
            return x;
        }
        public static void Show(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" ");
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Display(double[,] M, double[] b)
        {
            int s;
            s = Convert.ToInt32(Math.Sqrt(M.Length));
            for (int row = 0; row < s; row++)
            {
                for (int col = 0; col < s; col++)
                {
                    Console.Write($"{M[row, col]}\t");
                }
                Console.Write($"| {b[row]}");
                Console.WriteLine();
            }
        }
    }
}