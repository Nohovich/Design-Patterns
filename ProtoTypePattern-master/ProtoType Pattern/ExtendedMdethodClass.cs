using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType_Pattern
{
    /// <summary>
    /// for a class to become extended we need to make it static
    /// </summary>
    public static class ExtendedMdethodClass
    {
        /// <summary>
        /// this func will be added to employee class.
        /// the word this needs to be the first value we are passing
        /// </summary>
        /// <param name="e1"></param>
        public static void Print(this Employee e1)
        {
            Console.WriteLine($"{e1.FName} {e1.LName}");
        }
        public static int Div2(this Int32 i)
        {
            return i / 2;
        }
        /// <summary>
        /// making a generic shadow clone using reflection
        /// it will work only if the object has a default constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T CloneObject<T>(this object source)
        {
            T result = Activator.CreateInstance<T>();

            Type type = typeof(T);
            foreach (var prop in type.GetProperties())
            {
                prop.SetValue(result, prop.GetValue(0));
            }
            // with reflection - copy all properties
            return result;
        }
    }
}
