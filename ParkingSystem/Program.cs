using ParkingSystem.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

double initialPrice = 0;
double pricePerHour = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
initialPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
pricePerHour = Convert.ToDouble(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
ParkingLot parkingLot = new ParkingLot(initialPrice, pricePerHour);

string option = string.Empty;
bool showMenu = true;

// Realiza o loop do menu
while (showMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            parkingLot.AddCar();
            break;

        case "2":
            parkingLot.RemoveCar();
            break;

        case "3":
            parkingLot.ListCars();
            break;

        case "4":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadKey();
}

Console.WriteLine("O programa se encerrou");
