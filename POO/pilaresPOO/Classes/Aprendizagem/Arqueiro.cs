using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilaresPOO.Classes.Aprendizagem
{
    public class Arqueiro : Personagem
    {
                public override void  Atacar()
        {
            Console.WriteLine($"O Arqueiro dispara uma flecha🏹");
            //Console.WriteLine($"{Nome.Personagem} esta atacando");
        }
    }
}