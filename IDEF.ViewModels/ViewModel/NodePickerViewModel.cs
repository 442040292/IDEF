using IDEF.IWork;
using IDEF.ViewModels.Model;
using IDEF.WorkFlow;
using NotifyAppBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.ViewModels.ViewModel
{
    public class NodePickerViewModel : ViewModelBase
    {

        public NodePickerViewModel()
        {
            string path = @"E:\mypro\IDEF\IDEF.WorkDemo\bin\Debug\IDEF.WorkDemo.dll";
            var types = AssemblyHelper.GetRawActivityTypes(path);

            NodePickerItemSource = new ObservableCollection<NodePickerItemViewModel>(types.Select(x => new NodePickerItemViewModel(x)).ToList());
        }


        private ObservableCollection<NodePickerItemViewModel> _NodePickerItemSource;
        public ObservableCollection<NodePickerItemViewModel> NodePickerItemSource { get => _NodePickerItemSource; set => Set(ref _NodePickerItemSource, value); }



    }
}
