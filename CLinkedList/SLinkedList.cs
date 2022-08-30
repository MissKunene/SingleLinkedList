using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace LinkedListApp.CLinkedList
{
    class SLinkedList
    {
        CustomNode head;
        List<string> nextlist;
        
        CustomNode current;
       
        String data;
        int nodeCount;

        public void appendNode(string data) 
        {
            //if the list is empty make a node call it head
           if (head == null) 
            {
                head = new CustomNode(data);
                nodeCount++;
               
            }

            current = head;

            while (current.Next != null) 
            {
              
              current = current.Next;
               
            }

            current.Next = new CustomNode (data);
            //return data;
        }

       

         public List<string> showNext(int listSize, string data)
         {
             List<string> nextlist = new List<string>();
             current = head;
             nextlist.Add( current.data);
             while (current.Next != null)
             {
                 nextlist.Add( current.Next.data);
                 current = current.Next;
             }
             return nextlist;
         }

        internal List<string> showNext()
        {
            throw new NotImplementedException();
        }

        public void prepend(string data) 
        {
            if (head == null)
            {
                head = new CustomNode(data);
                nodeCount++;

            }
            else 
            {
                CustomNode newhead = new CustomNode(data);
                nodeCount++;        
                newhead.Next = head;        
                head = newhead;                
            }


            

        }

        public void deleteNode(string data) 
        {
            if (head == null) 
            {
                MessageBox.Show("Cannot delete a value from the empty list");
                return;
;            }

            if (head.data.Equals(data)) 
            {
                head = head.Next;
            }

            current = head;

            while (current.Next!=null) 
            {
                if (current.data.Equals(data)) 
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Node with data" + data+ "deleted");
                }
                
                current=current.Next;
            }

            MessageBox.Show("Could not delete data because data is not presented in list");
            
        }

        public void applyProfanitFilter(string data)
        {
            if (head == null)
            {
                MessageBox.Show("No list to clean ");
            }

            if (head.data.Contains(data))
            {
                string replaceString = head.data.Replace(data, "*****");
                head.data = replaceString;
                MessageBox.Show(head.data);

            }


            current =head;
            while (current.Next!=null) 
            {
                
                current = current.Next;
                if (current.data.Contains(data)) 
                {
                    string replaceString = current.data.Replace(data, "****");
                    current.data = replaceString;
                    MessageBox.Show(current.data);

                }

            }

            MessageBox.Show("No swearwords in here!");
        }

        public void insertAfter(string nodeData, string searchData) 
        {
            if (head == null) 
            {
                MessageBox.Show("There is no list you nana");
            }

            if (head.data.Contains(searchData)) 
            {
               CustomNode insertNode= new CustomNode(nodeData);
                insertNode.Next = head.Next;
                head.Next = insertNode;
            }
        }

        
    }
}
