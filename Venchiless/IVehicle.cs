﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        public bool CanDrive(double kilometers);

        public void Drive(double kilometers);

        public void Refuel(double amount);

    }
}
