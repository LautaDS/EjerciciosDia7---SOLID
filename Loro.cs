using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia7
{
    class Loro : AnimalVolador
    {
        public void Comer()
        {
            Console.WriteLine("El loro come semillas y fruta");
        }

        public void Mover()
        {
            Console.WriteLine("El loro camina lento y se trepa muy bien");
        }

        public void PrintBehaviour()
        {
            Mover();
            Volar();
            Comer();
        }

        public void Volar()
        {
            Console.WriteLine("El loro vuela muy eficientemente");
        }
    }
}
