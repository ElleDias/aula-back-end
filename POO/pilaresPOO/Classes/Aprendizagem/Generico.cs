using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pilaresPOO.Classes.Aprendizagem;

namespace pilaresPOO.Classes;
    public class Generico : Personagem
    {
                public override void  Atacar()
        {
            Console.WriteLine($"O Personagem esta atacando⚔️");
            //Console.WriteLine($"{Nome.Personagem} esta atacando");
        }
    }
