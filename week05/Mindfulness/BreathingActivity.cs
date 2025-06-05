using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.") { }

    protected override void PerformActivity()
    {
        int duration = GetDuration();
        while (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            duration -= 4;

            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
            duration -= 4;
        }
    }
}
