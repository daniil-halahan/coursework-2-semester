using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AnimationWindow : Form
    {
        private List<int> heightsOfValues = new List<int>();
        private int maxAbsValue;
        private int width;
        private int toCenter;
        Graphics g;
        public AnimationWindow()
        {
            InitializeComponent();
        }
        private void AnimationWindow_Load(object sender, EventArgs e)
        {
            int leftAbs = Math.Abs(Program.mainWindow.arraySorted[0]),
                rightAbs = Math.Abs(Program.mainWindow.arraySorted[Program.mainWindow.arraySorted.Count - 1]);
            maxAbsValue = (leftAbs > rightAbs) ? leftAbs : rightAbs;
            getHeightsOfValues();
            width = animArea.Width / heightsOfValues.Count;
            toCenter = (animArea.Width - heightsOfValues.Count * width) / 2;
        }
        private void AnimationWindow_Shown(object sender, EventArgs e)
        {
            g = animArea.CreateGraphics();
            drawArray();
        }
        private async void btnStartAnim_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            btnStartAnim.Enabled = false;
            getHeightsOfValues();
            await Task.Run(() => animateSorting());
            label1.Visible = true;
            btnStartAnim.Enabled = true;
        }
        private void getHeightsOfValues()
        {
            heightsOfValues.Clear();
            foreach (int value in Program.mainWindow.arrayToSort)
            {
                heightsOfValues.Add(animArea.Height * value / (maxAbsValue * 2));
            }
        }
        private void animateSorting()
        {
            drawArray();
            List<(int left, int right)> tuplesAnimation = Program.mainWindow.tuplesAnimation;
            try
            {
                foreach (var tuple in tuplesAnimation)
                {
                    Thread.Sleep(20);
                    int leftX = width * tuple.left + toCenter,
                        rightX = width * tuple.right + toCenter;
                    eraseRectangle(leftX);
                    eraseRectangle(rightX);
                    (heightsOfValues[tuple.left], heightsOfValues[tuple.right]) = (heightsOfValues[tuple.right], heightsOfValues[tuple.left]);
                    drawRectangle(heightsOfValues[tuple.left], leftX);
                    drawRectangle(heightsOfValues[tuple.right], rightX);
                }
            }
            catch { }
        }
        private void drawRectangle(int height, int currentX)
        {
            if (height <= 0)
            {
                g.FillRectangle(Brushes.Blue, currentX, animArea.Height / 2, width, height * -1);
            }
            else
            {
                g.FillRectangle(Brushes.Red, currentX, animArea.Height / 2 - height, width, height);
            }
        }
        private void eraseRectangle(int currentX)
        {
            g.FillRectangle(Brushes.White, currentX, 0, width, animArea.Height);
        }
        private void drawArray()
        {
            g.Clear(Color.White);
            int currentX = toCenter;
            foreach (int height in heightsOfValues)
            {
                drawRectangle(height, currentX);
                currentX += width;
            }
        }
        private void AnimationWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainWindow.sortEnable();
            Program.mainWindow.reviewEnable();
            Program.mainWindow.resultEnable();
        }
    }
}
