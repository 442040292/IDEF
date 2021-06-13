using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// 表示该节点是什么类型的节点
    /// 1.用于存储节点数据时，确定节点的类型，方便实例化还原
    /// 2.用于在设计器中，根据节点的类型展示不同的显示效果
    /// </summary>
    public class NodeType
    {
        public string FullName { get; set; }
        public string Namespace { get; set; }
        public string Name { get; set; }
    }
}
