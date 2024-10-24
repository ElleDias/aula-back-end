//DesafioLaco02: Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
//Total de Homens;
//Total de Mulheres;
//Média de idade dos Homens;
//Média de idade das mulheres.
//Nesta atividade você deverá postar o link do seu Github, de forma pública.


        int homens = 0;
        int mulheres = 0;
        int soma_idade_homens = 0;
        int soma_idade_mulheres = 0;

Console.WriteLine(@"
+--------------------------------------+
|            SEJA BEM-VINDO            |
|                                      |
|             AO PROGRAMA              |
|                                      |
|         CONTADOR DE PESSOAS          |
+--------------------------------------+
");

 Console.WriteLine($"Quantas pessoas tem na mesa?");
        int pessoas = int.Parse(Console.ReadLine()!);

        for (int n = 1; n <= pessoas; n++)
        {
            Console.WriteLine("Informe seu sexo (m / f):");
            string sexo = Console.ReadLine()!.ToLower();    

            Console.WriteLine("Informe o seu peso:");
            float peso = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe a sua idade:");
            int idade = int.Parse(Console.ReadLine()!);


    if (sexo == "m"){
        homens ++;
        soma_idade_homens += idade;
    }
    
    else if (sexo == "F"){
           mulheres ++;
         soma_idade_mulheres += idade;    
    }
}
media_idade_homens = soma_idade_homens / homens if homens > 0 else 0
media_idade_mulheres = soma_idade_mulheres / mulheres if mulheres > 0 else 0

Console.WriteLine($"A quantidade de homens é: {homens}");
Console.WriteLine($"A quantidade de mulheres é: {mulheres}");
Console.WriteLine($"A Media de idade dos homens é: {mediahomem}");
Console.WriteLine($"A Media de idade das mulheres é: {mediamulheres}");
