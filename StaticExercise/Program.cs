namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double celsius = 10;
            double fahrenheit = 50;
            Console.WriteLine($"Temperature Conversion between Celsius & Fahrenheit:" +
                $"\n{celsius} degrees Celsius is equivalent to {TempConverter.CelsiusToFahrenheit(celsius)} degrees Fahrenheit." +
                $"\n{fahrenheit} degrees Fahrenheit is equivalent to {TempConverter.FahrenheitToCelsius(fahrenheit)} degrees Celsius.");
        }
    }
}
