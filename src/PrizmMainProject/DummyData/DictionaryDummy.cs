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
                new Dictionary {DictionaryName = "Coating"} ,
                new Dictionary {DictionaryName = "Test"} 
            };
        }
    }
        public class Dictionary
    {
        public string DictionaryName { get; set; }
    }
}
