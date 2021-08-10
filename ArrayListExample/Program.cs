using System;

namespace ArrayList.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> test = new ArrayList<int>();
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(5);
            test.Add(6);
            test.Add(7);

            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(test[i]);
            }

            test.GetEnumerator();

            Console.WriteLine(test.IndexOf(7));
        }
    }
}
