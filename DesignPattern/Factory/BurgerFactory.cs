
namespace DesignPattern.Factory;

public static class BurgerFactory
{
    public static IBurger CreateBurger(string type) 
    {
        switch (type.ToLower())
        {
            case "veggie":
                return new VeggeBurger();
            case "beef":
                return new BeefBurger();
            default:
                throw new ArgumentException("Invalid burger type");
        }
    }
}
