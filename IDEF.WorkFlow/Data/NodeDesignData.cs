using IDEF.WorkFlow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IDEF.WorkFlow
{

    /// <summary>
    /// 节点设计时所需要的数据
    /// 1.区域只用于描绘这个节点占了位置 由于节点位置不会随意变化，并且在运行时此参数无用所以不需要和节点的参数一起存储
    /// 
    /// </summary>
    public class NodeDesignData
    {
        /// <summary>
        /// 节点的Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 节点所占的区域
        /// </summary>
        public NodeRect Rect { get; set; }
    }
}
