// Music App
string mensBoasVindas = "Seja bem vindo ao Music App\n";
List<string>listaDasBandas = new List<string>();

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
        case 2:
            Console.WriteLine("Você escolheu a opção " + escolhaNum);
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + escolhaNum);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + escolhaNum);
            break;
        case -1:
            Console.WriteLine("Fechando Programa");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da Banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();
