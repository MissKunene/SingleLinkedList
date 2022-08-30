using LinkedListApp.CLinkedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListApp
{
    public partial class Form1 : Form

    {

        SLinkedList sLinkedList = new SLinkedList();
        //string dataNode = null;
        List<String> nodesList = new List<String>();
        public Form1()
        {
            InitializeComponent();
            SLinkedList slinkedList = new SLinkedList();
            List<String> nodesList = new List<String>();
            slinkedList.appendNode("I am the Head");
            slinkedList.appendNode("I am the Second Node");
            slinkedList.appendNode("I am the Third Node");

            slinkedList.prepend("I am the new head");
            slinkedList.prepend("Mwhahaha I am the new head now");
            slinkedList.prepend("Look at me, I am the Captain now");

            //slinkedList.deteleWithData("I am the Second Node");
            //slinkedList.applyProfanityFilter("am");
            slinkedList.insertAfter("I have been inserted After", "Look at me, I am the Captain now");
            nodesList = slinkedList.showNext();

            foreach (string item in nodesList)
            {
                MessageBox.Show(item);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void  BtnSing_Click(object sender, EventArgs e)
        {

            
        }

        
        
    }
}
