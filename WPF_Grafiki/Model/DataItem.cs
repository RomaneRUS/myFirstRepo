using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Grafiki.Model
{
    class DataItem
    {
        public DataItem (string name, double value)
        {
            Name = name;
            Value = value;
        }
        public double Value { get; set; }
        public string Name { get; set; }
    }
}
