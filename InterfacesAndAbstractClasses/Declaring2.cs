namespace InterfacesAndAbstractClasses;

public class Declaring2
{
    public static void RunExample()
    {
        IAbstractionOne obj1 = new ClassA();
        obj1.InterfaceOneMethod();
        //obj1.InterfaceTwoMethod();
        
        IAbstractionTwo obj2 = new ClassA();
        //obj2.InterfaceOneMethod();
        obj2.InterfaceTwoMethod();
    }

    interface IAbstractionOne
    {
        public void InterfaceOneMethod();
    }
    
    interface IAbstractionTwo
    {
        public void InterfaceTwoMethod();
    }

    class ClassA : IAbstractionOne, IAbstractionTwo
    {
        public void InterfaceOneMethod()
        {
            
        }

        public void InterfaceTwoMethod()
        {
            
        }
    }
}