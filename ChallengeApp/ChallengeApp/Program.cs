﻿
﻿class Program
{
    static void Main()
    {
        string answer;

        do
        {
            Console.WriteLine("wprowadź liczbę: ");
            var number = Console.ReadLine();
            string numberInString = number.ToString();
            char[] letters = numberInString.ToArray();

            int counter0 = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            int counter7 = 0;
            int counter8 = 0;
            int counter9 = 0;

                foreach (char letter in letters)
                {
                    if (letter == '0')
                    {
                        counter0++;
                    }
                    else if (letter == '1')
                    {
                        counter1++;
                    }
                    else if (letter == '2')
                    {
                        counter2++;
                    }
                    else if (letter == '3')
                    {
                        counter3++;
                    }
                    else if (letter == '4')
                    {
                        counter4++;
                    }
                    else if (letter == '5')
                    {
                        counter5++;
                    }
                    else if (letter == '6')
                    {
                        counter6++;
                    }
                    else if (letter == '7')
                    {
                        counter7++;
                    }
                    else if (letter == '8')
                    {
                        counter8++;
                    }
                    else if (letter == '9')
                    {
                        counter9++;
                    }
                }
                Console.WriteLine($"cyfra 0 występuje {counter0}");
                Console.WriteLine($"cyfra 1 występuje {counter1}");
                Console.WriteLine($"cyfra 2 występuje {counter2}");
                Console.WriteLine($"cyfra 3 występuje {counter3}");
                Console.WriteLine($"cyfra 4 występuje {counter4}");
                Console.WriteLine($"cyfra 5 występuje {counter5}");
                Console.WriteLine($"cyfra 6 występuje {counter6}");
                Console.WriteLine($"cyfra 7 występuje {counter7}");
                Console.WriteLine($"cyfra 8 występuje {counter8}");
                Console.WriteLine($"cyfra 9 występuje {counter9}");

                Console.WriteLine("Czy chcesz powtórzyć program? (Y/N)");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "y") ;
        }
}