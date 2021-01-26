using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, P>
    {
        T[] illustrators;
        P[] items;

        public MyDictionary()
        {
            illustrators = new T[0];
            items = new P[0];
        }

        public void Add(T illustrator, P item)
        {
            T[] tempIllustrator = illustrators;
            P[] tempItem = items;
            illustrators = new T[illustrators.Length + 1];
            items = new P[items.Length + 1];
            for (int i = 0; i < tempIllustrator.Length; i++)
            {
                illustrators[i] = tempIllustrator[i];
            }
            for (int i = 0; i < tempItem.Length; i++)
            {
                items[i] = tempItem[i];
            }
            illustrators[illustrators.Length - 1] = illustrator;
            items[items.Length - 1] = item;
        }

        public void ShowAll()
        {
            for (int i = 0; i < illustrators.Length; i++)
            {
                Console.WriteLine(illustrators[i] + " " + items[i]);
            }
        }
        public void ShowRange(int a, int b)
        {
            if (a < b)
            {
                for (int i = a; i < b; i++)
                {
                    Console.WriteLine(illustrators[i] + " " + items[i]);
                }
            }
            if (b < a)
            {
                for (int i = b; i < a; i++)
                {
                    Console.WriteLine(illustrators[i] + " " + items[i]);
                }
            }
        }
        public void ShowInitial(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(illustrators[i] + " " + items[i]);
            }


        }


    }
}
