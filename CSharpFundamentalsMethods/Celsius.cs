namespace CSharpFundamentalsMethods
{
    struct Celsius
    {
        public double Temperature;

        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit fahrenheit = new Fahrenheit();
            fahrenheit.Temperature = (Temperature * 1.8) + 32;

            return fahrenheit;
        }
    }
}