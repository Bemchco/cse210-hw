public class BreathingActivity : Activity
{
    public override void Run()
    {
        SetActivityInfo("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        DisplayStartingMessage();

        int elapsed = 0;
        int duration = GetDuration();

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            elapsed += 4;

            if (elapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(6);
            elapsed += 6;
        }

        DisplayEndingMessage();
    }
}
