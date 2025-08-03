using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());
        // TODO: Implementar la lógica de menú


        Console.Write("Ingrese el primer número: ");
        double num1;
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            return;
        }

        Console.Write("Ingrese el segundo número: ");
        double num2;
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            return;
        }

        double resultado = 0;
        switch (opcion)
        {
            
            case 2:
                resultado = Resta(num1, num2);
                Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                break;
           
        }
    }


    static double Resta(double a, double b)
    {
        return a - b;
    }

}

    // TODO: Implementar funciones de suma, resta, multiplicación, división