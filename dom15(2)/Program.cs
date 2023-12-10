using System;
using System.Reflection;

class MyClass
{
    public int MyProperty1 { get; set; }
    public string MyProperty2 { get; set; }
}

class Program
{
    static void Main()
    {
        // Создаем экземпляр класса
        MyClass myObject = new MyClass();

        // Инициализируем свойства
        myObject.MyProperty1 = 42;
        myObject.MyProperty2 = "Hello, Reflection!";

        // Получаем тип класса
        Type myType = myObject.GetType();

        // Получаем массив свойств класса
        PropertyInfo[] properties = myType.GetProperties();

        // Выводим на экран свойства и их значения
        Console.WriteLine("Свойства класса MyClass и их значения:");
        foreach (PropertyInfo property in properties)
        {
            object value = property.GetValue(myObject);
            Console.WriteLine($"{property.Name}: {value}");
        }
    }
}
