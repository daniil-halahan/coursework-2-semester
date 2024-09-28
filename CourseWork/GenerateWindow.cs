using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class GenerateWindow : Form
    {
        private int numOfOccupied = 0;
        public GenerateWindow()
        {
            InitializeComponent();
        }
        public GenerateWindow(int numOfOccupied)
        {
            InitializeComponent(); 
            this.numOfOccupied = numOfOccupied;
        }
        private void GenerateWindow_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text
                .Replace("minNumElem", (MainWindow.minNumElem - numOfOccupied).ToString())
                .Replace("maxNumElem", (MainWindow.maxNumElem - numOfOccupied).ToString());
            countNum.Maximum = MainWindow.maxNumElem - numOfOccupied;
            countNum.Minimum = MainWindow.minNumElem - numOfOccupied;
            countNum.Value = MainWindow.minNumElem - numOfOccupied;

            label2.Text = label2.Text
                .Replace("minNum", MainWindow.minNum.ToString())
                .Replace("maxNum", MainWindow.maxNum.ToString());
            maxValue.Maximum = MainWindow.maxNum;
            maxValue.Minimum = MainWindow.minNum;
            maxValue.Value = MainWindow.maxNum;
            minValue.Maximum = MainWindow.maxNum;
            minValue.Minimum = MainWindow.minNum;
            minValue.Value = MainWindow.minNum;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (radioBtnAscending.Checked || radioBtnDescending.Checked)
            {
                double rangeModule = (double)(maxValue.Value - minValue.Value) / (double)countNum.Value;
                double curMinValue = 0.0, curMaxValue = 0.0;
                if (radioBtnAscending.Checked)
                {
                    curMinValue = (double)minValue.Value;
                    curMaxValue = curMinValue + rangeModule;
                }
                else if (radioBtnDescending.Checked)
                {
                    rangeModule *= -1.0;
                    curMaxValue = (double)maxValue.Value;
                    curMinValue = curMaxValue + rangeModule;
                }
                for (int i = 0; i < (int)countNum.Value; i++)
                {
                    Program.mainWindow.arrayToSort.Add(random.Next((int)Math.Round(curMinValue), (int)Math.Round(curMaxValue)));
                    curMinValue += rangeModule;
                    curMaxValue += rangeModule;
                }
            }
            else
            {
                for (int i = 0; i < (int)countNum.Value; i++)
                {
                    Program.mainWindow.arrayToSort.Add(random.Next((int)minValue.Value, (int)maxValue.Value));
                }
            }
            Close();
        }
        private void minValue_ValueChanged(object sender, EventArgs e)
        {
            if (minValue.Value > maxValue.Value)
            {
                minValue.Value = maxValue.Value;
            }
        }
        private void maxValue_ValueChanged(object sender, EventArgs e)
        {
            if (minValue.Value > maxValue.Value)
            {
                maxValue.Value = minValue.Value;
            }
        }
        private void GenerateWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (numOfOccupied != 0 && Program.mainWindow.arrayToSort.Count < MainWindow.minNumElem)
            {
                if (MessageBox.Show(
                    "Було введено " + numOfOccupied + " елементів, коли мінімальна кількість " + MainWindow.minNumElem + "." +
                    "\nЗакрити вікно генерації та очистити додані елементи?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.mainWindow.clearArray();
                    Program.mainWindow.selectEnable();
                }
            }
            else if (Program.mainWindow.arrayToSort.Count < MainWindow.minNumElem)
            {
                Program.mainWindow.selectEnable();
            }
            else
            {
                Program.mainWindow.sortEnable();
                Program.mainWindow.reviewEnable();
            }
        }
    }
}
