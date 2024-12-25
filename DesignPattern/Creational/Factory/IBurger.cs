namespace DesignPattern.Creational.Factory;

public interface IBurger
{
    void Prepare();
}

public class VeggieBurger : IBurger
{
    public void Prepare()
    {
        Console.WriteLine("Vegetable burger prepared");
    }
}

public class BeefBurger : IBurger
{
    public void Prepare()
    {
        Console.WriteLine("Beef burger prepared");
    }
}