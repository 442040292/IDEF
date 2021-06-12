using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// Node 表示每个事件的基类，只存储数据部分
    /// 1.Node的输入参数。
    /// 2.Node的输出参数。
    /// 3.
    /// </summary>
    public class Node
    {
        public Guid Id { get; set; }

        ////表示将往何处进行
        //public List<Port> Ports { get; set; }

        public List<Argument> Arguments { get; set; }

    }
}
