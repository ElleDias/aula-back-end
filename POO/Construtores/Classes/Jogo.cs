using System.Runtime.CompilerServices;
using Construtores.Classes;

namespace Construtores.Classes
{
    public class Jogo
    {
        public string nome2 { get; set; }
        public string genero { get; set; }
        public int preco { get; set; }
        public int lancamento { get; set; }

public Jogo (string ne, string gn, int pc, int lc){

    nome2 = ne;
    genero = gn;
    preco = pc;
    lancamento = lc;
}


public void ExibirDados(){
Console.WriteLine(@$"
nome: {nome2}
genero: {genero}
preco: {preco}
lancamento = {lancamento}
");}
    };
} 