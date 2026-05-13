namespace CalculatorApp.Tests
{
    public class CalculatorAppTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Calculator calc=new Calculator();
            int result = calc.add(2, 3);
            Assert.Equal(5, result);
        }
    }
}