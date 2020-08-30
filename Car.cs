using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Car
    {
        protected string Description;

        public virtual string GetDescription()
        {
            return this.Description;
        }

        public abstract int Cost();
    }

    public abstract class CarOptions : Car
    {
        protected Car DecoratedCar;
    }

    // -------------------------- Cars ------------------------------------

    public class ModelS : Car
    {
        public ModelS()
        {
            this.Description = "ModelS";
        }

        public override int Cost()
        {
            return 73000;
        }
    }
    public class ModelX : Car
    {
        public ModelX()
        {
            this.Description = "ModelX";
        }

        public override int Cost()
        {
            return 77000;
        }
    }

    // -------------------------- Options ------------------------------------

    public class EnhancedAutoPilot : CarOptions
    {
        public EnhancedAutoPilot(Car beverage)
        {
            this.DecoratedCar = beverage;
        }
        public override int Cost()
        {
            return this.DecoratedCar.Cost() + 5000;
        }
        public override string GetDescription()
        {
            return this.DecoratedCar.GetDescription() + ", Enhanced Autopilot";
        }
    }

    public class RearFacingSeats : CarOptions
    {
        public RearFacingSeats(Car beverage) 
        {
            
            this.DecoratedCar = beverage;
        }
        public override int Cost()
        {
            return this.DecoratedCar.Cost() + 4000;
        }
        public override string GetDescription()
        {
            return this.DecoratedCar.GetDescription() + ", Rear Facing Seats";
        }
    }
}
