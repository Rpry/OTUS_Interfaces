namespace InterfacesAndAbstractClasses;

public class Declaring
{
    public static void RunExample()
    {
        IAbstractionOne obj1 = new ClassA();
        obj1.InterfaceOneMethod();
        //obj1.ClassOnlyMethod();
 
        ClassA obj3 = new ClassA();
        obj3.InterfaceOneMethod();
        obj3.ClassOnlyMethod();
    }

    interface IAbstractionOne
    {
        void InterfaceOneMethod();
    }
    
    class ClassA : IAbstractionOne
    {
        public void InterfaceOneMethod()
        {
            
        }
        
        public void ClassOnlyMethod()
        {
            
        }
    }
}