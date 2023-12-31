using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("912345678", "G42", "350693148621095", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Instagram");
nokia.ListarAppsInstalados();

Console.WriteLine();

Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone("978451236", "13 Pro Max", "350693147851095", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("Instagram");
iphone.ListarAppsInstalados();

Console.WriteLine();

Console.WriteLine("Smartphone IPhone 2");
Smartphone iphone2 = new Iphone("965325698", "12", "6464897984132132", 256);
iphone2.Ligar();
iphone2.ReceberLigacao();
iphone2.ListarAppsInstalados();