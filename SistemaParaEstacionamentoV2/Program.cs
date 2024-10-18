using SistemaParaEstacionamentoV2.models;

string opcao;
bool exibirMenu = true;
bool menuConfiguracao = true;
bool menuOperacao = false;

Financeiro financeiro = new Financeiro();
Operacional operacional = new Operacional();
Administrativo administrativo = new Administrativo();


//Declaração de menu
while(exibirMenu)
{       
    if(menuConfiguracao)
    {
        Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("| Menu de configuração inicial do sistema de estacionamento.|");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Digite 0 para realizar a primeira configuração do sistema.");
    }

    if(menuOperacao)
    {
        Console.WriteLine("Menu Operacional:");
        Console.WriteLine("1 - Cadastrar veiculo:");
        Console.WriteLine("2 - Listar veiculos no estacionamento:");
        Console.WriteLine("3 - Retirada de veiculo");
        Console.WriteLine("4 - Encerrar expediente... ");        
    }

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "0":
            Console.Clear();
            administrativo.CadastrarAtendente();//cadastro do atendente do estacionamento
            //metodo da classe financeiro delegação de atividades financeiras
            financeiro.ResgatarValores();//entrada de valores financeiros
            menuConfiguracao = false;
            Console.Clear();
            menuOperacao = true;
            break;

        case "1":
            Console.Clear();
            operacional.CadastrarNovoVeiculo();
            menuConfiguracao = false;
            break;

        case "2":
            operacional.ListarVeiculos();
            menuConfiguracao = false;
            break;

        case "3":
            //metodo da classe financeiro delegação de atividades financeiras
            if(operacional.listaCarros.Any())
            {
                financeiro.CalcularValorTotal();
            }
            else
            {
                Console.WriteLine("Não há veiculos estacionados para calcular valores.");
            }
            
            if(financeiro.validaSaida==true){
                operacional.RetiradaDeVeiculo();
            }
            
            menuConfiguracao = false;
            break;
        
        case "4":
            Console.Clear();
            exibirMenu = false;
            Console.WriteLine($"{administrativo.Nome}, sua carga horaria foi de {administrativo.CargaHoraria}hs. Não se esqueça de fechar o caixa...");
            Console.WriteLine("Bom descanso!");
            Console.WriteLine("Encerrar programa");
            //Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine("opcao invalida...");
            break;
    }

}