using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("31999999999", "NokiaX", "33333333333", 256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("App da DIO");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("31999999999", "Iphone 14 pro max", "33333333333", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("App da DIO");
