using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Commit: first change
            Console.WriteLine("First change");
            
            // Commit: second change
            Console.WriteLine("Second change");

            // Commit: Integer Data Types
            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            byte byteMin = byte.MinValue;
            byte byteMax = byte.MaxValue;
            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            ushort ushortMin = ushort.MinValue;
            ushort ushortMax = ushort.MaxValue;
            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            uint uintMin = uint.MinValue;
            uint uintMax = uint.MaxValue;
            long longMin = long.MinValue;
            long longMax = long.MaxValue;
            ulong ulongMin = ulong.MinValue;
            ulong ulongMax = ulong.MaxValue;

            Console.WriteLine($"sbyte from {sbyteMin} to {sbyteMax}");
            Console.WriteLine($"byte from {byteMin} to {byteMax}");
            Console.WriteLine($"short from {shortMin} to {shortMax}");
            Console.WriteLine($"ushort from {ushortMin} to {ushortMax}");
            Console.WriteLine($"int from {intMin} to {intMax}");
            Console.WriteLine($"uint from {uintMin} to {uintMax}");
            Console.WriteLine($"long from {longMin} to {longMax}");
            Console.WriteLine($"sbyte from {ulongMin} to {ulongMax}");

            Console.WriteLine("------------------------------------------------------");

            // Commit: Char Data type (ASCII)system
            ushort charMin = char.MinValue;
            ushort charMax = char.MaxValue;
            char c;
            Console.WriteLine($"char from {charMin} to {charMax}");
            for(int charNumber = 0;charNumber<=255;charNumber++)
            {
                c = Convert.ToChar(charNumber);
                Console.WriteLine($"{charNumber} -> {c}");
            }

            /*
            int[] num = {1,2,3,4,5,6};
            try { Console.WriteLine(num[7]);}
            catch (Exception e) { Console.WriteLine(e.Message); }
            
            File.WriteAllText("filename.txt", "Hello world\nNew Line");
            Console.WriteLine(File.ReadAllText("filename.txt"));
            
            // variables syntax
            // type identifier = value;
            string name = "AHMED MAHMOUD ISMAIL";
            name = "Mohamed Abdullah";
            Console.WriteLine("Hello " + name);
            
            double age = 37.5D;
            Console.WriteLine(age);

            const double PI = 12E4;
            int x = 5, y = 6;
            Console.WriteLine(PI + y + x);

            bool isGood = true;
            bool isBad = false;
            Console.WriteLine(isGood);
            Console.WriteLine(isBad);
            
            // print byte (bit) values
            int n_1 = (int)Math.Pow(2, 0);
            int num_1 = (int)Math.Pow(2, 8) - 1;
            int num_2 = (int)Math.Pow(2, 16) - 1;
            int num_3 = (int)Math.Pow(2, 24) - 1;
            int num_4 = (int)Math.Pow(2, 32) - 1;
            long num_8 = (long)Math.Pow(2, 64) - 1;
            Console.WriteLine("1 BIT = " + n_1 + "(bool)");
            Console.WriteLine("1 BYTE ( 8 bit) = " + num_1);
            Console.WriteLine("2 BYTE (16 bit) = " + num_2 + "(char)");
            Console.WriteLine("3 BYTE (24 bit) = " + num_3);
            Console.WriteLine("4 BYTE (32 bit) = " + num_4 + "(int , float)");
            Console.WriteLine("8 BYTE (64 bit) = " + num_8 + "(long , double)");

            // USER INPUT
            Console.WriteLine("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Price 2: ");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(price + price2);
            
             */
        }
    }
}
