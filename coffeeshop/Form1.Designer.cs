namespace coffeeshop
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
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_ju0p4pju0p4pju0p_removebg_preview;
            pictureBox1.Location = new Point(483, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 381);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Sienna;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(42, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(345, 119);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Name";
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Coffee";
            Column2.HeaderText = "Coffee";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Sugar Level";
            Column3.HeaderText = "Sugar Level";
            Column3.Name = "Column3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Caramel", "BLACK", "Pait Coffee" });
            comboBox1.Location = new Point(42, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Tag = "";
            comboBox1.Text = "Select Coffee";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "25%", "50%", "75%", "100%" });
            comboBox2.Location = new Point(41, 367);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(102, 23);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "Select Sugar Lvl";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 224);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Enter Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 287);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Select Coffee";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 349);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 7;
            label3.Text = "Select Sugar Lvl";
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.Location = new Point(41, 413);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Enter ";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += button1_MouseClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Sienna;
            button2.Location = new Point(43, 502);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += button2_MouseClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Sienna;
            button3.Location = new Point(149, 502);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.MouseClick += button3_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(937, 537);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button2;
        private Button button3;
    }
}
