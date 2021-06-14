using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NotifyAppBase;

namespace IDEF.ViewModels.Model
{
    public class FlowPageModel : ObservableObject
    {


        public FlowPageModel()
        {
            NodeItemSource = new ObservableCollection<FlowNodeModel>();

        }

        public Guid Id { get; set; }

        private string _Name;
        public string Name { get => _Name; set => Set(ref _Name, value); }

        private ObservableCollection<FlowNodeModel> _NodeItemSource;
        public ObservableCollection<FlowNodeModel> NodeItemSource { get => _NodeItemSource; set => Set(ref _NodeItemSource, value); }


    }
}
