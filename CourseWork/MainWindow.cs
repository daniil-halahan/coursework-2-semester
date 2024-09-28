using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainWindow : Form
    {
        public static int minNumElem = 100;
        public static int maxNumElem = 50000;
        public static int minNum = -50000;
        public static int maxNum = 50000;
        public static int maxAnimNum = 300;
        public bool IsAscending;
        public enum SortMethods { MergeSort, QuickSort, IntroSort }
        public SortMethods Method;
        public List<int> arrayToSort = new List<int>();
        public List<int> arraySorted = new List<int>();
        public List<(int left, int right)> tuplesAnimation = new List<(int , int)>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            btnReadArray.Image = new Bitmap(SystemIcons.Information.ToBitmap(), new Size(17, 17));
            toolTip1.SetToolTip(btnReadArray, toolTip1.GetToolTip(btnReadArray)
                .Replace("minNumElem", minNumElem.ToString())
                .Replace("maxNumElem", maxNumElem.ToString())
                .Replace("minNum", minNum.ToString())
                .Replace("maxNum", maxNum.ToString()));

            radioBtnMergeSort.Checked = true;
            Method = SortMethods.MergeSort;
            radioBtnAscending.Checked = IsAscending = true;
        }

        //=========

        private void btnGenerateArray_Click(object sender, EventArgs e)
        {
            selectDisable();
            GenerateWindow generateWindow = new GenerateWindow();
            generateWindow.Show();
        }
        private void btnReadArray_Click(object sender, EventArgs e)
        {
            selectDisable();
            if (openFile.ShowDialog() == DialogResult.Cancel)
            {
                selectEnable();
                return;
            }
            string filePath = openFile.FileName;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int numElem = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    long value;
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    else if (!long.TryParse(line, out value))
                    {
                        selectEnable();
                        MessageBox.Show("У файлі повинні бути тільки цілі числа", "Помилки читання", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (value > maxNum)
                    {
                        selectEnable();
                        MessageBox.Show("Числа повинні бути не більше " + maxNum, "Вихід за діапазон", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (value < minNum)
                    {
                        selectEnable();
                        MessageBox.Show("Числа повинні бути не менші " + minNum, "Вихід за діапазон", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    numElem++;
                    if (numElem > maxNumElem)
                    {
                        selectEnable();
                        MessageBox.Show("Кількість елементів повинна бути не більша " + maxNumElem, "Некоректна кількість елементів", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (numElem < minNumElem)
                {
                    selectEnable();
                    MessageBox.Show("Кількість елементів повинна бути не менша " + minNumElem, "Некоректна кількість елементів", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reader.DiscardBufferedData();
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    arrayToSort.Add(int.Parse(line));
                }
            }
            sortEnable();
            reviewEnable();
        }
        private void btnInputArray_Click(object sender, EventArgs e)
        {
            InputWindow inputWindow = new InputWindow();
            inputWindow.Show();
        }
        private void btnOutputUnsortedArray_Click(object sender, EventArgs e)
        {
            OutputWindow outputWindow = new OutputWindow(arrayToSort);
            outputWindow.Show();
        }
        private void btnClearArray_Click(object sender, EventArgs e)
        {
            clearArray();
            sortDisable();
            selectEnable();
            reviewDisable();
        }
        
        //=========

        private void radioBtnMergeSort_CheckedChanged(object sender, EventArgs e)
        {
            Method = SortMethods.MergeSort;
            radioClear();
        }
        private void radioBtnQuickSort_CheckedChanged(object sender, EventArgs e)
        {
            Method = SortMethods.QuickSort;
            radioClear();
        }
        private void radioBtnIntroSort_CheckedChanged(object sender, EventArgs e)
        {
            Method = SortMethods.IntroSort;
            radioClear();
        }
        private void radioBtnAscending_CheckedChanged(object sender, EventArgs e)
        {
            IsAscending = true;
            radioClear();
        }
        private void radioBtnDescending_CheckedChanged(object sender, EventArgs e)
        {
            IsAscending = false;
            radioClear();
        }
        private void btnSortArray_Click(object sender, EventArgs e)
        {
            arraySorted = new List<int>(arrayToSort);
            Sorter sorter = new Sorter(IsAscending, arrayToSort.Count <= maxAnimNum);

            if (Method == SortMethods.MergeSort)
            {
                sorter.MergeSort(arraySorted);
            }
            else if (Method == SortMethods.QuickSort)
            {
                sorter.QuickSort(arraySorted);
            }
            else if (Method == SortMethods.IntroSort)
            {
                sorter.IntroSort(arraySorted);
            }

            label1.Text = "Практична складність: " + sorter.Complexity +
                "\nЧас виконання: " + sorter.ExecutionTime.Elapsed.TotalMilliseconds + " мс";
            resultEnable();
        }

        //=========

        private void btnOutputSortedArray_Click(object sender, EventArgs e)
        {
            OutputWindow outputWindow = new OutputWindow(arraySorted);
            outputWindow.Show();
        }
        private void btnAnimateArray_Click(object sender, EventArgs e)
        {
            sortDisable();
            reviewDisable();
            AnimationWindow animationWindow = new AnimationWindow();
            animationWindow.Show();
        }
        private void btnSaveArray_Click(object sender, EventArgs e)
        {
            sortDisable();
            reviewDisable();
            if (saveFile.ShowDialog() == DialogResult.Cancel)
            {
                sortEnable();
                reviewEnable();
                resultEnable();
                return;
            }
            string filePath = saveFile.FileName;
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                foreach (int num in arraySorted)
                {
                    writer.WriteLine(num);
                }
            }
            sortEnable();
            reviewEnable();
            resultEnable();
        }

        //=========

        public void sortEnable()
        {
            selectMethod.Enabled = true;
            selectOrder.Enabled = true;
            btnSortArray.Enabled = true;
        }
        public void sortDisable()
        {
            selectMethod.Enabled = false;
            selectOrder.Enabled = false;
            btnSortArray.Enabled = false;
            resultDisable();
        }
        public void resultEnable()
        {
            btnOutputSortedArray.Enabled = true;
            btnSaveArray.Enabled = true;
            if (arrayToSort.Count <= maxAnimNum)
                btnAnimateArray.Enabled = true;
            label1.Enabled = true;
        }
        public void resultDisable()
        {
            btnOutputSortedArray.Enabled = false;
            btnSaveArray.Enabled = false;
            btnAnimateArray.Enabled = false;
            label1.Enabled = false;
        }
        public void selectEnable()
        {
            btnGenerateArray.Enabled = true;
            btnReadArray.Enabled = true;
            btnInputArray.Enabled = true;
        }
        public void selectDisable()
        {
            btnGenerateArray.Enabled = false;
            btnReadArray.Enabled = false;
            btnInputArray.Enabled = false;
        }
        public void reviewEnable()
        {
            btnOutputUnsortedArray.Enabled = true;
            btnClearArray.Enabled = true;
        }
        public void reviewDisable()
        {
            btnOutputUnsortedArray.Enabled = false;
            btnClearArray.Enabled = false;
        }
        public void clearArray()
        {
            arrayToSort.Clear();
            arraySorted.Clear();
            tuplesAnimation.Clear();
        }
        public void radioClear()
        {
            arraySorted.Clear();
            tuplesAnimation.Clear();
            resultDisable();
        }
    }
}