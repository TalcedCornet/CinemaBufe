namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            txtBilet = new TextBox();
            label4 = new Label();
            txtCay = new TextBox();
            txtSu = new TextBox();
            txtMisir = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            lblKasa = new Label();
            label10 = new Label();
            lblToplam = new Label();
            button1 = new Button();
            label9 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(txtBilet);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCay);
            groupBox1.Controls.Add(txtSu);
            groupBox1.Controls.Add(txtMisir);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün";
            // 
            // txtBilet
            // 
            txtBilet.Location = new Point(72, 134);
            txtBilet.Name = "txtBilet";
            txtBilet.Size = new Size(100, 23);
            txtBilet.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 137);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "Bilet";
            // 
            // txtCay
            // 
            txtCay.Location = new Point(72, 105);
            txtCay.Name = "txtCay";
            txtCay.Size = new Size(100, 23);
            txtCay.TabIndex = 5;
            // 
            // txtSu
            // 
            txtSu.Location = new Point(72, 75);
            txtSu.Name = "txtSu";
            txtSu.Size = new Size(100, 23);
            txtSu.TabIndex = 4;
            // 
            // txtMisir
            // 
            txtMisir.Location = new Point(72, 46);
            txtMisir.Name = "txtMisir";
            txtMisir.Size = new Size(100, 23);
            txtMisir.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 108);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "Çay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 79);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 1;
            label2.Text = "Su";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Mısır : ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 255, 192);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(309, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(214, 207);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyat Tablosu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 96);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 11;
            label8.Text = "Bilet = 8 TL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 75);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 10;
            label7.Text = "Çay= 2 TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 54);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 9;
            label6.Text = "Su = 1 TL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 32);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 8;
            label5.Text = "Mısır = 4 TL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 192, 255);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(lblKasa);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(lblToplam);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(618, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(214, 207);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // lblKasa
            // 
            lblKasa.AutoSize = true;
            lblKasa.Location = new Point(126, 178);
            lblKasa.Name = "lblKasa";
            lblKasa.Size = new Size(37, 15);
            lblKasa.TabIndex = 4;
            lblKasa.Text = "00 TL ";
            lblKasa.Click += lblKasa_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(80, 178);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 3;
            label10.Text = "Kasa : ";
            label10.Click += label10_Click;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(122, 83);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(34, 15);
            lblToplam.TabIndex = 2;
            lblToplam.Text = "00 TL";
            // 
            // button1
            // 
            button1.Location = new Point(52, 105);
            button1.Name = "button1";
            button1.Size = new Size(125, 33);
            button1.TabIndex = 1;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(65, 83);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 0;
            label9.Text = "Toplam : ";
            // 
            // button2
            // 
            button2.Location = new Point(52, 142);
            button2.Name = "button2";
            button2.Size = new Size(125, 33);
            button2.TabIndex = 5;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 332);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBilet;
        private Label label4;
        private TextBox txtCay;
        private TextBox txtSu;
        private TextBox txtMisir;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private Button button1;
        private Label label9;
        private Label lblKasa;
        private Label label10;
        private Label lblToplam;
        private Button button2;
    }
}