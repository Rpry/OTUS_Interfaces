namespace BaseInterfaces;

public class Dispose
{
    public static void RunExample()
    {
        using (var myDisposableClass = new DisposableClass())
        {
            myDisposableClass.Method();
        }
    }
}