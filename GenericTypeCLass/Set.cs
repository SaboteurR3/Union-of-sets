using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeCLass
{
    class Set<T> : List<T>, IEnumerable 
    {
        // fields
        List<T> e = new List<T>();
        private new int Count;
        private bool IsEmpty;
        // default constructor
        public Set() { }
        // constructor for a list 
        public Set(List<T> e)
        {
            this.e = e;
        }
        // GetMethods
        public int COUNT
        {
            get
            {
                Count = e.Count();
                return Count;
            }
        }
        public bool ISEMPTY
        {
            get
            {
                int quantity;
                quantity = e.Count();
                if (quantity == 0)
                {
                    IsEmpty = true;
                    return IsEmpty;
                }
                else
                {
                    IsEmpty = false;
                    return IsEmpty;
                }
            }
        }
        // Overloading operator '+'(Union of sets)
        public static Set<T> operator +(Set<T> lhs, Set<T> rhs)
        {
            Set<T> tmp = new Set<T>();
            foreach (T s in lhs) tmp.Add(s);
            foreach (T s in rhs) tmp.Add(s);
            return tmp;
        }
        // Add method 
        public bool AddItem(T item)
        {
            if (e.Count == 0)
            {
                e.Add(item);
                return true;
            }
            else
                return false;
        }
        // Remove method 
        public new bool Remove(T item)
        {
            if (e.Contains(item))
            {
                e.Remove(item);
                return true;
            }
            else
                return false;
        }
        // Contains method
        public new bool Contains(T item)
        {
            if (e.Contains(item))
                return true;
            else
                return false;
        }
        public new IEnumerator GetEnumerator()
        {
            for (int i = 0; i < e.Count; i++)
            {
                yield return e[i];
            }
        }
    }
}