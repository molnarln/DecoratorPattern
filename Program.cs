using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic modelS = new ModelS();

            Console.WriteLine(modelS.GetDescription() + " " + modelS.Cost());

            modelS = new RearFacingSeats(modelS);
            modelS = new EnhancedAutoPilot(modelS);
            Console.WriteLine(modelS.GetDescription() + " " + modelS.Cost());

            
            
            // ------------ Custom Attribute test -------------
            var customAttributes = (MyCustomAttribute[])typeof(Foo).GetCustomAttributes(typeof(MyCustomAttribute), true);
            if (customAttributes.Length > 0)
            {
                var myAttribute = customAttributes[0];
                string value = myAttribute.SomeProperty;
                // TODO: Do something with the value
            }

        }
    }
}
