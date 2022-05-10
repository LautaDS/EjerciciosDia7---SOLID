using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia7
{
    class Pinguino : AnimalNadador
    {
        
        public void Comer()
        {
            Console.WriteLine("El pinguino come pescado");
        }

        public void Mover()
        {
            Console.WriteLine("El pinguino camina lento, pero camina");
        }

        public void Nadar()
        {
            Console.WriteLine("El pinguino nada muy eficientemente");
        }

        public void PrintBehaviour()
        {
            Comer();
            Mover();
            Nadar();
        }
    }
}
