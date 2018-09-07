using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    public interface ISomeInterface
    {
        void CommmonContractMethod();
    }

    //Note: When using the subclass generic type parameters, you must repeat any constraints stipulated 
    //at the base class level at the subclass level. For example, derivation constraint:
    public abstract class BaseClass<T> where T : ISomeInterface
    {
        public abstract string CommmonBaseMethod();
    }
    public class SubClass<T> : BaseClass<T> where T : ISomeInterface
    {
        public override string CommmonBaseMethod()
        {
            return $"type of class : {typeof(T)}";
        }
    }

    public class DerivedFromSubClass : ISomeInterface
    {
        public void CommmonContractMethod()
        {
            Console.WriteLine("Hi, i am in the Derived class");
        }
    }
}
