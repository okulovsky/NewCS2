using System;
namespace S22
{
    public class Person { }
    public class Employee : Person { }
    public class Manager : Employee { }


    public class Processor<T>
    {
        public T GetByID(int id) { throw new NotImplementedException(); }
        public void Save(T obj) { throw new NotImplementedException(); }
    }

    class Program
    {
        public static void MainX()
        {
            var p = new Processor<Employee>();
            Console.WriteLine(p is Processor<Employee>);
            Console.WriteLine(p is Processor<Person>);
            Console.WriteLine(p is Processor<Manager>);
        }
    }

}