// See https://aka.ms/new-console-template for more information

//Console.WriteLine ($"Ola, digite seu nome:");
//string nome = Console.ReadLine();
//Console.WriteLine ($"Ola, digite seu nome:");
//string sobrenome = Console.ReadLine();
//Console.WriteLine ($"Obrigado: {nome} {sobrenome}");



//criar um cabeçalho de boas vindas
//pedir dados de cadastro

Console.WriteLine(@"
+---------------------------------------------+
|            PROGRAMA DE CADASTROS            |
+                                             +
|      Por favor digite seus dados abaixo     |
+---------------------------------------------+

");



//nome
Console.WriteLine ($"1)Ola, digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine ($"Ola {nome} digite, seu sobrenome:");
string sobrenome = Console.ReadLine();

//data de nascimento
Console.WriteLine ($"3)Agora {nome} {sobrenome} digite sua data de nascimento:");
string dtNascimento = Console.ReadLine();


// email
Console.WriteLine ($"4) Digite seu email:");
string email = Console.ReadLine();

//telefone
Console.WriteLine ($"5)Digite seu telefone:");
UInt128 telefone = UInt128.Parse(Console.ReadLine());

//cpf
Console.WriteLine ($"6)Digite seu cpf:");
UInt128 cpf = UInt128.Parse(Console.ReadLine());

//endereço
Console.WriteLine ($"7)Digite seu endereço:");
string endereco = Console.ReadLine();

//idade- calcular baseado na data de nascimento
Console.WriteLine ($"8) {nome} Em que ano você nasceu?");
int anoNascimento = int.Parse(Console.ReadLine());
int AnoAtual = DateTime.Now.Year;
int idade = AnoAtual - anoNascimento;

//estado civil
Console.WriteLine ($"9){nome} {sobrenome} , digite seu estado civil:");
string estadocivil = Console.ReadLine();

//mostrar dado
Console.WriteLine ("\n");

Console.WriteLine ($"Obrigado: {nome} {sobrenome} Pelo seu Cadastro ");
Console.WriteLine ($"Sua data de nascimento: {dtNascimento}");
Console.WriteLine ($"Seu email: {email}");
Console.WriteLine ($"Seu telefone: {telefone}");
Console.WriteLine ($"Seu cpf: {cpf}");
Console.WriteLine ($"Seu endereço: {endereco}");
Console.WriteLine ($"Seu Estado Civil: {estadocivil}");
 Console.WriteLine ($"Sua idade eh: {idade}");



