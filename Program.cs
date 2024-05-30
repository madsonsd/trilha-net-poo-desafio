using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("91929394","C01", "1122334455", 256);
nokia.Ligar();
nokia.InstalarAplicativo("DIO");

Console.WriteLine("------------");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("95969798","15 PRO MAX", "5566778899", 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Digital Innovation One");