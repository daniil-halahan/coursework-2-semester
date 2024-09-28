using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class OutputWindow : Form
    {
        private List<int> outputList;
        public OutputWindow(List<int> outputList)
        {
            InitializeComponent();
            this.outputList = outputList;
        }
        private void OutputWindow_Load(object sender, EventArgs e)
        {
            lableNumElem.Text = lableNumElem.Text + outputList.Count.ToString();
            listBox1.Items.AddRange(Array.ConvertAll(outputList.ToArray(), ele => ele.ToString()));
        }
    }
}
