
namespace DesignPattern.Structural.Adapter;

public class FancyUIServiceAdapter : IMultiRestoApp
{
    private FancyUIService _service;
    public FancyUIServiceAdapter()
    {
        _service = new FancyUIService();
    }
    public void DisplayMenu(XmlData xmlData)
    {
        JsonData jsonData = convertJson(xmlData);
        _service.DisplayMenu(jsonData);

    }

    public void DisplayRecomendation(XmlData xmlData)
    {
        JsonData jsonData = convertJson(xmlData);
        _service.DisplayRecomendation(jsonData);
    }

    private JsonData convertJson(XmlData xmlData) {

        return new JsonData();
    }
}
