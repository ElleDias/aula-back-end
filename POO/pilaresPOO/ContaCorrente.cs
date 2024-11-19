namespace pilaresPOO
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(float limite)
        {
            this.limite = limite;

        }
        public float limite { get; set; }

        public override bool Depositar(float valor)
        {
            if (valor > 0)
            {
                saldo = saldo + valor;
                return true;

            }
            else
            {

                return false;
            }
        }

        public override float Sacar(float valor)
        {
            if (valor <= saldo){
                saldo = saldo - valor;
            return valor;
            }else

        {
    Console.WriteLine("Saldo insuficiente para o saque.");
        return 0;  // Retorna 0 se não houver saldo suficiente
        }
        }
}
}