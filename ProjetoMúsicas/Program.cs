// Music App
string mensBoasVindas = "Seja bem vindo ao Music App\n";
//List<string>listaDasBandas = new List<string> { "123", "456" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Banda", new List<int> {10, 8, 6 });

void ExibirLogo()
{
    Console.WriteLine(@"
████████████████████████████████████████████████████
█▄─▀█▀─▄█▄─██─▄█─▄▄▄▄█▄─▄█─▄▄▄─████▀▄─██▄─▄▄─█▄─▄▄─█
██─█▄█─███─██─██▄▄▄▄─██─██─███▀████─▀─███─▄▄▄██─▄▄▄█
█▄▄▄█▄▄▄██▄▄▄▄██▄▄▄▄▄█▄▄▄█▄▄▄▄▄███▄▄█▄▄█▄▄▄███▄▄▄███

");
    Console.WriteLine(mensBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string escolha = Console.ReadLine()!;
    int escolhaNum = int.Parse(escolha);
    switch (escolhaNum)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + escolhaNum);
            break;
        case -1:
            Console.WriteLine("Fechando programa...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();
    TituloDaOpcao("Registro de Bandas");
    Console.Write("\nDigite o nome da Banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    TituloDaOpcao("Exibindo bandas registradas");
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"\nBanda: {banda}");
    }
    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void TituloDaOpcao(string titulo)
{
    int quantLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantLetras, '*');
    Console.WriteLine(asteriscos + "***\n");
    Console.WriteLine(" " + titulo + "\n");
    Console.WriteLine(asteriscos + "***\n");
}

void AvaliarBanda()
{
    Console.Clear();
    TituloDaOpcao("Avalie uma Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Aperte qualquer tecla para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}


ExibirMenu();
