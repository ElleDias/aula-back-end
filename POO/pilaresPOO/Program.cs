using pilaresPOO;
Console.WriteLine($"Danielle");

Console.Clear();

ContaCorrente ctDani = new ContaCorrente(12500.0f);
ctDani.Titular = "Danielle C C D Santos";
ctDani.Depositar (12500.0f);


Console.WriteLine($"Titular da conta: {ctDani.Titular}");
Console.WriteLine($"Saldo da conta: {ctDani.saldo}");


float valorSacado = ctDani.Sacar (500);
Console.WriteLine($"Valor do saque: {valorSacado}");
Console.WriteLine($"Novo saldo: {ctDani.saldo}");