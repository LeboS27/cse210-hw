using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            Activity activity1 = null;

            switch (choice)
            {
                case "1":
                    activity1 = new BreathingActivity();
                    break;
                case "2":
                    activity1 = new ReflectingActivity();
                    break;
                case "3":
                    activity1 = new ListingActivity();
                    break;
                case "4":
                    running = false;
                    continue;
                default:
                    continue;
            }

            activity1.Start();
        }
    }
}
