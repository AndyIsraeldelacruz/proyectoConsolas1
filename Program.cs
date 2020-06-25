using System;

namespace MiprimerConsola
    
{
    class Program
    {
        static void Main(string[] args)

        {
            if (args.Length > 0)
            {
                Console.Write(args[0]);
            }

            Console.Write("Muy buenas  tardes le  agradecemos por habernos escogido.");


            Console.WriteLine("¿Digame  cúal es su nombre para poder ayudarlo?");

            string datosNecesarios = Console.ReadLine();

            Console.WriteLine("¿Es usted soltero o casado  ?");

            string datosNecesarios1 = Console.ReadLine();

            Console.WriteLine("¿Me ayuda con su número de cédula porfavor ?");

            string datosNecesarios2 = Console.ReadLine();

            Console.WriteLine("¿Cuantos años tiene ?");

            int datosNecesarios3 = Console.Read();

            Console.WriteLine("Usted  se llama " + datosNecesarios + " Su numero de   cedula es : " + datosNecesarios2 + 
                
                " porfavor  en unos   minutos lo ayudaremos  con su solicitud.");

            string datosNecesarios4 = Console.ReadLine();

        }

    }
}