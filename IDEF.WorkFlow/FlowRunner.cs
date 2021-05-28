using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    public class FlowRunner
    {

        // 节点连线信息 全部单独存
        // 节点数据信息 全部单独存


        public void RunFlow()
        {

            //1. Node 附加信息 可有可无 （每个节点 执行前 执行后 等待时间 备注信息 等等）
            //2. Node 主要信息 包括输入输出的信息 返回信息 实际节点钟会用到的信息


        }


        /// <summary>
        /// 这里是注释 说明
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [Obsolete("信息")]
        public object Method(object param)
        {


            return param;
        }


    }
}
