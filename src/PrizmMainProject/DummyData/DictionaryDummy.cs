using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.DummyData
{
    public class DictionaryDummy
    {
        public static BindingList<Dictionary> GetDictionaries()
        {
            return  new BindingList<Dictionary>()
            {
                new Dictionary {DictionaryName = "Test"} 
            };
        }
        public static BindingList<Item> GetItems()
        {
            return new BindingList<Item>()
            {
                new Item {English = "Ultrasound", Russian = "Ультразвук"} ,
                new Item {English = "Radiography ", Russian = "Радиография"} 
            };
        }
    }
        public class Dictionary
    {
        public string DictionaryName { get; set; }
    }

        public class Item
        {
            public string English { get; set; }
            public string Russian { get; set; }
        }
}
