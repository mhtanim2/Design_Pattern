using DesignPattern.Creational.AbstractFactory;

namespace DesignPattern.Creational.AbstractFactory;

public class Main_Abstract_Factory_Client
{
    public void Main()
    {
        Company msi = new MsiManufacturer();
        ClientCodeWithAbstractFactory(msi);

        Company giga = new GigabyteManufacturer();
        ClientCodeWithAbstractFactory(giga);
    }

    public void ClientCodeWithAbstractFactory(Company ob)
    {
        ob.BuildPc();
    }

}
