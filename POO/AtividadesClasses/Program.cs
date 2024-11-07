using System;
using AtividadesClasses;

Veiculo carro = new Veiculo();

Console.WriteLine("Qual é a Marca do seu carro?");
carro.marca = Console.ReadLine()!;

Console.WriteLine("Qual é o Modelo do seu carro?");
carro.modelo = Console.ReadLine()!;

Console.WriteLine("Qual é a Potência do seu carro?");
carro.potencia = int.Parse(Console.ReadLine()!);

Console.WriteLine("Qual é a Quantidade de portas do seu carro?");
carro.qtdPortas = int.Parse(Console.ReadLine()!);

Console.WriteLine("Qual é a Cor do seu carro?");
carro.cor = Console.ReadLine()!;

Console.WriteLine("--------------------------------------------------------------------------------");

Console.WriteLine("Digite o som para Acelerar:");
string acelero  = Console.ReadLine()!;

Console.WriteLine("Digite o som para Ligar:");
string ligo  = Console.ReadLine()!;

Console.WriteLine("Digite o som para Desligar:");
string desligo  = Console.ReadLine()!;

Console.WriteLine("Digite o som para Freiar:");
string freio = Console.ReadLine();

// Exibir as informações do carro
Console.WriteLine("--------------------------------------------------------------------------------");

Console.WriteLine($"Marca do carro: {carro.marca}");
Console.WriteLine($"Modelo do carro: {carro.modelo}");
Console.WriteLine($"Potência do carro: {carro.potencia} CV");
Console.WriteLine($"Quantidade de portas: {carro.qtdPortas}");
Console.WriteLine($"Cor do carro: {carro.cor}");


carro.Acelerar(acelero);
carro.Ligar(ligo);
carro.Desligar(desligo);
carro.Freiar(freio);





