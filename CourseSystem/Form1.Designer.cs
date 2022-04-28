namespace CourseSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button Exit_bt;
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.ProgramName_lb = new System.Windows.Forms.Label();
            this.Name_tb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Name_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DOB_lb = new System.Windows.Forms.Label();
            this.Add_bt = new System.Windows.Forms.Button();
            this.Edit_bt = new System.Windows.Forms.Button();
            this.Remove_bt = new System.Windows.Forms.Button();
            this.Search_tb = new System.Windows.Forms.TextBox();
            this.Search_lb = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            Exit_bt = new System.Windows.Forms.Button();
            this.MovingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovingPanel
            // 
            this.MovingPanel.Controls.Add(this.ProgramName_lb);
            resources.ApplyResources(this.MovingPanel, "MovingPanel");
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovingPanel_MouseDown);
            // 
            // ProgramName_lb
            // 
            resources.ApplyResources(this.ProgramName_lb, "ProgramName_lb");
            this.ProgramName_lb.Name = "ProgramName_lb";
            this.ProgramName_lb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgramName_lb_MouseDown);
            // 
            // Name_tb
            // 
            resources.ApplyResources(this.Name_tb, "Name_tb");
            this.Name_tb.Name = "Name_tb";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.PhoneColumn,
            this.LevelColumn,
            this.GroupColumn,
            this.JoinedColumn});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // NameColumn
            // 
            resources.ApplyResources(this.NameColumn, "NameColumn");
            this.NameColumn.Name = "NameColumn";
            // 
            // PhoneColumn
            // 
            resources.ApplyResources(this.PhoneColumn, "PhoneColumn");
            this.PhoneColumn.Name = "PhoneColumn";
            // 
            // LevelColumn
            // 
            resources.ApplyResources(this.LevelColumn, "LevelColumn");
            this.LevelColumn.Name = "LevelColumn";
            // 
            // GroupColumn
            // 
            resources.ApplyResources(this.GroupColumn, "GroupColumn");
            this.GroupColumn.Name = "GroupColumn";
            // 
            // JoinedColumn
            // 
            resources.ApplyResources(this.JoinedColumn, "JoinedColumn");
            this.JoinedColumn.Name = "JoinedColumn";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // Name_lb
            // 
            resources.ApplyResources(this.Name_lb, "Name_lb");
            this.Name_lb.Name = "Name_lb";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // DOB_lb
            // 
            resources.ApplyResources(this.DOB_lb, "DOB_lb");
            this.DOB_lb.Name = "DOB_lb";
            // 
            // Add_bt
            // 
            resources.ApplyResources(this.Add_bt, "Add_bt");
            this.Add_bt.Name = "Add_bt";
            this.Add_bt.UseVisualStyleBackColor = true;
            // 
            // Edit_bt
            // 
            resources.ApplyResources(this.Edit_bt, "Edit_bt");
            this.Edit_bt.Name = "Edit_bt";
            this.Edit_bt.UseVisualStyleBackColor = true;
            // 
            // Remove_bt
            // 
            resources.ApplyResources(this.Remove_bt, "Remove_bt");
            this.Remove_bt.Name = "Remove_bt";
            this.Remove_bt.UseVisualStyleBackColor = true;
            // 
            // Search_tb
            // 
            resources.ApplyResources(this.Search_tb, "Search_tb");
            this.Search_tb.Name = "Search_tb";
            // 
            // Search_lb
            // 
            resources.ApplyResources(this.Search_lb, "Search_lb");
            this.Search_lb.Name = "Search_lb";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // Exit_bt
            // 
            Exit_bt.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(Exit_bt, "Exit_bt");
            Exit_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Exit_bt.Name = "Exit_bt";
            Exit_bt.UseVisualStyleBackColor = true;
            Exit_bt.Click += new System.EventHandler(this.Exit_bt_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(Exit_bt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Search_lb);
            this.Controls.Add(this.Search_tb);
            this.Controls.Add(this.Remove_bt);
            this.Controls.Add(this.Edit_bt);
            this.Controls.Add(this.Add_bt);
            this.Controls.Add(this.DOB_lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name_lb);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Name_tb);
            this.Controls.Add(this.MovingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.MovingPanel.ResumeLayout(false);
            this.MovingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MovingPanel;
        private System.Windows.Forms.TextBox Name_tb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Name_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DOB_lb;
        private System.Windows.Forms.Button Add_bt;
        private System.Windows.Forms.Button Edit_bt;
        private System.Windows.Forms.Button Remove_bt;
        private System.Windows.Forms.TextBox Search_tb;
        private System.Windows.Forms.Label Search_lb;
        private System.Windows.Forms.Label ProgramName_lb;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinedColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}

