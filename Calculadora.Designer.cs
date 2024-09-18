namespace CalculadoraForms
{
    partial class Calculadora
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_clear = new Button();
            btn_par1 = new Button();
            btn_div = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn_multi = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn_minus = new Button();
            btn0 = new Button();
            btn_eq = new Button();
            btn5 = new Button();
            btn_plus = new Button();
            btn_par2 = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn_clear, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_par1, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_div, 3, 0);
            tableLayoutPanel1.Controls.Add(btn7, 0, 1);
            tableLayoutPanel1.Controls.Add(btn8, 1, 1);
            tableLayoutPanel1.Controls.Add(btn9, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_multi, 3, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 2);
            tableLayoutPanel1.Controls.Add(btn6, 2, 2);
            tableLayoutPanel1.Controls.Add(btn1, 0, 3);
            tableLayoutPanel1.Controls.Add(btn2, 1, 3);
            tableLayoutPanel1.Controls.Add(btn3, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_minus, 3, 2);
            tableLayoutPanel1.Controls.Add(btn0, 1, 4);
            tableLayoutPanel1.Controls.Add(btn_eq, 3, 4);
            tableLayoutPanel1.Controls.Add(btn5, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_plus, 3, 3);
            tableLayoutPanel1.Controls.Add(btn_par2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(0, 75);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(333, 302);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = SystemColors.ControlLightLight;
            btn_clear.Location = new Point(3, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 56);
            btn_clear.TabIndex = 0;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_par1
            // 
            btn_par1.Location = new Point(86, 3);
            btn_par1.Name = "btn_par1";
            btn_par1.Size = new Size(75, 56);
            btn_par1.TabIndex = 1;
            btn_par1.Text = "(";
            btn_par1.UseVisualStyleBackColor = true;
            btn_par1.Click += btn_par1_Click;
            // 
            // btn_div
            // 
            btn_div.Location = new Point(252, 3);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(75, 56);
            btn_div.TabIndex = 3;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(3, 65);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 56);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(86, 65);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 56);
            btn8.TabIndex = 5;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(169, 65);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 56);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn_multi
            // 
            btn_multi.Location = new Point(252, 65);
            btn_multi.Name = "btn_multi";
            btn_multi.Size = new Size(75, 56);
            btn_multi.TabIndex = 7;
            btn_multi.Text = "x";
            btn_multi.UseVisualStyleBackColor = true;
            btn_multi.Click += btn_multi_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(3, 127);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 56);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(169, 127);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 56);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(3, 189);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 56);
            btn1.TabIndex = 12;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(86, 189);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 56);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(169, 189);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 56);
            btn3.TabIndex = 14;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn_minus
            // 
            btn_minus.Location = new Point(252, 127);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(75, 56);
            btn_minus.TabIndex = 11;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(86, 251);
            btn0.Name = "btn0";
            btn0.Size = new Size(75, 48);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += this.btn0_Click;
            // 
            // btn_eq
            // 
            btn_eq.Location = new Point(252, 251);
            btn_eq.Name = "btn_eq";
            btn_eq.Size = new Size(75, 48);
            btn_eq.TabIndex = 19;
            btn_eq.Text = "=";
            btn_eq.UseVisualStyleBackColor = true;
            btn_eq.Click += btn_eq_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(86, 127);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 56);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn_plus
            // 
            btn_plus.Location = new Point(252, 189);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(75, 56);
            btn_plus.TabIndex = 15;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_par2
            // 
            btn_par2.Location = new Point(169, 3);
            btn_par2.Name = "btn_par2";
            btn_par2.Size = new Size(75, 56);
            btn_par2.TabIndex = 20;
            btn_par2.Text = ")";
            btn_par2.UseVisualStyleBackColor = true;
            btn_par2.Click += btn_par2_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLightLight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 63);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(333, 377);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "Calculadora";
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_clear;
        private Button btn_par1;
        private Button btn_div;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn_multi;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn_plus;
        private Button btn_minus;
        private Button btn0;
        private Button btn_eq;
        private Label label1;
        private Button btn_par2;
    }
}
