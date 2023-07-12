namespace InterfacesAndAbstractClasses;

public class Introdution
{
    public static void RunExample()
    {
        IMyInterface obj = new MyClass();
        obj.MyMethod(1);
    }

    interface IMyInterface
    {
        string MyMethod(int parameter);
        
        bool MyMethod2();

        bool MyMethod3()
        {
            throw new NotImplementedException();
        }
    }

    class MyClass : IMyInterface
    {
        public string MyMethod(int parameter)
        {
            throw new NotImplementedException();
        }

        public bool MyMethod2()
        {
            throw new NotImplementedException();
        }
    }
    
    class MyClass2 : IMyInterface
    {
        public string MyMethod(int parameter)
        {
            throw new NotImplementedException();
        }

        public bool MyMethod2()
        {
            throw new NotImplementedException();
        }

        public bool MyMethod3()
        {
            throw new NotImplementedException();
        }
        
    }
    
    class MyClass3 : IMyInterface
    {
        public string MyMethod(int parameter)
        {
            throw new NotImplementedException();
        }

        public bool MyMethod2()
        {
            throw new NotImplementedException();
        }
    }
}