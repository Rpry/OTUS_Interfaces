namespace InterfacesAndAbstractClasses;

public class Declaring3
{
    public static void RunExample()
    {
        IAbstraction obj1 = new ClassA();
        obj1.InterfaceMethod();
        
        IAbstraction obj2 = new ClassB();
        obj2.InterfaceMethod();
    }

    interface IAbstraction
    {
        public void InterfaceMethod();
    }

    class ClassA : IAbstraction
    {
        public void InterfaceMethod()
        {
            
        }
    }
    
    class ClassB : IAbstraction
    {
        public void InterfaceMethod()
        {
            
        }
    }
}