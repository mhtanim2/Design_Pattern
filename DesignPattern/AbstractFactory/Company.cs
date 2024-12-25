namespace DesignPattern.AbstractFactory;

public abstract class Company
{
    public void BuildPc() 
    {
        IGpu gpu=CreateGpu();
        IMonitor monitor=CreateMonitor();
        gpu.Assemble();
        monitor.Assemble();
    }

    public abstract IGpu CreateGpu();
    public abstract IMonitor CreateMonitor();
}
