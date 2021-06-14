using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotifyAppBase;
using System.Collections.ObjectModel;

namespace IDEF.ViewModels.Model
{
    public class MainFlowPageModel : ViewModelBase
    {

        public MainFlowPageModel()
        {
            PageItemSource = new ObservableCollection<FlowPageModel>();
        }





        /// <summary>
        /// 创建一个空白的流程页
        /// </summary>
        public void CreateDefaultFlow()
        {

        }


        private ObservableCollection<FlowPageModel> _PageItemSource;
        public ObservableCollection<FlowPageModel> PageItemSource { get => _PageItemSource; set => Set(ref _PageItemSource, value); }



    }

}
