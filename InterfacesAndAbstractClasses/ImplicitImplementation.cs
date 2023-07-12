namespace InterfacesAndAbstractClasses;

public class ImplicitImplementation
{
    public static void RunExample()
    {
        IAbstractionA obj1 = new ClassA();
        obj1.InterfaceMethodA();

        IAbstractionB obj2 = new ClassA();
        obj2.InterfaceMethodB();
    }

    interface IAbstractionA
    {
        public void InterfaceMethodA();
    }
    
    interface IAbstractionB
    {
        public void InterfaceMethodB();
    }

    class ClassA : IAbstractionA, IAbstractionB
    {
        void IAbstractionA.InterfaceMethodA()
        {
            
        }

        void IAbstractionB.InterfaceMethodB()
        {
            
        }
    }
}