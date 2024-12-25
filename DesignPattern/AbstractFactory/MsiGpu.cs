namespace DesignPattern.AbstractFactory;

public class MsiGpu : IGpu
{
    public void Assemble()
    {
        Console.WriteLine("Uses Msi Gpu");
    }
}
public class MsiMonitor : IMonitor
{
    public void Assemble()
    {
        Console.WriteLine("Uses Msi Monitor");
    }
}
public class GigabyteGpu : IGpu
{
    public void Assemble()
    {
        Console.WriteLine("Uses Gigabyte Gpu");
    }
}
public class GigabyteMonitor : IMonitor
{
    public void Assemble()
    {
        Console.WriteLine("Uses Gigabyte Monitor");
    }
}
