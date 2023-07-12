using System.Collections;

namespace BaseInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection collection = new List<string>();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            
            //collection[0]

            IList list = new List<string>();
            var zeroElement = list[0];
            
            //Linq.RunExample();
            Dispose.RunExample();
        }
    }
}