using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.WorkFlow
{
    public class Flow
    {

        public List<Node> FlowShip { get; set; }

        public List<NodeData> NodeDatas { get; set; }


        public void Run()
        {
            var startNode = FlowShip.FirstOrDefault(x => x is StartNode);

            if (startNode == null)
            {
                //请设置一个开始接点
                return;
            }

            var secondNode = startNode.Ports.First();

            while (true)
            {

                var nodeData = GetNode(secondNode.To);
                IAction action = nodeData as IAction;
                action.DoExecute(nodeData);

                var nextNode = GetNextNode(secondNode.To);
                if (nextNode == Guid.Empty)
                {
                    break;
                }
            }

        }


        private NodeData GetNode(Node node)
        {
            return GetNode(node.Id);
        }
        private NodeData GetNode(Guid nodeid)
        {
            var nodeData = NodeDatas.FirstOrDefault(x => x.Id == nodeid);
            return nodeData;
        }
        private Guid GetNextNode(Node node)
        {
            return GetNextNode(node.Id);
        }
        private Guid GetNextNode(Guid guid)
        {
            var nextNode = FlowShip.FirstOrDefault(x => x.Id == guid);
            if (nextNode == null)
            {
                return Guid.Empty;
            }
            else
            {
                var nextPort = nextNode.Ports.FirstOrDefault();
                if (nextNode.Ports.Any(x => x is CasePort))
                {
                    if (nextPort is CasePort casePort)
                    {
                        if (casePort.Condition)
                        {
                            return casePort.To;
                        }
                        else
                        {

                        }
                    }
                }
                else
                {
                    return nextPort.To;
                }
                return nextPort.To;
            }
        }



        public void Run(Guid nodeid)
        {







        }

    }
}
