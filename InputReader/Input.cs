using System;

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

    public static bool TryExecuteOperation(int option, string operationName, out double finalResult)
    {
        finalResult = 0;

        if (!TryRead($"Introduzca el primer numero que desea {operationName}:", out finalResult))
        {
            return false;
        }

        int count = 1;

        while (true)
        {
            Console.WriteLine($"\nIngresa el siguiente numero para {operationName} (o el signo de '=' para calcular):");
            string input = Console.ReadLine();

            if (input == "=")
            {
                if (count < 2)
                {
                    Alerts.NotEnoughNumbers();
                    Alerts.Pause();
                    return false;
                }
                break;
            }

            if (double.TryParse(input, out double nextNum))
            {
                if (option == 4 && nextNum == 0)
                {
                    Alerts.NotValidDivision();
                    Alerts.Pause();
                    return false;
                }

                if (option == 1) finalResult = Calculator.Add(finalResult, nextNum);
                else if (option == 2) finalResult = Calculator.Subtract(finalResult, nextNum);
                else if (option == 3) finalResult = Calculator.Multiply(finalResult, nextNum);
                else if (option == 4) finalResult = Calculator.Divide(finalResult, nextNum);

                count++;
            }
            else
            {
                Alerts.NotValidNumber();
                Alerts.Pause();
            }
        }

        return true;
    }
}