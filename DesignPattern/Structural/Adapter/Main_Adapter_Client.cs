
namespace DesignPattern.Structural.Adapter;

public class Main_Adapter_Client
{
    public void Main()
    {
        FancyUIServiceAdapter serviceAdapter = new FancyUIServiceAdapter();
        serviceAdapter.DisplayMenu(new XmlData());
        serviceAdapter.DisplayRecomendation(new XmlData());
    }
}
