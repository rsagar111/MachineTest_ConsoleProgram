using System;

namespace MachineTestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            /*
             Write 3 program in c#
            1. for Factorial
            2. for Strong Number
            3. for Sum of Diagonal
            4. for Swapping character of a string 
             */
            Console.WriteLine("Strong Number Program..");
            int choice;
            string ch = "";
            bool res;
            do
            {
                Console.Write("Choice your program \n 1. for Factorial :  \n 2. for Strong Number :  \n 3. for Sum of Diagonal : \n 4. for Swapping character of a string :  \n 0. for Exit the program : ");
                ch = Console.ReadLine();
                res = int.TryParse(ch, out choice);
                Console.WriteLine("/*****************************************************/\n");
                switch (choice)
                {
                    case 0:
                        Environment.Exit(choice);
                        break;
                    case 1:
                        p.FactorialProgram();
                        Console.WriteLine("-------------------------------------------");
                        break;
                    case 2:
                        p.StrongNumber();
                        Console.WriteLine("-------------------------------------------");
                        break;
                    case 3:
                        p.SumOfDiagonal();
                        Console.WriteLine("-------------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("Enter String : ");
                        string str = Console.ReadLine();
                        Console.WriteLine($"You input  : {str}");
                        string[] ss = p.SwappingCharacter(str);
                        for (int i = 0; i < ss.Length; i++)
                        {
                            Console.Write($"{ss[i]}");
                            Console.Write(" ");
                        }
                        Console.WriteLine("\n -------------------------------------------");
                        break;
                    default:
                        Console.WriteLine("Sorry given input is wrong");
                        break;
                }
            }
            while (choice != 0);

            Console.ReadLine();
        }
        public static int getfactorial(int rem)
        {
            int fact = 1;

            for (int i = 1; i <= rem; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        //Case 1 for factorial
        public void FactorialProgram()
        {
            Console.Write("Enter Number : ");
            int num = int.Parse(Console.ReadLine());
            int fact = Program.getfactorial(num);
            Console.WriteLine($"factorial of {num} : {fact}");
        }
        //Case 2 for Strong Number
        public void StrongNumber()
        {
            Console.Write("Enter Number : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0, rem = 0;
            int temp = num;

            while (num != 0)
            {
                rem = num % 10;
                int f = Program.getfactorial(rem);
                num /= 10;
                sum += f;
            }
            if (sum == temp)
                Console.WriteLine($"{temp} is Strong Number");
            else
                Console.WriteLine($"{temp} is Not Strong Number");
        }

        //Case 3 for Sum of diagonal
        public void SumOfDiagonal()
        {
            // Console.WriteLine("Enter Number of rows and cols : ");
            //int[][] arr=Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[3, 3] {
            { 1,2,3},
            { 4,5,6},
            { 9,8,9}
            };
            int sum = 0, RtL = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($" I is {arr[i, 0]} and J values : {arr[i, j]}");

                    if ((i == 0 && j == 0))
                    {
                        sum += arr[i, 0];
                        RtL += arr[i, 2];
                    }
                    else if ((i == 1 && j == 1))
                    {
                        sum += arr[i, 1];
                        RtL += arr[i, 1];
                    }
                    else if ((i == 2 && j == 2))
                    {
                        sum += arr[i, 2];
                        RtL += arr[i, 0];
                    }

                }

            }
            Console.WriteLine($" and LtoR sum of diagonal : {sum} and Right To Left is {RtL}");
        }

        //Case 4 SwappingCharacter
        public string[] SwappingCharacter(string str)
        {
            string[] result = new string[str.Length];
            string[] strArr = str.Split(" ");
            for (int i = 0; i < strArr.Length; i++)
            {
                char[] ch = strArr[i].ToCharArray();
                for (int j = ch.Length - 1; j >= 0; j--)
                {
                    strArr[i] = Convert.ToString(ch[j]);
                    result[i] += strArr[i];
                }
            }
            return result;
        }

    }
}
