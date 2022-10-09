using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewAlex
{
    public class IphoneModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public bool IsReallyAnIphone { get; set; }
        public string Image { get; set; }
        public IphoneModel()
        {
        }
    }

    public class GroupedIphoneModel : ObservableCollection<IphoneModel>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}
