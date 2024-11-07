namespace AtividadesClasses
{
    public class Veiculo
    {
        public string marca = "nulo";
        public string modelo = "nulo";
        public string cor = "nulo";
        public int potencia = 0;
        public int qtdPortas = 0;

        public void Acelerar(string SomAcelerar ) 
        {
            Console.WriteLine($"O som de ligar seu carro eh {SomAcelerar}");
        }

        // Método para Ligar
        public void Ligar (string SomLigar)
        {
            Console.WriteLine($"O som de ligar seu carro eh {SomLigar}");
        }

        // Método para Desligar
        public void Desligar(string SomDesligar)
        {
            Console.WriteLine($"O som de ligar seu carro eh {SomDesligar}");
        }

        // Método para Freiar
        public void Freiar(string SomFreiar)
        {
            Console.WriteLine($"O som de ligar seu carro eh {SomFreiar}");
        }
    }
}