// See https://aka.ms/new-console-template for more information
using Strategegy_Patterns;

Duck mallard = new MallardDuck(new FlyWithWings(), new Quack());
mallard.Display();
mallard.performfly();
mallard.performQuack();

// نغيّر السلوك أثناء التشغيل:
mallard.setFly(new FlyWithNoway());
mallard.performfly();
