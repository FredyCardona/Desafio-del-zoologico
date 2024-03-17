using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZoologicoVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool abandonar = false;

            do
            {


                Console.WriteLine("Bienvenido al zoologico!");
              
                Console.WriteLine("1. Visitar al Leon");
                Console.WriteLine("2. Visitar al Elefante");
                Console.WriteLine("3. Visitar a la Jirafa");
                Console.WriteLine("4. Visitar al tigre");
                Console.WriteLine("5. Visitar al Mono");
                Console.WriteLine("6. Visitar al Oso");
                Console.WriteLine("7. Visitar al Cocodrilo");
                Console.WriteLine("8. Visitar a la Serpiente");
                Console.WriteLine("9. Visitar al Pinguino");
                Console.WriteLine("10. Visitar al Lobo");
                Console.WriteLine("11. Visitar a la Cebra");
                Console.WriteLine("12. Visitar al rinoceronte");
                Console.WriteLine("13. Visitar al Panda");
                Console.WriteLine("14. Visitar al Pavo Real");
                Console.WriteLine("15. Visitar a la Tortuga");
                Console.Write("Guia?: ");
                int opcion = int.Parse(Console.ReadLine()); 

                

                switch (opcion)
                {
                   
                    case 0:abandonar = true;break;
                    case 1:visitas.visitarLeon();break;
                    case 2: visitas.visitarElefante(); break;
                    case 3: visitas.visitarJirafa(); break;
                    case 4: visitas.visitarTigre(); break;
                    case 5: visitas.visitarMono(); break;
                    case 6: visitas.visitarOso(); break;
                    case 7: visitas.visitarCocodrilo(); break;
                    case 8: visitas.visitarSerpiente(); break;
                    case 9: visitas.visitarPinguino(); break;
                    case 10: visitas.visitarLobo(); break;
                    case 11: visitas.visitarCebra(); break;
                    case 12: visitas.visitarRinoceronte(); break;
                    case 13: visitas.visitarPanda(); break;
                    case 14: visitas.visitarPavoReal(); break;
                    case 15: visitas.visitarTortuga(); break;
                    default: Console.WriteLine("La opcion no está dentro de los parametros"); break;


                }

                Console.ReadKey();
                Console.Clear();

            } while (!abandonar);

            Console.ReadKey(true);



        }






       

    }



}