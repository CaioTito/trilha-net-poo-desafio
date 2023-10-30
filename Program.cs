using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "999999999", modelo: "N90", iMEI: "11111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "111111111", modelo: "XR", iMEI: "2222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");