using DesafioPOO.Models;

Iphone iphone = new Iphone("5593999-9999","15 Pro","1111111",32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("____________________");

Nokia nokia = new Nokia("5593999-9999", "Tijolão das antigas", "1111111", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Firefox");