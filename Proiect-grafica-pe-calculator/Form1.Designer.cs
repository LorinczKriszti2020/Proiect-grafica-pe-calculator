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
            this.btn_draw_rectangle = new System.Windows.Forms.Button();
            this.btn_troubleshoot = new System.Windows.Forms.Button();
            this.a_txtbox = new System.Windows.Forms.TextBox();
            this.c_txtbox = new System.Windows.Forms.TextBox();
            this.b_txtbox = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.txtbox_colt1x = new System.Windows.Forms.TextBox();
            this.txtbox_colt1y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_colt2x = new System.Windows.Forms.TextBox();
            this.txtbox_colt2y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_inter = new System.Windows.Forms.Button();
            this.listbox_result = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawing_board
            // 
            this.drawing_board.BackColor = System.Drawing.Color.White;
            this.drawing_board.Location = new System.Drawing.Point(120, 12);
            this.drawing_board.Name = "drawing_board";
            this.drawing_board.Size = new System.Drawing.Size(930, 518);
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
            this.btn_roots.Location = new System.Drawing.Point(28, 128);
            this.btn_roots.Name = "btn_roots";
            this.btn_roots.Size = new System.Drawing.Size(75, 23);
            this.btn_roots.TabIndex = 2;
            this.btn_roots.Text = "Radacini";
            this.btn_roots.UseVisualStyleBackColor = true;
            this.btn_roots.Click += new System.EventHandler(this.btn_roots_Click);
            // 
            // btn_vertex
            // 
            this.btn_vertex.Location = new System.Drawing.Point(28, 99);
            this.btn_vertex.Name = "btn_vertex";
            this.btn_vertex.Size = new System.Drawing.Size(75, 23);
            this.btn_vertex.TabIndex = 3;
            this.btn_vertex.Text = "Varf";
            this.btn_vertex.UseVisualStyleBackColor = true;
            this.btn_vertex.Click += new System.EventHandler(this.btn_vertex_Click);
            // 
            // btn_draw_rectangle
            // 
            this.btn_draw_rectangle.Location = new System.Drawing.Point(28, 41);
            this.btn_draw_rectangle.Name = "btn_draw_rectangle";
            this.btn_draw_rectangle.Size = new System.Drawing.Size(75, 23);
            this.btn_draw_rectangle.TabIndex = 4;
            this.btn_draw_rectangle.Text = "Draw R";
            this.btn_draw_rectangle.UseVisualStyleBackColor = true;
            this.btn_draw_rectangle.Click += new System.EventHandler(this.btn_draw_rectangle_Click);
            // 
            // btn_troubleshoot
            // 
            this.btn_troubleshoot.Location = new System.Drawing.Point(28, 613);
            this.btn_troubleshoot.Name = "btn_troubleshoot";
            this.btn_troubleshoot.Size = new System.Drawing.Size(75, 23);
            this.btn_troubleshoot.TabIndex = 5;
            this.btn_troubleshoot.Text = "Trblshoot";
            this.btn_troubleshoot.UseVisualStyleBackColor = true;
            this.btn_troubleshoot.Visible = false;
            this.btn_troubleshoot.Click += new System.EventHandler(this.btn_troubleshoot_Click);
            // 
            // a_txtbox
            // 
            this.a_txtbox.Location = new System.Drawing.Point(140, 539);
            this.a_txtbox.Name = "a_txtbox";
            this.a_txtbox.Size = new System.Drawing.Size(100, 23);
            this.a_txtbox.TabIndex = 6;
            // 
            // c_txtbox
            // 
            this.c_txtbox.Location = new System.Drawing.Point(140, 588);
            this.c_txtbox.Name = "c_txtbox";
            this.c_txtbox.Size = new System.Drawing.Size(100, 23);
            this.c_txtbox.TabIndex = 7;
            // 
            // b_txtbox
            // 
            this.b_txtbox.Location = new System.Drawing.Point(140, 564);
            this.b_txtbox.Name = "b_txtbox";
            this.b_txtbox.Size = new System.Drawing.Size(100, 23);
            this.b_txtbox.TabIndex = 8;
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(118, 542);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(16, 15);
            this.lbl_a.TabIndex = 9;
            this.lbl_a.Text = "a:";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(118, 567);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(17, 15);
            this.lbl_b.TabIndex = 10;
            this.lbl_b.Text = "b:";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Location = new System.Drawing.Point(118, 591);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(16, 15);
            this.lbl_c.TabIndex = 11;
            this.lbl_c.Text = "c:";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(566, 547);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(45, 15);
            this.lbl_result.TabIndex = 12;
            this.lbl_result.Text = "Result: ";
            // 
            // txtbox_colt1x
            // 
            this.txtbox_colt1x.Location = new System.Drawing.Point(300, 539);
            this.txtbox_colt1x.Name = "txtbox_colt1x";
            this.txtbox_colt1x.Size = new System.Drawing.Size(100, 23);
            this.txtbox_colt1x.TabIndex = 13;
            // 
            // txtbox_colt1y
            // 
            this.txtbox_colt1y.Location = new System.Drawing.Point(300, 564);
            this.txtbox_colt1y.Name = "txtbox_colt1y";
            this.txtbox_colt1y.Size = new System.Drawing.Size(100, 23);
            this.txtbox_colt1y.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "y colt 1:";
            // 
            // txtbox_colt2x
            // 
            this.txtbox_colt2x.Location = new System.Drawing.Point(460, 539);
            this.txtbox_colt2x.Name = "txtbox_colt2x";
            this.txtbox_colt2x.Size = new System.Drawing.Size(100, 23);
            this.txtbox_colt2x.TabIndex = 17;
            // 
            // txtbox_colt2y
            // 
            this.txtbox_colt2y.Location = new System.Drawing.Point(460, 564);
            this.txtbox_colt2y.Name = "txtbox_colt2y";
            this.txtbox_colt2y.Size = new System.Drawing.Size(100, 23);
            this.txtbox_colt2y.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "x colt 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "y colt 2:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(28, 157);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 21;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_inter
            // 
            this.btn_inter.Location = new System.Drawing.Point(28, 70);
            this.btn_inter.Name = "btn_inter";
            this.btn_inter.Size = new System.Drawing.Size(75, 23);
            this.btn_inter.TabIndex = 22;
            this.btn_inter.Text = "Intersectia";
            this.btn_inter.UseVisualStyleBackColor = true;
            this.btn_inter.Click += new System.EventHandler(this.btn_inter_Click);
            // 
            // listbox_result
            // 
            this.listbox_result.FormattingEnabled = true;
            this.listbox_result.ItemHeight = 15;
            this.listbox_result.Location = new System.Drawing.Point(887, 542);
            this.listbox_result.Name = "listbox_result";
            this.listbox_result.Size = new System.Drawing.Size(163, 94);
            this.listbox_result.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "x colt 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 655);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listbox_result);
            this.Controls.Add(this.btn_inter);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_colt2y);
            this.Controls.Add(this.txtbox_colt2x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_colt1y);
            this.Controls.Add(this.txtbox_colt1x);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.b_txtbox);
            this.Controls.Add(this.c_txtbox);
            this.Controls.Add(this.a_txtbox);
            this.Controls.Add(this.btn_troubleshoot);
            this.Controls.Add(this.btn_draw_rectangle);
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
        private Button btn_draw_rectangle;
        private Button btn_troubleshoot;
        private TextBox a_txtbox;
        private TextBox c_txtbox;
        private TextBox b_txtbox;
        private Label lbl_a;
        private Label lbl_b;
        private Label lbl_c;
        private Label lbl_result;
        private TextBox txtbox_colt1x;
        private TextBox txtbox_colt1y;
        private Label label2;
        private TextBox txtbox_colt2x;
        private TextBox txtbox_colt2y;
        private Label label3;
        private Label label4;
        private Button btn_clear;
        private Button btn_inter;
        private ListBox listbox_result;
        private Label label5;
    }
}