using System;
class Program
{
    static int Main()
    {
        int option;
        bool isValidOption;
        double result;
        double num1;
        double num2;

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
                if(!InputReader.TryRead("Introduzca el primer numero que desea sumar (Ejemplo: 1, 2, 3)", out num1)) break;

                if(!InputReader.TryRead("Introduzca el segundo numero que desea sumar (Ejemplo: 1, 2, 3)", out num2)) break;

                result = Calculator.Add(num1, num2);
                Alerts.ResultMessage(result);
                Alerts.Pause();
                break;

                case 2:
                if(!InputReader.TryRead("Introduzca el primer numero que desea restar (Ejemplo: 1, 2, 3)", out num1)) break;

                if(!InputReader.TryRead("Introduzca el segundo numero que desea restar (Ejemplo: 1, 2, 3)", out num2)) break;

                result = Calculator.Subtract(num1, num2);
                Alerts.ResultMessage(result);
                Alerts.Pause();
                break;

                case 3:
                if(!InputReader.TryRead("Introduzca el primer numero que desea multiplicar (Ejemplo: 1, 2, 3)", out num1)) break;

                if(!InputReader.TryRead("Introduzca el segundo numero que desea multiplicar (Ejemplo: 1, 2, 3)", out num2)) break;

                result = Calculator.Multiply(num1, num2);
                Alerts.ResultMessage(result);
                Alerts.Pause();
                break;

                case 4:
                if(!InputReader.TryRead("Introduzca el primer numero que desea dividir (Ejemplo: 1, 2, 3)", out num1)) break;

                if(!InputReader.TryRead("Introduzca el segundo numero que desea dividir (Ejemplo: 1, 2, 3)", out num2)) break;

                if(num2 == 0)
                    {
                        Alerts.NotValidDivision();
                        Alerts.Pause();
                        break;
                    }

                result = Calculator.Divide(num1, num2);
                Alerts.ResultMessage(result);
                Alerts.Pause();
                break;

                case 5:
                double gradeSum = 0;
                double gradeCount = 0;
                double gradeInput;

                    while (true)
                    {
                        if(!InputReader.TryRead("Ingresa una nota (0-100) o -1 para terminar:", out gradeInput))
                        {
                            continue;
                        }

                        if(gradeInput == -1) break;

                        if(gradeInput < 0 || gradeInput > 100)
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
        while(option != 0);

        return 0;
    }
}