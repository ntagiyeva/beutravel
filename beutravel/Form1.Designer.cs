using System;
using System.Drawing;
using System.Windows.Forms;

namespace beutravel
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
            panel1 = new Panel();
            label2 = new Label();
            button2 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            maskedTextBox4 = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(12, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 95);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 453);
            button2.Name = "button2";
            button2.Size = new Size(155, 29);
            button2.TabIndex = 3;
            button2.Text = "Siyahidan sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 86);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 15);
            label1.Name = "label1";
            label1.Size = new Size(199, 48);
            label1.TabIndex = 1;
            label1.Text = "BEU Travel";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 128, 255);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Travel Information";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(95, 179);
            maskedTextBox2.Mask = @"00\:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 3;

            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(95, 132);
            maskedTextBox1.Mask = @"00\/00\/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 2;

            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(128, 128, 255);
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(6, 183);
            label6.Name = "label6";
            label6.Size = new Size(50, 23);
            label6.TabIndex = 3;
            label6.Text = "Vaxt:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(128, 128, 255);
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(6, 136);
            label5.Name = "label5";
            label5.Size = new Size(54, 23);
            label5.TabIndex = 2;
            label5.Text = "Tarix:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(128, 128, 255);
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 1;
            label4.Text = "Haraya:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(128, 128, 255);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(6, 40);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 0;
            label3.Text = "Haradan:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 128, 255);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(447, 92);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 239);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person Information";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(127, 135);
            maskedTextBox4.Mask = @"(+\9\9\4) 00-000-00-00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(145, 27);
            maskedTextBox4.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(128, 128, 255);
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(6, 183);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 3;
            label7.Text = "Email:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(128, 128, 255);
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(6, 136);
            label8.Name = "label8";
            label8.Size = new Size(73, 23);
            label8.TabIndex = 2;
            label8.Text = "Telefon:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(128, 128, 255);
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(6, 88);
            label9.Name = "label9";
            label9.Size = new Size(42, 23);
            label9.TabIndex = 1;
            label9.Text = "FIN:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(128, 128, 255);
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(6, 40);
            label10.Name = "label10";
            label10.Size = new Size(115, 23);
            label10.TabIndex = 0;
            label10.Text = "Ad ve Soyad:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(95, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(95, 88);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 27);
            textBox3.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(682, 453);
            button3.Name = "button3";
            button3.Size = new Size(157, 29);
            button3.TabIndex = 5;
            button3.Text = "Proqramdan cixis";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Bilet siyahısı və mövcud hadisə metodları üçün düymələr.
            listBox1.Name = "listBox1";
            listBox1.Dock = DockStyle.Fill;
            listBox1.IntegralHeight = false;
            listBox1.HorizontalScrollbar = true;
            listBox1.TabIndex = 0;
            button1.Name = "button1";
            button1.Text = "Bilet əlavə et";
            button1.Location = new Point(185, 453);
            button1.Size = new Size(155, 29);
            button1.TabIndex = 2;
            button1.Click += button1_Click;
            button4.Name = "button4";
            button4.Text = "İstiqaməti dəyiş";
            button4.Location = new Point(358, 453);
            button4.Size = new Size(170, 29);
            button4.TabIndex = 4;
            button4.Click += button4_Click;
            Controls.Add(button1);
            Controls.Add(button4);
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(851, 496);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information center";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private Button button2;
        private Panel panel2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
        private Button button1;
        private Button button4;
        private ListBox listBox1;
    }
}

namespace beutravel
{
    public partial class Form1
    {
        private void label6_Click(object sender, EventArgs e)
        {
            // handle click or leave empty
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // handle click or leave empty
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // handle click or leave empty
        }
    }
}
