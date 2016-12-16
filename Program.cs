using System;
using System.Collections.Generic;

namespace Factory
{
    abstract class Product
    {
        public abstract string GetType();
        public string Processor{get;set;}
        public string Name{get;set;}
        public string Memory{get;set;}
        public string Description{get;set;}
    }

    class ConcreteProductA : Product
    {
        public override string GetType() { return "SmartPhone A"; }

        class MobilePhone : Product
        {
            public override string GetType() { return "SmartPhone B"; }
            public MobilePhone()
            {
                Name = "Mobile Phone";
                Description = "Mobile Phone connects people";
                Memory = "2048mb";
                Processor = "Exynos 7420";
            }
        }
        public string PhoneType { get; set; }

    }

    class ConcreteProductB : Product
    {
        public override string GetType() { return "SmartPhone B"; }
    }

    class ConcreteProductC : Product
    {
        public override string GetType() { return "SmartPhone C"; }
    }
    
    class ConcreteProductD : Product
    {
        public override string GetType() { return "SmartPhone D"; }
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductA(); }
    }

    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductB(); }
    }

    class ConcreteCreatorC : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductC(); }
    }

    class ConcreteCreatorD : Creator
    {
        public override Product FactoryMethod() { return new ConcreteProductD(); }
    }


    public class MainApp
    {
        public static void Main()
        {
            // an array of creators
            Creator[] creators = { new ConcreteCreatorA(), new ConcreteCreatorB(), new ConcreteCreatorC(), new ConcreteCreatorD() };
            // iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType());
            }
        // Wait for user
        Console.Read();
        }
    }
}