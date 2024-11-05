using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//namespace e um recurso usado para nomear os arquivos e deixar as partes unicas
namespace ClassesObjetos.classes
{
    public class Animal
    {
        public string raca;
        public string Cor;
        public string Nome;
        public int Idade =0;

        public void FazerBarulho(string barulho = "Barulho genérico"){
    Console.WriteLine($"Som que o/a {Nome} faz: {barulho} ");
}
    

    public void Envelhecer()
    {
        Idade = Idade +1;
    }
}
}