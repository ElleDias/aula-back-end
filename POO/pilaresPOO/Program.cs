using pilaresPOO.Classes.Aprendizagem;


Pessoa joao = new Pessoa();
joao.nome = "";
Console.WriteLine($"{joao.nome} Nasceu com {joao.idade} anos");

Professor Alex = new Professor(1234556, 2500);

Alex.nome = "Alex";
Alex.idade = 26;




Aluno BrunoBorges = new Aluno();




BrunoBorges.nome = "Bruno Borges";
BrunoBorges.idade = 23;
BrunoBorges.CPF = 12123347;
BrunoBorges.matricula = "123456789";
BrunoBorges.Peso = 21;
BrunoBorges.Altura = 1.84f;
BrunoBorges.curso = "Curso";
BrunoBorges.media = 8;


Console.WriteLine($"Curso:{BrunoBorges.curso}");
Console.WriteLine($" Professor(a): {Alex.idade}");
Console.WriteLine($"{Alex.nome} seu idade eh: {BrunoBorges.idade}");







Console.WriteLine($"{BrunoBorges.nome} seu idade eh: {BrunoBorges.idade}");
Console.WriteLine($"{BrunoBorges.nome} seu cpf eh: {BrunoBorges.CPF}");
Console.WriteLine($"{BrunoBorges.nome} seu peso eh: {BrunoBorges.Peso}");
Console.WriteLine($"{BrunoBorges.nome} sua altura eh: {BrunoBorges.Altura}");
Console.WriteLine($"{BrunoBorges.nome} sua matricula eh: {BrunoBorges.matricula}");
Console.WriteLine($"{BrunoBorges.nome} seu curso eh: {BrunoBorges.curso}");
Console.WriteLine($"{BrunoBorges.nome}sua media eh: {BrunoBorges.media}");
Console.WriteLine();




//Veiculos Abstrata

//marca, modelo, cor, potencia, qtdportas


//ligar, desligar, buzinar

//carro-- qtdportas
//aviao qtdportas
//moto 

