using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia (numero: "9999-8888",modelo: "básico", imei:"111100000",memoria: 65);
nokia.Ligar();
nokia.InstalarAplicativo("dotnet");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone (numero: "5555-7777",modelo: "médio", imei:"222223333",memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("vccode");