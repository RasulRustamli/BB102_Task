using System.Reflection;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            
            MyList<string> list2 = new MyList<string>();
            list2.Add("a");
            list2.Add("B");
            list2.Add("C");
            list2.Remove("a");


        }
    }

    class MyList<T>
        where T : class
    {
        T[] myArray;
        public int Count { get; set; }
       public void Add(T item)
        {
            if(Count==0)
            {
                myArray = new T[4];
                myArray[Count++] = item;
            }
            else if(Count==myArray.Length)
            {

                Array.Resize(ref myArray,myArray.Length*2);
                myArray[Count++] = item;
            }
            else
            {
                myArray[Count++] = item;
            }
        }
        public void Remove(T item)
        {
            int index = IndexOf(item);
            if(index!=-1)
            {
                T[] newArray = new T[myArray.Length-1];
                int j = 0;
                for(int i=0;i<myArray.Length;i++)
                {
                    if(index!=i)
                    {
                        newArray[j++]=myArray[i];
                    }
                }
                myArray= newArray;
              
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

    }
    
}