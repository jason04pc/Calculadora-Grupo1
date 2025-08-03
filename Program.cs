using System;

class Program
{
    static void Main()
    {
        //menu del programa
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");
        //obtencion de la seleccion de operacion
        int opcion = int.Parse(Console.ReadLine() ?? "");
        
        //ingreso de datos y asignacion a varianbles aplicables a operaciones
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());


        switch (opcion)
        {
            case 3:
                Console.WriteLine($"Resultado: ",num1 * num2);
                break;

        }
    }
    }
