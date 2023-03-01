class Program
{
    static void Main(string[] args)
    {
        // Inicialização das variáveis
        List<double> transacoes = new List<double>();
        double saldo = 0;
        int opcao;

        // Apresentação do menu
        do
        {
            Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar:");
            Console.WriteLine("1 - Adicionar Transação");
            Console.WriteLine("2 - Consultar extrato");
            Console.WriteLine("3 - Sair");
            Console.Write("Opção escolhida: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: // Adicionar transação
                    Console.Write("Digite o valor da transação: ");
                    double valor = double.Parse(Console.ReadLine());
                    transacoes.Add(valor);
                    saldo += valor;
                    Console.WriteLine("Transação adicionada com sucesso!");
                    break;
                case 2: // Consultar extrato
                    Console.WriteLine("Histórico de transações:");
                    foreach (double transacao in transacoes)
                    {
                        Console.WriteLine(transacao);
                    }
                    Console.WriteLine("Saldo: " + saldo);
                    break;
                case 3: // Sair
                    Console.WriteLine("Programa encerrado.");
                    break;
                default: // Opção inválida
                    Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                    break;
            }
            Console.WriteLine();
        } while (opcao != 3);
    }
}