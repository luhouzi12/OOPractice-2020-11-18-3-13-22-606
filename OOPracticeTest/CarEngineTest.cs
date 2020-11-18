using OOPractice;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOPracticeTest
{
    public class CarEngineTest
    {
        [Fact]
        public void Test1()
        {
            var car = new Car("Cool Car", new ElectricEngine());
            //given
            string expected = "Cool Car: speed up 30 km/h";

            //when
            string actual = car.Speedup();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
