using decomposition;
using static decomposition.SystemOfLinearEquations;
namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] A;
            double[] b;
            int s;

            Console.Write("Enter side: ");
            s = Int32.Parse(Console.ReadLine());
            A = new double[s, s];

            b = new double[s];
            double det = 0.0;
            for (int row = 0; row < s; row++)
            {
                for (int col = 0; col < s; col++)
                {
                    Console.Write($"A[{row},{col}]: ");
                    A[row, col] = double.Parse(Console.ReadLine());
                }
                Console.Write($"b[{row}]: ");
                b[row] = double.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Display(A, b);
            //SystemOfLinearEquations reserch = new SystemOfLinearEquations();
            //reserch.SolveUsingLU(A, b, s);

            double[,] C1;
            
            A = recMatB(A, out C1);
            
            double[] y = new double[s];
            double[] x = new double[s];
           //x = retY(C1, b, s);
            
            Show(A);//для х по ній шукаєм визначник
            Console.WriteLine();
            Show(C1);//для у (одинична)
            for (int i = 0; i < s; i++)
            {
                double sum = 0;
                for (int k = 0; k < i; k++)
                    sum += A[i, k] * y[k];
                y[i] = (b[i] - sum)/A[i,i];

            }
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine($"y[{i}]={y[i]}");
            }
            //Console.WriteLine(y);
            //find solution of Ux = y
            for (int i = s - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int k = i + 1; k < s; k++)
                    sum += C1[i, k] * x[k];
                x[i] = (1 / C1[i, i]) * (y[i] - sum);
            }
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine($"x[{i}]={x[i]}");
            }



            if (s >= 1)
            {
                det = 1;
                for (int row = 0; row < s; row++)
                {

                    det = det * A[row, row];

                }

                Console.WriteLine($"Determinant = {det}");
            }
        }

        public static double[,] recMatB(double[,] matrix, out double[,] C)
        {
            double[,] B = new double[matrix.GetLength(0), matrix.GetLength(1)];
            C = new double[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                for (int l = 0; l < i + 1; l++)
                {
                    B[l, 0] = matrix[l, 0];
                    if (i > 0)
                    {
                        double sum = 0;
                        //B[i, l];
                        for (int k = 0; k < l; k++)
                        {
                            sum = B[i, k] * C[k, l] + sum;
                        }
                        B[i, l] = matrix[i, l] - sum;
                        

                        sum = 0;
                    }
                   
                   
                }
                for (int l = 0; l < j + 1; l++)
                {
                    C[0, l] = matrix[0, l] / B[0, 0];
                    if (j < 2)
                    {
                        for (int m = 2; m > i - 1; m--)
                        {
                            //c[j,l]
                            double sum = 0;
                            for (int k = 0; k < i; k++)
                            {
                                sum = B[i, k] * C[k, m] + sum;
                            }
                            C[i, m] = (1 / B[i, i]) * (matrix[i, m] - sum);
                            ///////////                                                  
                            
                            sum = 0;

                        }
                    }
                }                 

            }            
            return B;
                       
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
        private static void Show(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("\t ");
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
