namespace DesignPattern.Factory;
// This is a factory class
public abstract class Restaurent
{
    public IBurger OrderBurger() {
        IBurger burger = CreateBurger();
        burger.Prepare();
        return burger;
    }

    public abstract IBurger CreateBurger();
}
