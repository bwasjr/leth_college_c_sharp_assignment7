namespace Assignment6
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
            label5 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            listBox1 = new ListBox();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            closeFileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(123, 276);
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
            label1.Location = new Point(5, 116);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Player Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 174);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 2;
            label2.Text = "Jersey Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 231);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Goals Scored";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(123, 224);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(281, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 66);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 7;
            label4.Text = "Current Players";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(123, 66);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 27);
            textBox4.TabIndex = 8;
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
            button2.Location = new Point(280, 361);
            button2.Name = "button2";
            button2.Size = new Size(124, 29);
            button2.TabIndex = 11;
            button2.Text = "View player list";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alphabetically", "Jersey Number", "Goals Scored" });
            comboBox1.Location = new Point(123, 362);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 339);
            label6.Name = "label6";
            label6.Size = new Size(109, 20);
            label6.TabIndex = 13;
            label6.Text = "Sorting Criteria";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(123, 405);
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
            radioButton2.Location = new Point(123, 435);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 24);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "Descending";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(471, 110);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(510, 463);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // button3
            // 
            button3.Location = new Point(280, 276);
            button3.Name = "button3";
            button3.Size = new Size(124, 29);
            button3.TabIndex = 17;
            button3.Text = "Update Player";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadFileToolStripMenuItem, saveFileToolStripMenuItem, closeFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(993, 25);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(103, 21);
            loadFileToolStripMenuItem.Text = "Load File";
            loadFileToolStripMenuItem.Click += loadFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(103, 21);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // closeFileToolStripMenuItem
            // 
            closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            closeFileToolStripMenuItem.Size = new Size(67, 21);
            closeFileToolStripMenuItem.Text = "Close";
            closeFileToolStripMenuItem.Click += closeFileToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 586);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label label5;
        private Button button2;
        private ComboBox comboBox1;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox listBox1;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem closeFileToolStripMenuItem;
    }
}