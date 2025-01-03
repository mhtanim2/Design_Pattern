namespace DesignPattern.Creational.Factory;

public class VeggieBurgerRestaurent : Restaurent
{
    public override IBurger CreateBurger()
    {
        return new VeggieBurger();
    }
}
public class BeefBurgerRestaurent : Restaurent
{
    public override IBurger CreateBurger()
    {
        return new BeefBurger();
    }
}