using System.Runtime.CompilerServices;
using Construtores.Classes;

Veiculo carro1 = new Veiculo("Ford", " Ka", 2000, "Vermelho");
Veiculo carro2 = new Veiculo("Ford", " Mustang", 2010, "Preto");

carro1.ExibirDados();
carro2.ExibirDados();

Jogo game = new Jogo("Little Nigtmares", "Terror,Suspense", 256, 2017);

game.ExibirDados();

Aluno matriculaaluno = new Aluno("Bela Flores Matos", 16, "0000109357292178sp");

matriculaaluno.ExibirDados();

List<Jogo> estoqueJogos = new List<Jogo>();

Jogo c0Duty = new Jogo("Call of Duty", "Ação", 23, 2003);
Jogo c0DutyColossus = new Jogo(@"Call of Duty - Shadow of the 
Colossus", "Ação", 90, 2005);


Jogo Multiversus = new Jogo("Multiversus", "Ação", 00, 2022);
Jogo valorant = new Jogo("Valorant", "Battle Shooter", 00, 2022);


estoqueJogos.Add(c0Duty);
estoqueJogos.Add(c0DutyColossus);

estoqueJogos.Add(Multiversus);
estoqueJogos.Add(valorant);

foreach (var Jogo in estoqueJogos)
{
    Console.WriteLine($"Jogo: {Jogo.nome2}");
}








// altere o programa para que contenha os seguintes elementos:

// menu de opções:
// 1) Cadastrar jogo
// 2) Listar jogo
// 0) Sair

// os dados deverão ser solicitador ao usuário 

// o programa devera rodar ate o usuário escolher a opção sair




while (true)
{
    Console.WriteLine(@$"
1) Cadastrar jogo
2) Listar jogos
0) Sair
");
    //recebendo a opcao escolhida:
int resposta = int.Parse(Console.ReadLine());

    if (resposta == 1)
    {
        // Cadastrando o jogo:

        Console.WriteLine("Qual o nome do seu jogo?");
        string nome = Console.ReadLine();

        Console.WriteLine($"Qual o gênero do  {nome}?");
        string genero = Console.ReadLine();

        Console.WriteLine($"Qual o preço do {nome}?");
        int preco = int.Parse(Console.ReadLine());

        Console.WriteLine($"Qual o ano de lançamento do {nome}?");
        int lancamento = int.Parse(Console.ReadLine());

        Jogo novoJogo = new Jogo(nome, genero, preco, lancamento);
        estoqueJogos.Add(novoJogo);

        Console.WriteLine(@"Jogo cadastrado com sucesso!! 
        Caso deseje verificar como ficou , escolha a opção 2 \n");
    }
    else if (resposta == 2)
    {
        // Opção para listar os jogos cadastrados ( se nao tiver nenhum cadastrado vai aparecer a opção para cadastrar)
        if (estoqueJogos.Count > 0)
        {
            Console.WriteLine("\nJogos cadastrados:");
            foreach (var jogo in estoqueJogos)
            {
                jogo.ExibirDados();
            }
        }
        else
        {
            Console.WriteLine(@"Nenhum jogo cadastrado.
            Cadastre o Jogo primeiro, para ele ser listado \n");
        }
    }
    else if (resposta == 0)
    {
        // Opção para sair
        Console.WriteLine(@"Obrg por entrar no programa,
        Saindo do programa agora... 
        
        .
        
        ..

        ...
        
        Até logo!");
        break; // Encerra o loop e sai do programa
    }
    else
    {
        // Se o usuário inserir uma opção inválida
        Console.WriteLine("Opção inválida, tente novamente.\n");
    }
}