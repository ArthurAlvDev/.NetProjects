using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando o programa...");

        // Criando um smartphone Nokia
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 3310", imei: "1111111111", memoria: 32);
        Console.WriteLine("Teste com Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criando um smartphone iPhone
        Smartphone iphone = new Iphone(numero: "987654", modelo: "iPhone 13", imei: "2222222222", memoria: 128);
        Console.WriteLine("Teste com iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
