using System;
using System.Timers;

public class FakePort
{
    public event Action<string> DataReceived;

    private Timer _timer;
    private Random _rand = new Random();

    public void Open()
    {
        _timer = new Timer(5000); // co 1 sekundę
        _timer.Elapsed += (s, e) =>
        {
            double temp = 20 + _rand.NextDouble() * 30;
            double pressure = _rand.NextDouble() * 10;      // 0.0 - 10.0 bar
            int fuel = _rand.Next(0, 101);                  // 0 - 100 %

            // Symuluj dane telemetryczne
            DataReceived?.Invoke($"TEMP:{temp:0.0}");
            DataReceived?.Invoke($"PRESSURE={pressure:0.0}");
            DataReceived?.Invoke($"FUEL={fuel}");
        };

        _timer.Start();
    }

    public void WriteLine(string command)
    {
        Console.WriteLine("Wysłano komendę: " + command);
        // Możesz tu dorobić odpowiedź, np. symulować otwarcie zaworu
    }
}
