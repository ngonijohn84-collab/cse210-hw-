using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartActivity();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountdown(4);

            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountdown(4);

            Console.WriteLine();
        }

        EndActivity();
    }
}