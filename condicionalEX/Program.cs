// See https://aka.ms/new-console-template for more information

Console.WriteLine (@$"
+------------------------------+
|     Bem Vindo ao Programa    |
|             do               |
|          orçamento           |
+------------------------------+
");



Console.WriteLine ($"5)Informe seu salario recebido:");
int salarioR = int.Parse(Console.ReadLine());

Console.WriteLine ($"5)Informe seu salario gasto:");
int salarioG = int.Parse(Console.ReadLine());

if (salarioR >= salarioG) {
Console.WriteLine ($"Gasto dentro do orçamento");
}
else {
    Console.WriteLine ($"Orçamento estourado");
}