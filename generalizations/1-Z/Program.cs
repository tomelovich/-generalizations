using System;
using System.Collections;

namespace _1_Z
{
    class MyList<T>
    {
        private T[] myList = null;
        public T this[int index]
        {
            get { return myList[index]; }
            set { myList[index] = value; }
        }
        public MyList()
        {
            this.myList = new T[1];
        }
        public MyList(int count)
        {
            this.myList = new T[count];
        }
        public void Add(T item)
        {
            T[] extendedList = new T[myList.Length + 1];
            extendedList[extendedList.Length - 1] = item;
            myList = extendedList;
        }
        public int Count
        {
            get { return myList.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylist = new MyList<int>(3);       
            mylist.Add(12);
            mylist.Add(33);
            Console.WriteLine("Список содержит: {0} элемент(-ов)", mylist.Count);
            Console.WriteLine("Введите индекс:");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение элемента = {0}", mylist[index]);
            Console.ReadKey();
        }
    }
}
