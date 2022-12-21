using AbstraindoumCelularcomPOO.Models;

Console.WriteLine("Teste Nokia");
Smartphone nokia = new Nokia("(11) 92222-2222", "Uia4", "123123123", 64);
nokia.Ligar();
nokia.InstalarAplicativo("LinkedIn");

Console.WriteLine("\n");

Console.WriteLine("Teste iPhone");
Smartphone iphone = new Iphone("(11) 93333-3333", "Modelo Top", "321321321", 185);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");