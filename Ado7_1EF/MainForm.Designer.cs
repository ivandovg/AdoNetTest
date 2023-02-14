namespace Ado7_1EF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.colDepId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherBirthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherDepartment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edDepartmentName = new System.Windows.Forms.TextBox();
            this.edDepartmentPhone = new System.Windows.Forms.TextBox();
            this.btnDepartmentAdd = new System.Windows.Forms.Button();
            this.btnDepartmentDelete = new System.Windows.Forms.Button();
            this.btnDepartmentSave = new System.Windows.Forms.Button();
            this.btnDepartmentUpdate = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.btnGetAllPeoples = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTeachersAdd = new System.Windows.Forms.Button();
            this.edTeacherLastname = new System.Windows.Forms.TextBox();
            this.edTeacherFirstname = new System.Windows.Forms.TextBox();
            this.edTeacherBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cmbTeacherDepartment = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDepartmentUpdate);
            this.tabPage1.Controls.Add(this.btnDepartmentSave);
            this.tabPage1.Controls.Add(this.btnDepartmentDelete);
            this.tabPage1.Controls.Add(this.btnDepartmentAdd);
            this.tabPage1.Controls.Add(this.edDepartmentPhone);
            this.tabPage1.Controls.Add(this.edDepartmentName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvDepartments);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Departments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbTeacherDepartment);
            this.tabPage2.Controls.Add(this.edTeacherBirthdate);
            this.tabPage2.Controls.Add(this.btnTeachersAdd);
            this.tabPage2.Controls.Add(this.edTeacherLastname);
            this.tabPage2.Controls.Add(this.edTeacherFirstname);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgvTeachers);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teachers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDepId,
            this.colDepDepartment,
            this.colDepPhone});
            this.dgvDepartments.Location = new System.Drawing.Point(8, 6);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.Size = new System.Drawing.Size(497, 344);
            this.dgvDepartments.TabIndex = 0;
            this.dgvDepartments.SelectionChanged += new System.EventHandler(this.dgvDepartments_SelectionChanged);
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTeacherId,
            this.colTeacherFirstname,
            this.colTeacherLastname,
            this.colTeacherBirthdate,
            this.colTeacherDepartment});
            this.dgvTeachers.Location = new System.Drawing.Point(8, 6);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(497, 344);
            this.dgvTeachers.TabIndex = 1;
            // 
            // colDepId
            // 
            this.colDepId.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDepId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDepId.HeaderText = "Id";
            this.colDepId.Name = "colDepId";
            this.colDepId.ReadOnly = true;
            this.colDepId.Width = 60;
            // 
            // colDepDepartment
            // 
            this.colDepDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepDepartment.DataPropertyName = "Department1";
            this.colDepDepartment.HeaderText = "Department name";
            this.colDepDepartment.Name = "colDepDepartment";
            // 
            // colDepPhone
            // 
            this.colDepPhone.DataPropertyName = "Phone";
            this.colDepPhone.HeaderText = "Phone";
            this.colDepPhone.Name = "colDepPhone";
            // 
            // colTeacherId
            // 
            this.colTeacherId.DataPropertyName = "Id";
            this.colTeacherId.HeaderText = "Id";
            this.colTeacherId.Name = "colTeacherId";
            this.colTeacherId.ReadOnly = true;
            this.colTeacherId.Width = 50;
            // 
            // colTeacherFirstname
            // 
            this.colTeacherFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeacherFirstname.DataPropertyName = "Firstname";
            this.colTeacherFirstname.HeaderText = "Firstname";
            this.colTeacherFirstname.Name = "colTeacherFirstname";
            // 
            // colTeacherLastname
            // 
            this.colTeacherLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeacherLastname.DataPropertyName = "Lastname";
            this.colTeacherLastname.HeaderText = "Lastname";
            this.colTeacherLastname.Name = "colTeacherLastname";
            // 
            // colTeacherBirthdate
            // 
            this.colTeacherBirthdate.DataPropertyName = "Birthdate";
            this.colTeacherBirthdate.HeaderText = "Birthdate";
            this.colTeacherBirthdate.Name = "colTeacherBirthdate";
            // 
            // colTeacherDepartment
            // 
            this.colTeacherDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTeacherDepartment.HeaderText = "Department";
            this.colTeacherDepartment.Name = "colTeacherDepartment";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone";
            // 
            // edDepartmentName
            // 
            this.edDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edDepartmentName.Location = new System.Drawing.Point(56, 367);
            this.edDepartmentName.Name = "edDepartmentName";
            this.edDepartmentName.Size = new System.Drawing.Size(182, 20);
            this.edDepartmentName.TabIndex = 3;
            // 
            // edDepartmentPhone
            // 
            this.edDepartmentPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edDepartmentPhone.Location = new System.Drawing.Point(56, 393);
            this.edDepartmentPhone.Name = "edDepartmentPhone";
            this.edDepartmentPhone.Size = new System.Drawing.Size(182, 20);
            this.edDepartmentPhone.TabIndex = 4;
            // 
            // btnDepartmentAdd
            // 
            this.btnDepartmentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDepartmentAdd.Location = new System.Drawing.Point(244, 365);
            this.btnDepartmentAdd.Name = "btnDepartmentAdd";
            this.btnDepartmentAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentAdd.TabIndex = 5;
            this.btnDepartmentAdd.Text = "Add";
            this.btnDepartmentAdd.UseVisualStyleBackColor = true;
            this.btnDepartmentAdd.Click += new System.EventHandler(this.btnDepartmentAdd_Click);
            // 
            // btnDepartmentDelete
            // 
            this.btnDepartmentDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDepartmentDelete.Location = new System.Drawing.Point(244, 391);
            this.btnDepartmentDelete.Name = "btnDepartmentDelete";
            this.btnDepartmentDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentDelete.TabIndex = 6;
            this.btnDepartmentDelete.Text = "Delete";
            this.btnDepartmentDelete.UseVisualStyleBackColor = true;
            this.btnDepartmentDelete.Click += new System.EventHandler(this.btnDepartmentDelete_Click);
            // 
            // btnDepartmentSave
            // 
            this.btnDepartmentSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDepartmentSave.Location = new System.Drawing.Point(325, 365);
            this.btnDepartmentSave.Name = "btnDepartmentSave";
            this.btnDepartmentSave.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentSave.TabIndex = 7;
            this.btnDepartmentSave.Text = "Save";
            this.btnDepartmentSave.UseVisualStyleBackColor = true;
            this.btnDepartmentSave.Click += new System.EventHandler(this.btnDepartmentSave_Click);
            // 
            // btnDepartmentUpdate
            // 
            this.btnDepartmentUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDepartmentUpdate.Location = new System.Drawing.Point(325, 391);
            this.btnDepartmentUpdate.Name = "btnDepartmentUpdate";
            this.btnDepartmentUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentUpdate.TabIndex = 8;
            this.btnDepartmentUpdate.Text = "Update";
            this.btnDepartmentUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentUpdate.Click += new System.EventHandler(this.btnDepartmentUpdate_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGetAllPeoples);
            this.tabPage3.Controls.Add(this.dgvTest);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(513, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Test";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToAddRows = false;
            this.dgvTest.AllowUserToDeleteRows = false;
            this.dgvTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Location = new System.Drawing.Point(8, 6);
            this.dgvTest.MultiSelect = false;
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.ReadOnly = true;
            this.dgvTest.Size = new System.Drawing.Size(497, 358);
            this.dgvTest.TabIndex = 0;
            // 
            // btnGetAllPeoples
            // 
            this.btnGetAllPeoples.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetAllPeoples.Location = new System.Drawing.Point(8, 393);
            this.btnGetAllPeoples.Name = "btnGetAllPeoples";
            this.btnGetAllPeoples.Size = new System.Drawing.Size(107, 23);
            this.btnGetAllPeoples.TabIndex = 1;
            this.btnGetAllPeoples.Text = "GetAllPeoples";
            this.btnGetAllPeoples.UseVisualStyleBackColor = true;
            this.btnGetAllPeoples.Click += new System.EventHandler(this.btnGetAllPeoples_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firstname";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lastename";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Birthdate";
            // 
            // btnTeachersAdd
            // 
            this.btnTeachersAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTeachersAdd.Location = new System.Drawing.Point(430, 362);
            this.btnTeachersAdd.Name = "btnTeachersAdd";
            this.btnTeachersAdd.Size = new System.Drawing.Size(75, 23);
            this.btnTeachersAdd.TabIndex = 8;
            this.btnTeachersAdd.Text = "Add";
            this.btnTeachersAdd.UseVisualStyleBackColor = true;
            this.btnTeachersAdd.Click += new System.EventHandler(this.btnTeachersAdd_Click);
            // 
            // edTeacherLastname
            // 
            this.edTeacherLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edTeacherLastname.Location = new System.Drawing.Point(73, 390);
            this.edTeacherLastname.Name = "edTeacherLastname";
            this.edTeacherLastname.Size = new System.Drawing.Size(158, 20);
            this.edTeacherLastname.TabIndex = 7;
            // 
            // edTeacherFirstname
            // 
            this.edTeacherFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edTeacherFirstname.Location = new System.Drawing.Point(73, 364);
            this.edTeacherFirstname.Name = "edTeacherFirstname";
            this.edTeacherFirstname.Size = new System.Drawing.Size(158, 20);
            this.edTeacherFirstname.TabIndex = 6;
            // 
            // edTeacherBirthdate
            // 
            this.edTeacherBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edTeacherBirthdate.Location = new System.Drawing.Point(309, 364);
            this.edTeacherBirthdate.Name = "edTeacherBirthdate";
            this.edTeacherBirthdate.Size = new System.Drawing.Size(115, 20);
            this.edTeacherBirthdate.TabIndex = 9;
            // 
            // cmbTeacherDepartment
            // 
            this.cmbTeacherDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTeacherDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherDepartment.FormattingEnabled = true;
            this.cmbTeacherDepartment.Location = new System.Drawing.Point(309, 390);
            this.cmbTeacherDepartment.Name = "cmbTeacherDepartment";
            this.cmbTeacherDepartment.Size = new System.Drawing.Size(196, 21);
            this.cmbTeacherDepartment.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EF - Database First";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherBirthdate;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTeacherDepartment;
        private System.Windows.Forms.Button btnDepartmentUpdate;
        private System.Windows.Forms.Button btnDepartmentSave;
        private System.Windows.Forms.Button btnDepartmentDelete;
        private System.Windows.Forms.Button btnDepartmentAdd;
        private System.Windows.Forms.TextBox edDepartmentPhone;
        private System.Windows.Forms.TextBox edDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnGetAllPeoples;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.ComboBox cmbTeacherDepartment;
        private System.Windows.Forms.DateTimePicker edTeacherBirthdate;
        private System.Windows.Forms.Button btnTeachersAdd;
        private System.Windows.Forms.TextBox edTeacherLastname;
        private System.Windows.Forms.TextBox edTeacherFirstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

