using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// 这里表示节点的属性 参数，
    /// 1.可以直接输入作为节点参数
    /// 2.可以使用引用变量作为节点参数
    /// </summary>
    public class ArgumentData
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 表达式
        /// </summary>
        public string Expression { get; set; }

    }
}
