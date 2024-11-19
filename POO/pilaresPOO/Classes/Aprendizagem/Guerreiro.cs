using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilaresPOO.Classes.Aprendizagem
{
    public class Guerreiro : Personagem
    {
                public override void  Atacar()
        {
            Console.WriteLine($"O guerreiro ataca sua espada⚔️");
            //Console.WriteLine($"{Nome.Personagem} esta atacando");
        }
    }
}