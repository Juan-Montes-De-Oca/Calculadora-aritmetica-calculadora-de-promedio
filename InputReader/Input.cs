public static class InputReader
{
    public static bool TryRead(string message, out double result)
    {
        Console.WriteLine(message);
        bool isValid = double.TryParse(Console.ReadLine(), out result);

        if (!isValid)
        {
            Alerts.NotValidNumber();
            Alerts.Pause();
        }
        return isValid;
    }
}