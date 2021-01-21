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
        /// <summary>
        /// the graphics for the application
        /// </summary>
        Graphics g;
        /// <summary>
        /// an integer that will provide the x coordinate
        /// </summary>
        int x = -1;
        /// <summary>
        /// an interger that will provide the y coordinate
        /// </summary>
        int y = -1;
        /// <summary>
        /// figures out if the user is drawing or not
        /// </summary>
        bool moving = false;
        /// <summary>
        /// the pen used to draw 
        /// </summary>
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
        /// <summary>
        /// When a picture box is clicked upon, the pen's color will change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Happens when the user first clicks to draw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPaintPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            uxPaintPanel.Cursor = Cursors.Cross;
            
        }
        /// <summary>
        /// When the user is drawing and using color 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPaintPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving == true && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                
            }
        }
        /// <summary>
        /// When the user stops drawing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxPaintPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            uxPaintPanel.Cursor = Cursors.Default;
        }
    }
}
