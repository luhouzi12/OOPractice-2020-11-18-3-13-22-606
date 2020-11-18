using OOPractice;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OOPracticeTest
{
    public class DriverTest
    {
        [Fact]
        public void Test1()
        {
            var driver = new Driver(new Vehicle("Cool Car", 30));
            //given
            string expected = "Cool Car: speed up 30 km/h";

            //when
            string actual = driver.Speedup();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
