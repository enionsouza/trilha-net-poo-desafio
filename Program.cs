using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("***Teste para o Smartphone Nokia***");
Smartphone nokia = new Nokia(numero: "555-1234", modelo: "Nokia-01", imei: "123imei", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n-----------------------------------------------\n");

Console.WriteLine("***Teste para o Smartphone iPhone***");
Smartphone iphone = new Iphone(numero: "555-2023", modelo: "iPhone-01", imei: "456imei", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
