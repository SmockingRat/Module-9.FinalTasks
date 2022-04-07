using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = false;
            do
            {
                try
                {
                    Console.WriteLine("Введите символ не равный нулю, не более 256 и не менее 0, введите ЦИФРУ, не равный 5 и число не должно быть длиннее 2 знаков");
                    string Input = Console.ReadLine();
                    byte Num = Convert.ToByte(Input);
                    float ZeroCheck = 12/Num;
                    if (Num == 5) throw new MyException($"Недопустима цифра 5 \n");
                    if (Num > 99) throw new IndexOutOfRangeException();
                }
                catch (FormatException a)
                {
                    Console.WriteLine("Требуется положительное число");
                    Console.WriteLine(a);
                }
                catch (DivideByZeroException a)
                {
                    Console.WriteLine("Недопустим ноль");
                    Console.WriteLine(a);
                }
                catch (MyException a)
                {
                    Console.WriteLine(a);
                }
                catch (IndexOutOfRangeException a)
                {
                    Console.WriteLine("Требуется число лдинной не более 2 знаков");
                    Console.WriteLine(a);
                }
                catch (OverflowException a)
                {
                    Console.WriteLine("Требуется положительное число не более 99");
                    Console.WriteLine(a);
                }

                Console.WriteLine("Вы желаете выйти из программы? Да/Нет");
                switch (Console.ReadLine())
                {
                    case "Да":
                        answer = false;
                        break;
                    case "Нет":
                        answer = true;
                        break;
                    default:
                        Console.WriteLine("Вы не ответили, происходит закрытие программы");
                        answer = false;
                        Console.ReadKey();
                        break;
                }


            } while (answer == true);


        }
    }



    class MyException : Exception
    {
        public MyException(string _exceptionMessage) : base(_exceptionMessage)
        {

        }
    }



}
