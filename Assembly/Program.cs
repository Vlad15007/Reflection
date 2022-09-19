using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
 
namespace AssemblyInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom("V:\\Lada.dll");

            GetInfo(assembly.GetType());

            Console.ReadKey();
        }

        public static void GetInfo(Type type)
        {

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
