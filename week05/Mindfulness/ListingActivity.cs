using System;

public class ListingActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "When have you felt peace this month?",
        "Who are your heroes?"
    };

    public ListingActivity() : base("Listing Activity", "List as many positive things as you can.") { }

    protected override void PerformActivity()
    {
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Length)]);
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        int duration = GetDuration();
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
    }
}
