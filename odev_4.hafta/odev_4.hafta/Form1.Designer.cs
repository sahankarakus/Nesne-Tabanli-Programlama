﻿namespace odev_4.hafta
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
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(148, 160);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(45, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 237);
            panel1.TabIndex = 1;
            panel1.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 95);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 5;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 62);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumAquamarine;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(listBox1);
            panel2.Location = new Point(369, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 484);
            panel2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(18, 326);
            button2.Name = "button2";
            button2.Size = new Size(106, 55);
            button2.TabIndex = 6;
            button2.Text = "Kullanıcıları Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(18, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(379, 284);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 571);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private ListBox listBox1;
        private Button button2;
    }
}