// See https://aka.ms/new-console-template for more information
public class Program
{
    static void Main()
    {
        // Create a Porsche object.
        //
        // We CANNOT do:
        // var car = new Car(); // ❌
        //
        // because Car is abstract.
        var car = new Porsche();

        // Calls Porsche's implementation of type().
        car.type();

        // message() comes from the abstract Car class.
        // It already has an implementation,
        // so Porsche inherits it directly.
        car.message();


        // Create a BMW object.
        var _car = new Bmw();

        // Calls BMW's implementation of type().
        _car.type();

        // Calls the normal method inherited from Car.
        _car.message();
    }
} 
/*
            ============================================================
                                ABSTRACT CLASS FLOW
            ============================================================
            
                                     Car
                                abstract class
                                     |
                          +----------+----------+
                          |                     |
                         BMW                 Porsche
                          |                     |
                   override type()       override type()
                          |                     |
                       "BMW"                 "Porsche"
            
            
            ============================================================
                                THE MAIN IDEA
            ============================================================
            
            Abstract class
                ↓
            Cannot create an object directly
                ↓
            Can be inherited
                ↓
            Can contain normal methods
                ↓
            Can contain abstract methods
            
            
            Abstract method
                ↓
            Declaration/signature exists in the abstract class
                ↓
            No implementation in the abstract class
                ↓
            Derived class must implement it using override
            
            
            Normal method in abstract class
                ↓
            Already has implementation
                ↓
            Derived classes inherit it
                ↓
            They can use it directly
            
            
            Polymorphism
                ↓
            Different derived classes
                ↓
            Same method name: type()
                ↓
            Different implementations
                ↓
            BMW → BMW implementation
            Porsche → Porsche implementation
            
            
            Sealed class
                ↓
            Can create objects from it
                ↓
            Cannot inherit from it
            
            
            Sealed override
                ↓
            The method can be overridden here
                ↓
            But derived classes cannot override it again
            ============================================================
*/
