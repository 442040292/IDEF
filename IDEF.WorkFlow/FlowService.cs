using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{

    /// <summary>
    /// 流程运行服务 
    /// </summary>
    public class FlowService
    {


        //流程服务 做这几件事
        //1.任务调度
        //2.任务运行
        //3.接受任务
        //4.任务结果反馈

        //任务队列
        //1.使用sqllite存储任务信息
        //2.使用文件记录任务

        //流程队列部分功能
        //1.运行一个流程
        //2.运行多个流程
        //3.流程互斥
        //4.流程先后顺序
        //5.流程后台运行（纯后台运行的流程，比如下载任务可以多个并行）
        //6.同时运行流程个数


        ConcurrentQueue<WorkTask> WorkDatabase { get; set; }

        /// <summary>
        /// 负责运行列表中的任务，
        /// </summary>
        BackgroundWorker WorkListener = new BackgroundWorker();


        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            WorkDatabase = new ConcurrentQueue<WorkTask>();

            WorkListener.DoWork += WorkListener_DoWork;


            WorkListener.RunWorkerAsync();
        }

        private void WorkListener_DoWork(object sender, DoWorkEventArgs e)
        {
            //1.检查是否有需要执行的任务，如果有就执行，没有就等下一次执行
            


        }





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
