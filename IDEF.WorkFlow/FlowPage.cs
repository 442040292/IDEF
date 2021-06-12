using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// 流程页 节点的容器， 一个流程页表示 一段简单逻辑的封装，对一段流程编辑的过程，
    /// 1.流程页更像是一个逻辑关系
    /// 2.流程页中存储了节点的逻辑顺序数据，以及节点的参数数据
    /// 3.
    /// </summary>
    public class FlowPage
    {
        public Guid Id { get; set; }

        public List<NodeData> NodeDatas { get; set; }

        public List<NodeDesignData> NodeDesignData { get; set; }



    }
}
