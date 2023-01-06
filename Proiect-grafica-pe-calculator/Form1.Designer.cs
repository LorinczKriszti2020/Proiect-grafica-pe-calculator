namespace Proiect_grafica_pe_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawing_board = new System.Windows.Forms.Panel();
            this.btn_draw = new System.Windows.Forms.Button();
            this.btn_roots = new System.Windows.Forms.Button();
            this.btn_vertex = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.a_txtbox = new System.Windows.Forms.TextBox();
            this.c_txtbox = new System.Windows.Forms.TextBox();
            this.b_txtbox = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawing_board
            // 
            this.drawing_board.Location = new System.Drawing.Point(120, 12);
            this.drawing_board.Name = "drawing_board";
            this.drawing_board.Size = new System.Drawing.Size(709, 383);
            this.drawing_board.TabIndex = 0;
            this.drawing_board.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_board_Paint);
            // 
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(28, 12);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(75, 23);
            this.btn_draw.TabIndex = 1;
            this.btn_draw.Text = "Draw";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // btn_roots
            // 
            this.btn_roots.Location = new System.Drawing.Point(28, 41);
            this.btn_roots.Name = "btn_roots";
            this.btn_roots.Size = new System.Drawing.Size(75, 23);
            this.btn_roots.TabIndex = 2;
            this.btn_roots.Text = "Roots";
            this.btn_roots.UseVisualStyleBackColor = true;
            this.btn_roots.Click += new System.EventHandler(this.btn_roots_Click);
            // 
            // btn_vertex
            // 
            this.btn_vertex.Location = new System.Drawing.Point(28, 70);
            this.btn_vertex.Name = "btn_vertex";
            this.btn_vertex.Size = new System.Drawing.Size(75, 23);
            this.btn_vertex.TabIndex = 3;
            this.btn_vertex.Text = "Vertex";
            this.btn_vertex.UseVisualStyleBackColor = true;
            this.btn_vertex.Click += new System.EventHandler(this.btn_vertex_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // a_txtbox
            // 
            this.a_txtbox.Location = new System.Drawing.Point(164, 415);
            this.a_txtbox.Name = "a_txtbox";
            this.a_txtbox.Size = new System.Drawing.Size(100, 23);
            this.a_txtbox.TabIndex = 6;
            // 
            // c_txtbox
            // 
            this.c_txtbox.Location = new System.Drawing.Point(164, 464);
            this.c_txtbox.Name = "c_txtbox";
            this.c_txtbox.Size = new System.Drawing.Size(100, 23);
            this.c_txtbox.TabIndex = 7;
            // 
            // b_txtbox
            // 
            this.b_txtbox.Location = new System.Drawing.Point(164, 440);
            this.b_txtbox.Name = "b_txtbox";
            this.b_txtbox.Size = new System.Drawing.Size(100, 23);
            this.b_txtbox.TabIndex = 8;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(120, 418);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(16, 15);
            this.lbl_a.TabIndex = 9;
            this.lbl_a.Text = "a:";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(120, 443);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(17, 15);
            this.lbl_b.TabIndex = 10;
            this.lbl_b.Text = "b:";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(120, 467);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(16, 15);
            this.lbl_c.TabIndex = 11;
            this.lbl_c.Text = "c:";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(481, 443);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(45, 15);
            this.lbl_result.TabIndex = 12;
            this.lbl_result.Text = "Result: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 569);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.b_txtbox);
            this.Controls.Add(this.c_txtbox);
            this.Controls.Add(this.a_txtbox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_vertex);
            this.Controls.Add(this.btn_roots);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.drawing_board);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel drawing_board;
        private Button btn_draw;
        private Button btn_roots;
        private Button btn_vertex;
        private Button button4;
        private Button button5;
        private TextBox a_txtbox;
        private TextBox c_txtbox;
        private TextBox b_txtbox;
        private Label lbl_a;
        private Label lbl_b;
        private Label lbl_c;
        private Label lbl_result;
    }
}