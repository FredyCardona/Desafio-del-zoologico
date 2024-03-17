using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoVirtual
{
    internal class visitas
    {
        public static void visitarLeon()
        {
            
            Leon leon = new Leon("Blandito", "Macho");
            Console.WriteLine("Esta es la jaula de  {0}", leon);
            leon.hacerRuido();
            leon.comer();
            leon.caminar();
        }





        public static void visitarElefante()
        {
            Elefante elefante = new Elefante("Octavio", "Hombre");
            Console.WriteLine("Esta es la jaula de  {0} ", elefante);
            elefante.hacerRuido();
            elefante.comer();
            elefante.caminar();
        }



        public static void visitarJirafa()
        {
            Jirafa Jirafa = new Jirafa("Rizu", "Hembra");
            Console.WriteLine("Esta es la jaula de  {0} ", Jirafa);
            Jirafa.hacerRuido();
            Jirafa.comer();
            Jirafa.caminar();
        }



        public static void visitarTigre()
        {
            Tigre tigre = new Tigre("Neme", "Macho");
            Console.WriteLine("Esta es la jaula de  {0} ", tigre);
            tigre.hacerRuido();
            tigre.comer();
            tigre.caminar();
        }



        public static void visitarMono()
        {
            Mono mono = new Mono("Pancho", "Macho");
            Console.WriteLine("Esta es la jaula de  {0} ", mono);
            mono.hacerRuido();
            mono.comer();
            mono.caminar();
        }


        public static void visitarOso()
        {
            Oso oso = new Oso("Rosalia", "Hembra");
            Console.WriteLine("Esta es la jaula de  {0} ", oso);
            oso.hacerRuido();
            oso.comer();
            oso.caminar();
        }



        public static void visitarCocodrilo()
        {
            Cocodrilo cocodrilo = new Cocodrilo("Douglas", "Macho");
            Console.WriteLine("Esta es la jaula de  {0} ", cocodrilo);
            cocodrilo.hacerRuido();
            cocodrilo.comer();
            cocodrilo.caminar();
        }


        public static void visitarSerpiente()
        {
            Serpiente serpiente = new Serpiente("Mistad", "Macho");
            Console.WriteLine("Esta es la jaula de  {0} ", serpiente);
            serpiente.hacerRuido();
            serpiente.comer();
            serpiente.caminar();
        }



        public static void visitarPinguino()
        {
            Pinguino pinguino = new Pinguino("Simba", "hembra");
            Console.WriteLine("Esta es la jaula de  {0} ", pinguino);
            pinguino.hacerRuido();
            pinguino.comer();
            pinguino.caminar();
        }



        public static void visitarLobo()
        {
            Lobo lobo = new Lobo("Caucholo", "Hembra");
            Console.WriteLine("Esta es la jaula de  {0} ", lobo);
            lobo.hacerRuido();
            lobo.comer();
            lobo.caminar();
        }


        public static void visitarCebra()
        {
            Cebra cebra = new Cebra("Rajas", "Macho");
            Console.WriteLine("Esta es la jaula de  {0} ", cebra);
            cebra.hacerRuido();
            cebra.comer();
            cebra.caminar();
        }


        public static void visitarRinoceronte()
        {
            Rinoceronte rinoceronte = new Rinoceronte("Cuernito", "Macho");
            Console.WriteLine("Esta es la jaula de  {0} ", rinoceronte);
            rinoceronte.hacerRuido();
            rinoceronte.comer();
            rinoceronte.caminar();
        }


        public static void visitarPanda()
        {
            Panda panda = new Panda("Manchas", "Hembra");
            Console.WriteLine("Esta es la jaula de  {0} ", panda);
            panda.hacerRuido();
            panda.comer();
            panda.caminar();
        }


        public static void visitarPavoReal()
        {
            PavoReal pavoreal = new PavoReal("GLUGLUG", "Macho");
            Console.WriteLine("Esta es la jaula de  {0} ", pavoreal);
            pavoreal.hacerRuido();
            pavoreal.comer();
            pavoreal.caminar();
        }



        public static void visitarTortuga()
        {
            Tortuga tortuga = new Tortuga("Tobi", "Hembra");
            Console.WriteLine("Esta es la jaula de  {0} ", tortuga);
            tortuga.hacerRuido();
            tortuga.comer();
            tortuga.caminar();
        }




    }
}
