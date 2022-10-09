using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewAlex
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListGroupView : ContentPage

    {
        private ObservableCollection<GroupedIphoneModel> grouped { get; set; }
        public ListGroupView()
        {
            InitializeComponent();
            grouped = new ObservableCollection<GroupedIphoneModel>();
            var iphoneGroup = new GroupedIphoneModel() { LongName = "iphones", ShortName = "v" };
            var androidGroup = new GroupedIphoneModel() { LongName = "androids", ShortName = "f" };
            iphoneGroup.Add(new IphoneModel() { Name = "iphone7", IsReallyAnIphone = true, Comment = "2016" });
            iphoneGroup.Add(new IphoneModel() { Name = "iphone8", IsReallyAnIphone = false, Comment = "2017" });
            iphoneGroup.Add(new IphoneModel() { Name = "iphoneX", IsReallyAnIphone = true, Comment = "2017" });
            iphoneGroup.Add(new IphoneModel() { Name = "iphone11", IsReallyAnIphone = true, Comment = "2019" });
            androidGroup.Add(new IphoneModel() { Name = "samsungA50", IsReallyAnIphone = false, Comment = "2019" });
            androidGroup.Add(new IphoneModel() { Name = "sony", IsReallyAnIphone = false, Comment = "2018" });
            androidGroup.Add(new IphoneModel() { Name = "motorola", IsReallyAnIphone = false, Comment = "Si" });
            grouped.Add(iphoneGroup); grouped.Add(androidGroup);
            lstView.ItemsSource = grouped;


        }
    }
}