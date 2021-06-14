using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls.Primitives;
using IDEF.ViewModels.Model;


namespace IDEF.Controls
{
    public class ThumbNodeEx : Thumb
    {

        public event Action<FlowNodeModel> DragBeginEvent;
        public event Action<FlowNodeModel, bool> DragEndEvent;

        public event Action<FlowPageModel> WorkflowPageSelectionChangedEvent;
        public event Action<Guid> DoubleClickJumpToPageEvent;//双击跳转到子组调用组
        public event Action ClearAllSelectNodeEvent;//双击跳转到子组调用组
        public event Action<Guid, double, double> PageContextDragDeltaEvent;// 拖动节点
        public event Action<Guid> PageContextSelectLoopNodeEvent;// 选中当前关联的循环节点
        public event Func<Guid, bool> PageContextHasSelectNodeEvent;// 有没有选中的节点，没有就不拖拽

        //private FuncPageCanvas _pageCanvas => VisualTreeHelperEx.GetAncestor<FuncPageCanvas>(this);

        /// <summary>
        /// 是否已拖动过
        /// </summary>
        private static bool _HasDraged;

        #region 依赖属性

        public FlowNodeModel Source
        {
            get { return (FlowNodeModel)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }
        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(FlowNodeModel), typeof(ThumbNodeEx), new FrameworkPropertyMetadata(null));

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
            DependencyProperty.Register("IsDragRect", typeof(bool), typeof(ThumbNodeEx), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public ICommand MarkStartPortCommand
        {
            get { return (ICommand)GetValue(MarkStartPortCommandProperty); }
            set { SetValue(MarkStartPortCommandProperty, value); }
        }
        // Using a DependencyProperty as the backing store for MarkStartPortCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MarkStartPortCommandProperty =
            DependencyProperty.Register("MarkStartPortCommand", typeof(ICommand), typeof(ThumbNodeEx), new PropertyMetadata(null));

        #region 右键菜单

        public ICommand DeleteCommand
        {
            get { return (ICommand)GetValue(DeleteCommandProperty); }
            set { SetValue(DeleteCommandProperty, value); }
        }
        // Using a DependencyProperty as the backing store for DeleteCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DeleteCommandProperty =
            DependencyProperty.Register("DeleteCommand", typeof(ICommand), typeof(ThumbNodeEx), new PropertyMetadata(null));

        public ICommand ExecuteThisNodeCommand
        {
            get { return (ICommand)GetValue(ExecuteThisNodeCommandProperty); }
            set { SetValue(ExecuteThisNodeCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ExecuteThisNodeCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ExecuteThisNodeCommandProperty =
            DependencyProperty.Register("ExecuteThisNodeCommand", typeof(ICommand), typeof(ThumbNodeEx), new PropertyMetadata(null));

        public ICommand RunFlowFromThisNodeCommand
        {
            get { return (ICommand)GetValue(RunFlowFromThisNodeCommandProperty); }
            set { SetValue(RunFlowFromThisNodeCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RunFlowFromeThisNodeCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RunFlowFromThisNodeCommandProperty =
            DependencyProperty.Register("RunFlowFromThisNodeCommand", typeof(ICommand), typeof(ThumbNodeEx), new PropertyMetadata(null));

        /// <summary>
        /// 复制
        /// </summary>
        public ICommand CopyCommand
        {
            get { return (ICommand)GetValue(CopyCommandProperty); }
            set { SetValue(CopyCommandProperty, value); }
        }
        // Using a DependencyProperty as the backing store for CopyCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CopyCommandProperty =
            DependencyProperty.Register("CopyCommand", typeof(ICommand), typeof(ThumbNodeEx), new PropertyMetadata(null));

        /// <summary>
        /// 剪切
        /// </summary>
        public ICommand CutCommand
        {
            get { return (ICommand)GetValue(CutCommandProperty); }
            set { SetValue(CutCommandProperty, value); }
        }
        // Using a DependencyProperty as the backing store for CutCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CutCommandProperty =
            DependencyProperty.Register("CutCommand", typeof(ICommand), typeof(ThumbNodeEx), new PropertyMetadata(null));

        /// <summary>
        /// 解散组
        /// </summary>
        public ICommand UnGroupCommand
        {
            get { return (ICommand)GetValue(UnGroupCommandProperty); }
            set { SetValue(UnGroupCommandProperty, value); }
        }
        // Using a DependencyProperty as the backing store for UnGroupCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UnGroupCommandProperty =
            DependencyProperty.Register("UnGroupCommand", typeof(ICommand), typeof(ThumbNodeEx), new PropertyMetadata(null));

        /// <summary>
        /// 保存为组件
        /// </summary>
        public ICommand SaveAsComponentCommand
        {
            get { return (ICommand)GetValue(SaveAsComponentCommandProperty); }
            set { SetValue(SaveAsComponentCommandProperty, value); }
        }
        // Using a DependencyProperty as the backing store for SaveAsComponentCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SaveAsComponentCommandProperty =
            DependencyProperty.Register("SaveAsComponentCommand", typeof(ICommand), typeof(ThumbNodeEx), new PropertyMetadata(null));

        #endregion

        #endregion

        public ThumbNodeEx()
        {
            //this.Style = this.FindResource("ThumbNodeStyle") as Style;
            this.Loaded += ThumbNodeEx_Loaded;
            this.Unloaded += ThumbNodeEx_Unloaded;
        }

        private void ThumbNodeEx_Loaded(object sender, RoutedEventArgs e)
        {
            this.DragStarted += ThumbNodeEx_DragStarted;
            this.DragDelta += ThumbNodeEx_DragDelta;
            this.DragCompleted += ThumbNodeEx_DragCompleted;
            this.PreviewMouseLeftButtonDown += ThumbNodeEx_PreviewMouseLeftButtonDown;
            this.PreviewMouseDoubleClick += ThumbNodeEx_PreviewMouseDoubleClick;
        }

        private void ThumbNodeEx_Unloaded(object sender, RoutedEventArgs e)
        {
            this.Loaded -= ThumbNodeEx_Loaded;
            this.Unloaded -= ThumbNodeEx_Unloaded;
            this.DragStarted -= ThumbNodeEx_DragStarted;
            this.DragDelta -= ThumbNodeEx_DragDelta;
            this.DragCompleted -= ThumbNodeEx_DragCompleted;
            this.PreviewMouseLeftButtonDown -= ThumbNodeEx_PreviewMouseLeftButtonDown;
            this.PreviewMouseDoubleClick -= ThumbNodeEx_PreviewMouseDoubleClick;
        }
        #region 拖动
        private void ThumbNodeEx_DragStarted(object sender, DragStartedEventArgs e)
        {
            _HasDraged = false;
            DragBeginEvent?.Invoke(this.Source);
        }

        private void ThumbNodeEx_DragDelta(object sender, DragDeltaEventArgs e)
        {
            //int x = this.Source.Rect.X + Convert.ToInt32(e.HorizontalChange);
            //int y = this.Source.Rect.Y + Convert.ToInt32(e.VerticalChange);
            int eH = 0;
            int eV = 0;
            // 拖动距离绝对值大于(Page.GRID_SIZE / 2)时，再修改节点坐标
            //if (Math.Abs(e.HorizontalChange) > Page.GRID_SIZE / 2)
            //{
            //    eH = Convert.ToInt32(e.HorizontalChange);
            //}
            //if (Math.Abs(e.VerticalChange) > Page.GRID_SIZE / 2)
            //{
            //    eV = Convert.ToInt32(e.VerticalChange);
            //}
            if (Math.Abs(e.HorizontalChange) > 5)
            {
                eH = Convert.ToInt32(e.HorizontalChange);
            }
            if (Math.Abs(e.VerticalChange) > 5)
            {
                eV = Convert.ToInt32(e.VerticalChange);
            }
            if (eH == 0 && eV == 0)
            {
                return;
            }
            _HasDraged = true;
            var x = this.Source.Rect.X + eH;
            var y = this.Source.Rect.Y + eV;

            this.Source.SetLocation(x, y);
            //this.PageContext?.DragDelta(this.Source, eH, eV);
            PageContextDragDeltaEvent?.Invoke(this.Source.Id, eH, eV);
            return;
        }

        private void ThumbNodeEx_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            DragEndEvent?.Invoke(this.Source, _HasDraged);
        }
        #endregion

        #region Mouse
        private void ThumbNodeEx_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var ctrl = Keyboard.Modifiers.HasFlag(ModifierKeys.Control);//按下ctrl 多选节点
            if (!ctrl && this.IsDragRect && this.Source.IsSelected)
            {
                this.Source.IsSelected = true;
                //SetLoopNodeSelected();
                return;
            }
            if (ctrl)
            {
                this.Source.IsSelected = !this.Source.IsSelected;
                //this.PageContext.SelectLoopNode();
                PageContextSelectLoopNodeEvent.Invoke(this.Source.Id);
                if (this.PageContextHasSelectNodeEvent?.Invoke(this.Source.Id) == true)
                {
                    this.IsDragRect = true;
                }
                else
                {
                    this.IsDragRect = false;
                }
            }
            else
            {
                ClearAllSelectNodeEvent?.Invoke();
                this.Source.IsSelected = true;
            }
            //SetLoopNodeSelected();
        }

        /// <summary>
        /// 鼠标双击 跳转到 子组或者调用组 引用的子组 其他类型忽略
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThumbNodeEx_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            DoubleClickJumpToPageEvent?.Invoke(this.Source.Id);
        }
        #endregion
    }
}
