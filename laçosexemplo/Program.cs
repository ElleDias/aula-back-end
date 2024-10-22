
+--------------------------------------+
|            SEJA BEM-VINDO            |
|                                      |
|             AO PROGRAMA              |
|                                      |
|         CONTADOR DE PESSOAS          |
+--------------------------------------+
");

//  criar um laco de 10 repeticoes dentro do laco perguntar o sexo da pessoa
// se for homem contar na variavel homem, se for mulher contar na variavel mulher.


int homem = 0;
int mulher = 0;
string sexo;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Qual o seu sexo?");
    sexo = Console.ReadLine();

    if(sexo == "feminino"){
        mulher++;
    }else{
        homem++;
    }
    
}

Console.WriteLine($"Quantidade de homem: {homem}");
Console.WriteLine($"Quantidade de mulher: {mulher}");

