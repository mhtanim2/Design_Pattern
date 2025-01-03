using DesignPattern.Creational.Singleton;
using DesignPattern.DInversion;
using DesignPattern;
using DesignPattern.Creational.Factory;
using DesignPattern.Creational.AbstractFactory;
using DesignPattern.Structural.Adapter;


/*Dependency Invertion 
 MacBook ob=new MacBook(new WairedKeyboard(),new WairlessMouse());
 ob.showDetail();

 * Singleton
  DatabaseConnection db= DatabaseConnection.getInstance();

 * Factory 
    new Main_Factory_Client().Main();
 
 * Abstract Factory  
    new Main_Abstract_Factory_Client().Main();

 */

// Adapter
new Main_Adapter_Client().Main();