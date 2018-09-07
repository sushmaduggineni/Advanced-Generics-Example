using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples
{
    public class MyGenericClassWithConstrint<T> where T: class
    {
        private T GenericMemberVariable;

        public T GenericProperty { get; set; }

        public MyGenericClassWithConstrint(T value)
        {
            this.GenericMemberVariable = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine($"type of GenericParameter: {typeof(T)}, value: {genericParameter}");
            Console.WriteLine($"type of GeneriaVariable: {typeof(T)}, value: {GenericMemberVariable}");

            return genericParameter;
        }
    }


    public class MyGenericClass<T> 
    {
        private T GenericMemberVariable;

        public T GenericProperty { get; set; }

        public MyGenericClass(T value)
        {
            this.GenericMemberVariable = value;
        }

        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine($"type of GenericParameter: {typeof(T)}, value: {genericParameter}");
            Console.WriteLine($"type of GeneriaVariable: {typeof(T)}, value: {GenericMemberVariable}");

            return genericParameter;
        }
    }

    public class MyDerivedClass : MyGenericClass<int>
    {
        public MyDerivedClass(int value) : base(value)
        {
            
        }
    }

    //it will allow only class type as T here , wont allow any structs..
    public class MyDerivedClassWithConstraint : MyGenericClassWithConstrint<object>
    {
        public MyDerivedClassWithConstraint(int value) : base(value)
        {

        }
    }

    public class MyDerivedGenericClass<U> : MyGenericClass<U> where U : class
    {
        public MyDerivedGenericClass(U value): base(value)
        {

        }
    }
}
