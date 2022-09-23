using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Datatypes
{
    public class GenericList<T>
    {
        List<T> list = new List<T>();
        public void Add(T input)
        {
            list.Add(input);   
        }

        public List<T> Get()
        {
            return list;
        }
    }
}
