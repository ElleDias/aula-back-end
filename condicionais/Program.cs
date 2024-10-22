// See https://aka.ms/new-console-template for more information
//float precoProduto = 200;
//float nubgaCarteira = 350;


//criar um programa que responda se ey consigo comprar o produot sim ou nao

//Console.WriteLine ($"5)Digite seu telefone:");
//Console.WriteLine ($"");

Console.WriteLine (@$"
+------------------------------+
|     Bem Vindo ao Programa    |
|             do               |
|           Produto            |
+------------------------------+
");
Console.WriteLine ($"5)Digite o preco da sua carteira:");
UInt128 carteira = UInt128.Parse(Console.ReadLine());

Console.WriteLine ($"5)Digite o preco do produto:");
UInt128 produto = UInt128.Parse(Console.ReadLine());

if (carteira >= produto) {
Console.WriteLine ($"Voce consegue comprar o produto");
}
else {
    Console.WriteLine ($"Voce NÃO poderá comprar o produto");
}

