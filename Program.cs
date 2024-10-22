using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone i = new Iphone("123684255","iphone 11","46557557",16);
i.Ligar();
i.InstalarAplicativo("Telegram");

Console.WriteLine("./");

Nokia n =  new Nokia("654754","GH3","5646856",8);
n.ReceberLigacao();
n.InstalarAplicativo("Whatshap");