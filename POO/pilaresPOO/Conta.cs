using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilaresPOO
{
    public abstract class Conta
    { 
        public float saldo { get; set; }

        public string?   Titular { get; set; }

        public abstract float Sacar (float valor);
        public abstract bool Depositar (float valor);


        public float getSaldo(){
            return saldo;
        }
        }
    }
