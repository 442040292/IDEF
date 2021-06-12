using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow.Model
{
    public struct NodePoint
    {

        //
        // 摘要:
        //     创建一个新 System.Windows.Point 结构，其中包含指定的坐标。
        //
        // 参数:
        //   x:
        //     新的 x 坐标 System.Windows.Point 结构。
        //
        //   y:
        //     新的 y 坐标 System.Windows.Point 结构。
        public NodePoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        //
        // 摘要:
        //     获取或设置 System.Windows.Point.Y-协调此值的 System.Windows.Point。
        //
        // 返回结果:
        //     System.Windows.Point.Y-协调此值的 System.Windows.Point 结构。 默认值为 0。
        public double Y { get; set; }
        //
        // 摘要:
        //     获取或设置 System.Windows.Point.X-协调此值的 System.Windows.Point 结构。
        //
        // 返回结果:
        //     System.Windows.Point.X-协调此值的 System.Windows.Point 结构。 默认值为 0。
        public double X { get; set; }
    }
}
