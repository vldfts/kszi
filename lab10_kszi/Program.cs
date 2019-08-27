using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10_kszi
{

    class Resource
    {
        public Random rand = new Random();

        public string Name { get; set; }
        public int Access { get; set; }
        public Resource()
        {

        }
        public Resource(string name, int access)
        {
            Access = access;
            Name = name;
        }
        public List<Resource> createList(string[] resourceList, int N)
        {
            List<Resource> list = new List<Resource>();
            for (int i = 0; i < resourceList.Length; i++)
            {
                list.Add(new Resource(resourceList[i], rand.Next(N)));
            }
            return list;
        }
    }
    class User
    {
        public Random rand = new Random();

        public string Name { get; set; }
        public int Access { get; set; }
        public User()
        {

        }
        public User(string name, int access)
        {
            Access = access;
            Name = name;
        }
        public List<User> createList(string[] nameList, int N)
        {
            List<User> list = new List<User>();
            HashSet<string> checkList = new HashSet<string>();
            for (int i = 0; i < nameList.Length; i++)
            {
                list.Add(new User(nameList[i], rand.Next(N)));
            }
            return list;
        }
    }

    class Program
    {
        public static void Bella(List<User> users, List<Resource> resources)
        {
            foreach (var v in users)
            {
                foreach (var m in resources)
                {
                    if (v.Access >= m.Access)
                    {
                        Console.WriteLine(v.Name  + "\tможе читати " + "\t" + m.Name + "\t(" + v.Access + ") " + "(" + m.Access+")");
                    }
                    if (v.Access <= m.Access)
                    {
                        Console.WriteLine(v.Name  + "\tможе писати " + "\t" + m.Name + "\t(" + v.Access + ") " + "(" + m.Access + ")");
                    }
                }
            }
        }
        public static void Biba(List<User> users, List<Resource> resources)
        {
            foreach (var v in users)
            {
                foreach (var m in resources)
                {
                    if (v.Access <= m.Access)
                    {
                        Console.WriteLine(v.Name + "\tможе читати " + "\t" + m.Name + "\t(" + v.Access + ") " + "(" + m.Access + ")");

                    }
                    if (v.Access >= m.Access)
                    {
                        Console.WriteLine(v.Name + "\tможе читати " + "\t" + m.Name + "\t(" + v.Access + ") " + "(" + m.Access + ")");
                    }
                }
            }
        }
        public static void Lattice(int n)
        {
            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19 };
            List<int> numbers = new List<int>();
            for (int i = 0; i < n / 2; i++)
            {
                numbers.Add(primeNumbers[i]);
            }
            while (numbers.Count() != n)
            {
                for (int i = 0; i < numbers.Count(); i++)
                {
                    if (!numbers.Contains(numbers[i] * numbers[i + 1]))
                    {
                        numbers.Add(numbers[i] * numbers[i + 1]);
                        if (numbers.Count() == n)
                            break;
                    }
                }


            }
            Console.WriteLine("lattice ");
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (numbers[j] % numbers[i] == 0)
                        Console.WriteLine(numbers[i] + " have access to object " + numbers[j]);
                }
            }
        }
        static void Main(string[] args)
        {
            string[] nameList = { "Коля", "Вася", "Рома", "Дiма", "Вова", "Саня", "Олег" };
            string[] resourceList = { "Вода", "Повiтря", "Земля", "Вогонь" };
            List<User> users = new User().createList(nameList, 4);
            List<Resource> resources = new Resource().createList(resourceList, 4);
            Bella(users, resources);
            Console.WriteLine(new string('_', 50));
            Biba(users, resources);
            Lattice(10);
            Console.ReadKey();
        }
    }

}
