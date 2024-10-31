

using System.Collections.Generic;
using ClassesObjetos.classes;

Console.WriteLine();
Console.WriteLine(); 

Animal cachorro = new Animal();

cachorro.Nome = "Laid Amber";
cachorro.raca = "Dálmata";
cachorro.Cor = "preto e branco";
cachorro.Idade = 2;

Console.WriteLine($"Nome do cachorro:{cachorro.Nome}");
Console.WriteLine($"idade da {cachorro.Nome}:{cachorro.Idade}");
Console.WriteLine($"Raça da {cachorro.Nome}:{cachorro.raca}");
Console.WriteLine($"cor da {cachorro.Nome}:{cachorro.Cor}");

Console.WriteLine();
Console.WriteLine(); 


Animal coelho = new Animal();

coelho.Nome = "Lolita";
coelho.raca = "Mini Lop";
coelho.Cor = "branca";
coelho.Idade = 2;

Console.WriteLine($"Nome do Coelho:{coelho.Nome}");
Console.WriteLine($"idade da {coelho.Nome}:{coelho.Idade}");
Console.WriteLine($"Raça da {coelho.Nome}:{coelho.raca}");
Console.WriteLine($"cor da {coelho.Nome}:{coelho.Cor}");
