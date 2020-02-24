namespace CSharpFundamentalsMethods
{
    struct Fahrenheit
    {
        public double Temperature;

        public Celsius ToCelsius()
        {
            Celsius celsius = new Celsius();
            celsius.Temperature = (Temperature - 32) / 1.8;
            return celsius;
        }
    }
}