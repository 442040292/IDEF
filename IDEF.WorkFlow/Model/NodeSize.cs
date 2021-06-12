using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow.Model
{
    public struct NodeSize
    {
        //
        // 摘要:
        //     新实例初始化 System.Windows.Size 结构，并将其分配一个初始 width 和 height。
        //
        // 参数:
        //   width:
        //     实例的初始宽度 System.Windows.Size。
        //
        //   height:
        //     实例的初始高度 System.Windows.Size。
        public NodeSize(double width, double height)
        {
            this.Width = width;
            this.Height = height;

            this.IsEmpty = (this.Width == 0 && this.Height == 0);
        }

        //
        // 摘要:
        //     获取一个值，表示静态空 System.Windows.Size。
        //
        // 返回结果:
        //     空实例 System.Windows.Size。
        public static NodeSize Empty { get; }
        //
        // 摘要:
        //     获取一个值，该值指示是否此实例的 System.Windows.Size 是 System.Windows.Size.Empty。
        //
        // 返回结果:
        //     true 如果此实例的大小为 System.Windows.Size.Empty; 否则为 false。
        public bool IsEmpty { get; }
        //
        // 摘要:
        //     获取或设置 System.Windows.Size.Width 的此实例的 System.Windows.Size。
        //
        // 返回结果:
        //     System.Windows.Size.Width 的此实例的 System.Windows.Size。 默认值为 0。 值不能为负数。
        public double Width { get; set; }
        //
        // 摘要:
        //     获取或设置 System.Windows.Size.Height 的此实例的 System.Windows.Size。
        //
        // 返回结果:
        //     System.Windows.Size.Height 的此实例的 System.Windows.Size。 默认值为 0。 值不能为负数。
        public double Height { get; set; }

    }
}
