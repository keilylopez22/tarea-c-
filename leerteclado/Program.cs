namespace LeerTeclado
{

    /// <sumary>
    /// Leer datos desde teclado
    /// </sumary>
 class program
 {
        static void Main(string[] args)
        {
            Console.WriteLine("suma de dos numeros");
            Console.Write("Ingresa numero 1: ");
            //los datos se leen como cadena
            string dato = Console.ReadLine();
            //convertir a numero con int.parse
            int n1 =int.Parse(dato);
            Console.Write("ingresa numero 2: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("el resultado es: {0}", suma);
        }

    }
}
