using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using IDEF.ViewModels.Model;

namespace IDEF.Controls
{
    public class FlowPageCanvas : Canvas
    {
        public event Action<NodeTypeModel, Point> CreateDropNodeEvent;

        #region 依赖属性

        public FlowPageModel PageContext
        {
            get { return (FlowPageModel)GetValue(PageContextProperty); }
            set { SetValue(PageContextProperty, value); }
        }
        // Using a DependencyProperty as the backing store for PageContext.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PageContextProperty =
            DependencyProperty.Register("PageContext", typeof(FlowPageModel), typeof(FlowPageCanvas), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public Rect SelectionRect
        {
            get { return (Rect)GetValue(SelectionRectProperty); }
            set { SetValue(SelectionRectProperty, value); }
        }
        // Using a DependencyProperty as the backing store for SelectionRect.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectionRectProperty =
            DependencyProperty.Register("SelectionRect", typeof(Rect), typeof(FlowPageCanvas), new FrameworkPropertyMetadata(default(Rect), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// 是否是拖动块
        /// </summary>
        public bool IsDragRect
        {
            get { return (bool)GetValue(IsDragRectProperty); }
            set { SetValue(IsDragRectProperty, value); }
        }
        // Using a DependencyProperty as the backing store for IsDragRect.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsDragRectProperty =
            DependencyProperty.Register("IsDragRect", typeof(bool), typeof(FlowPageCanvas), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        #endregion


        protected override void OnDrop(DragEventArgs e)
        {
            if (e.Data.GetData(typeof(NodeTypeModel)) is NodeTypeModel type)
            {
                e.Handled = true;
                CreateDropNodeEvent?.Invoke(type, e.GetPosition(this));
            }


        }
    }
}
