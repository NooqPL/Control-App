using System;
using System.Timers;

public class FakePort
{
    public event Action<string> DataReceived;

    private Timer _timer;
    private Random _rand = new Random();

    public void Open()
    {
        _timer = new Timer(1000); // 1 sekunda
        _timer.Elapsed += (s, e) =>
        {
            string fakeData = "TEMP:" + (20 + _rand.NextDouble() * 30).ToString("0.0");
            DataReceived?.Invoke(fakeData);
        };
        _timer.Start();
    }

    public void WriteLine(string command)
    {
        Console.WriteLine("Wysłano komendę: " + command);
        // Można tu dodać logikę odpowiedzi np. na OPEN/CLOSE
    }
}
