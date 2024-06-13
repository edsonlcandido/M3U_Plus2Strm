namespace M3U_Plus2Strm
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
            propertyGrid1 = new PropertyGrid();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            loadm3uToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Left;
            propertyGrid1.Location = new Point(3, 3);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(522, 533);
            propertyGrid1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 567);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(propertyGrid1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 539);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Config";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 539);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Movies";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 74);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(8, 6);
            button1.Name = "button1";
            button1.Size = new Size(91, 35);
            button1.TabIndex = 1;
            button1.Text = "Create strm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(3, 92);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(786, 444);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 539);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Series";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(786, 452);
            dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadm3uToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadm3uToolStripMenuItem
            // 
            loadm3uToolStripMenuItem.Name = "loadm3uToolStripMenuItem";
            loadm3uToolStripMenuItem.Size = new Size(75, 20);
            loadm3uToolStripMenuItem.Text = "Load .m3u";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(562, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(680, 23);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 591);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Create .strm from M3U";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PropertyGrid propertyGrid1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadm3uToolStripMenuItem;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox1;
    }
}