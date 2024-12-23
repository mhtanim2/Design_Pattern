﻿using DesignPattern;
using DesignPattern.DInversion;
using DesignPattern.Factory;
using DesignPattern.Singleton;

/*Dependency Invertion 
 MacBook ob=new MacBook(new WairedKeyboard(),new WairlessMouse());
 ob.showDetail();

 * Singleton
  DatabaseConnection db= DatabaseConnection.getInstance();*/

//* Factory
Restaurant factory = new Restaurant(SD.Veggie);
factory.SaveBurger();

IBurger ob = BurgerFactory.CreateBurger(SD.Beef);
ob.Prepare();