namespace labCmla5
{
	public static class Program
	{

		public static double[] MatrixByVector(double[,] matrix, double[] vector)
		{
			double[] result = new double[vector.Length];
			for (int i = 0; i < vector.Length; i++)
			{
				for (int j = 0; j < vector.Length; j++)
				{
					result[i] += matrix[i, j] * vector[j];
				}
			}
			return result;
		}

		public static double VectorByVector(double[] vector1, double[] vector2)
		{
			double result = 0;
			for (int i = 0; i < vector1.Length; i++)
			{
				result += vector1[i] * vector2[i];
			}
			return result;
		}

		public static double Middle(double[] vector)
		{
			double result = 0;
			foreach (var item in vector)
			{
				result += item;
			}
			return result / vector.Length;
		}

		public static double Norma(double[] vector)
		{
			double sum = 0;
			for (int i = 0; i < vector.Length; i++)
			{
				//sum += Math.Abs(vector[i]);
				sum += vector[i]* vector[i];
		}
			return Math.Sqrt(sum);
		}

		public static double[] VectorSubtraction(double[] vector, double[] vector2)
		{
			double[] result = new double[vector.Length];
			for (int i = 0; i < result.Length; i++)
			{
				result[i] = vector[i] - vector2[i];
			}
			return result;
		}

		public static void PMalg(double[,] matrix, double[] y, double epsilon)
		{
			double[] lamda = new double[y.Length];
			double[] lamdaPrevious = new double[y.Length];
			double[] x = new double[y.Length];
			double[] xPrevious = new double[y.Length];
			int k = 1;
			double yNorm;
			for (int i = 0; i < x.Length; i++)
			{
				x[i] = y[i] / Norma(y);
			}

			while (true)
			{
				
				y = MatrixByVector(matrix, x);
				
				yNorm = Norma(y);
				//saving x k-1
				for (int i = 0; i < x.Length; i++)
				{
					xPrevious[i] = x[i];
				}
				
				for (int i = 0; i < x.Length; i++)
				{
					x[i] = y[i] / yNorm;
					Console.WriteLine(x[i]);
				}
				
				for (int i = 0; i < lamda.Length; i++)
				{
					lamdaPrevious[i] = lamda[i];
					//Console.WriteLine($"{lamdaPrevious[i]}");
				}
				for (int i = 0; i < lamda.Length; i++)
				{
					lamda[i] = y[i] / xPrevious[i];
					//Console.WriteLine($"{lamda[i]}");
					
				}
				k++;
				if (Norma(VectorSubtraction(lamda, lamdaPrevious)) < epsilon)
				{

					Console.WriteLine($"Nubmer of Iterations : {k}");
					Console.WriteLine($"Value: {Middle(lamda)}");

					Console.WriteLine("Vector");
					for (int i = 0; i < x.Length; i++)
					{
						Console.WriteLine($"{x[i]} ");
					}
					Console.WriteLine("********************************************");
					for (int i = 0; i < x.Length; i++)
					{
						Console.WriteLine(x[i] * Middle(lamda));
					}
					Console.WriteLine("********************************************");
					double[] a = MatrixByVector(matrix, x);
					for (int i = 0; i < x.Length; i++)
					{
						Console.WriteLine(a[i]);
					}
					Console.WriteLine((7 + Math.Sqrt(61))/2);
					break;
				}
			}
		}

		static int Main(string[] args)
		{
			//double[,] matrix = new double[,] { {3, 5, 0  },
			//								   {1 , 4, 1 },
			//								   {0, -3, 3 }
			//	
			double[,] matrix = new double[,] {{ 2, 2 },
				                               { 2, 5}
		                                           };
			double[] vector = new double[] { 1, 1 };
			const double epsilon = 0.000001;

			PMalg(matrix, vector, epsilon);

			return 0;
		}
	}
}