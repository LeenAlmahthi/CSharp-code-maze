public class program
{
    public static void Main(string[] args)
    {
        // Create an instance of the Car class
        Car car = new Car();
        car.make = "BMW";
        car.model = "X5";
        car.year = 2022;
        //
        Car _car = new Car
        {
            make = "BMW",
            model = "X5",
            year = 2022
        };
        Car _car_1 = new Car("Bmw",2026)
        {
            model = "X5",
        };

        var car1 = new Car("BMW", 2022);
        Console.WriteLine(car.make); // Accessing the read-only property 
    }
}