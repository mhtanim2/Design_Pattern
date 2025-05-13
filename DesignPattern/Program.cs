using DesignPattern.Creational.Singleton;
using DesignPattern.DInversion;
using DesignPattern;
using DesignPattern.Creational.Factory;
using DesignPattern.Creational.AbstractFactory;
using DesignPattern.Structural.Adapter;
using DesignPattern.Structural.Decorator;
using DesignPattern.Structural.Decorator.Problem;


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
//new Main_Adapter_Client().Main();
Main_Decorator_Clinet.Main();

//Main_Decorator_Clinet_Problem.Main();
