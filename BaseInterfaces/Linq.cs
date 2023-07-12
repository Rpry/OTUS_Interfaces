using System.Collections;

namespace BaseInterfaces;

public class Linq
{
    public static void RunExample()
    {
        IList list = new List<string>(); 
        Console.WriteLine(list[0]);
            
        var myClasses = new List<MyClass>()
        {
            new MyClass() { Id = 1, Name = "Ivan", BirthDate = DateTime.Parse("15.04.1980"), IsDeleted = false},
            new MyClass() { Id = 2, Name = "Petr", BirthDate = DateTime.Parse("1.01.1982"), IsDeleted = false},
            new MyClass() { Id = 3, Name = "Boris", BirthDate = DateTime.Parse("19.07.1985"), IsDeleted = false},
            new MyClass() { Id = 4, Name = "Denis", BirthDate = DateTime.Parse("16.02.1990"), IsDeleted = true},
            new MyClass() { Id = 5, Name = "Anatoly", BirthDate = DateTime.Parse("11.03.1975"), IsDeleted = false},
        };

        var notDeleted = myClasses.Where(l => !l.IsDeleted);//.ToList();
        var notDeleted2 = from mclass in myClasses where !mclass.IsDeleted select mclass;
            
        var idsOfNotDeleted = myClasses
            .Where(m => !m.IsDeleted)
            .Select(m=>m.Id)
            .ToList();
            
        var top2IdsOfNotDeleted = myClasses
            .Where(m => !m.IsDeleted)
            .OrderBy(m=> m.Name)
            .Select(m=> m.Name)
            .Take(2)
            .ToList();
    }
}