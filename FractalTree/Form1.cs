using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalTree
{
    public partial class Window1 : Form
    {
        private Graphics g;
        private Pen p;
        private int _depth;
        private float _length, _theta, _length_scale, _dtheta;
        private long done;
        private double step, progress;

        public Window1()
        {
            InitializeComponent();
        }

        private SolidBrush RandomColor()
        {
            SolidBrush result;
            Random randomizer = new Random();
            int r = randomizer.Next(0, 256);
            int g = randomizer.Next(0, 256);
            int b = randomizer.Next(0, 256);

            result = new SolidBrush(Color.FromArgb(r, g, b));
            return result;
        }

        private void LoadData()
        {
            progress = 0;
            g = CreateGraphics();
            p = new Pen(RandomColor(), 7);
            _length = (float)length_value.Value;
            _theta = (float)-Math.PI / 2;
            _length_scale = (float)length_scale_value.Value;
            _dtheta = (float)DTheta_value.Value;
            _depth = (int)depth_value.Value;
            done = (long)Math.Pow(2, _depth) - 1;
            step = (double)100 / (double)done;
        }

        private void draw_btn_Click(object sender, EventArgs e)
        {
            LoadData();
            g.FillRectangle(new SolidBrush(Color.DarkGray), new Rectangle(0, 0, 1920, 1080));
            DrawBranch(g, p, _depth, panel1.Width/2, panel1.Top-20, _length, _theta, _length_scale, _dtheta);
        }

        private void DrawBranch(Graphics gr, Pen pen, int depth,
            float x, float y, float length, float theta,
            float length_scale, float dtheta)
        {
            float x1 = (float)(x + length * Math.Cos(theta));
            float y1 = (float)(y + length * Math.Sin(theta));

            gr.DrawLine(pen, x, y, x1, y1);
            pen = new Pen(RandomColor(), (length_scale>1.0)?pen.Width*length_scale:3);
            progress += step;

            proggres_bar.Value = (int)progress;
            if (depth > 1)
            {
                DrawBranch(gr, pen, depth - 1, x1, y1,
                    length * length_scale, theta + dtheta, length_scale,
                    dtheta);
                DrawBranch(gr, pen, depth - 1, x1, y1,
                    length * length_scale, theta - dtheta, length_scale,
                    dtheta);
            }
        }
    }
}
