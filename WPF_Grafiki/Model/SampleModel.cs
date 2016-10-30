using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WPF_Grafiki.Model
{
    class SampleModel
    {
        public SampleModel()
        {
            _collection = new ObservableCollection<DataItem>();
            //_collection.Add(new DataItem("0", 0));
        }

        public int MaxValue
        {
            get
            {
                MaxValue = (int)_collection.Max(DataItem => DataItem.Value);
                return MaxValue;
            }
            private set { MaxValue = (int)_collection.Max(DataItem => DataItem.Value); }
        }

        public int MinValue
        {
            get
            {
                MinValue = (int)_collection.Min(DataItem => DataItem.Value);
                return MinValue;
            }
            private set { MinValue = (int)_collection.Min(DataItem => DataItem.Value); }
        }
        
        
        private ObservableCollection<DataItem> _collection;
        public ObservableCollection<DataItem> Data
        {
            get
            {
                if(_collection == null) _collection = new ObservableCollection<DataItem> ();
                for (int i = 0; i < 100; i++)
                {
                    _collection.Add(new DataItem(i.ToString(), Math.Cos(i * Math.PI / 40)));
                }

                return _collection;
            }

        }
    }
}
