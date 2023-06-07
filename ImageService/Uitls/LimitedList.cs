using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageService.Uitls
{
    public class LimitedList<T>
    {
        private List<T> list;

        public List<T> List { get => list ??= new List<T>(); }

        private int maxSize;

        public int MaxSize { get => maxSize; }

        public int CurrentIndex { get; set; }
        public LimitedList(int maxSize)
        {
            if (maxSize <= 0)
            {
                throw new ArgumentException("Max size must be a positive integer.");
            }

            this.list = new List<T>();
            this.maxSize = maxSize;
        }

        public void Add(T item)
        {
            list.Add(item);

            if (list.Count > maxSize)
            {
                list.RemoveAt(0); // Remove the oldest item
            }
        }

        public T Get(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                return list[index];
            }

            throw new IndexOutOfRangeException("Index is out of range.");
        }
        public void Empty()
        {
            list.Clear();
            CurrentIndex = 0;
        }
        public void Remove(int index)
        {
            list.RemoveAt(index);   
        }
        public int Count => list.Count;
    }
}
