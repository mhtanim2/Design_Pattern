namespace DesignPattern.Creational.AbstractFactory;

public class MsiManufacturer : Company
{
    public override IGpu CreateGpu()
    {
        return new MsiGpu();
    }

    public override IMonitor CreateMonitor()
    {
        return new MsiMonitor();
    }
}
