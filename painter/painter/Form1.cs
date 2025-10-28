using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace painter
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g=Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

        }
        Pen P = new Pen(Color.Black, 3);
        int x, y;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(800, 600);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g= Graphics.FromImage(pictureBox1.Image);
                g.DrawLine(P,x,y,e.X,e.Y);
                x=e.X; y=e.Y;
                pictureBox1.Refresh();
            }
        }

        private void 藍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.Color = Color.Blue;
        }

        private void 黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.Color= Color.Black;
        }

        private void 紅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.Color=Color.Red;
        }

        private void 細ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.Width = 1;
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.Width= 3;
        }

        private void 出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.Width=5;
        }

        private void 短虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
        }

        private void 直線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void 長虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        }

        private void 長短虛線ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void 處存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\Users\user\Desktop\1.jpg",ImageFormat.Png);
            MessageBox.Show("處存成功");
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x=e.X;
            y=e.Y;

        }
    }
}
