using IDEF.WorkFlow;
using NotifyAppBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.ViewModels.Model
{
    public class NodePickerItemViewModel : ObservableObject
    {

        public NodePickerItemViewModel(NodeTypeModel nodeType)
        {
            this.Type = nodeType;
            this.Name = nodeType.Name;
            this.Namespace = nodeType.Namespace;
            this.FullName = nodeType.FullName;
        }

        public NodeTypeModel Type { get; set; }

        private string _Name;
        public string Name { get => _Name; set => Set(ref _Name, value); }

        private string _Namespace;
        public string Namespace { get => _Namespace; set => Set(ref _Namespace, value); }

        private string _FullName;
        public string FullName { get => _FullName; set => Set(ref _FullName, value); }
    }
}
