### Class Library for getting Type Info

Here's represented a Class Library, which can be used to get information about any C# types, e.g. type's full name, methods list, custom attributes etc.

First you have to attach the reference of the library to your project. Right click on your project Add -> Reference, choose library DLL then in 'using' spaces add

~~~csharp
using ClassLibrary1;
~~~

### How to Use
Simply create an instance of TypeInfo Class by using its one parameter constructor as follows
~~~csharp
TypeInfo t = new TypeInfo(typeof(typeName));
~~~

Then using TypeInfo instance get what information you need like this
~~~csharp
t.GetName();

t.GetMethods();

t.GetInterfaces();

t.GetCustomAttributes();
~~~

The output for type integer looks like this
~~~csharp
Int32

*************Methods****************

        Int32 CompareTo(System.Object)
        Int32 CompareTo(Int32)
        Boolean Equals(System.Object)
        Boolean Equals(Int32)
        Int32 GetHashCode()
        System.String ToString()
        System.String ToString(System.String)
        System.String ToString(System.IFormatProvider)
        System.String ToString(System.String, System.IFormatProvider)
        Int32 Parse(System.String)
        Int32 Parse(System.String, System.Globalization.NumberStyles)
        Int32 Parse(System.String, System.IFormatProvider)
        Int32 Parse(System.String, System.Globalization.NumberStyles, System.IFormatProvider)
        Boolean TryParse(System.String, Int32 ByRef)
        Boolean TryParse(System.String, System.Globalization.NumberStyles, System.IFormatProvider, Int32 ByRef)
        System.TypeCode GetTypeCode()
        System.Type GetType()

*************Interfaces****************

        System.IComparable
        System.IFormattable
        System.IConvertible
        System.IComparable`1[System.Int32]
        System.IEquatable`1[System.Int32]

*************Custom Attributes****************

        System.SerializableAttribute
        System.Runtime.InteropServices.ComVisibleAttribute
        __DynamicallyInvokableAttribute
~~~
