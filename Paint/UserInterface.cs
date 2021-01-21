/*UserInterface.cs
 * Author: Eve Steinle
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class UserInterface : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        public UserInterface()
        {
            InitializeComponent();
            g = uxPaintPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black,5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            uxBlack.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            uxBlue.BorderStyle = BorderStyle.None;
            uxBlack.BorderStyle = BorderStyle.None;
            uxRed.BorderStyle = BorderStyle.None;
            uxYellow.BorderStyle = BorderStyle.None;
            p.BorderStyle = BorderStyle.Fixed3D;
            pen.Color = p.BackColor;
        }

        private void uxPaintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            uxPaintPanel.Cursor = Cursors.Cross;
            
        }

        private void uxPaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving == true && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                
            }
        }

        private void uxPaintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            uxPaintPanel.Cursor = Cursors.Default;
        }
    }
}
