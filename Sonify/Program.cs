 

void  Logo() // void é usado quando não se espera um retorno da função
{
    // isso abaixo se chama Verbatim Literal, é usado para que o texto seja impresso exatamente como está escrito
    Console.WriteLine(@"
    
░██████╗░█████╗░███╗░░██╗██╗███████╗██╗░░░██╗
██╔════╝██╔══██╗████╗░██║██║██╔════╝╚██╗░██╔╝
╚█████╗░██║░░██║██╔██╗██║██║█████╗░░░╚████╔╝░
░╚═══██╗██║░░██║██║╚████║██║██╔══╝░░░░╚██╔╝░░
██████╔╝╚█████╔╝██║░╚███║██║██║░░░░░░░░██║░░░
╚═════╝░░╚════╝░╚═╝░░╚══╝╚═╝╚═╝░░░░░░░░╚═╝░░░

");
    
    string message = "Boas Vindas ao Sonify!";
    //List<string> list_of_bands = new List<string>();
    Console.WriteLine(message);
}
Dictionary<string, List<int>> dict_bands = new Dictionary<string, List<int>>(); // dicionario vazio
void MenuOptions()
{
    Logo();
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - Digite 1 para registrar uma banda");
    Console.WriteLine("2 - Digite 2 para listar as bandas");
    Console.WriteLine("3 - Digite 3 para avaliar uma banda");
    Console.WriteLine("4 - Digite 4 para Exibir a média de avaliação das bandas");
    Console.WriteLine("5 - Digite 5 para sair");
    
    Console.Write("\nEscreva sua opção:");
    string option_choose = Console.ReadLine()!;
    int option_choose_int = int.Parse(option_choose);

    switch (option_choose_int)
    {
        case 1: RegisterBanda();
            break;
        case 2: see_bands_registered();
            break;
        case 3: Console.WriteLine("Voce escolheu a opção" + option_choose_int);
            break;
        case 4: Console.WriteLine("Voce escolheu a opção" + option_choose_int);
            break;
        case -1: Console.WriteLine("Voce escolheu a opção" + option_choose_int);
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }

}

void RegisterBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda:");
    string name_of_band = Console.ReadLine()!; // ! é usado para dizer que a variável não é nula
    list_of_bands.Add(name_of_band);
    Console.WriteLine($"A banda {name_of_band} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    MenuOptions();
}

void see_bands_registered()
{
    Console.Clear();
    title_option("Bandas Registradas");
    // for (int i = 0; i<list_of_bands.Count; i++)
    // {
    //     Console.WriteLine(list_of_bands[i]);
    // }
    
    foreach (string band in list_of_bands) // percorrendo a lista e guardando o valor na variável band
    {
        Console.WriteLine(band);
    }
    
    Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    MenuOptions();
    
}

void title_option(string title)
{
    Console.WriteLine("*******************");
    Console.WriteLine(title);
    Console.WriteLine("*******************");
}

Logo();
see_bands_registered();
MenuOptions();