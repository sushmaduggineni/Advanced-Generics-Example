using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> myGenericClass = new MyGenericClass<int>(1);
            myGenericClass.GenericMethod(2);

            SubClass<DerivedFromSubClass> subclass = new SubClass<DerivedFromSubClass>();
            subclass.CommmonBaseMethod();
            Console.Read();

        }
    }
}
