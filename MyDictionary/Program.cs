using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {



            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("kullanıcı1", "Melih");
            myDictionary.Add("kullanıcı2", "Engin");


            myDictionary.ShowInitial(2);
            myDictionary.ShowRange(1, 0);


        }
    }
}
