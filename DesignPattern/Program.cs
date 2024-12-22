// See https://aka.ms/new-console-template for more information

//MacBook ob=new MacBook(new WairedKeyboard(),new WairlessMouse());
using DesignPattern.Strategy;

Computer ob = new Computer(new WairedKeyboard());
ob.showDetail();