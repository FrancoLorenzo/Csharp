using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {   

            WriteLine("------------------------------------------------------------------------------------------------------------");
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}", 
                "Type", 
                "Byte(s) of memory", 
                "Min",
                "Max"
            );
            WriteLine("------------------------------------------------------------------------------------------------------------");
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(sbyte),
                sizeof(sbyte),
                sbyte.MinValue,
                sbyte.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(byte),
                sizeof(byte),
                byte.MinValue,
                byte.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(short),
                sizeof(short),
                short.MinValue,
                short.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(ushort),
                sizeof(ushort),
                ushort.MinValue,
                ushort.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(int),
                sizeof(int),
                Int32.MinValue,
                Int32.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(uint),
                sizeof(uint),
                uint.MinValue,
                uint.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(long),
                sizeof(long),
                long.MinValue,
                long.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(ulong),
                sizeof(ulong),
                ulong.MinValue,
                ulong.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(float),
                sizeof(float),
                float.MinValue,
                float.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(double),
                sizeof(double),
                double.MinValue,
                double.MaxValue
            );
            WriteLine("{0, -15} {1, -20} {2, 35} {3, 35}",
                typeof(decimal),
                sizeof(decimal),
                decimal.MinValue,
                decimal.MaxValue
            );

            WriteLine("------------------------------------------------------------------------------------------------------------");
            
        }
    }
}
