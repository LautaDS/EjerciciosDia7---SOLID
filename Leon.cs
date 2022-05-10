using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosDia7
{
    class Leon : DepredadorTerrestre, Animal
    {
        public void Cazar()
        {
            Console.WriteLine("Despues de mucho esfuerzo atrapo una cebra"); ;
        }

        public void Comer()
        {
            Console.WriteLine("Come copiosas cantidades de carne de su presa");
        }

        public void Descansar()
        {
            Console.WriteLine("Como todo carnivoro, despues de comer necesita descansar bastante");
        }

        public void Mover()
        {
            Console.WriteLine("Un leon puede moverse sigilosamente o muy rapido");
        }

        public void PrintBehaviour()
        {
            Mover();
            Cazar();
            Comer();
            Descansar();
        }
    }
}
