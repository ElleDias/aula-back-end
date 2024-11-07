using RPG.Classes;
personagem rpgpersonagem = new personagem();

Console.Clear();
Console.WriteLine($"***** PROGRAMA RPG *****");
Console.WriteLine();

Console.Write("Define o nome do personagem: ");
rpgpersonagem.Nomepg = Console.ReadLine();

Console.Write("Represente a idade do seu personagem: ");
rpgpersonagem.Idadepg = int.Parse(Console.ReadLine());

Console.Write("Informe o nome da armadura utilizada pelo personagem: ");
rpgpersonagem.NomeDaArmadura = Console.ReadLine();

Console.Write("Nome da inteligência artificial que auxilia o personagem: ");
rpgpersonagem.inteligênciaArtificial = Console.ReadLine();

// Exibir as informações do carro
Console.WriteLine("--------------------------------------------------------------------------------");

Console.WriteLine($"Nome do personagem: {rpgpersonagem.Nomepg}");
Console.WriteLine($"Idade do personagem: {rpgpersonagem.Idadepg}");
Console.WriteLine($"Nome da armadura do personagem: {rpgpersonagem.NomeDaArmadura}");
Console.WriteLine($"Nome da inteligência Artificial: {rpgpersonagem.inteligênciaArtificial}");


rpgpersonagem.ATAQUE();
rpgpersonagem.DEFESA();
rpgpersonagem.ARMADURA();


