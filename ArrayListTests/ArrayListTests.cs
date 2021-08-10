using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArrayList.Tests
{
    [TestClass()]
    public class ArrayListTests
    {
        [TestMethod()]
        public void AddTest()
        {
            int expected = 5;
            ArrayList<int> test = new ArrayList<int>();

            test.Add(5);

            int actual = test[0];
            Assert.AreEqual(expected, actual, "Add Failed");
        }

        [TestMethod()]
        public void AddFullTest()
        {
            int expected = 14;
            ArrayList<int> test = new ArrayList<int>();
            
            for (int i = 0; i < 15; i ++)
                test.Add(i);

            int actual = test[test.Count - 1];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ClearTest()
        {
            int expected = 0;
            ArrayList<int> test = new ArrayList<int>();

            for (int i = 0; i < 15; i++)
                test.Add(i);
            test.Clear();

            int actual = test.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InsertTest()
        {
            int expected = 6;
            ArrayList<int> test = new ArrayList<int>();

            for (int i = 0; i < 15; i++)
                test.Add(i);
            test.Insert(3, 6);

            int actual = test[3];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ContainsTest()
        {
            bool expected = true;
            ArrayList<int> test = new ArrayList<int>();

            for (int i = 0; i < 6; i++)
                test.Add(i);

            bool actual = test.Contains(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IndexOfTest()
        {
            int expected = 5;
            ArrayList<int> test = new ArrayList<int>();

            for (int i = 0; i < 6; i++)
                test.Add(i);

            int actual = test.IndexOf(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            ArrayList<int> expected = new ArrayList<int> { 0, 1, 2, 3, 5 };
            ArrayList<int> test = new ArrayList<int>();

            for (int i = 0; i < 6; i++)
                test.Add(i);
            test.Remove(4);

            ArrayList<int> actual = test;
            for (int i = 0; i < test.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod()]
        public void RemoveAtTest()
        {
            ArrayList<int> expected = new ArrayList<int> { 0, 1, 2, 4, 5 };
            ArrayList<int> test = new ArrayList<int>();

            for (int i = 0; i < 6; i++)
                test.Add(i);
            test.RemoveAt(3);

            ArrayList<int> actual = test;
            for (int i = 0; i < test.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod()]
        public void CountTest()
        {
            int expected = 4;
            ArrayList<int> test = new ArrayList<int>();

            for (int i = 0; i < 4; i++)
                test.Add(i);

            int actual = test.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CopyToTest()
        {
            int[] expected = new int[] { 0, 1, 2, 3 };
            ArrayList<int> test = new ArrayList<int>();

            for (int i = 0; i < 4; i++)
                test.Add(i);

            int[] actual = new int[4];
            test.CopyTo(actual, 0);
            for (int i = 0; i < test.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}