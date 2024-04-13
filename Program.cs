using programacion_1_clase_10;
using programacion_1_clase_10.Clase_base;
using programacion_1_clase_10.clase_hija;

Nintendo sw = new Nintendo();

sw.marca = "Nintendo Switch";
sw.aniolanzamineto = 2017;
sw.esportatil = true;

playstation ps = new playstation();

ps.marca = "play sattion 5";
ps.aniolanzamineto = 2020;
ps.control = "dual shock 5";

xbox sx = new xbox();
sx.marca = "series x";
sx.aniolanzamineto = 2020;
sx.gamepass = true;

string n = sw.mostrardetallesnintendo();
Console.WriteLine(n);
n = ps.mostrardetallesps();
Console.WriteLine(n);
n = sx.mostrardetallesxb();
Console.WriteLine(n);  

