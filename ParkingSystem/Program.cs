using ParkingSystem.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

double initialPrice = 2.5;
double pricePerHour = 5;

Console.WriteLine("Welcome to the parking lot!");

ParkingLot parkingLot = new ParkingLot(initialPrice, pricePerHour);

bool showMenu = true;

while (showMenu)
{
    Console.Clear();
    Console.WriteLine("0 - Exit");
    Console.WriteLine("1 - Add vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicle");

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

        case "0":
            showMenu = false;
            break;

        default:
            Console.WriteLine("Fatal Error: Invalid Input!");
            break;
    }
    Console.ReadKey();
}