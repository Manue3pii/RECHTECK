using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paralelogramme
{
    public partial class Form1 : Form
    {
        public int index = 0;
        public List<Point[]> ListPP = new List<Point[]>();
        public Point[] PP = new Point[4];
        public Pen Pen = new Pen(Brushes.Red, 5);
        public int tempX = 0, tempY = 0;
        public bool drawnonce = false;
        public Form1()
        {
            InitializeComponent();
           // FormBorderStyle = FormBorderStyle.None;
          //  WindowState = FormWindowState.Maximized;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (index == 4 && index <= 4 && index >= 0)
            {
                //ListPP.Add(PP.ToArray());
                //foreach (Point[] item in ListPP)
                //{
                //    e.Graphics.DrawLines(Pen, item);                                  später, falls wir mehrere vierecke machen wollen
                //    e.Graphics.DrawLine(Pen, item[item.Length - 1], item[0]);
                //}
                e.Graphics.DrawLines(Pen, PP);
                e.Graphics.DrawLine(Pen, PP[PP.Length - 1], PP[0]);
               
                //for (int i = 0; i < 20; i++)
                //{
                //    for (int j = 0; j < 4; j++)
                //    {
                //       PP[j].X = Math.Abs(PP[j].X - PP[PP.Length - j].X);
                //        PP[j].Y = Math.Abs(PP[j].Y - PP[PP.Length - j].Y);
                //        if (j == 3)
                //        {
                //            e.Graphics.DrawLine(Pen, PP[j], PP[0]);
                //        }
                //        else
                //        {
                //            e.Graphics.DrawLine(Pen, PP[j], PP[j+1]);
                //        }
                //    }
                //}
                index = 0;
                Array.Clear(PP, 0, PP.Length);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PP[index] == Point.Empty)
                {
                    PP[index] = new Point(MousePosition.X, MousePosition.Y);
                    //Console.Beep(300, 250);
                }
                index++;
                if (index == 4)
                {
                    Invalidate();
                    //Refresh();
                }
            }
            catch (Exception)
            { 
            }
           
                       
        }
    }
}
