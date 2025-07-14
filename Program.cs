using System.Xml.Schema;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone (numero: "2712", model:"12", imei:"654645641621", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Aptoide");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone nokia = new Nokia (numero: "1602", model:"5", imei:"443654635345", memoria:256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Nubank");
