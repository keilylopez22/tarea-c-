using System;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("1. Opción 1: Sumar");
            Console.WriteLine("2. Opción 2: Restar");
            Console.WriteLine("3. Opción 3: Multiplicar");
            Console.WriteLine("4. Opción 4: Dividir");
            Console.WriteLine("5. Opción 5: Salir");

            Console.WriteLine("Elige una de las opciones");
            int opcion = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = RealizarSumatoria();
                    break;

                case 2:
                    resultado = RealizarRest();
                    break;

                case 3:
                    resultado = RealizarMulti();
                    break;
                case 4:
                    resultado = RealizarDivision();
                    break;
                case 5:
                    Console.WriteLine("Has elegido salir de la aplicación");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Elige una opción entre 1 y 5");
                    break;
            }

            Console.WriteLine($"El resultado es: {resultado}");
        }
    }

    static int RealizarSumatoria()
    {
        Console.Write("Ingresa el primer número que deseas sumar: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el segundo número que deseas sumar: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        return num1 + num2;
    }

    static int RealizarRest()
    {
        Console.Write("Ingresa el primer número que deseas restar: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el segundo número que deseas restar: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        return num3 - num4;
    }

    static int RealizarMulti()
    {
        Console.Write("Ingresa el primer número que deseas multiplicar: ");
        int num5 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el segundo número que deseas multiplicar: ");
        int num6 = Convert.ToInt32(Console.ReadLine());
        return num5 * num6;
    }

    static int RealizarDivision()
    {
        Console.Write("Ingresa el numerador que deseas dividir: ");
        int num7numerador = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el denominador que deseas dividir: ");
        int num8denominador = Convert.ToInt32(Console.ReadLine());

        if (num8denominador != 0)
        {
            return num7numerador / num8denominador;
        }
        else
        {
            Console.WriteLine("ERROR: No puedes dividir por cero");
            return 0;
        }
    }
}





