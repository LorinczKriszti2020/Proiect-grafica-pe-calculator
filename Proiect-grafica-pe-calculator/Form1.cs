namespace Proiect_grafica_pe_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //calories += Convert.ToDouble(lbl_cal_barley.Text) * (double.Parse(txtbox_barley.Text) / 100);

        
        private void drawing_board_Paint(object sender, PaintEventArgs e)
        {

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

        private void btn_draw_Click(object sender, EventArgs e)
        {
            int a = int.Parse(a_txtbox.Text);
            int b = int.Parse(b_txtbox.Text);
            int c = int.Parse(c_txtbox.Text);
            double x;
            double y;


            int origo_x = drawing_board.Width / 2;
            int origo_y = drawing_board.Height/ 2;

            Bitmap pen = new Bitmap(1, 1);
            pen.SetPixel(0, 0, Color.Black);    
            System.Drawing.Graphics g = drawing_board.CreateGraphics();

            for(double i = 0; i <= 10000; i += 0.01)
            {
                x = i;
                y = (a * (x * x)) + ((b * x) + c);

                g.DrawImageUnscaled(pen, origo_x + (int)x, origo_y - (int)y);
                g.DrawImageUnscaled(pen, origo_x - (int)x, origo_y - (int)y);

                if (y >= origo_y)
                    break;
            }
            
        }
    }
}