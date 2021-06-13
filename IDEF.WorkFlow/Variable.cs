using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// 变量，用于存储各种类型的数据，类似Argument，Argument 是节点内固定的属性
    /// </summary>
    public class Variable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CustomerName { get; set; }

        public Guid Id { get; set; }

        public string Type { get; set; }

        public string Expression { get; set; }

    }
}
