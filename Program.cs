using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("NOKIA:");
Smartphone nokia = new Nokia(numero: "1190000-0000", modelo: "Tijolão", imei: "128947128942", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Chrome");

Console.WriteLine("IPHONE:");
Smartphone iphone = new Iphone(numero: "1190000-0000", modelo: "Tijolão", imei: "128947128942", memoria: 8);
iphone.Ligar();
iphone.InstalarAplicativo("Safire");