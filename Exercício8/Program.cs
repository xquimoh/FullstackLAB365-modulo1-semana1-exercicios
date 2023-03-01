Console.WriteLine ("Vamos descobrir os 20 primeiros números da Sequência de Fibonacci!");

int[] fibo = new int[20];
fibo[0] = 1;
fibo[1] = 1;

for (int i = 2; i < 20; i++) {
    fibo[i] = fibo[i-1] + fibo[i-2];
}

for (int i = 0; i < 20; i++) {
    Console.WriteLine (fibo[i] + ",");
}