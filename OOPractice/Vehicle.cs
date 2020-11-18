using System;
using System.Collections.Generic;
using System.Text;

namespace OOPractice
{
    public class Vehicle
    {
        protected string name;
        protected int speed;
        public Vehicle(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public string Speedup()
        {
            return this.name + ": speed up " + this.speed.ToString() + " km/h";
        }
    }
}
