using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IDEF.Views
{
    /// <summary>
    /// NodePickerControl.xaml 的交互逻辑
    /// </summary>
    public partial class NodePickerControl : UserControl
    {
        public NodePickerControl()
        {
            InitializeComponent();
        }

        private void CreateNode_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as FrameworkElement).DataContext is ViewModels.Model.NodePickerItemViewModel nodePickerItem)
            {
                // 事件飞跃 {EFCF1AD9-3EFD-4DF5-940F-C6FB8278A197}
                DragDrop.DoDragDrop(this, nodePickerItem.Type, DragDropEffects.Copy);
            }
        }
    }
}
