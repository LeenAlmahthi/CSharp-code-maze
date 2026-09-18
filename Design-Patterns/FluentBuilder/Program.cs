// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var modelcar = new CarBuilder().SetName("Leen Ghanim").SetCar("Porach 911").SetModel("911-732").SetPrice(150.500).build();

Console.WriteLine($"Owner: {modelcar.NamePerson}");
Console.WriteLine($"Car: {modelcar.NameCar}");
Console.WriteLine($"Model: {modelcar.Model}");
Console.WriteLine($"Price: {modelcar.Price:F3}");

