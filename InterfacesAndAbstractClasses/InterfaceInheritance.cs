namespace InterfacesAndAbstractClasses;

public class InterfaceInheritance
{
    public static void RunExample()
    {
        
    }

    interface IAbstractionA
    {
        public void InterfaceMethodA();
    }
    
    interface IAbstractionB : IAbstractionA
    {
        public void InterfaceMethodB();
    }

    class ClassA : IAbstractionA
    {
        public void InterfaceMethodA()
        {
        }

        public void InterfaceMethodB()
        {
        }
    }
}