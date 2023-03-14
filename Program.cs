namespace Calculadora
{
    class Program
    {
        public static void Main()
        {
            bool continuar = true;

            decimal n1 = 0;
            decimal n2 = 0;
            string expressao = "";
            int posicao = 0;

            string[] historico = new string[100];

            while (continuar)
            {
                int opcao = Menu();

                if (opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4)
                {
                    Console.Clear();
                    System.Console.Write("Informe o primeiro valor: ");
                    n1 = Convert.ToDecimal(Console.ReadLine());

                    System.Console.Write("Informe o segundo valor: ");
                    n2 = Convert.ToDecimal(Console.ReadLine());
                    Console.Clear();

                }
                switch (opcao)
                {
                    case 1:
                        System.Console.WriteLine(expressao = $"{n1} + {n2} = {n1 + n2}");
                        historico[posicao] = expressao;
                        posicao++;
                        break;
                    case 2:
                        System.Console.WriteLine(expressao = $"{n1} - {n2} = {n1 - n2}");
                        historico[posicao] = expressao;
                        posicao++;
                        break;
                    case 3:
                        System.Console.WriteLine(expressao = $"{n1} / {n2} = {Math.Round((n1 / n2), 2)}");
                        historico[posicao] = expressao;
                        posicao++;
                        break;
                    case 4:
                        System.Console.WriteLine(expressao = $"{n1} x {n2} = {n1 * n2}");
                        historico[posicao] = expressao;
                        posicao++;
                        break;

                    case 5:
                        GerarTabuada();
                        break;

                    case 6:
                        MostrarOperacoesEfetuadas(historico);
                        break;

                    case 7:
                        continuar = false;
                        break;

                    default:
                        System.Console.WriteLine("Opção Inválida\nTecle para continuar");
                        Console.ReadLine();
                        break;
                }
                Console.ReadKey();
            }

        }

        public static int Menu()
        {
            Console.Clear();
            System.Console.WriteLine("--- [CALCULADORA] ---\nSelecione uma Opção\n");
            System.Console.WriteLine("[1] Adição");
            System.Console.WriteLine("[2] Subtração");
            System.Console.WriteLine("[3] Divisão");
            System.Console.WriteLine("[4] Multiplicação");
            System.Console.WriteLine("[5] Gerar Tabuada");
            System.Console.WriteLine("[6] Mostrar Operações Efetuadas");
            System.Console.WriteLine("[7] Sair");

            return int.Parse(Console.ReadLine()!);
        }



        public static void GerarTabuada()
        {
            Console.Clear();
            System.Console.WriteLine("Digite o número da tabuada que gostaria de gerar");
            var opcao = int.Parse(Console.ReadLine()!);

            for (int i = 0; i <= 10; i++)
            {
                System.Console.WriteLine($"{opcao} x {i} = {opcao * i}");
            }
        }

        public static void MostrarOperacoesEfetuadas(string[] historico)
        {
            Console.Clear();
            System.Console.WriteLine(" -- Operações Salvas -- \n");

            foreach (var item in historico)
            {
                if (item != null)
                    System.Console.WriteLine(item);
            }
        }
    }
}

