using IDEF.IWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkDemo
{
    public class SampleWork : IWork.IWork
    {
        public NodeRequest Request { get; set; } = null;
        public NodeResponse Response { get; set; } = null;


        public void RunWork(FlowContext flowcontext)
        {
            

        }
    }
}
