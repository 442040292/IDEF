using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow.Model
{
    public struct NodeRect
    {
        //
        // 摘要:
        //     新实例初始化 System.Windows.Rect 结构，它指定大小的是，它位于 (0，0)。
        //
        // 参数:
        //   size:
        //     一个 System.Windows.Size 结构，它指定的宽度和矩形的高度。
        //public NodeRect(NodeSize size)
        //{
        //    this.Size = size;
        //    this.Width = size.Width;
        //    this.Height = size.Height;


        //    this.Top = this.Y = 0;
        //    this.Left = this.X = 0;


        //}
        //
        // 摘要:
        //     新实例初始化 System.Windows.Rect 结构，它具有指定的左上角位置和指定的宽度和高度。
        //
        // 参数:
        //   location:
        //     一个指定的矩形的左上角的位置的点。
        //
        //   size:
        //     一个 System.Windows.Size 结构，它指定的宽度和矩形的高度。
        //public NodeRect(NodePoint location, NodeSize size);
        ////
        //// 摘要:
        ////     新实例初始化 System.Windows.Rect 结构，它是刚好足以包含两个指定的点。
        ////
        //// 参数:
        ////   point1:
        ////     新添加的矩形必须包含的第一个点。
        ////
        ////   point2:
        ////     新添加的矩形必须包含第二个点。
        //public NodeRect(NodePoint point1, NodePoint point2);
        ////
        //// 摘要:
        ////     新实例初始化 System.Windows.Rect 结构，它是刚好足以包含指定的点和指定的点和指定的向量的总和。
        ////
        //// 参数:
        ////   point:
        ////     必须包含该矩形的第一个点。
        ////
        ////   vector:
        ////     若要指定的点的偏移量。 生成的矩形将刚好足以包含这两个点。
        //public NodeRect(NodePoint point, NodeVector vector);
        //
        // 摘要:
        //     新实例初始化 System.Windows.Rect 结构，它具有指定的 x 坐标，y 坐标、 宽度和高度。
        //
        // 参数:
        //   x:
        //     矩形左上角的 x 坐标。
        //
        //   y:
        //     矩形左上角的 y 坐标。
        //
        //   width:
        //     矩形的宽度。
        //
        //   height:
        //     矩形的高度。
        //
        // 异常:
        //   T:System.ArgumentException:
        //     width 是负值。- 或 -height 是负值。
        public NodeRect(double x, double y, double width, double height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }
        //
        // 摘要:
        //     获取一个特殊值，表示一个矩形，有没有位置或区域。
        //
        // 返回结果:
        //     具有空矩形 System.Windows.Rect.X 和 System.Windows.Rect.Y 属性值 System.Double.PositiveInfinity,
        //     ，并且具有 System.Windows.Rect.Width 和 System.Windows.Rect.Height 属性值 System.Double.NegativeInfinity。
        public static NodeRect Empty { get; }

        //
        // 摘要:
        //     获取或设置矩形的左侧的 x 轴值。
        //
        // 返回结果:
        //     左侧的矩形的 x 轴值。
        //
        // 异常:
        //   T:System.InvalidOperationException:
        //     System.Windows.Rect.X 在上设置 System.Windows.Rect.Empty 矩形。
        public double X { get; set; }

        //
        // 摘要:
        //     获取或设置矩形的顶边的 y 轴值。
        //
        // 返回结果:
        //     该矩形的顶边 y 轴的值。
        //
        // 异常:
        //   T:System.InvalidOperationException:
        //     System.Windows.Rect.Y 在上设置 System.Windows.Rect.Empty 矩形。
        public double Y { get; set; }

        //
        // 摘要:
        //     获取或设置矩形的宽度。
        //
        // 返回结果:
        //     正数，表示矩形的宽度。 默认值为 0。
        //
        // 异常:
        //   T:System.ArgumentException:
        //     System.Windows.Rect.Width 设置为负值。
        //
        //   T:System.InvalidOperationException:
        //     System.Windows.Rect.Width 在上设置 System.Windows.Rect.Empty 矩形。
        public double Width { get; set; }
        //
        // 摘要:
        //     获取或设置矩形的高度。
        //
        // 返回结果:
        //     正数，表示矩形的高度。 默认值为 0。
        //
        // 异常:
        //   T:System.ArgumentException:
        //     System.Windows.Rect.Height 设置为负值。
        //
        //   T:System.InvalidOperationException:
        //     System.Windows.Rect.Height 在上设置 System.Windows.Rect.Empty 矩形。
        public double Height { get; set; }
    }

    //public static class NodeExtensions
    //{

    //    public NodePoint BottomRight(this NodeRect rect)
    //    {
    //    }



    //    //
    //    // 摘要:
    //    //     获取矩形的右下角的位置。
    //    //
    //    // 返回结果:
    //    //     矩形的右下角的位置。
    //    public NodePoint BottomRight { get; }
    //    //
    //    // 摘要:
    //    //     获取或设置宽度和矩形的高度。
    //    //
    //    // 返回结果:
    //    //     一个 System.Windows.Size 结构，它指定的宽度和矩形的高度。
    //    //
    //    // 异常:
    //    //   T:System.InvalidOperationException:
    //    //     System.Windows.Rect.Size 在上设置 System.Windows.Rect.Empty 矩形。
    //    public NodeSize Size { get; set; }
    //    //
    //    // 摘要:
    //    //     获取或设置的矩形的左上角的位置。
    //    //
    //    // 返回结果:
    //    //     该矩形的左上角的位置。 默认值为 (0, 0)。
    //    //
    //    // 异常:
    //    //   T:System.InvalidOperationException:
    //    //     System.Windows.Rect.Location 在上设置 System.Windows.Rect.Empty 矩形。
    //    public NodePoint Location { get; set; }
    //    //
    //    // 摘要:
    //    //     获取一个值，该值指示是否为该矩形 System.Windows.Rect.Empty 矩形。
    //    //
    //    // 返回结果:
    //    //     true 如果此矩形 System.Windows.Rect.Empty 矩形; 否则为 false。
    //    public bool IsEmpty { get; }

    //    //
    //    // 摘要:
    //    //     获取矩形的左下角的位置
    //    //
    //    // 返回结果:
    //    //     矩形的左下角的位置。
    //    public NodePoint BottomLeft { get; }
    //    //
    //    // 摘要:
    //    //     获取矩形的左侧的 x 轴值。
    //    //
    //    // 返回结果:
    //    //     左侧的矩形的 x 轴值。
    //    public double Left { get; }
    //    //
    //    // 摘要:
    //    //     获取矩形的顶部的 y 轴位置。
    //    //
    //    // 返回结果:
    //    //     Y 轴位置的矩形的顶部。
    //    public double Top { get; }

    //    //
    //    // 摘要:
    //    //     获取矩形的右端的 x 轴值。
    //    //
    //    // 返回结果:
    //    //     右侧的矩形的 x 轴值。
    //    public double Right { get; }

    //    //
    //    // 摘要:
    //    //     获取矩形的右上角的位置。
    //    //
    //    // 返回结果:
    //    //     矩形右上角的位置。
    //    public NodePoint TopRight { get; }
    //    //
    //    // 摘要:
    //    //     获取该矩形的底部的 y 轴值。
    //    //
    //    // 返回结果:
    //    //     该矩形的底部 y 轴的值。 如果该矩形为空，则值是 System.Double.NegativeInfinity 。
    //    public double Bottom { get; }
    //    //
    //    // 摘要:
    //    //     获取矩形的左上角的位置。
    //    //
    //    // 返回结果:
    //    //     该矩形的左上角的位置。
    //    public NodePoint TopLeft { get; }

    //}
}
