﻿namespace Assignment6
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(123, 229);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(92, 31);
            button1.TabIndex = 0;
            button1.Text = "Add Player";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 69);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Player Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 127);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Jersey Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 184);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Goals Scored";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 1);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 7;
            label4.Text = "Current Players";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(123, 1);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 27);
            textBox4.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(471, 98);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(472, 464);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 69);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 10;
            label5.Text = "Team's player list";
            // 
            // button2
            // 
            button2.Location = new Point(280, 355);
            button2.Name = "button2";
            button2.Size = new Size(124, 29);
            button2.TabIndex = 11;
            button2.Text = "View player list";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alphabetically", "Jersey Number", "Goals Scored" });
            comboBox1.Location = new Point(123, 356);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 333);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 13;
            label6.Text = "Sorting Criteria";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(123, 399);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(99, 24);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ascending";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(123, 429);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 24);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "Descending";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 586);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private RichTextBox richTextBox1;
        private Label label5;
        private Button button2;
        private ComboBox comboBox1;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}