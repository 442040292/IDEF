using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow.Context
{
    public class ArgumentContext
    {

        public Guid Id { get; set; }

        /// <summary>
        /// 运行时的值，在输入结点之前，提前计算出参数的值
        /// 1.节点初始化
        /// 2.节点参数初始化（计算进入节点的Runtime值）
        /// 3.节点运行
        /// 4.节点输出参数
        /// 5.节点处理参数
        /// </summary>
        public string RuntimeValue { get; set; }
    }
}
