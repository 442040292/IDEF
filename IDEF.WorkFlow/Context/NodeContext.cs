using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// 节点上下文 存储单个节点所用到的参数
    /// 1.设计时和运行时，
    /// 2.设计时，也就是流程的绘制和存储，数据不会变化只会保留一份
    /// 3.运行时，在运行时，可以存储节点每一次调用时，参数的变化，根据流程的运行走向，记录节点运行的时间，参数等具体的日志。
    /// 4.使用实体的方式，是为了后续增加调试功能，和高危操作时做出必要的日志记录。虽然可以使用日志工具来记录错误，但是大部分日志不可读，而且无法还原场景。
    /// 5.缺点，会造成很多的内存占用。可以尝试使用数据库，或者文件的方式进行记录。
    /// </summary>
    public class NodeContext
    {
        public Guid Id { get; set; }
        public List<Argument> Arguments { get; set; }

    }
}
