using System;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNUm1 = 0;
            int iNUm2 = 0;
            int iResult = 0;
            char cOption;

            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("A to Add");
            Console.WriteLine("S to Subtract");
            Console.WriteLine("D to Divide");
            Console.WriteLine("M to Multiply");
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            cOption = char.Parse(Console.ReadLine());
            cOption = char.ToUpper(cOption);

            Console.WriteLine("Please enter the first number: ");
            iNUm1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter the second number: ");
            iNUm2 = int.Parse(Console.ReadLine());

            if (cOption == 'A')
            {
                iResult = iNUm1 + iNUm2;
            }
            else if (cOption == 'M')
            {
                iResult = iNUm1 * iNUm2;
            }
            else if (cOption == 'S')
            {
                iResult = iNUm1 - iNUm2;
            }
            else
            {
                iResult = iNUm1 / iNUm2;
            }

            Console.WriteLine("The answer is:  " + iResult);
            Console.ReadLine();

            
        }
    }
}
