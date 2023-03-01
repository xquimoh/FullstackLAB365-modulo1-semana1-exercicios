Console.WriteLine ("Digite o nome do discente");
string nome = Console.ReadLine();

Console.WriteLine ("Digite a quantidade de notas a serem inseridas");
int quantidadeNotas;
while (!int.TryParse(Console.ReadLine(), out quantidadeNotas)){
   Console.WriteLine("Número inválido, digite novamente a quantidade de notas");
}

double[] notas = new double[quantidadeNotas];

for (int i = 0; i < quantidadeNotas; i++) {
  Console.WriteLine ("Digite a " + (i+1) + "a" + " nota:");
  notas[i] = double.Parse(Console.ReadLine());
}

double soma = 0;

Console.WriteLine (" ");
Console.WriteLine ($"Boletim do discente: {nome}");
for (int i = 0; i < quantidadeNotas; i++){
  Console.WriteLine ($"Nota {(i+1)}: {notas[i]}");
  soma = soma + notas[i];
}

double media = soma / quantidadeNotas;
string status;

if (media >= 6) {
  status = "Aprovado"; 
}
else if (media >= 5 ){
  status = "Recuperação";
}
else {
  status = "Reprovado"; 
}

Console.WriteLine ($"Média: {media} - {status}");