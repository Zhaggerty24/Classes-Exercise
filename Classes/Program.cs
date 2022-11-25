namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Car = new Car();
            Car.Make = "Mclaren";
            Car.Model = "Senna";
            Car.Year = 2023;

            Console.WriteLine($" I own a {Car.Year} {Car.Make} {Car.Model}");
        }
    }
}
