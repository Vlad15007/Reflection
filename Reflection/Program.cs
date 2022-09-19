using Group;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lada lada = new Lada();

            //1
            Type type = lada.GetType();

            //2
            type = Type.GetType("Reflection.Lada");

            //3
            type = typeof(Lada);


            Console.WriteLine(type.FullName);
            Console.WriteLine(type.BaseType);
            Console.WriteLine(type.IsAbstract);
            Console.WriteLine(type.IsCOMObject);
            Console.WriteLine(type.IsSealed);
            Console.WriteLine(type.IsClass);



            //MethodInfo[] metods = type.GetMethods(BindingFlags.Public);
            MethodInfo[] metods = type.GetMethods();
            Console.WriteLine();
            foreach (MethodInfo mi in metods)
            {
                Console.WriteLine(mi);
            }
            
            ConstructorInfo[] constr = type.GetConstructors();
            Console.WriteLine();
            foreach (ConstructorInfo mi in constr)
            {
                Console.WriteLine(mi);
            }


            
            //FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Instance
            //                                        | BindingFlags.Static
            //                                        | BindingFlags.Public
            //                                        | BindingFlags.NonPublic);

            FieldInfo[] fieldInfos = type.GetFields();
            Console.WriteLine();
            foreach (FieldInfo field in fieldInfos)
            {
                Console.WriteLine(field);
            }




            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine();
            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine(prop);
            }


            Type[] types = type.GetInterfaces();
            Console.WriteLine();
            foreach (Type interfacxe in types)
            {
                Console.WriteLine(interfacxe);
            }






            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("*");







            GetInfo(lada);

            Console.ReadKey();
        }




        public static void GetInfo(object show)
        {
            Type type = show.GetType();

            TypeInfo info = type.GetTypeInfo();

            IEnumerable<PropertyInfo> properties = info.DeclaredProperties;
            Show(properties);

            IEnumerable<MethodInfo> methods = info.DeclaredMethods;
            Show(methods);

            IEnumerable<EventInfo> events = info.DeclaredEvents;
            Show(events);
        }

        public static void Show(IEnumerable<MemberInfo> information)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(information.GetType().Name);
            Console.WriteLine(information.GetType().GetElementType().Name);
            Console.ResetColor();
            foreach (MemberInfo member in information)
            {
                Console.WriteLine(member);
            }
        }
    }
}
