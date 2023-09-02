namespace Disconnected
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
            dgv_instructors = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_name = new TextBox();
            cb_degree = new ComboBox();
            nud_salary = new NumericUpDown();
            cb_department = new ComboBox();
            btn_add = new Button();
            btn_save = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_salary).BeginInit();
            SuspendLayout();
            // 
            // dgv_instructors
            // 
            dgv_instructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_instructors.Location = new Point(12, 230);
            dgv_instructors.Name = "dgv_instructors";
            dgv_instructors.RowTemplate.Height = 25;
            dgv_instructors.Size = new Size(776, 208);
            dgv_instructors.TabIndex = 0;
            dgv_instructors.RowHeaderMouseDoubleClick += dgv_instructors_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 46);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 101);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Degree";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 48);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 101);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "Department";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(164, 43);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(177, 23);
            txt_name.TabIndex = 5;
            // 
            // cb_degree
            // 
            cb_degree.FormattingEnabled = true;
            cb_degree.Items.AddRange(new object[] { "Master", "PHD" });
            cb_degree.Location = new Point(164, 101);
            cb_degree.Name = "cb_degree";
            cb_degree.Size = new Size(177, 23);
            cb_degree.TabIndex = 6;
            // 
            // nud_salary
            // 
            nud_salary.DecimalPlaces = 2;
            nud_salary.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_salary.Location = new Point(521, 44);
            nud_salary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_salary.Name = "nud_salary";
            nud_salary.Size = new Size(172, 23);
            nud_salary.TabIndex = 7;
            // 
            // cb_department
            // 
            cb_department.FormattingEnabled = true;
            cb_department.Location = new Point(521, 101);
            cb_department.Name = "cb_department";
            cb_department.Size = new Size(172, 23);
            cb_department.TabIndex = 8;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(202, 171);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 9;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(642, 171);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(113, 23);
            btn_save.TabIndex = 10;
            btn_save.Text = "Save changes";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(350, 171);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 11;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(480, 171);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 12;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_save);
            Controls.Add(btn_add);
            Controls.Add(cb_department);
            Controls.Add(nud_salary);
            Controls.Add(cb_degree);
            Controls.Add(txt_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_instructors);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_salary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_instructors;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_name;
        private ComboBox cb_degree;
        private NumericUpDown nud_salary;
        private ComboBox cb_department;
        private Button btn_add;
        private Button btn_save;
        private Button btn_edit;
        private Button btn_delete;
    }
}