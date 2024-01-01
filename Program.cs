using System;

namespace DesafioPOO.Models
{
    class Program
    {
        static void Main()
        {
            // Teste com Iphone
            Iphone iphone = new Iphone("123456789", "iPhone X", "IMEI123", 64);
            RealizarTestes(iphone, "WhatsApp");

            // Teste com Nokia
            Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI456", 16);
            RealizarTestes(nokia, "Angry Birds");

            Console.ReadLine();
        }

       static void RealizarTestes(Smartphone smartphone, string aplicativo)
        {
            Console.WriteLine($"Modelo: {smartphone.GetModelo()}");
            Console.WriteLine($"IMEI: {smartphone.GetIMEI()}");
            Console.WriteLine($"Memória: {smartphone.GetMemoria()}GB");

            smartphone.Ligar();
            smartphone.ReceberLigacao();
            smartphone.InstalarAplicativo(aplicativo);

            Console.WriteLine();
        }
    }
}
