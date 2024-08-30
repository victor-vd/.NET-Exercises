using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class Car
    {
        public int Id { get; private set; }
        private string Model { get; set; }
        private string Color { get; set; }
        private string ParkingSlot { get; set; }

        public Car(int carId, string model, string color, string parkingSlot)
        {
            Id = carId;
            Model = model;
            Color = color;
            ParkingSlot = parkingSlot;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Model: {Model}, Color: {Color}, ParkingSlot: {ParkingSlot}";
        }
    }
}
