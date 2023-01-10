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

            string result = Convert.ToString(root1) + " si " + Convert.ToString(root2);

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
            
            for (double i = vertex_x; i <= 10000; i += 0.01)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_troubleshoot_Click(object sender, EventArgs e)
        {
            int a = int.Parse(a_txtbox.Text);
            int b = int.Parse(b_txtbox.Text);
            int c = int.Parse(c_txtbox.Text);
            int xcolt1 = Convert.ToInt32(txtbox_colt1x.Text);

            double x = xcolt1;
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

            if (y <= Math.Max(ycolt1, ycolt3) && y >= Math.Min(ycolt1, ycolt3))
            {
                listbox_result.Items.Add(Convert.ToString(x) + " si " + Convert.ToString(y));
            }

            x = xcolt2;
            y = (a * (x * x)) + (b * x) + c;

            if (y <= Math.Max(ycolt2, ycolt4) && y >= Math.Min(ycolt2, ycolt4))
            {
                listbox_result.Items.Add(Convert.ToString(x) + " si " + Convert.ToString(y));
            }

            c += -ycolt1;
            double x1;
            double x2;

            double ac = 4 * double.Parse(a_txtbox.Text) * double.Parse(c_txtbox.Text);

            x1 = (-double.Parse(b_txtbox.Text) + Math.Sqrt(Math.Pow(double.Parse(b_txtbox.Text), 2) - ac)) / 2 * double.Parse(a_txtbox.Text);
            x2 = (-double.Parse(b_txtbox.Text) - Math.Sqrt(Math.Pow(double.Parse(b_txtbox.Text), 2) - ac)) / 2 * double.Parse(a_txtbox.Text);

            if (x1 <= Math.Max(xcolt1, xcolt4) && x1 >= Math.Min(xcolt1, xcolt4))
            {
                listbox_result.Items.Add(Convert.ToString(x) + " si " + Convert.ToString(y));
            }
            if (x2 <= Math.Max(xcolt1, xcolt4) && x2 >= Math.Min(xcolt1, xcolt4))
            {
                listbox_result.Items.Add(Convert.ToString(x) + " si " + Convert.ToString(y));
            }

            c += -ycolt3; 

            ac = 4 * double.Parse(a_txtbox.Text) * double.Parse(c_txtbox.Text);

            x1 = (-double.Parse(b_txtbox.Text) + Math.Sqrt(Math.Pow(double.Parse(b_txtbox.Text), 2) - ac)) / 2 * double.Parse(a_txtbox.Text);
            x2 = (-double.Parse(b_txtbox.Text) - Math.Sqrt(Math.Pow(double.Parse(b_txtbox.Text), 2) - ac)) / 2 * double.Parse(a_txtbox.Text);

            if (x1 <= Math.Max(xcolt2, xcolt3) && x1 >= Math.Min(xcolt2, xcolt3))
            {
                listbox_result.Items.Add(Convert.ToString(x) + " si " + Convert.ToString(y));
            }
            if (x2 <= Math.Max(xcolt2, xcolt3) && x2 >= Math.Min(xcolt2, xcolt3))
            {
                listbox_result.Items.Add(Convert.ToString(x) + " si " + Convert.ToString(y));
            }

        }
    }
}