namespace ParkingSystem.Models
{
    public class ParkingLot
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<Car> cars = new List<Car>();

        public ParkingLot(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }
        public void AddCar()
        {
            cars.Add(new Car() { id = setId(), model = setModel(), color = setColor(), parkingSlot = setParkingSlot() });

            int setId()
            {
                Console.WriteLine("Type your car's ID:");
                return Convert.ToInt32(Console.ReadLine());
            }
            string setModel()
            {
                Console.WriteLine("Type your car's model:");
                return Console.ReadLine();
            }
            string setColor()
            {
                Console.WriteLine("Type your car's color:");
                return Console.ReadLine();
            }
            string setParkingSlot()
            {
                Console.WriteLine("Type your car's parking slot:");
                return Console.ReadLine();
            }
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Type the vehicle's ID:");

            string verifyId = Convert.ToInt32(Console.ReadLine());

            // Verifica se o veículo existe
            if (veiculos.Any(id == verifyId))
            {
                Console.WriteLine("Type how many hours you left your car parked:");
                string hoursParked = Convert.ToInt32(Console.ReadLine());
                double totalValue = hoursParked * 4.2 + 5;

                Console.WriteLine($"The vehicle '{verifyId}' was removed and the total payment was: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Sorry, that vehicle doesn't exist");
            }
        }

        public void ListCars()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("The parked vehicles are:");
                for (int i = 0; i <= cars.Count; i++)
                {
                    Console.WriteLine(cars[i]);
                }
            }
            else
            {
                Console.WriteLine("There is no parked vehicles");
            }
        }
    }
}