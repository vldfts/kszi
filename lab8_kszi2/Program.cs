using System;

namespace kszi2
{
    class Program
    {
        static void Main(string[] args)
        {
            int type1 = 5;
            int type2 = 5;
            int type3 = 5;
            int type4 = 5;
            int type5 = 5;
            int type6 = 5;
            int type7 = 5;
            int type8 = 5;

            Console.Write("Цiна: ");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Кiлькiсть експертiв: ");
            int N = int.Parse(Console.ReadLine());
            int[] vartist = { 700, 400, 350, 200,150,350,250,300 };
            double[] effect = { 0.241, 0.202, 0.174, 0.174,0.112,0.032,0.045,0.019 };
            double best_effect = 0;
            int best_cina = 0;
            for (int i1 = 0; i1 <= type1; i1++)
            {
                for (int i2 = 0; i2 <= type2; i2++)
                {
                    for (int j1 = 0; j1 <= type3; j1++)
                    {
                        for (int j2 = 0; j2 <= type4; j2++)
                        {
                            for (int k1 = 0; k1 <= type5; k1++)
                            {
                                for (int k2 = 0; k2 <= type6; k2++)
                                {
                                    for (int m1 = 0; m1 <= type7; m1++)
                                    {
                                        for (int m2 = 0; m2 <= type8; m2++)
                                        {
                                            int tmp_c = vartist[0] * i1 + vartist[1] * i2 + vartist[2] * j1 + vartist[3] * j2 + vartist[4] * k1 + vartist[5] * k2 + vartist[6] * m1 + vartist[7] * m2;
                                            double tmp_s = effect[0] * i1 + effect[1] * i2 + effect[2] * j1 + effect[3] * j2 + effect[4] * k1 + effect[5] * k2 + effect[6] * m1 + effect[7] * m2;
                                            int count = i1 + i2 + j1 + j2 + k1 + k2 + m1 + m2;
                                            if (tmp_c <= C && tmp_s > best_effect && count<N+1)
                                            {
                                                //Console.Clear();
                                                best_effect = tmp_s;
                                                best_cina = tmp_c;
                                                Console.WriteLine("Цiна: " + C);
                                                Console.WriteLine("Кiлькiсть експертiв: "+N);
                                                Console.WriteLine(new string('-', 50));
                                                Console.WriteLine("\ntype1:\t--- " + i1 + "\ntype2:\t--- " + i2 + "\ntype3:\t--- " + j1 + "\ntype4:\t--- " + j2 + "\ntype5:\t--- "+ k1 + "\ntype6:\t--- " + k2 + "\ntype7:\t--- " + m1 + "\ntype8:\t--- " + m2);
                                                Console.WriteLine("Кращi: якiсть - " + best_effect + ", цiна - " + best_cina);
                                                Console.WriteLine();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}