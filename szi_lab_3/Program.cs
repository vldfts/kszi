using System;

namespace kszi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            double[] ai = new double[10];
            #region ai_obrah
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                ai[i] = rand.Next(0, 15);
                sum += ai[i];
            }
            for (int i = 0; i < 10; i++)
            {
                ai[i] = Math.Round(ai[i] / sum, 4);
                //Console.WriteLine(ai[i]);
            }
            #endregion 
            double[] deltaqi = new double[10] { 0.07, 0.11, 0.13, 0.11, 0.1, 0.07, 0.12, 0.15, 0.08, 0.06 };
            double[,] betaij = new double[10, 11];
            #region betaij_obrah
            double[] suma = new double[10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    betaij[i, j] = rand.Next();
                    suma[i] += betaij[i, j];
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    betaij[i, j] = Math.Round(betaij[i, j] / suma[i], 4);
                    Console.Write(betaij[i, j] + "\t|");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('_',89));
            Console.WriteLine();
            #endregion
            double[] naikrashche = new double[8] { 2, 5, 3, 3, 3, 2, 4, 4 };//Кількісні вимоги
            double[] naihirshe = new double[8] { 0, 0.5, 1, 1, 1, 0, 1, 2 };
            double[] potochne = new double[8] { 1, 3, 2, 2, 2, 1, 3, 3 };
            double[] xij = new double[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0.5, 1, 0.7 };
            #region xij_obrah
            for (int i = 0; i < 8; i++)
            {
                xij[i] = Math.Round((potochne[i] - naihirshe[i]) / (naikrashche[i] - naihirshe[i]), 4);
            }
            #endregion
            foreach (double item in xij)
            {
                Console.Write(item + "\t|");
            }
            Console.WriteLine(" <-- Xij");
            Console.WriteLine(new string('_', 89));
            Console.WriteLine();
            double[] pYsynennya = new double[10];
            double[] pYsynennya_ideal = new double[10];
            #region pYsynnenya_obrah
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    pYsynennya[i] += betaij[i, j] * xij[j];
                    pYsynennya_ideal[i] += betaij[i, j];
                }
            }
            #endregion
            double W = 0;
            double W2 = 0;
            for (int i = 0; i < 10; i++)
            {
                W += Math.Round(deltaqi[i] * ai[i] * pYsynennya[i], 4);
                W2 += Math.Round(deltaqi[i] * ai[i] * pYsynennya_ideal[i], 4);
            }
            Console.WriteLine("Поточна W: " + W);
            Console.WriteLine("Найкраща W: " + W2);
            Console.WriteLine("Чи задовольняє поточна реалiзацiя - \t"+(potochne[2]*200+potochne[0]*400<1600));
            Console.WriteLine("Чи задовольняє найкраща реалiзацiя - \t" + (naikrashche[2] * 200 + naikrashche[0] * 400 < 1600));
            Console.ReadKey();
        }
    }
}

