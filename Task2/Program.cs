using System;

namespace Task2
{
    class Program
    {


        public delegate void SortName(string[] Names, string Queue);

        static void Main(string[] args)
        {

            SortSecNames s = new SortSecNames();
            s.NeedSort += s.SortNames;
            s.GoSorting();
            
            Console.ReadKey();
        }


    }


    class SortSecNames
    {

        public delegate void SortName(string[] Names, string Queue);

        public void GoSorting()
        {
            Console.WriteLine("Введите пять фамилий");

            string[] SecNames = new string[5];

            for (int i = 0; i < SecNames.Length; i++)
            {
                SecNames[i] = Console.ReadLine();
            }

            string Queue;
            bool InCheck = false;
            do
            {
                Console.WriteLine("Введите порядок вывода фамилий (1 - А-Я, 2 - Я-А)");
                Queue = Console.ReadLine();

                switch (Queue)
                {
                    case "1":
                        InCheck = false;
                        break;

                    case "2":
                        InCheck = false;
                        break;

                    default:
                        Console.WriteLine("Требовалось ввести 1 или 2");
                        InCheck = true;
                        break;
                }

            } while (InCheck == true);

            NeedSort(SecNames, Queue);

           
        }


        public event SortName NeedSort;





        public void SortNames(string[] Names, string Queue)
        {
            Array.Sort(Names);

            if (Queue == "1")
            {
                foreach (string n in Names)
                {
                    Console.WriteLine(n);
                }
            }
            else
            {
                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine(Names[i-1]);
                }
            }

        }



    }
}
