
//  criar um laco de 10 repeticoes dentro do laco perguntar o sexo da pessoa
// se for homem contar na variavel homem, se for mulher contar na variavel mulher.

//  criar um laco de 10 repeticoes 
// dentro do laco perguntar o sexo da pessoa
// se for homem contar na variavel homem, se for mulher contar na variavel mulher.

int homem= 0;
int mulher = 0;
int sport = 0;
int entrevistados = 0;
int nsport = 0;

Console.WriteLine(@"
+--------------------------------------+
|            SEJA BEM-VINDO            |
|                                      |
|             AO PROGRAMA              |
|                                      |
|         CONTADOR DE PESSOAS          |
+--------------------------------------+
");

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int pessoas = int.Parse(Console.ReadLine()!);


for (int n = 1; n <= pessoas; n++)
{
    Console.WriteLine("INforme seu sexo(m / f)");
    string sexo = Console.ReadLine()!;
    Console.WriteLine("voce gosta de esportes(s/n)?");
    string esporte = Console.ReadLine()!;


    if(sexo == "m")
    {
        homem++;
    }
    else 
    {
        mulher++;
    }
    
    if (esporte == "s" )
    {
        sport++;
    }else {
        nsport++;
    }
    
    float percentual = (100 / Entrevistados) * sport
}

Console.WriteLine($"A quantidade de homens é: {homem}");
Console.WriteLine($"A quantidade de mulheres é: {mulher}");
Console.WriteLine($"A quantidade de pessoa que gostam de esporte é: {sport}");
Console.WriteLine($"A quantidade de pessoa que NÃO gostam de esporte é: {nsport}");
Console.WriteLine($"A quantidade de pessoa que NÃO gostam de esporte é: {nsport}");
Console.WriteLine($"A quantidade de entrevistados é: {mulher + homem}");
Console.WriteLine($"percentual de pessoas que gostam de esportes {percentual}");