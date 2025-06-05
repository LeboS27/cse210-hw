using System;

public class ReflectingActivity : MindfulnessActivity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "What did you learn from it?",
        "How did you get started?",
        "How did it make you feel?",
        "How can you apply this experience in the future?"
    };

    public ReflectingActivity() : base("Reflection Activity", "This activity helps you reflect on your strengths and resilience.") { }

    protected override void PerformActivity()
    {
        Random rnd = new Random();
        Console.WriteLine(_prompts[rnd.Next(_prompts.Length)]);
        ShowSpinner(3);

        int duration = GetDuration();
        while (duration > 0)
        {
            Console.WriteLine(_questions[rnd.Next(_questions.Length)]);
            ShowSpinner(5);
            duration -= 5;
        }
    }
}
