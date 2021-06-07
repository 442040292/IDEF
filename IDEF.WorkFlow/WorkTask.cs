using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{

    /// <summary>
    /// 创建的任务，只记录任务的基本信息，而不加载不运行具体的任务。
    /// 此类仅用于管理队列中的执行调度顺序等逻辑，防止在操作调度时带数据跑来跑去
    /// </summary>
    class WorkTask
    {
        /// <summary>
        /// 工作任务
        /// </summary>
        public Guid Id { get; set; }


    }
}
