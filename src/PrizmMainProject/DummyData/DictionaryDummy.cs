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
                new Dictionary {DictionaryName = "Pipe inspection statuses"} 
            };
        }
        public static BindingList<Item> GetItems()
        {
            return new BindingList<Item>()
            {
                new Item {enEn = "Rejected", ruRu = "Забракован"} ,
                new Item {enEn = "Accepted", ruRu = "Принят"}  ,
                new Item {enEn = "Hold", ruRu = "Задержан"} 
            };
        }
    }
        public class Dictionary
    {
        public string DictionaryName { get; set; }
    }

        public class Item
        {
            public string enEn { get; set; }
            public string ruRu { get; set; }
        }
}
