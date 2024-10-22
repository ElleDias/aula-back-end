
Console.WriteLine (@$"
+------------------------------+
|     Bem Vindo ao Programa    |
|             de               |
|         Media aluno          |
+------------------------------+
");




Console.Write("informe a porcentagem da sua presença: ");
float frequencia = float.Parse(Console.ReadLine());

Console.Write("informe a sua media: ");
float nota = float.Parse(Console.ReadLine());

if (frequencia >= 75 && nota >= 7 ) {
    Console.WriteLine($"Aprovado");
} else if (nota >3 && nota <7 ) {
    Console.WriteLine($"Recuperação");
} else {
    Console.WriteLine($"Reprovado");
}