public class CarBuilder{
    public string? NamePerson {get; set;}
    public string? NameCar {get; set;}
    public string? Model {get; set;}
    public double Price {get; set;}
    
    public CarBuilder SetName(string _name)
    {
        NamePerson = _name;
        return this;
    }
    public CarBuilder SetCar(string _car)
    {
        NameCar = _car;
        return this;
    }
    public CarBuilder SetModel(string _model)
    {
        Model = _model;
        return this;
    }
    public CarBuilder SetPrice(double _price)
    {
        Price = _price;
        return this;
    }
    public Car build()
    {
        if (string.IsNullOrWhiteSpace(NamePerson) ||
            string.IsNullOrWhiteSpace(NameCar) ||
            string.IsNullOrWhiteSpace(Model) ||
            Price <= 0)
            throw new InvalidOperationException("Owner, car name, model, and a positive price are required.");
        return new Car(NamePerson, NameCar, Model, Price);
    }
}