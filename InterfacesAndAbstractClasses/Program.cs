namespace InterfacesAndAbstractClasses
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //1. Определение
            Introdution.RunExample();

            //2. Декларация
            Declaring.RunExample();
            
            //2. Декларация с реализацией двумя классами одного интерфейса
            //Declaring3.RunExample();
            
            //3. Декларация множественной реализацией
            Declaring2.RunExample();
            
            //4. Наследование интерфейсов
            InterfaceInheritance.RunExample();

            //5. Явная реалиация
            //ImplicitImplementation.RunExample();
            
            //6. Переопределение дефолтного метода в классе
            //SingleImplementationClassExample1.RunExample();
            
            //6. Скрытие и переопределение дефолтного метода в интерфейсе
            SingleImplementationClassExample2.RunExample();
            
            //6. Проблема одинаковых методов
            ImplementationClassExample1.RunExample();
            ImplementationClassExample2.RunExample();
            MultipleInheritanceProblem1.RunExample();
            MultipleInheritanceProblem2.RunExample();
            MultipleInheritanceProblem3.RunExample();
        }
    }
}


