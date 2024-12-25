
namespace DesignPattern.Factory;

public class Main_Factory_Client
{
    public void Main()
    {
/*     //* Breaking Factory Pattern Rules
        
        ProbRestaurentFactory problem = new ProbRestaurentFactory();
        IBurger ob = ClientCode(problem);
        ob.Prepare();
*/
        //* Using Factory
        
        Restaurent beefObj = new BeefBurgerRestaurent();
        ClientCodeWithFactory(beefObj); 
        Restaurent veggie = new VeggieBurgerRestaurent();
        ClientCodeWithFactory(veggie); 
    }

    // The client code works with an instance of a concrete creator, albeit
    // through its base interface. As long as the client keeps working with
    // the creator via the base interface, you can pass it any creator's
    // subclass.
    
    public IBurger ClientCode(ProbRestaurentFactory creator)
    {
        return creator.CreateBurger(SD.Beef);
    }
    
    public void ClientCodeWithFactory(Restaurent creator)
    {
        creator.OrderBurger();
    }
}
