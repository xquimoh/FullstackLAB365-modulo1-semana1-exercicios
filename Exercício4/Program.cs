Console.WriteLine ("Qual o seu salário?");
var salario = double.Parse (Console.ReadLine ());

int percentual;

if (salario <= 900) {
    percentual = 0;
    Console.WriteLine ("Isento de imposto");
    return;
}
else if (salario <= 1500) {
    percentual = 5;
    Console.WriteLine ("O imposto é de 5%");
}
else if (salario <= 2500) {
    percentual = 10;
    Console.WriteLine ("O imposto é de 10%");
}
else {
    percentual = 20;
    Console.WriteLine ("O imposto é de 20%");
}

var imposto = (salario/100)*percentual;

Console.WriteLine ($"O valor do imposto é de R$ {imposto}");