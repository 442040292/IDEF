using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotifyAppBase;
using IDEF.ViewModels.Model;
using System.Windows;
using System.Collections.ObjectModel;

namespace IDEF.ViewModels.ViewModel
{
    public class FlowPageViewModel : ViewModelBase
    {

        public FlowPageViewModel()
        {
            PageContext = new FlowPageModel();
        }

        private FlowPageModel _PageContext;
        public FlowPageModel PageContext { get => _PageContext; set => Set(ref _PageContext, value); }

        public void InitData(FlowPageModel pageModel)
        {

        }

        public void CreateDropNode(NodeTypeModel arg1, Point arg2)
        {

            var newNode = new FlowNodeModel(arg1, arg2);
            PageContext.NodeItemSource.Add(newNode);
            //NodeItemSource.Add(newNode);

        }
    }
}
