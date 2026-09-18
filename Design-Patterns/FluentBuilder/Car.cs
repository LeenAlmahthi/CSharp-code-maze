public class Car{
    public string? NamePerson {get; set;}
    public string? NameCar {get; set;}
    public string? Model {get; set;}
    public double Price {get; set;}
    public Car (String _name,String _car, String _model, double _price)
    {
        NamePerson = _name;
        NameCar = _car;
        Model = _model;
        Price = _price; 
    }
}