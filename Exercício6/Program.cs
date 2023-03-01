Console.WriteLine ("Digite um número e obtenha a tabuada dele de 0 a 10!");
int num = int.Parse(Console.ReadLine());

Console.WriteLine (" ");

for (int i = 0; i <= 10; i++) {
    Console.WriteLine ($"{num} X {i} = {num*i}");
}
