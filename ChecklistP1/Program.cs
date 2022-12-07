// quebra de frase por palavras usando o split

string frase;

Console.WriteLine("quais são as 7 cores do arco-iris ? ");

string[] v = Console.ReadLine().Split(' ');
string a = v[0];
string b = v[1];
string c = v[2];
string d = v[3];    
string e = v[4];
string f = v[5];  
string g = v[6];


Console.WriteLine("\n\n\nsua resposta foi: ");
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);


Console.ReadLine();