using DesafioPOO.Models;
class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia();
        nokia.Numero = "123456";
        nokia.Modelo = "Nokia 310";
        nokia.IMEI = "111111111";
        nokia.Memoria = 16;
        //Console.WriteLine("Smartphone Nokia:");
        //Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("jogoNokia");

        Console.WriteLine("\n");

        //Console.WriteLine("Smartphone IPhone:");
        //Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
        //iphone.ReceberLigacao();
        //iphone.InstalarAplicativo("Telegram");


        Iphone iphone = new Iphone();
        iphone.Numero = "123456";
        iphone.Modelo = "Iphone 9910";
        iphone.IMEI = "222222";
        iphone.Memoria = 132;
        //Console.WriteLine("Smartphone Nokia:");
        //Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("jogoIphone");
    }
}