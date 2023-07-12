namespace InterfacesAndAbstractClasses;

public class DefaultMethods
{
    public static void RunExample()
    {
        
    }

    interface IAbstractionA
    {
        public void InterfaceMethod1();
        
        // public void InterfaceMethod2();

        public void InterfaceMethod2()
        {
            throw new NotImplementedException();
        }
    }
    
    class ClassA : IAbstractionA
    {
        public void InterfaceMethod1()
        {
            
        }
    }
    
    class ClassB : IAbstractionA
    {
        public void InterfaceMethod1()
        {
            
        }
    }
    
    class ClassC : IAbstractionA
    {
        public void InterfaceMethod1()
        {
            
        }
    }
}