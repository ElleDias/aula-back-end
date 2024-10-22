
Console.WriteLine (@$"
+------------------------------+
|     Bem Vindo ao Programa    |
|             dos              |
|       pontos de times        |
+------------------------------+
");





Console.WriteLine("Gols do time1");
float time1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Gols do time2");
float time2 = float.Parse(Console.ReadLine()!);

if(time1 > time2)
{
    Console.WriteLine($"O time1 ganhou do time2 com o placar de {time1} x {time2}");
}
else if (time1 < time2)
{
     Console.WriteLine($"O time2 ganhou do tim1 com o placar de {time2} x {time1}");
}
else
{
     Console.WriteLine($"Os times empataram com o placar de {time1} x {time2}");}