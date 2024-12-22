namespace DesignPattern.Factory;

public interface IBurger
{
    void Prepare();
}

/*
 Can have multiple type of burger
 */

public class VeggeBurger : IBurger
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