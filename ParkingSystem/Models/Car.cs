using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSystem.Models
{
    public class Car
    {
        private int id { get; set; }
        private string model { get; set; }
        private string color { get; set; }
        private string parkingSlot { get; set; }

        public Car(int id, string model, string color, string parkingSlot)
        {
            this.id = id;
            this.model = model;
            this.color = color;
            this.parkingSlot = parkingSlot;
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                model = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }
        public string Slot
        {
            get { return parkingSlot; }
            set
            {
                parkingSlot = value;
            }
        }
    }
}
