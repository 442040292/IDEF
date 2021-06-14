using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotifyAppBase;
using System.Collections.ObjectModel;
using System.Windows;

namespace IDEF.ViewModels.Model
{
    public class FlowNodeModel : ViewModelBase
    {
        public FlowNodeModel()
        {

        }


        public FlowNodeModel(NodeTypeModel nodeType, Point point)
        {
            Id = Guid.NewGuid();
            IsSelected = true;
            Name = nodeType.FullName;
            CustomerName = "用户自定义名称";
            this.Rect = new Rect(point, new Size(50, 50));
        }


        public Guid Id { get; set; }

        private Rect _Rect;
        public Rect Rect { get => _Rect; set => Set(ref _Rect, value); }

        private bool _IsSelected;
        public bool IsSelected { get => _IsSelected; set => Set(ref _IsSelected, value); }


        private string _Name;
        public string Name { get => _Name; set => Set(ref _Name, value); }


        private string _CustomerName;
        public string CustomerName { get => _CustomerName; set => Set(ref _CustomerName, value); }


        public void SetLocation(double x, double y)
        {
            Rect = new Rect(new Point(x, y), Rect.Size);
        }

    }
}
