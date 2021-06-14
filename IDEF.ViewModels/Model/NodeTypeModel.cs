using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEF.ViewModels.Model
{
    public class NodeTypeModel : WorkFlow.NodeType
    {
        public NodeTypeModel(Type type)
        {
            this.Type = type;
            this.FullName = type.FullName;
            this.Namespace = type.Namespace;
            this.Name = type.Name;
        }


        public Type Type { get; set; }

    }
}
