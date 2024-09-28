using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class InputWindow : Form
    {
        public InputWindow()
        {
            InitializeComponent();
        }
        private void InputWindow_Load(object sender, EventArgs e)
        {
            Program.mainWindow.selectDisable();
            label1.Text = label1.Text
                .Replace("minNum", MainWindow.minNum.ToString())
                .Replace("maxNum", MainWindow.maxNum.ToString());
            numValue.Maximum = MainWindow.maxNum;
            numValue.Minimum = MainWindow.minNum;
            numValue.Value = 0;
            label2.Text = label2.Text
                .Replace("minNumElem", MainWindow.minNumElem.ToString())
                .Replace("maxNumElem", MainWindow.maxNumElem.ToString());
            label3.Text = "Додано чисел: " + 0;
        }
        private void btnAddElem_Click(object sender, EventArgs e)
        {
            Program.mainWindow.arrayToSort.Add((int)numValue.Value);
            listBox1.Items.Add((int)numValue.Value);
            label3.Text = "Додано чисел: " + Program.mainWindow.arrayToSort.Count.ToString();
            if (Program.mainWindow.arrayToSort.Count == MainWindow.maxNumElem)
            {
                inputBox.Enabled = false;
                if(MessageBox.Show(
                    "Додано максимальну кількість чисел." +
                    "\nЗакрити вікно вводу масиву?",
                    "",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Close();
                }
            }

        }
        private void InputWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            int countValue = Program.mainWindow.arrayToSort.Count;
            if (countValue < MainWindow.minNumElem)
            {
                DialogResult result = MessageBox.Show(
                    "Всього введено " + countValue + " елементів, коли мінімальна кількість " + MainWindow.minNumElem + "." +
                    "\nЗгенерувати випадково бракуючі елементи?" +
                    "\nПри негативній відповіді додані елементи будуть очищені.",
                    "",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GenerateWindow generateWindow = new GenerateWindow(countValue);
                    generateWindow.Show();
                }
                else if (result  == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.mainWindow.clearArray();
                    Program.mainWindow.selectEnable();
                }
            }
            else
            {
                Program.mainWindow.sortEnable();
                Program.mainWindow.reviewEnable();
            }
        }
    }
}