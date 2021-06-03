using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here
        private int count;
        public RoverList ()
        {
            count = 0;
        }

        public override int Count
        {
            get
            {
                return count;
            }
        }

        public override void Add(T data)
        {
            Node newNode = new RoverListBase<T>.Node(data, null);

            if (head == null)
            {
                head = newNode;
                current = head;
            }

            else
            {
                current.Next = newNode;
                current = current.Next;
             
               
               

            }

            count++;
        }

        public override void Add(int Position, T data)
        {
            Node newNode = new RoverListBase<T>.Node(data, null);

            var temp = head;
            int internalCount = 0;


            if (head == null)
            {
                head = newNode;
                current = head;
            }

            if (Position == 0)
            {
                var temp3 = head;
                head = newNode;
                head.Next = temp3;
            }


            else
            {
                while (internalCount != Position - 1)
                {
                    temp = temp.Next;
                    internalCount++;

                }

              

                    var temp2 = temp.Next;
                    temp.Next = newNode;
                    temp = temp.Next;
                    temp.Next = temp2;
                    
                    

               

            }

            count++;
        }

        public override void Clear()
        {
            head = null;
        }

        public override T ElementAt(int Position)
        {
            int internalCount = 0;
            current = head;

            while (current != null)
            {
                if (internalCount == Position)
                { 
                    return current.Data;
                }

                current = current.Next;
                internalCount++;
                    
            }
            return default(T);
        }

        public override void ListNodes()
        {
            var temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

        }

        public override bool RemoveAt(int Position)
        {
            bool removed = false;
            var temp = head;

            if (Position == 0)
            {
                head = head.Next;
                return true;
            }


            int internalCount = 0;

            while (temp != null)
            {
                if (internalCount + 1 == Position)
                {
                    if (temp.Next == null)
                    {
                        temp = null;
                        return true;
                    }
                    temp.Next = temp.Next.Next;
                    return true;
                }

                temp = temp.Next;
                internalCount++;

            }

            return removed;
        }
    }
}
