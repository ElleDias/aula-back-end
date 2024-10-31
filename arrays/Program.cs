Console.WriteLine(@"
+--------------------------------------+
|            SEJA BEM-VINDO            |
|                                      |
|             AO PROGRAMA              |
+--------------------------------------+
");

string[] carros = new string[3];


for (int n = 0; n < 3; n++)
{

    Console.WriteLine($"Digite o nome do carro a ser cadastrado:");
    carros[n] = Console.ReadLine();

}

Console.WriteLine($"O carro cadastrado é {carros[0]}, {carros[1]}, {carros[2]}"); ; ; ;
