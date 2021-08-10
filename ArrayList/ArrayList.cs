using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArrayList
{
    public class ArrayList<T> : IList<T>
    {
        private const int _DefaultSize = 10;
        private T[] _items;
        private int _count = 0;

        public ArrayList () 
        {
            _items = new T[0];
        }

        public ArrayList(T[] array)
        {
            for (int i = 0; i < array.Count(); i++)
            {
                Add(array[i]);
            }
        }

        public T this[int index]
        {
            get
            {
                return _items[index];
            }
            set
            {
                _items[index] = value;
            }
        }

        public int Count
        {
            get { return _count; }
            private set
            {
                _count = value;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            Initialize();
            if (CheckIfFull())
            {
                T[] temp = new T[_items.Length * 2];
                for (int i = 0; i < Count; i++)
                    temp[i] = _items[i];

                temp[Count] = item;
                _items = temp;
                Count++;
            }
            else
            {
                _items[Count] = item;
                Count++;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < Count; i++)
            {
                _items[i] = default(T);
            }
            Count = 0;
        }

        public bool Contains(T item)
        {
            return (IndexOf(item) >= 0);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (arrayIndex >= 0 && arrayIndex < Count)
            {
                try
                {
                    for (int i = arrayIndex; i < Count; i++)
                    {
                        array[i] = _items[i];
                    }
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException("Not enough space in array to copy.");
                }
            }
        }

        public int IndexOf(T item)
        {
            return IndexOf(item, 0);
        }

        public int IndexOf(T item, int startingIndex)
        {
            for (int i = startingIndex; i < Count; i++)
            {
                if (_items[i].Equals(item))
                    return i;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index >= 0 && index < Count)
            {
                if (CheckIfFull())
                {
                    T[] temp;
                    temp = new T[_items.Length * 2];

                    for (int i = 0, j = 0; i < Count + 1 && j < Count + 1; i++, j++)
                    {
                        if (j == index)
                        {
                            temp[j] = item;
                            i++;
                        }
                        temp[i] = _items[j];
                    }

                    _items = temp;
                }
                else
                    for (int i = Count; i >= 0; i--)
                    {
                        _items[i + 1] = _items[i];
                        if (i == index)
                        {
                            _items[index] = item;
                            return;
                        }
                    }
                Count++;
            }
        }

        public bool Remove(T item)
        {
            try
            {
                RemoveAt(IndexOf(item));
                return true;
            } catch {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            {
                Count--;
                for (int i = index; i < Count; i++)
                {
                    if (i + 1 == Count + 1)
                        return;
                    else
                        _items[i] = _items[i + 1];
                }
            }
            else
            {
                throw new Exception("Item was not able to be removed.");
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_items).Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)_items).Take(Count).GetEnumerator();
        }

        private void Initialize(int size = 10)
        {
            if (_items.Length == 0)
                _items = new T[Math.Max(_DefaultSize, size)];
            else
                return;
        }

        private bool CheckIfFull()
        {
            if (_items.Length == Count)
                return true;
            else
                return false;
        }
    }
}
