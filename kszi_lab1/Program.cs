using System;
using System.Collections.Generic;
using System;
using System.Text;
using System.Threading.Tasks;

namespace kszi_lab1
{
    class Program
    {         
        

        static void Main(string[] args)
        {
            double pok_yak = 0.55;
            Random rand = new Random();
            double[,,] Matrix = new double[4, 5, 7];
            int[,,] Matrix2 = new int[4, 5, 7];
            int[,,] Matrix3 = new int[4, 5, 7];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 7; k++)
                    {
                        Matrix[i, j, k] = rand.NextDouble();
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 7; k++)
                    {
                        if (Matrix[i,j,k]>pok_yak)
                        {
                            Matrix2[i, j, k] = 1;
                        }
                        else { Matrix2[i, j, k] = 0; }
                        
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 7; k++)
                    {
                        if (Matrix[i, j, k] < 0.9)
                        {
                            if (Matrix[i, j, k] < 0.7)
                            {
                                if (Matrix[i, j, k] < 0.5)
                                {
                                    if (Matrix[i, j, k] < 0.3)
                                    {
                                        Matrix3[i, j, k] = 1;
                                    }
                                    else
                                    {
                                        Matrix3[i, j, k] = 2;
                                    }
                                }
                                else
                                {
                                    Matrix3[i, j, k] = 3;
                                }
                            }
                            else
                            {
                                Matrix3[i, j, k] = 4;
                            }
                        }
                        else
                        {
                            Matrix3[i, j, k] = 5;
                        }
                    }
                }
            }

            double[] Osnovy = new double[4] { 1,1,1,1};
            double[] Napramky = new double[5] { 1,1,1,1,1 };
            double[] Etapy = new double[7] { 1,1,1,1,1,1,1 };
            double Q1=0;
            double Q2=0;
            double Q3=0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 7; k++)
                    {
                        Q1 += Osnovy[i] * Napramky[j] * Etapy[k] * Matrix[i, j, k];
                        Q2 += Osnovy[i] * Napramky[j] * Etapy[k] * Matrix2[i, j, k];
                        Q3 += Osnovy[i] * Napramky[j] * Etapy[k] * Matrix3[i, j, k];
                    }
                }
            }


            for (int l = 0; l < 4; l++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0}\t", Math.Round(Matrix[l, i, 0],3));
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-',50));
            for (int l = 0; l < 4; l++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0}\t", Matrix2[l, i, 0]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 50));
            for (int l = 0; l < 4; l++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0}\t", Matrix3[l, i, 0]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(Q1/140);
            Console.WriteLine(Q2/140);
            Console.WriteLine(Q3/140);

            Console.ReadKey();
        }
    }
}
