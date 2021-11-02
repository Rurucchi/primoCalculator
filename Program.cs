using System;

namespace PrimoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking primogem number

            Console.WriteLine("Primogem number");
            int primoNumber = Int32.Parse(Console.ReadLine());

            // Asking for blessing

            Console.WriteLine("Do you possess the Blessing of the Welkin Moon ? (y/n)");
            string blessing = (Console.ReadLine());
            bool isBlessing = false;

            // Asking for Daily Check in

            Console.WriteLine("Daily check-in ?");
            int daily = Int32.Parse(Console.ReadLine());

            // Asking for pity
            Console.WriteLine("Pity ?");
            int pity = Int32.Parse(Console.ReadLine());
            pity = pity * 160;

            while (blessing.ToUpper() != "Y" & blessing.ToUpper() != "N")
            {
                Console.WriteLine("Do you possess the Blessing of the Welkin Moon ? (y/n)");
                blessing = (Console.ReadLine());
            }
            if (blessing.ToUpper() == "Y")
            {
                isBlessing = true;
            }

            // Declaring Variables

            int guarantee = 28800;
            int dayLeft = 0;
            int blessingAdd = 0;

            // -------------- Calculation part ---------------

            primoNumber += pity;
            
            if (isBlessing == true)
            {
                blessingAdd = 90;
            }

            while (primoNumber <= guarantee)
            {

                primoNumber += 60;
                dayLeft += 1;
                daily += 1;
                primoNumber += blessingAdd;

                if (daily == 4)
                {
                    primoNumber += 20;
                }
                else if (daily == 11)
                {
                    primoNumber += 20;
                }
                else if (daily == 20)
                {
                    primoNumber += 20;
                }
                else if (daily <= 31)
                {
                    daily = 0;
                }
            }
            Console.WriteLine($"For a total of {primoNumber},");
            Console.WriteLine($"Excluding events, {dayLeft / 2} days ({dayLeft / 60} months) are left before your next 50/50");
            Console.WriteLine($"and {dayLeft} days ({dayLeft / 30} months) are left before your next guaranteed limited 5-star character.");
        }
    }
}