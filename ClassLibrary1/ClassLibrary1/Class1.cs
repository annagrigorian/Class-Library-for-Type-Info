using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace ClassLibrary1
{
    public class TypeInfo
    {
        private Type type;

        public TypeInfo(Type type)
        {
            try
            {
                this.type = type;
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception)
            {
                throw;
            }

            Console.WriteLine(type.Name);
        }
      
        #region Info Methods

        public void GetMethods()
        {
            Console.WriteLine();       
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine("*************Methods****************");
            Console.WriteLine();
            foreach (var method in methods)
            {
                Console.WriteLine("\t" + method.ToString());
            }
        }

        public void GetProperties()
        {
            Console.WriteLine();
            Console.WriteLine("*************Properties****************");
            Console.WriteLine();
            PropertyInfo[] properties = type.GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine("\t" + prop.ToString());
            }
        }

        public void GetNestedTypes()
        {
            Console.WriteLine();
            Console.WriteLine("*************Nested Types****************");
            Console.WriteLine();
            Type[] nestedTypes = type.GetNestedTypes();
            foreach (var nestedType in nestedTypes)
            {
                Console.WriteLine("\t" + nestedType.ToString());
            }
        }

        public void GetMembers()
        {
            Console.WriteLine();
            Console.WriteLine("*************Members****************");
            Console.WriteLine();
            MemberInfo[] members = type.GetMembers();
            foreach (var member in members)
            {
                Console.WriteLine("\t" + member.ToString());
            }
        }

        public void GetConstructors()
        {
            Console.WriteLine();
            Console.WriteLine("*************Constructors****************");
            Console.WriteLine();
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine("\t" + constructor.ToString());
            }
        }

        public void GetInterfaces()
        {
            Console.WriteLine();
            Console.WriteLine("*************Interfaces****************");
            Console.WriteLine();
            Type[] interfaces = type.GetInterfaces();
            foreach (var interFace in interfaces)
            {
                Console.WriteLine("\t" + interFace.ToString());
            }
        }

        public void GetCustomAttributes()
        {
            Console.WriteLine();
            Console.WriteLine("*************Custom Attributes****************");
            Console.WriteLine();
            IEnumerable<Attribute> attributes = type.GetCustomAttributes();
            foreach (var attribute in attributes)
            {
                Console.WriteLine("\t" + attribute.ToString());
            }
        }
        #endregion

    }
}
