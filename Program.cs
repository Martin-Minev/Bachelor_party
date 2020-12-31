using System;

namespace bachelor_party
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int targetMoney = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int totalPrice = 0;
            int totalPerson = 0;


            while (command != "The restaurant is full")
            {
                int groupSize = int.Parse(command);
                totalPerson += groupSize;
                int pricePerPerson = 0;
                command = Console.ReadLine();

                if (groupSize < 5)
                {

                    pricePerPerson = 100;
                }

                else
                {
                    pricePerPerson = 70;
                }

                int totalGroupPrice = groupSize * pricePerPerson;

                totalPrice += totalGroupPrice;
            }

            if (totalPrice>=targetMoney)
            {
                Console.WriteLine($"You have {totalPerson} guests and {totalPrice - targetMoney} leva left.");
            }

            else
            {
                Console.WriteLine($"You have {totalPerson} guests and {totalPrice} leva income, but no singer.");
            }


            
        }
    }
}
