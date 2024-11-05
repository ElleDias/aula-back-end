using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco.obj
{
    public class Classes
    {
        
        public int NumeroConta;


        public string? Titular = "";

        public float saldo = 0;

        public void Depositar (float valor){

            saldo = saldo + valor;
        }
        
        public void Sacar (){

            saldo = saldo - saldo;
        }
    }
}