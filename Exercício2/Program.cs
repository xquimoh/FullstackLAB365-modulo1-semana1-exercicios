int baseT;
int altura;
int area;

Console.WriteLine ("Qual a base do triângulo?");
baseT = int.Parse (Console.ReadLine ());
Console.WriteLine ("Qual a altura do triângulo?");
altura = int.Parse (Console.ReadLine ());
area = (baseT*altura)/2;
Console.WriteLine ("A área do triângulo é " + area);
