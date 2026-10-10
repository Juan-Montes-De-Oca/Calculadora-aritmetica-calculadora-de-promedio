using System;

public static class Alerts
{
    public static void NotValidOption()
    {
        Console.WriteLine("\nERROR! Debe seleccionar una de las siguientes opciones para continuar: \n1- Sumar \n2- Restar \n3- Multiplicar \n4- Dividir \n5 Calcular promedio del estudiante \n0- Cerrar programa \n");
    }

    public static void NotValidNumber()
    {
        Console.WriteLine("\nERROR! No es un numero valido. \n");
    }

    public static void NotValidDivision()
    {
        Console.WriteLine("\nERROR! No se puede dividir entre 0. \n");
    }

    public static void NotEnoughNumbers()
    {
        Console.WriteLine("\nERROR! Debe ingresar al menos 2 numeros para realizar la operacion. \n");
    }

    public static void ExitMessage()
    {
        Console.WriteLine("\nGracias por usar la calculadora. Hasta luego! \n");
    }

    public static void ResultMessage(double result)
    {
        Console.WriteLine($"\nEl resultado es {result} \n");
    }

    public static void Pause()
    {
        Console.WriteLine("\nPresione una tecla para continuar. \n");
        Console.ReadKey(true);
    }

    public static void GradeOutOfRange()
    {
        Console.WriteLine("\nERROR! La nota debe estar entre 0 y 100. \n");
    }

    public static void NoGrade()
    {
        Console.WriteLine("\nERROR! No se ha ingresado ninguna nota. Debe ingresar una nota entre 0 y 100. \n");
    }

    public static void IsApproved(bool StudentStatus, double average)
    {
        if (StudentStatus)
        {
            Console.WriteLine($"\n¡Felicidades! El estudiante ha APROBADO con un promedio de: {average:F2}\n");
        }
        else
        {
            Console.WriteLine($"\nEl estudiante ha REPROBADO con un promedio de: {average:F2}\n");
        }
    }
    
}