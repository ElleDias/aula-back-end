using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PilaresPOO.Classes.Aprendizagem;

namespace pilaresPOO.Classes
{
    public class Professor : Pessoa
    {
        public int NIF { get; set; }

        public float Salario { get; set; }

    public Professor(int nif, float salario)
        {
            NIF = nif;
            Salario = salario;

        }
    }
    }