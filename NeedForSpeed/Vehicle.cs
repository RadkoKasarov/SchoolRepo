using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(int  horsepower, double fuel)
        {
            this.Horsepower = horsepower;
            this.Fuel = fuel;
        }
        public virtual void Drive(double kilometers)
        {
            bool canDrive = (this.Fuel - kilometers * this.FuelConsumption) >= 0;
            if (canDrive)
            {
                this.Fuel -= kilometers * this.FuelConsumption;
            }
        }

    }
}
