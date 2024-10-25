using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    public class CustomList<T>
    {

        private T[] items;
        private int count;
        public T capacity { get; set; }

        public CustomList()
        {
            T[] nums = new T[0];
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }

            set
            {
                items[index] = value;
            }
        }

        public void Add(T num)
        {

            Array.Resize(ref items, count + 1);
            items[count] = num;
            count++;
        }

        public void AddRange(params T[] NewItems)
        {
            foreach (var item in NewItems)
            {
                Add(item);

            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += Convert.ToInt32(items[i]);
            }
            return sum;

        }

        public void Remove(T value)
        {
            T[] newList = new T[count];
            int j = 0;
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(value))
                {
                    newList[j] = items[i];
                    j++;

                }
            }
            items = newList;
            count = j;


        }

        public void RemoveRange(params T[] NewItems)
        {
            foreach (var item in NewItems)
            {
                Remove(item);
            }
        }

        public override string ToString()
        {
            return string.Join(", ", items);
        }
    }
}
