using System.ComponentModel;
using DesafioPOO.Models;

// Realiza os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "1125trg7", memoria: 128); 
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "1598", modelo: "Modelo 2", imei: "1563tgh9", memoria: 128); 
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");