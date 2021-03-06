﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kszi2
{
    class Program
    {
        static void Main(string[] args)
        {   
            int mme_rout = 3; //MME
            int amo = 3; //AMO
            int shyfrat = 1; //Шифратори(заміна)
            int ids = 2; //IDS(заміна)
            int ips = 2; //IPS(заміна)

            int C = 50;
            int[] vartist = { 7, 8, 8, 4, 5, 10, 7, 10 };
            int[] effect = { 6, 8, 9, 6, 8, 9, 6, 10 };
            int best_effect = 0;
            int best_cina = 0;
            for (int i1 = 0; i1 <= mme_rout; i1++)
            {
                for (int i2 = 0; i2 + i1 <= amo; i2++)
                {
                    for (int j1 = 0; j1 <= shyfrat; j1++)
                    {
                        for (int j2 = 0; j1 + j2 <= shyfrat; j2++)
                        {
                            for (int k1 = 0; k1 <= ids; k1++)
                            {
                                for (int k2 = 0; k1 + k2 <= ids; k2++)
                                {
                                    for (int m1 = 0; m1 <= ips; m1++)
                                    {
                                        for (int m2 = 0; m1 + m2 <= ips; m2++)
                                        {
                                            int tmp_c = vartist[0] * i1 + vartist[1] * i2 + vartist[2] * j1 + vartist[3] * j2 +
                                                    vartist[4] * k1 + vartist[5] * k2 + vartist[6] * m1 + vartist[7] * m2;
                                            int tmp_s = effect[0] * i1 + effect[1] * i2 + effect[2] * j1 + effect[3] * j2 +
                                                    effect[4] * k1 + effect[5] * k2 + effect[6] * m1 + effect[7] * m2;
                                            if (tmp_c <= C && tmp_s > best_effect && i1 + i2 >= 1 && j1 + j2 >= 1 && k1 + k2 >= 1 && m1 + m2 >= 1)
                                            {
                                                Console.Clear();
                                                best_effect = tmp_s;
                                                best_cina = tmp_c;
                                                Console.WriteLine("Роутер ММЕ:\t--- " + i1 + "\nAMO:\t\t--- " + i2 + "\nШифратори:\t--- " + j1 + "\nПЗ шифрацiї:\t--- " + j2 + "\nIDS(пр):\t--- " + k1 + "\nIDS(aп):\t--- " + k2 + "\nIPS(пр):\t--- " + m1 + "\nIPS(aп):\t--- " + m2);
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
