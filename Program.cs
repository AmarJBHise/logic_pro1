namespace logic_pro
{
    internal class Program
    {
        public static void Main()
        {
            //PrimeNumber();
            Uppercase();
        }

        //1. Program to show all prime numbers from 1 to 100

        public static void PrimeNumber()
        {
            for (int Num = 1; Num < 100; Num++)
            {
                int Total = 0;
                for (int i = 1; i <= Num; i++)
                {
                    if (Num % i == 0)
                    {
                        Total++;
                    }

                }
                if (Total == 2)
                {
                    Console.WriteLine(Num);
                }
               

            }
        }

        public static void Uppercase()
        {
            string str1 ,str2;
            Console.WriteLine("Please enter the string");
            str1 = Console.ReadLine();

            str2 = str1.ToUpper();

            Console.WriteLine(str1+" ="+"This is lower case input");
            Console.WriteLine(str2+" ="+" This is Upper case Ouput");
        }
      

        

    }
}