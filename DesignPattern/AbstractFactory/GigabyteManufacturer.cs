namespace DesignPattern.AbstractFactory;

public class GigabyteManufacturer:Company
{
    public override IGpu CreateGpu()
    {
        return new GigabyteGpu();
    }

    public override IMonitor CreateMonitor()
    {
        return new GigabyteMonitor();
    }
}

