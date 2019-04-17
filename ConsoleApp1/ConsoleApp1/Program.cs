using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeInfo t = new TypeInfo(typeof(int));

            t.GetName();

            t.GetMethods();

            t.GetInterfaces();

            t.GetCustomAttributes();
        }
    }
}
