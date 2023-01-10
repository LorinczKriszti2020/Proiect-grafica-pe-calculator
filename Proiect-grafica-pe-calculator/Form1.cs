using System;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace Proiect_grafica_pe_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawing_board_Paint(object sender, PaintEventArgs e)
        {
            //axele x si y

            Graphics gra = this.drawing_board.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 1);

            e.Graphics.DrawLine(blackPen, drawing_board.Width / 2, 0, drawing_board.Width / 2, drawing_board.Width);
            e.Graphics.DrawLine(blackPen, 0, drawing_board.Height / 2, drawing_board.Width, drawing_board.Height / 2);
        }

        private void btn_roots_Click(object sender, EventArgs e)
        {
            calc_roots();
        }

        public void calc_roots()
        {
            // -b +- sqrt(b^2 - 4ac) / 2a

            double root1;
            double root2;

            double ac = 4 * double.Parse(a_txtbox.Text) * double.Parse(c_txtbox.Text);

            root1 = (-double.Parse(b_txtbox.Text) + Math.Sqrt(Math.Pow(double.Parse(b_txtbox.Text), 2) - ac)) / 2 * double.Parse(a_txtbox.Text);
            root2 = (-double.Parse(b_txtbox.Text) - Math.Sqrt(Math.Pow(double.Parse(b_txtbox.Text), 2) - ac)) / 2 * double.Parse(a_txtbox.Text);

            string result = "Radacinile reale sunt: " + Convert.ToString(root1) + " si " + Convert.ToString(root2);

            if ((Math.Pow(double.Parse(b_txtbox.Text), 2) - ac) < 0)
            {
                lbl_result.Text = "Radacinile sunt complexe";
            }
            else if ((Math.Pow(double.Parse(b_txtbox.Text), 2) - ac) == 0)
            {
                lbl_result.Text = "Radacina dubla este: " + Convert.ToString(root1);
            }
            else
                lbl_result.Text = result;
        }

        private void btn_vertex_Click(object sender, EventArgs e)
        {
            calc_vertex();
        }

        public void calc_vertex()
        {
            // -b/2a

            double vertex_x = -double.Parse(b_txtbox.Text) / (2 * double.Parse(a_txtbox.Text));
            double vertex_y = double.Parse(a_txtbox.Text) * Math.Pow(vertex_x, 2) + double.Parse(b_txtbox.Text) * vertex_x + double.Parse(c_txtbox.Text);

            string result = "Coordonatele varfului sunt: " + Convert.ToString(vertex_x) + " si " + Convert.ToString(vertex_y);

            lbl_result.Text = result;
        }

        // EventArgs e,
        private void btn_draw_Click(object sender, EventArgs e)
        {
            int a = int.Parse(a_txtbox.Text);
            int b = int.Parse(b_txtbox.Text);
            int c = int.Parse(c_txtbox.Text);
            double x;
            double y;

            double vertex_x = -double.Parse(b_txtbox.Text) / (2 * double.Parse(a_txtbox.Text));
            double vertex_y = double.Parse(a_txtbox.Text) * Math.Pow(vertex_x, 2) + double.Parse(b_txtbox.Text) * vertex_x + double.Parse(c_txtbox.Text);

            int origin_x = drawing_board.Width / 2 + Convert.ToInt32(vertex_x);
            int origin_y = drawing_board.Height/ 2 - Convert.ToInt32(vertex_y);

            Bitmap pen = new Bitmap(1, 1);
            pen.SetPixel(0, 0, Color.Black);    
            System.Drawing.Graphics g = drawing_board.CreateGraphics();
            
            for (double i = 0; i <= 10000; i += 0.01)
            {
                x = i;
                y = (a * (x * x)) + ((b * x) + c);

                g.DrawImageUnscaled(pen, origin_x + (int)x, origin_y - (int)y);
                g.DrawImageUnscaled(pen, origin_x - (int)x, origin_y - (int)y);

                if (y >= origin_y)
                    break;
            }
        }

        private void btn_draw_rectangle_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics g = drawing_board.CreateGraphics();

            Pen blackPen = new Pen(Color.Black, 1);

            int xcolt1 = Convert.ToInt32(txtbox_colt1x.Text) + (drawing_board.Width / 2);
            int ycolt1 = (drawing_board.Height / 2) - Convert.ToInt32(txtbox_colt1y.Text);

            int xcolt2 = Convert.ToInt32(txtbox_colt2x.Text) + (drawing_board.Width / 2);
            int ycolt2 = (drawing_board.Height / 2) - Convert.ToInt32(txtbox_colt2y.Text);

            int xcolt3 = xcolt1;
            int ycolt3 = ycolt2;

            int xcolt4 = xcolt2;
            int ycolt4 = ycolt1;

            g.DrawLine(blackPen, xcolt1, ycolt1, xcolt3, ycolt3);
            g.DrawLine(blackPen, xcolt2, ycolt2, xcolt3, ycolt3);
            g.DrawLine(blackPen, xcolt2, ycolt2, xcolt4, ycolt4);
            g.DrawLine(blackPen, xcolt4, ycolt4, xcolt1, ycolt1);
        }

        private void btn_troubleshoot_Click(object sender, EventArgs e)
        {
            int a = int.Parse(a_txtbox.Text);
            int b = int.Parse(b_txtbox.Text);
            int c = int.Parse(c_txtbox.Text);

            double x = 0.4384471871911697;
            double y = (a * (x * x)) + (b * x) + c;

            string result = Convert.ToString(y);

            lbl_result.Text = result;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            drawing_board.Refresh();
            listbox_result.Items.Clear();
        }

        private void btn_inter_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics g = drawing_board.CreateGraphics();

            int xcolt1 = Convert.ToInt32(txtbox_colt1x.Text);
            int ycolt1 = Convert.ToInt32(txtbox_colt1y.Text);

            int xcolt2 = Convert.ToInt32(txtbox_colt2x.Text);
            int ycolt2 = Convert.ToInt32(txtbox_colt2y.Text);

            int xcolt3 = xcolt1;
            int ycolt3 = ycolt2;

            int xcolt4 = xcolt2;
            int ycolt4 = ycolt1;

            int a = int.Parse(a_txtbox.Text);
            int b = int.Parse(b_txtbox.Text);
            int c = int.Parse(c_txtbox.Text);

            double x = xcolt1;
            double y = (a * (x * x)) + (b * x) + c;

            Pen redPen = new Pen(Color.Red, 2);
            int radius = 5;

            if (y <= Math.Max(ycolt1, ycolt3) && y >= Math.Min(ycolt1, ycolt3))
            {
                listbox_result.Items.Add(Convert.ToString(x) + " si1 " + Convert.ToString(y)); 
                g.DrawEllipse(redPen, (int)x + drawing_board.Width / 2 - radius, -(int)y + drawing_board.Height / 2 - radius, radius + radius, radius + radius);
            }

            x = xcolt2;
            y = (a * (x * x)) + (b * x) + c;

            if (y <= Math.Max(ycolt2, ycolt4) && y >= Math.Min(ycolt2, ycolt4))
            {
                listbox_result.Items.Add(Convert.ToString(x) + " si2 " + Convert.ToString(y));
                g.DrawEllipse(redPen, (int)x + drawing_board.Width / 2 - radius, -(int)y + drawing_board.Height / 2 - radius, radius + radius, radius + radius);
            }

            for (double i = -100; i <= 100; i += 0.01)
            {
                x = i;
                y = (a * (x * x)) + ((b * x) + c);

                Math.Round(y, 0);
                y = Convert.ToInt32(y);

                if (y == ycolt1 || y == ycolt2)
                {
                    if (x <= Math.Max(xcolt1, xcolt2) && x >= Math.Min(xcolt1, xcolt2))
                    {
                        listbox_result.Items.Add(Convert.ToString(Math.Round(x, 3)) + " si " + Convert.ToString(y));
                        g.DrawEllipse(redPen, (int)x + drawing_board.Width / 2 - radius, -(int)y + drawing_board.Height / 2 - radius, radius + radius, radius + radius);
                        i = i + 1;
                    }
                }
            }
        }
    }
}