using OOPractice;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOPracticeTest
{
    public class TruckTest
    {
        [Fact]
        public void Test1()
        {
            var truck = new Truck("Big Truck", 10);
            //given
            string expected = "Big Truck: speed up 10 km/h";

            //when
            string actual = truck.Speedup();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
