using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// 节点数据，用于存储节点数据
    /// </summary>
    public class NodeData
    {
        public Guid Id { get; set; }

        public List<ArgumentData> Arguments { get; set; }
    }
}
