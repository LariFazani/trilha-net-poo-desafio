namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public abstract void Ligar();
        public abstract void ReceberLigacao();
        public abstract void InstalarAplicativo(string nome);

        // Construtor da classe abstrata
        //public Smartphone(string numero, string modelo, string imei, int memoria)
        //{
            //Numero = numero;
            //Modelo = modelo;
            //Imei = imei;
            //Memoria = memoria;
        //}

        //public void Ligar()
        //{
            //Console.WriteLine("Ligando...");
        //}

        //public void ReceberLigacao()
        //{
            //Console.WriteLine("Recebendo ligação...");
        //}

        // Método abstrato que deve ser implementado nas classes filhas
        //public abstract void InstalarAplicativo(string nomeApp);
    }
}