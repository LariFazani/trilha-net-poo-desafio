namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor da classe filha
        //public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        //{
            // TODO: Implementar inicialização específica da classe iPhone se necessário
        //}

        // Sobrescrever o método InstalarAplicativo
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} no iPhone...");
        }
        public override void Ligar()
        {
            Console.WriteLine("Ligando o Iphone...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo chamadas no Iphone...");
        }
    }
}