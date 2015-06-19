using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication5
{
    class ListClass1: List<Class1>
    {
        public ListClass1 SortFromX()
        {
            ListClass1 list = this;
                for (int i = 0; i < Count; i++)
                {
                    if(list[i].название.ToLower().CompareTo(list[i + 1].название.ToLower()) > 0)
                    {
                        list[i] = null;
                    }
                }
            return this;
        }
    }
}
