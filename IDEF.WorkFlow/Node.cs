using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    /// <summary>
    /// Node 表示每个事件的基类，只存储数据部分
    /// 1.Node的输入参数。
    /// 2.Node的输出参数。
    /// 3.
    /// </summary>
    public class Node
    {
        public Guid Id { get; set; }

        ////表示将往何处进行
        //public List<Port> Ports { get; set; }

        public List<Argument> Arguments { get; set; }

        //参数进出以json得方式传递
        //变量


        //变量-数据-将是整个流程最重要的部分
        //一个变量就是一个单位 存储一个json的数据块（如果是文件类型有实体映射）
        //节点的输入是一个变量
        //节点的参数可以通过字符串和其他变量的拼接，形成一个新的变量
        //每一个变量应该使用guid来唯一定义，如果需要数字或者字符串定义的来展示可以另行添加注解属性，精确查找只对应guid
        //输出参数 也是一个json包装，方便外部获取

        //逻辑走向节点 

        //对于分支类型
        //可以自由更改节点的 分支类型
        //通过节点的输出 给到判断走向的 -》容器，设置容器的判断走向依据
        //如果是简单判断 如if else 提供默认的 true false 
        //如果是分支判断 根据顺序判断分支的条件是否成立来决定走哪一个分支
        //类似外挂的东西-

        //当然 单独的节点也是必不可少的
        //此方式是减少 单独拿出节点来设置流程走向的方式

        //循环节点





    }
}
