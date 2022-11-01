using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> sehirler = new MyList<string>();

            sehirler.Add("İzmir");
            sehirler.Add("Ankara");
            sehirler.Add("Aydın");

            Console.WriteLine("Şehir sayısı : " + sehirler.Count + "\n\n");
            Console.WriteLine("Şehirler\n");
            foreach (var item in sehirler.GetList())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

    class MyList<T>
    {
        T[] array;
        T[] tempArray;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T item)
        {
            tempArray = array;
            array = new T[array.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
            array[array.Length - 1] = item;
            
        }
        public List<T> GetList()
        {
            return array.ToList();
        }
        public int Count
        {
            get { return array.Length; }
        }

    }
}
