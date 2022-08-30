using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    public class CustomNode
    {
        
        public CustomNode Next;
        public string data; 

        public CustomNode()
        {
                //good practice
        }

        public CustomNode(string data)
        {
            this.data = data;
        }

        
        }
}
