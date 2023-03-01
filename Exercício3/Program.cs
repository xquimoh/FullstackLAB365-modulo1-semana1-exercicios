decimal nota1;
decimal nota2;
decimal nota3;
decimal mediaNota;

Console.WriteLine ("Digite a primeira nota");
nota1 = decimal.Parse (Console.ReadLine ());
Console.WriteLine ("Digite a segunda nota");
nota2 = decimal.Parse (Console.ReadLine ());
Console.WriteLine ("Digite a terceira nota");
nota3 = decimal.Parse (Console.ReadLine ());

mediaNota = (nota1 + nota2 + nota3)/3;

if (mediaNota >= 6) {
    Console.WriteLine ("Estudante aprovade com média " + mediaNota);
}
else if (mediaNota >= 5 && mediaNota <6) {
    Console.WriteLine ("Estudante em recuperação com média " + mediaNota);
}
else {
    Console.WriteLine ("Estudante reprovade com média " + mediaNota);
}