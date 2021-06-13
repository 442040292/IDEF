using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkDemo
{
    /// <summary>
    /// 参数校验 
    /// 1.针对参数校验，也应当在这里设定相应的规则，如果参数校验不通过则不用再继续进入运行
    /// 2.针对参数，应当提前从变量转换为，真实数据
    /// </summary>
    public class SampleWork : IWork.IWork
    {
        public int Param1 { get; set; }

        public int Param2 { get; set; }

        public CacType CacType { get; set; }

        public int Result { get; set; }

        public void RunWork()
        {
            switch (CacType)
            {
                case CacType.Add:
                    this.Result = Param1 + Param2;
                    break;
                case CacType.Cut:
                    this.Result = Param1 - Param2;
                    break;
                default:
                    throw new Exception($"不存在的运算类型");
                    break;
            }
        }
    }
}
