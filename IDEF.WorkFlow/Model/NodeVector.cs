using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow.Model
{
    public struct NodeVector
    {        //
        // 摘要:
        //     初始化 System.Windows.Vector 结构的新实例。
        //
        // 参数:
        //   x:
        //     System.Windows.Vector.X-新的偏移量 System.Windows.Vector。
        //
        //   y:
        //     System.Windows.Vector.Y-新的偏移量 System.Windows.Vector。
        public NodeVector(double x, double y)
        {
            this.X = x;
            this.Y = y;
            this.LengthSquared = Math.Pow(x, 2) + Math.Pow(y, 2);
            this.Length = Math.Sqrt(LengthSquared);
        }

        //
        // 摘要:
        //     获取此向量的长度的平方。
        //
        // 返回结果:
        //     平方 System.Windows.Vector.Length 此向量。
        public double LengthSquared { get; }
        //
        // 摘要:
        //     获取或设置 System.Windows.Vector.Y 此向量的组件。
        //
        // 返回结果:
        //     System.Windows.Vector.Y 此向量的组件。 默认值为 0。
        public double Y { get; set; }
        //
        // 摘要:
        //     获取或设置 System.Windows.Vector.X 此向量的组件。
        //
        // 返回结果:
        //     System.Windows.Vector.X 此向量的组件。 默认值为 0。
        public double X { get; set; }
        //
        // 摘要:
        //     获取此向量的长度。
        //
        // 返回结果:
        //     此向量的长度。
        public double Length { get; }
    }
}
