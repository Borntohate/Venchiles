﻿
namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public double FuelQuantity { get; set; }

        public virtual double FuelConsumption { get; set; }
          
        public double TankCapacity { get; set; }

        public bool CanDrive(double kilometers)
            => this.FuelQuantity - (kilometers * this.FuelConsumption) >= 0;


        public void Drive(double kilometers)
        {
            if (this.FuelQuantity - (kilometers * this.FuelConsumption) >= 0)
            {
                this.FuelQuantity -= kilometers * this.FuelConsumption;
            }
        }

        public virtual void Refuel(double amount)
        {
            this.FuelQuantity += amount;
        }
    }
}
