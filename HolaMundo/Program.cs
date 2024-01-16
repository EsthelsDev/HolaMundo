internal class Program
{
    private static void Main(string[] args)
    {


        /*
         * 
         * PROBLEMA: HALLAR EL NÚMERO ALEATOIO GENERADO USANDO WHILE: 
         * 
        int ale = new Random().Next(0, 100);
        int intentos =0;

        Console.WriteLine("que número se generó?");
        int respuesta = int.Parse(Console.ReadLine());
        while (ale != respuesta) {
            if (ale < respuesta) Console.WriteLine("Te pasaste");
            if (ale > respuesta) Console.WriteLine("Te falto poco");
            Console.WriteLine("Intentalo de nuevo");
            respuesta = int.Parse(Console.ReadLine());
            intentos++;
        }

        Console.WriteLine($"Lo lograste!!! el número aleatorio era {ale}");*/




        /*
         * 
         * HALLA EL NÚMERO GENERADO USANDO DO-WHILE
         * 
         */
        int ale = new Random().Next(0, 100);
        int intentos = 0;
        int respuesta;
        Console.WriteLine("Se genero un número entre 0 y 100, sabes cual fue??");
        do
        {
            intentos++;

            try
            {
                respuesta = int.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("No has introducico un valor númerico");
                respuesta=0;
            }
            
            if (ale < respuesta) Console.WriteLine("Te pasaste");
            if (ale > respuesta) Console.WriteLine("Te falto poco");
            Console.WriteLine("Intentalo de nuevo");
        } while (ale!=respuesta);

        Console.WriteLine($"Lo lograste en {intentos} intentos!!! el número aleatorio era {ale}"); 
        



    }
}