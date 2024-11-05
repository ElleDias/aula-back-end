﻿using System.Security.Cryptography;

Console.Clear();
Console.WriteLine("Bem vindo ao Nubanquinho");
Console.WriteLine();


ContaCorrente contaEmilly = new ContaCorrente();    
ContaCorrente contaClara = new ContaCorrente();    


contaEmilly.Titular = "Emilly";
contaEmilly.Depositar (100000f);

contaClara.Titular = "Clara";
contaClara.Depositar (100000f);


Console.WriteLine($"Conta da {contaEmilly.Titular} tem R$ {contaEmilly.Saldo}");
Console.WriteLine($"Conta da {contaClara.Titular} tem R$ {contaEmilly.Saldo}");

Console.WriteLine();
Console.WriteLine();


contaClara.Sacar(250f);
Console.WriteLine($"Voce sacou e sua conta ficou com R${contaClara.Saldo}");

Console.WriteLine($"Conta da {contaEmilly.Titular} tem R$ {contaEmilly.Saldo}");
Console.WriteLine($"Conta da {contaClara.Titular} tem R$ {contaClara.Saldo}");

Console.WriteLine();
Console.WriteLine();