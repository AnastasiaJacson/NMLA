using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobiIteration
{
    class Jacobi
{
    int n;
    public int N
    {
        get { return n; }
        set { n = value; }
    }
    double[,] a;
    public double[,] A
    {
        get { return a; }
        set { a = value; }
    }
    double[] x;
    public double[] X
    {
        get { return x; }
        set { x = value; }
    }
    double e = 0.00001;
    public double E
    {
        get { return e; }
        set { e = value; }
    }
    private double[] x2;
    public double[] X2
    {
        get { return x2; }
        set { x2 = value; }
    }
    public void Input()
    {
        Console.WriteLine("enter the order:");
        n = Convert.ToInt32(Console.ReadLine());
        a = new double[n, n + 1];
        x = new double[n];
        x2 = new double[N + 1];
        for (int i = 0; i < N; i++)
        {
            X[i] = 0;
        }
        Console.WriteLine("enter the coefficient of each line (' 'separated):");
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
                for (int j = 0; j < n + 1; j++)
                {
                    a[i, j] = Convert.ToDouble(ss[j]);
                }
            }
    }
    public void Calcu5()
    {
        int count1 = 0, count2 = 0;
        while (true)
        {
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        sum += a[i, j] * x[j];
                    }
                }
                x2[i] = (a[i, n] - sum) / a[i, i];
                if (Math.Abs(x2[i] - x[i]) < e)
                    count2++;
            }
            count1++;
            if (count1 > 10000)
            { Console.WriteLine("Iteration not match!!!", count1); break; }
            if (count2 == n)
            { Console.WriteLine("Number of iterations: {0}", count2); break; }
            for (int i = 0; i < n; i++)
            { x[i] = x2[i]; }
        }
    }
    public void Output()
    {
        Console.WriteLine("The equation coefficient is:");
        for (int i = 0; i < n; i++)
        {
            string s = null;
            for (int j = 0; j < n + 1; j++)
            {
                s += string.Format("{0,8:f2}", a[i, j]);
            }
            Console.WriteLine(s);
        }
    }

    public void OutputX()
    {
        Console.WriteLine("\nThe solution of the equation group is:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("x{0}={1}", i + 1, x[i]);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Jacobi abc = new Jacobi();
        abc.Input();
        abc.Output();
        abc.Calcu5();
        abc.OutputX();
    }
}
}