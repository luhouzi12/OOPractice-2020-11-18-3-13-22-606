using System;
using System.Collections.Generic;
using System.Text;

namespace OOPractice
{
    public class Car
    {
        private string name;
        private int speed;
        public Car(string name, int speed)
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
