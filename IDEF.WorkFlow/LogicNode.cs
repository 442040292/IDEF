using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// 表示节点的逻辑关系，逻辑顺序
    /// 分开的意义是，为了更方便的的解耦，让不变的数据和经常变化的数据，分离开来
    /// 另一方面，在单纯的查找时不必带上数据去查找
    /// </summary>
    public class LogicNode
    {

        public Guid Id { get; set; }

        public List<LogicNode> NextNodes { get; set; }

    }

    /// <summary>
    /// 表示逻辑走向为 二段分支类型
    /// </summary>
    public class StartNode : LogicNode
    {

    }
    /// <summary>
    /// 表示逻辑走向为 二段分支类型
    /// </summary>
    public class EndNode : LogicNode
    {

    }

    /// <summary>
    /// 表示逻辑走向为 二段分支类型
    /// </summary>
    public class DecisionNode : LogicNode
    {

    }

    /// <summary>
    /// 表示逻辑走向为 多节点分支类型
    /// </summary>
    public class CaseNode : LogicNode
    {

    }

    /// <summary>
    /// 表示逻辑走向为 流程页子组类型
    /// </summary>
    public class GroupNode : LogicNode
    {
        /// <summary>
        /// 如果是流程页，执行的是逻辑顺序，流程会进入内部的subNodes进行运行
        /// 最后会寻找nextNodes进行运行
        /// </summary>
        public List<LogicNode> SubNodes { get; set; }
    }

}
