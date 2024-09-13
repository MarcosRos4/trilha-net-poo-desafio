using DesafioPOO.Models;

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine("SmartPhone Nokia: ");
Nokia nokia = new("40028922", "N+", "IMEI DO NOKIA", 300);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tetris 98");

Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine("\nSmartPhone Iphone: ");
Iphone iphone = new("12345678", "Iphone 19", "IMEI DO IPHONE", 10000);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Crypto Wallet");
Console.ResetColor();