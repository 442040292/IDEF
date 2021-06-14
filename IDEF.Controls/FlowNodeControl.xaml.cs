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
using IDEF.ViewModels.Model;

namespace IDEF.Controls
{
    /// <summary>
    /// FlowNodeControl.xaml 的交互逻辑
    /// </summary>
    public partial class FlowNodeControl : UserControl
    {
        public FlowNodeControl()
        {
            InitializeComponent();
        }

        public FlowNodeModel Source
        {
            get { return (FlowNodeModel)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(FlowNodeModel), typeof(FlowNodeControl), new FrameworkPropertyMetadata(null));
    }
}
