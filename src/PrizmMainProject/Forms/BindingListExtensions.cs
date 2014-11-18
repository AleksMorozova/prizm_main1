using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms
{
   public static class BindingListExtensions
   {
      public static void ForEach<T>(this BindingList<T> list, Action<T> action)
      {
         if (list == null)
            return;

         foreach (T item in list)
         {
            action(item);
         }
      }
   }
}
