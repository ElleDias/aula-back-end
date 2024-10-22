//Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo  usuário.     A     senha     válida     é     o     número     1234.    Devem     ser    impressas     as    seguintes     mensagens:     

  // - ACESSO    PERMITIDO    caso    a    senha    seja    válida.     
  // - ACESSO    NEGADO    caso    a    senha    seja    inválida


// See https://aka.ms/new-console-template for more information

Console.WriteLine (@$"
+------------------------------+
|     Bem Vindo ao Programa    |
|             de               |
|     Confirmação de senha     |
+------------------------------+
");





Console.WriteLine ($"Informe sua senha");
int Senha1 = int.Parse(Console.ReadLine());

Console.WriteLine ($"confirme sua senha");
int Senha2 = int.Parse(Console.ReadLine());

if (Senha1 == Senha2) {
Console.WriteLine ($" ACESSO    PERMITIDO ");
}
else {
    Console.WriteLine ($"ACESSO    NEGADO");
}
