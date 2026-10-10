using System;

class Program
{
    static int Main()
    {
        int option;
        bool isValidOption;
        double result;

        Console.WriteLine("=== CALCULADORA ARITMETICA & CALCULADORA DE PROMEDIO ===");

        do
        {
            Console.Clear();
            Menu.MainMenu();
            isValidOption = int.TryParse(Console.ReadLine(), out option);

            if (!isValidOption)
            {
                option = -1;
                Alerts.NotValidOption();
                Alerts.Pause();
                continue;
                
            }

            switch (option)
            {
                case 1:
                    if (InputReader.TryExecuteOperation(1, "sumar", out result))
                    {
                        Alerts.ResultMessage(result);
                        Alerts.Pause();
                    }
                    break;

                case 2:
                    if (InputReader.TryExecuteOperation(2, "restar", out result))
                    {
                        Alerts.ResultMessage(result);
                        Alerts.Pause();
                    }
                    break;

                case 3:
                    if (InputReader.TryExecuteOperation(3, "multiplicar", out result))
                    {
                        Alerts.ResultMessage(result);
                        Alerts.Pause();
                    }
                    break;

                case 4:
                    if (InputReader.TryExecuteOperation(4, "dividir", out result))
                    {
                        Alerts.ResultMessage(result);
                        Alerts.Pause();
                    }
                    break;

                case 5:
                    double gradeSum = 0;
                    double gradeCount = 0;
                    double gradeInput;

                    while (true)
                    {
                        if (!InputReader.TryRead("Ingresa una nota (0-100) o -1 para terminar:", out gradeInput))
                        {
                            continue;
                        }

                        if (gradeInput == -1) break;

                        if (gradeInput < 0 || gradeInput > 100)
                        {
                            Alerts.GradeOutOfRange();
                            Alerts.Pause();
                            continue;
                        }
                        else
                        {
                            gradeCount += 1;
                            gradeSum += gradeInput;
                        }
                    }

                    if (gradeCount == 0)
                    {
                        Alerts.NoGrade();
                        Alerts.Pause();
                    }
                    else
                    {
                        double average = StudentGrade.StudentAvg(gradeSum, gradeCount);
                        bool status = StudentGrade.StudentStatus(average);
                        Alerts.IsApproved(status, average);
                        Alerts.Pause();
                    }
                    break;

                case 0:
                    Alerts.ExitMessage();
                    break;

                default:
                    Alerts.NotValidOption();
                    Alerts.Pause();
                    break;
            }
        }
        while (option != 0);

        return 0;
    }
}
