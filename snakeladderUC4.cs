using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeandladder
{
    internal class snakeladderUC4
    {
        public static void UC4()
        {
            int position = 0;
            Console.WriteLine("position is " + position);


            Random obj = new Random();
            int rollDice = obj.Next(1, 7);
            Console.WriteLine("Dice Value: " + rollDice);

            Random num = new Random();
            int value = num.Next(1, 4);
            Console.WriteLine("case number is " + value);

            while (position <= 99)
            {

                Random var = new Random();
                int optionValue = var.Next(1, 4);

                switch (optionValue)
                {
                    case 1:
                        Console.WriteLine("No Play You are in the same position");
                        break;
                    case 2:
                        position = (position + rollDice);
                        Console.WriteLine("your position after ladder is: " + position);
                        break;

                    case 3:
                        position = (position - rollDice);
                        if (position < 0)
                        {
                            position = 0;
                        }
                        Console.WriteLine("Your Position after snake is: " + position);
                        break;
                }
            }
        }
    }
}
