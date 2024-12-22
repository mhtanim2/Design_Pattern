
namespace DesignPattern.Factory;

public class Restaurant
{
    private IBurger burger;
    public Restaurant(string type)
    {
        burger=BurgerFactory.CreateBurger(type);
    }

    public void SaveBurger()
    {
        burger.Prepare();
    }
}
