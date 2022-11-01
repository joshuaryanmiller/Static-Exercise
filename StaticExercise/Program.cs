namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Temperature Conversion between Celsius & Fahrenheit:" +
                $"\n10 degrees Celsius is the equivalent of {TempConverter.CelsiusToFahrenheit(10)} degrees Fahrenheit." +
                $"\n50 degrees Fahrenheit is the equivalent of {TempConverter.FahrenheitToCelsius(50)} degrees Celsius.");
        }
    }
}
