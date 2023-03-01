float lado1;
float lado2;
float lado3;

Console.WriteLine ("Vamos descobrir que triângulo é esse?");
Console.WriteLine ("Digite o valor dos 3 lados do triângulo");
Console.WriteLine ("Digite o valor do lado 1:");
lado1 = float.Parse (Console.ReadLine());
Console.WriteLine ("Digite o valor do lado 2:");
lado2 = float.Parse (Console.ReadLine());
Console.WriteLine ("Digite o valor do lado 3:");
lado3 = float.Parse (Console.ReadLine());


if (!(lado1 + lado2 > lado3 || lado2 + lado3 > lado1 || lado3 + lado1 > lado2)) {
    Console.WriteLine ("Isso não é um triângulo");
    return;
}


        Console.WriteLine ("Os lados formam um triângulo!");
    if (lado1 == lado2 && lado2 == lado3 && lado1 == lado3) {
        Console.WriteLine ("Seu triângulo é equilátero (três lados iguais)");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1) {
        Console.WriteLine ("Seu triângulo é isósceles (dois lados iguais)");
    }
    else if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1) {
        Console.WriteLine ("Seu triângulo é escaleno (três lados diferentes)");
    }