namespace ITI.presentation
{
    partial class InstructorForm
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
            btn_delete = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            cb_department = new ComboBox();
            nud_salary = new NumericUpDown();
            cb_degree = new ComboBox();
            txt_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_instructors = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nud_salary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).BeginInit();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(480, 156);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 25;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(350, 156);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 24;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(202, 156);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 22;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cb_department
            // 
            cb_department.FormattingEnabled = true;
            cb_department.Location = new Point(521, 86);
            cb_department.Name = "cb_department";
            cb_department.Size = new Size(172, 23);
            cb_department.TabIndex = 21;
            // 
            // nud_salary
            // 
            nud_salary.DecimalPlaces = 2;
            nud_salary.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nud_salary.Location = new Point(521, 29);
            nud_salary.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nud_salary.Name = "nud_salary";
            nud_salary.Size = new Size(172, 23);
            nud_salary.TabIndex = 20;
            // 
            // cb_degree
            // 
            cb_degree.FormattingEnabled = true;
            cb_degree.Items.AddRange(new object[] { "Master", "PHD" });
            cb_degree.Location = new Point(164, 86);
            cb_degree.Name = "cb_degree";
            cb_degree.Size = new Size(177, 23);
            cb_degree.TabIndex = 19;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(164, 28);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(177, 23);
            txt_name.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 86);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 17;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 33);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 16;
            label3.Text = "Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 86);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 15;
            label2.Text = "Degree";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 31);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // dgv_instructors
            // 
            dgv_instructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_instructors.Location = new Point(12, 215);
            dgv_instructors.Name = "dgv_instructors";
            dgv_instructors.RowTemplate.Height = 25;
            dgv_instructors.Size = new Size(776, 208);
            dgv_instructors.TabIndex = 13;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
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
            Name = "InstructorForm";
            Text = "Form1";
            Load += InstructorForm_Load;
            ((System.ComponentModel.ISupportInitialize)nud_salary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_instructors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_delete;
        private Button btn_edit;
        private Button btn_add;
        private ComboBox cb_department;
        private NumericUpDown nud_salary;
        private ComboBox cb_degree;
        private TextBox txt_name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_instructors;
    }
}