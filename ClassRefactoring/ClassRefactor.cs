using System;
using System.ComponentModel;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African,
        European
    }

    public enum SwallowLoad
    {
        None,
        Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType)
        {
            if (swallowType == SwallowType.African)
            {
                return new SwallowAfrican();
            }
            else if (swallowType == SwallowType.European)
            {
                return new SwallowEuropean();
            }

            throw new InvalidEnumArgumentException(nameof(swallowType));
        }
    }

    public abstract class Swallow
    {
        //public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        public Swallow()
        {
            //Type = swallowType;
        }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public abstract double GetAirspeedVelocity();

        //{
        //    if (Type == SwallowType.African && Load == SwallowLoad.None)
        //    {
        //        return 22;
        //    }
        //    if (Type == SwallowType.African && Load == SwallowLoad.Coconut)
        //    {
        //        return 18;
        //    }
        //    if (Type == SwallowType.European && Load == SwallowLoad.None)
        //    {
        //        return 20;
        //    }
        //    if (Type == SwallowType.European && Load == SwallowLoad.Coconut)
        //    {
        //        return 16;
        //    }
        //    throw new InvalidOperationException();
        //}
    }

    public class SwallowAfrican : Swallow
    {
        public override double GetAirspeedVelocity()
        {
            if (Load == SwallowLoad.None)
            {
                return 22;
            }
            else if(Load == SwallowLoad.Coconut)
            {
                return 18;
            }

            throw new InvalidOperationException();
        }
    }

    public class SwallowEuropean : Swallow
    {
        public override double GetAirspeedVelocity()
        {
            if (Load == SwallowLoad.None)
            {
                return 20;
            }
            else if (Load == SwallowLoad.Coconut)
            {
                return 16;
            }

            throw new InvalidOperationException();
        }
    }
}