using System;

namespace ArrayList.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> test = new ArrayList<int>();
            for (int i = 0; i < 10; i++)
                test.Add(i);

            test.Insert(3, 6);

            foreach (var value in test)
                Console.WriteLine(value);
        }
    }
}
