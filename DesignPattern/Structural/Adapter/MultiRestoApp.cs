namespace DesignPattern.Structural.Adapter;

public class MultiRestoApp : IMultiRestoApp
{
    public void DisplayMenu(XmlData xmlData)
    {
        throw new NotImplementedException();
    }

    public void DisplayRecomendation(XmlData xmlData)
    {
        throw new NotImplementedException();
    }
}

public class FancyUIService 
{
    public void DisplayMenu(JsonData jsonData)
    {
        throw new NotImplementedException();
    }

    public void DisplayRecomendation(JsonData jsonData)
    {
        throw new NotImplementedException();
    }
}