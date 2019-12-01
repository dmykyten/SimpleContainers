using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleContainers
{
    public class List<T>
    {
        public List<T> Previous { get; set; }
        public List<T> Next { get; set; }
        public List(T item) {
            Previous = null;
            Next = null;
            this.Item = item;
        }
        public T Item { get; set; }
        public List<T> Append(T Item)
        {
            var temp = Next;
            Next = new List<T>(Item);
            this.Next.Next = temp;
            this.Next.Previous = this;
            if (temp != null) {
                temp.Previous = Next;
            }
            return Next;
        }

        public List<T> Insert__(T Item) {
            var temp = Previous;
            var temp1 = Previous.Next;
            Previous = new List<T>(Item);
            Previous.Previous = temp;
            Previous.Previous.Next = Previous;
            Previous.Next = temp1;
            return Next.Next;
        }


        public List<T> Insert(T Item)
        {
            var temp = Previous;
            Previous = new List<T>(Item);
            this.Previous.Previous = temp;
            this.Previous.Next = this;
            if (temp != null)
            {
                temp.Next = Previous;
            }      
            return Previous;
        }

        public void Delete() {
            if (Previous != null)
            {
                Previous.Next = Next;
            }
            if (Next != null)
            {
                Next.Previous = Previous;
            }
            Previous = null;
            Next = null;
        }

        public override string ToString()
        {
            var prevValue = Previous == null ? "null" : Previous.Item.ToString();
            var nextValue = Next == null ? "null" : Next.Item.ToString();
            return $"List(prev={prevValue},{Item},next={nextValue})";
        }
    }
}
