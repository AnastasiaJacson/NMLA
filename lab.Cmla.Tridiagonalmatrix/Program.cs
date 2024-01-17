namespace TriDiagonalMatrixAlgorithm
{
    class TDMA
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter the size of the matrix (n): ");
            int n = int.Parse(Console.ReadLine());
            double[] equivalentMatrix = new double[n];
            double[,] reducedMatrix = new double[n, 3];

            if (n == 3)
            {
                Console.WriteLine(@"

| a1    a2     0|   | b1 |
| a3    a4    a5| = | b2 |
| 0     a6    a7|   | b3 | ");

                Console.WriteLine("\nEnter all matrix value like in example: ");
                Console.Write("a1: ");
                double a1 = double.Parse(Console.ReadLine());
                reducedMatrix[0, 1] = a1;

                Console.Write("a2: ");
                double a2 = double.Parse(Console.ReadLine());
                reducedMatrix[0, 2] = a2;

                Console.Write("a3: ");
                double a3 = double.Parse(Console.ReadLine());
                reducedMatrix[1, 0] = a3;

                Console.Write("a4: ");
                double a4 = double.Parse(Console.ReadLine());
                reducedMatrix[1, 1] = a4;

                Console.Write("a5: ");
                double a5 = double.Parse(Console.ReadLine());
                reducedMatrix[1, 2] = a5;

                Console.Write("a6: ");
                double a6 = double.Parse(Console.ReadLine());
                reducedMatrix[2, 0] = a6;

                Console.Write("a7: ");
                double a7 = double.Parse(Console.ReadLine());
                reducedMatrix[2, 1] = a7;

                for (int y = 0; y < n; y++)
                {
                    Console.Write("Enter b{0}:  ", (y + 1));
                    equivalentMatrix[y] = double.Parse(Console.ReadLine());
                }
            }
            else if (n == 4)
            {
                Console.WriteLine(@"
| a1    a2    0      0|   | b1 |
| a3    a4    a5     0|   | b2 |
| 0     a6    a7    a8| = | b3 |
| 0     0     a9    a10|  | b4 |");



                Console.WriteLine("\nEnter all matrix value like in example: ");
                Console.Write("a1: ");
                double a1 = double.Parse(Console.ReadLine());
                reducedMatrix[0, 1] = a1;

                Console.Write("a2: ");
                double a2 = double.Parse(Console.ReadLine());
                reducedMatrix[0, 2] = a2;

                Console.Write("a3: ");
                double a3 = double.Parse(Console.ReadLine());
                reducedMatrix[1, 0] = a3;

                Console.Write("a4: ");
                double a4 = double.Parse(Console.ReadLine());
                reducedMatrix[1, 1] = a4;

                Console.Write("a5: ");
                double a5 = double.Parse(Console.ReadLine());
                reducedMatrix[1, 2] = a5;

                Console.Write("a6: ");
                double a6 = double.Parse(Console.ReadLine());
                reducedMatrix[2, 0] = a6;

                Console.Write("a7: ");
                double a7 = double.Parse(Console.ReadLine());
                reducedMatrix[2, 1] = a7;

                Console.Write("a8: ");
                double a8 = double.Parse(Console.ReadLine());
                reducedMatrix[2, 2] = a8;

                Console.Write("a9: ");
                double a9 = double.Parse(Console.ReadLine());
                reducedMatrix[3, 0] = a9;

                Console.Write("a10: ");
                double a10 = double.Parse(Console.ReadLine());
                reducedMatrix[3, 1] = a10;

                for (int y = 0; y < n; y++)
                {
                    Console.Write("Enter b{0}:  ", (y + 1));
                    equivalentMatrix[y] = double.Parse(Console.ReadLine());
                }
            }
            else if (n == 5)
            {
                Console.WriteLine(@"
| a1    a2    0     0      0|   | b1 |
| a3    a4    a5    0      0|   | b2 |
| 0     a6    a7    a8     0| = | b3 |
| 0     0     a9    a10    a11| | b4 |
| 0     0     0     a12    a13| | b5 |");

                Console.WriteLine("\nEnter all matrix value like in example: ");
                Console.Write("a1: ");
                double a1 = double.Parse(Console.ReadLine());
                reducedMatrix[0, 1] = a1;

                Console.Write("a2: ");
                double a2 = double.Parse(Console.ReadLine());
                reducedMatrix[0, 2] = a2;

                Console.Write("a3: ");
                double a3 = double.Parse(Console.ReadLine());
                reducedMatrix[1, 0] = a3;

                Console.Write("a4: ");
                double a4 = double.Parse(Console.ReadLine());
                reducedMatrix[1, 1] = a4;

                Console.Write("a5: ");
                double a5 = double.Parse(Console.ReadLine());
                reducedMatrix[1, 2] = a5;

                Console.Write("a6: ");
                double a6 = double.Parse(Console.ReadLine());
                reducedMatrix[2, 0] = a6;

                Console.Write("a7: ");
                double a7 = double.Parse(Console.ReadLine());
                reducedMatrix[2, 1] = a7;

                Console.Write("a8: ");
                double a8 = double.Parse(Console.ReadLine());
                reducedMatrix[2, 2] = a8;

                Console.Write("a9: ");
                double a9 = double.Parse(Console.ReadLine());
                reducedMatrix[3, 0] = a9;

                Console.Write("a10: ");
                double a10 = double.Parse(Console.ReadLine());
                reducedMatrix[3, 1] = a10;

                Console.Write("a11: ");
                double a11 = double.Parse(Console.ReadLine());
                reducedMatrix[3, 2] = a11;

                Console.Write("a12: ");
                double a12 = double.Parse(Console.ReadLine());
                reducedMatrix[4, 0] = a12;

                Console.Write("a13: ");
                double a13 = double.Parse(Console.ReadLine());
                reducedMatrix[4, 1] = a13;

                for (int y = 0; y < n; y++)
                {
                    Console.Write("Enter b{0}:  ", (y + 1));
                    equivalentMatrix[y] = double.Parse(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("\nEnter all matrix value like in example: ");
                Console.Write("a1: ");
                double a1 = double.Parse(Console.ReadLine());
                reducedMatrix[0, 1] = a1;

                Console.Write("a2: ");
                double a2 = double.Parse(Console.ReadLine());
                reducedMatrix[0, 2] = a2;

                Console.Write("a3: ");
                double a3 = double.Parse(Console.ReadLine());
                for (int y = 1; y < n - 1; y++)
                {
                    reducedMatrix[y, 0] = a3;
                }

                Console.Write("a4: ");
                double a4 = double.Parse(Console.ReadLine());
                for (int y = 1; y < n - 1; y++)
                {
                    reducedMatrix[y, 1] = a4;
                }

                Console.Write("a5: ");
                double a5 = double.Parse(Console.ReadLine());
                for (int y = 1; y < n - 1; y++)
                {
                    reducedMatrix[y, 2] = a5;
                }

                Console.Write("a6: ");
                double a6 = double.Parse(Console.ReadLine());
                reducedMatrix[n - 1, 0] = a6;

                Console.Write("a7: ");
                double a7 = double.Parse(Console.ReadLine());
                reducedMatrix[n - 1, 1] = a7;

                //Console.WriteLine("\nAre there repetitive values between first and last elements of matrix C? ");
                //Console.Write("Answer (yes/no):  ");
                //string reply = Console.ReadLine().ToLower();

                //if (reply == "yes" || reply == "y")
                //{
                //    Console.Write("b1: ");
                //    double r = double.Parse(Console.ReadLine());
                //    equivalentMatrix[0] = r;

                //    Console.Write("b2: ");
                //    double h = double.Parse(Console.ReadLine());
                //    for (int y = 1; y < n - 1; y++)
                //    {
                //        equivalentMatrix[y] = h;
                //    }

                //    Console.Write("bn: ");
                //    double i = double.Parse(Console.ReadLine());
                //    equivalentMatrix[n - 1] = i;
                //}
                //else if (reply == "no" || reply == "n")
                //{
                //    for (int y = 0; y < n; y++)
                //    {
                //        Console.Write("Enter b{0}:  ", (y + 1));
                //        equivalentMatrix[y] = double.Parse(Console.ReadLine());
                //    }
                //}
            }

            reducedMatrix[0, 0] = 0.0;
            reducedMatrix[n - 1, 2] = 0.0;

            reducedMatrix[0, 2] = reducedMatrix[0, 2] / reducedMatrix[0, 1];
            equivalentMatrix[0] = equivalentMatrix[0] / reducedMatrix[0, 1];
            reducedMatrix[0, 1] = 1.0;

            for (int y = 1; y < n; y++)
            {
                reducedMatrix[y, 1] = reducedMatrix[y, 1] - (reducedMatrix[y, 0] * reducedMatrix[y - 1, 2]);
                equivalentMatrix[y] = equivalentMatrix[y] - (reducedMatrix[y, 0] * equivalentMatrix[y - 1]);
                equivalentMatrix[y] = equivalentMatrix[y] / reducedMatrix[y, 1];
                reducedMatrix[y, 2] = reducedMatrix[y, 2] / reducedMatrix[y, 1];
                reducedMatrix[y, 0] = 0.0;
                reducedMatrix[y, 1] = 1.0;
            }


            double[] results = new double[n];
            results[n - 1] = equivalentMatrix[n - 1];
            for (int y = n - 2; y >= 0; y--)
            {
                results[y] = equivalentMatrix[y] - (results[y + 1] * reducedMatrix[y, 2]);
            }
            //double[] check = new double[n];
            //for (int y = 0; y < n; y++)
            //{
            //    Console.WriteLine(check[y]);
            //}
            //Print2dMatrix(reducedMatrix);
            Console.WriteLine("\n\nResults");
            for (int y = 0; y < n; y++)
            {
                Console.WriteLine("x{0} = {1}", (y + 1), results[y]);
            }
        }

        static void Print1dMatrix(double[] print)
        {
            for (int u = 0; u < print.Length; u++)
            {
                Console.WriteLine("{0}", print[u]);
            }
        }

        static void Print2dMatrix(double[,] print)
        {
            for (int u = 0; u < print.GetLength(0); u++)
            {
                for (int v = 0; v < 3; v++)
                {
                    Console.Write("{0}  ", print[u, v]);
                }
                Console.WriteLine(" ");
            }
        }
    }
}

