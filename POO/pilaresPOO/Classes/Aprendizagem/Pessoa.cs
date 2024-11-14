namespace PilaresPOO.Classes.Aprendizagem
{
    public class Pessoa 
    {
        public string nome;
        public int idade;
        public int CPF;
        public float Peso { get; set; }
        public float Altura { get; set; }
        public void Envelhecer()
        {
            idade++;
        }
        public void Engordar(float kg)
        {
            Peso = Peso + kg;
        }

        public void Emagrecer(float kg)
        {
            Peso = Peso - kg;
        }
    }
}