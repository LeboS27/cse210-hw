abstract class Activity(string name, string description)
{
    protected string _name = name;
    protected string _description = description;
    protected int _duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"{_name}\n{_description}");
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        PerformActivity();

        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected int GetDuration() => _duration;

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected static void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

        protected abstract void PerformActivity();
    }
