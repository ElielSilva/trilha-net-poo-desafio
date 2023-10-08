using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("123456","modelo 1","11111111111",64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("6543211","modelo 2","2222222222",128);
iphone.Ligar();
iphone.InstalarAplicativo("telegram");
