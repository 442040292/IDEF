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
using IDEF.ViewModels.ViewModel;

namespace IDEF.Views
{
    /// <summary>
    /// FlowPageControl.xaml 的交互逻辑
    /// </summary>
    public partial class FlowPageControl : UserControl
    {
        FlowPageViewModel ViewModel;
        public FlowPageControl()
        {
            InitializeComponent();
            ViewModel = this.FindName("FlowPageViewModel") as FlowPageViewModel;
        }


        public FlowPageModel PageContext
        {
            get { return (FlowPageModel)GetValue(PageContextProperty); }
            set { SetValue(PageContextProperty, value); }
        }
        // Using a DependencyProperty as the backing store for PageContext.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PageContextProperty =
            DependencyProperty.Register("PageContext", typeof(FlowPageModel), typeof(FlowPageControl), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));//, PageContext_PropertyChangedCallback));


        public Point LinkStartPoint
        {
            get { return (Point)GetValue(LinkStartPointProperty); }
            set { SetValue(LinkStartPointProperty, value); }
        }
        // Using a DependencyProperty as the backing store for LinkStartPoint.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LinkStartPointProperty =
            DependencyProperty.Register("LinkStartPoint", typeof(Point), typeof(FlowPageControl), new FrameworkPropertyMetadata(default(Point), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public Point LinkEndPoint
        {
            get { return (Point)GetValue(LinkEndPointProperty); }
            set { SetValue(LinkEndPointProperty, value); }
        }
        // Using a DependencyProperty as the backing store for LinkEndPoint.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LinkEndPointProperty =
            DependencyProperty.Register("LinkEndPoint", typeof(Point), typeof(FlowPageControl), new FrameworkPropertyMetadata(default(Point), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        //private void LinkPath_OnDropEvent(string arg1, FuncLinkModel arg2, Point arg3)
        //{

        //}

        private void LinkPath_HighLightEvent(string obj)
        {

        }

        private void myCanvasPage_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {

        }

        private void scrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {

        }

        private void uc_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.PageContext == null)
            {
                return;
            }
            ViewModel.InitData(this.PageContext);
        }

        #region Node Events
        //private void ThumbNode_DragStartedEvent(Node obj)
        //{
        //    //ViewModel.RefreshGroupButtonEnableState();
        //    //ViewModel.SetLinkGray(obj);
        //    //ViewModel.Node_MarkLinkEndNodeEvent(obj);
        //}
        //private void ThumbNode_DragCompletedEvent(Node obj, bool hasDraged)
        //{
        //    //ViewModel.SetLinkNormal(obj, hasDraged); // 先执行连线绘制

        //    //this.SelectedNode = null; // 此行用于强制刷新属性面板
        //    //this.SelectedNode = obj;
        //}
        #endregion

        private void MyCanvasNodes_CreateDropNodeEvent(NodeTypeModel arg1, Point arg2)
        {
            ViewModel.CreateDropNode(arg1, arg2);
        }
    }
}
