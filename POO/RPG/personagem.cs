namespace RPG.Classes
{
    public class personagem
    {
        public string Nomepg;
        public int Idadepg = 0;
        public string NomeDaArmadura;
        public string inteligênciaArtificial;
        public void ATAQUE()
        {
 Console.WriteLine("O personagem atacou!");

        }
        public void DEFESA()
        {

 Console.WriteLine("O personagem defendeu!");
        }
       public void ARMADURA()
        {
 Console.WriteLine("O personagem restaurou a armadura!");
            
        }
    }
}



