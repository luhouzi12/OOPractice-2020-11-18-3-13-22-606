using OOPractice;
using Xunit;

namespace OOPracticeTest
{
    public class CarTest
    {
        [Fact]
        public void Test1()
        {
            var car = new Car("Cool Car", 30);
            //given
            string expected = "Cool Car: speed up 30 km/h";

            //when
            string actual = car.Speedup();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
