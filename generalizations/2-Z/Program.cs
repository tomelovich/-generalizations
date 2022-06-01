using System;

namespace _2_Z
{
    class MyDictionary<Tkey, Tval>
    {
        private int counter = 0;
        private Tkey[] keysArray = null;
        private Tval[] valsArray = null;
        public int Counter
        {
            get { return this.counter; }
        }
        public void Add(Tkey key, Tval val)
        {
            this.counter++;
            Array.Resize(ref keysArray, counter);
            keysArray[counter - 1] = key;
            Array.Resize(ref valsArray, counter);
            valsArray[counter - 1] = val;
        }
        public Tval this[Tkey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keysArray.Length; i++)
                {
                    if (key.Equals(keysArray[i]))
                        ind = i;
                }
                return valsArray[ind];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> mydictionary = new MyDictionary<int, string>();
            mydictionary.Add(0, "Ноль");
            mydictionary.Add(1, "Один");
            mydictionary.Add(2, "Два");
            mydictionary.Add(3, "Три");
            Console.WriteLine("Кол-во пар элементов = {0}",mydictionary.Counter);
            Console.WriteLine("Введите индекс:");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение элемента = {0}", mydictionary[index]);
            Console.ReadKey();    
        }
    }  
}