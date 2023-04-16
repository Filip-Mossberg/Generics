using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Labb1
{
    internal class BoxCollection : ICollection<Box>
    {

        private List<Box> innerBoxCollection;
        public BoxCollection()
        {
            innerBoxCollection = new List<Box>();
        }

        // Indexor
        public Box this[int index]
        {
            get { return innerBoxCollection[index]; }
            set { innerBoxCollection[index] = value;}
        }
        public int Count
        {
            get { return innerBoxCollection.Count; }
        }

        public bool IsReadOnly { get { return false; } }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerBoxCollection.Add(item);
            }
            else
            {
                Console.WriteLine("Item was already added!");
            }
        }

        public void Clear()
        {
            innerBoxCollection.Clear();
        }

        public bool Contains(Box item)
        {
            bool Equal = false;
            foreach (Box b in innerBoxCollection)
            {
                Equal = (b.Equals(item)) ? true : false; 
            }
            return Equal;
        }

        // I would have checked these both in the normal Contains method if I could choose 
        public bool Contains(Box box, IEqualityComparer<object> compare)
        {
            bool Equal = false;
            foreach (Box b in innerBoxCollection)
            {
                if (compare.Equals(b, box))
                {
                    Equal = true;
                }
                Equal = false;
            }
            return Equal;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool Equal = false;
            foreach (Box b in innerBoxCollection)
            {
                if (b.Equals(item))
                {
                    innerBoxCollection.Remove(b);
                    Console.WriteLine($"Box Where : Height = {item.Height} , Width = {item.Width} , Length = {item.Length} Has Been Removed!");
                    return Equal = true;
                }
                else
                {
                    Equal = false;
                }
            }
            Console.WriteLine("0 Removed Items!");
            return Equal;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public void Display(BoxCollection col)
        {
            foreach(var item in col)
            {
                Console.WriteLine($"Height = {item.Height} , Width = {item.Width} , Length = {item.Length}");
            }
        }
    }
}
