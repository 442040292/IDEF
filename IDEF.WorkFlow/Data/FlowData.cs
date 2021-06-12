using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// 所有的流程数据都以 Data 为标识，表示是数据的一部分
    /// </summary>
    public class FlowData
    {

        /// <summary>
        /// 流程Id 用于标识流程
        /// </summary>
        public Guid Id { get; set; }


        /// <summary>
        /// 流程名称
        /// </summary>
        public string FlowName { get; set; }

        /// <summary>
        /// 流程的逻辑顺序关系，只在乎流程的逻辑走向，不关系流程的数据
        /// </summary>
        public List<LogicNode> FlowLogics { get; set; }


        /// <summary>
        /// 所有的节点数据部分都在这里，并列排列，相当于一个数据库
        /// </summary>
        public List<NodeData> NodeDatas { get; set; }
        /// <summary>
        /// 流程的设计时数据，一般情况下在运行时都不会变更的数据
        /// 1.如流程块所占的区域 RECT 用
        /// 2.用户自定义节点的名称
        /// 3.用户自定义的备注
        /// 
        /// 注：节点参数，节点说明不在此范围，应当在具体的节点中通过其他方式设置和获取
        /// </summary>
        public List<NodeDesignData> NodeDesignDatas { get; set; }

    }
}
