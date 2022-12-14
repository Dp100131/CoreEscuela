namespace CorEscuela.util
{
    public static class Printer
    {
        public static void DrawLine(int tam = 10){

            System.Console.WriteLine("\t"+"".PadLeft(tam, '='));

        }

        public static void WriteTitle(string titulo){

            int tam = titulo.Length + 4;
            DrawLine(tam);
            Console.WriteLine($"\t| {titulo} |");
            DrawLine(tam);

        }

        public static void Beep(int hz = 2000, int time = 500, int cantidad = 1){

            while (cantidad > 0)
            {
                Console.Beep(hz, time);
                cantidad--;
            }

        }

    }
}