namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor da classe filha
        //public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        //{
            // TODO: Implementar inicialização específica da classe Nokia se necessário
        //}

        // Sobrescrever o método InstalarAplicativo
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no Nokia...");
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o Nokia...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo chamadas no Nokia...");
        }
    }
}