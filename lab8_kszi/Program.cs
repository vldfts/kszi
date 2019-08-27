using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_kszi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("N= ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mas = new double[(n * n - n) / 2];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(1, 9);
            }
            double[,] mas2 = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j < i)
                        continue;
                    else if (i == j)
                        mas2[i, j] = 1;
                    else { mas2[i, j] = mas[i + j - 1]; mas2[j, i] = 1 / mas[i + j - 1]; }
                }
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(Math.Round(mas2[j, i], 3) + " \t");
                }
                Console.WriteLine();
            }
            double[] mas3 = new double[n];
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas3[i] += mas2[i, j];
                }
                sum += mas3[i];
            }
            Console.WriteLine(new string('_',n*n));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1+" --> "+Math.Round(mas3[i],3)+"\t --> "+Math.Round(mas3[i]/sum,3)+"%");
            }
            Console.ReadKey();
        }
    }
}
