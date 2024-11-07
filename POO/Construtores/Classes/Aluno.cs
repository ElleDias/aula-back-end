namespace Construtores.Classes
{
    public class Aluno
    {
        public string nome1 { get; set; }
        public int idade { get; set; }
        public string matricula { get; set; }

public Aluno (string nm, int idd, string mt){

    nome1 = nm;
    idade = idd;
    matricula = mt;
    }


public void ExibirDados(){
Console.WriteLine(@$"
Nome: {nome1}
Idade: {idade}
Matricula: {matricula}
");}
}
}