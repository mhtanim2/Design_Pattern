
/*
 * If there added new type of burger
 * it will hamper open close principle
 * Also Client need the dependecy
 * Tightly Coupling
*/

namespace DesignPattern.Factory;

public class ProbRestaurentFactory
{
    public IBurger CreateBurger(string type) 
    {
        switch (type.ToLower())
        {
            case "veggie":
                return new VeggieBurger();
            case "beef":
                return new BeefBurger();
            default:
                throw new ArgumentException("Invalid burger type");
        }
    }
}
