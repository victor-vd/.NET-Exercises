using ParkingSystem.Models;

namespace ParkingSystem.Models
{
    public class ParkingLot
    {
        private double initialPrice = 0;
        private double pricePerHour = 0;
        private List<Car> cars = new List<Car>();

        public ParkingLot(double initialPrice, double pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }
        public void AddCar()
        {
            Car car = new Car(setId(), setModel(), setColor(), setParkingSlot());
            cars.Add(car);

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
        public void RemoveCar()
        {
            Console.WriteLine("Type the vehicle's ID:");
            int verifyId = Convert.ToInt32(Console.ReadLine());
            bool idExists = false;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Id == verifyId)
                {
                    idExists = true;
                    Console.WriteLine("Type how many hours you left your car parked:");
                    int hoursParked = Convert.ToInt32(Console.ReadLine());
                    double totalValue = Math.Round((hoursParked * 4.2 + 5), 2, MidpointRounding.AwayFromZero);
                    cars.Remove(cars[i]);
                    Console.WriteLine($"The vehicle '{verifyId}' was removed and the total payment was: R$ {totalValue:0.00}");
                }
            }
            if (!idExists)
            {
                Console.WriteLine("Sorry, that vehicle doesn't exist");
            }
        }
        public void ListCars()
        {
            if (cars.Any())
            {
                Console.WriteLine("The parked vehicles are:");
                for (int i = 0; i < cars.Count; i++)
                {

                    Console.WriteLine(cars[i].ToString());
                }
            }
            else
            {
                Console.WriteLine("There is no parked vehicles");
            }
        }
    }
}