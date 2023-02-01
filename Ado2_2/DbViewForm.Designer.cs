namespace Ado2_2
{
    partial class DbViewForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTeachers = new System.Windows.Forms.TabPage();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.edDepartment = new System.Windows.Forms.NumericUpDown();
            this.edBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edLastname = new System.Windows.Forms.TextBox();
            this.edFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.edFacultyId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.edGroupName = new System.Windows.Forms.TextBox();
            this.lbGroupName = new System.Windows.Forms.Label();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabTeachers.SuspendLayout();
            this.tabGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFacultyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTeachers);
            this.tabControl1.Controls.Add(this.tabGroups);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 471);
            this.tabControl1.TabIndex = 11;
            // 
            // tabTeachers
            // 
            this.tabTeachers.Controls.Add(this.btnAdd);
            this.tabTeachers.Controls.Add(this.edDepartment);
            this.tabTeachers.Controls.Add(this.edBirthdate);
            this.tabTeachers.Controls.Add(this.label4);
            this.tabTeachers.Controls.Add(this.label3);
            this.tabTeachers.Controls.Add(this.edLastname);
            this.tabTeachers.Controls.Add(this.edFirstname);
            this.tabTeachers.Controls.Add(this.label2);
            this.tabTeachers.Controls.Add(this.label1);
            this.tabTeachers.Controls.Add(this.btnUpdate);
            this.tabTeachers.Controls.Add(this.dgvTeachers);
            this.tabTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabTeachers.Name = "tabTeachers";
            this.tabTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeachers.Size = new System.Drawing.Size(642, 445);
            this.tabTeachers.TabIndex = 0;
            this.tabTeachers.Text = "Teachers";
            this.tabTeachers.UseVisualStyleBackColor = true;
            // 
            // tabGroups
            // 
            this.tabGroups.Controls.Add(this.btnUpdateGroup);
            this.tabGroups.Controls.Add(this.btnAddGroup);
            this.tabGroups.Controls.Add(this.edFacultyId);
            this.tabGroups.Controls.Add(this.label5);
            this.tabGroups.Controls.Add(this.edGroupName);
            this.tabGroups.Controls.Add(this.lbGroupName);
            this.tabGroups.Controls.Add(this.dgvGroups);
            this.tabGroups.Location = new System.Drawing.Point(4, 22);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroups.Size = new System.Drawing.Size(642, 445);
            this.tabGroups.TabIndex = 1;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(559, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // edDepartment
            // 
            this.edDepartment.Location = new System.Drawing.Point(377, 405);
            this.edDepartment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edDepartment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edDepartment.Name = "edDepartment";
            this.edDepartment.Size = new System.Drawing.Size(147, 20);
            this.edDepartment.TabIndex = 20;
            this.edDepartment.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edBirthdate
            // 
            this.edBirthdate.Location = new System.Drawing.Point(376, 370);
            this.edBirthdate.Name = "edBirthdate";
            this.edBirthdate.Size = new System.Drawing.Size(148, 20);
            this.edBirthdate.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Birthdate";
            // 
            // edLastname
            // 
            this.edLastname.Location = new System.Drawing.Point(78, 405);
            this.edLastname.Name = "edLastname";
            this.edLastname.Size = new System.Drawing.Size(208, 20);
            this.edLastname.TabIndex = 16;
            // 
            // edFirstname
            // 
            this.edFirstname.Location = new System.Drawing.Point(78, 370);
            this.edFirstname.Name = "edFirstname";
            this.edFirstname.Size = new System.Drawing.Size(208, 20);
            this.edFirstname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Firstname";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(559, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(8, 13);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(626, 349);
            this.dgvTeachers.TabIndex = 11;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(240, 371);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 27;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // edFacultyId
            // 
            this.edFacultyId.Location = new System.Drawing.Point(87, 408);
            this.edFacultyId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edFacultyId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edFacultyId.Name = "edFacultyId";
            this.edFacultyId.Size = new System.Drawing.Size(147, 20);
            this.edFacultyId.TabIndex = 26;
            this.edFacultyId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Faculty";
            // 
            // edGroupName
            // 
            this.edGroupName.Location = new System.Drawing.Point(87, 373);
            this.edGroupName.Name = "edGroupName";
            this.edGroupName.Size = new System.Drawing.Size(147, 20);
            this.edGroupName.TabIndex = 24;
            // 
            // lbGroupName
            // 
            this.lbGroupName.AutoSize = true;
            this.lbGroupName.Location = new System.Drawing.Point(18, 376);
            this.lbGroupName.Name = "lbGroupName";
            this.lbGroupName.Size = new System.Drawing.Size(67, 13);
            this.lbGroupName.TabIndex = 23;
            this.lbGroupName.Text = "Group Name";
            // 
            // dgvGroups
            // 
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(8, 16);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.Size = new System.Drawing.Size(626, 349);
            this.dgvGroups.TabIndex = 22;
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.Location = new System.Drawing.Point(321, 370);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateGroup.TabIndex = 28;
            this.btnUpdateGroup.Text = "Update";
            this.btnUpdateGroup.UseVisualStyleBackColor = true;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // DbViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 471);
            this.Controls.Add(this.tabControl1);
            this.Name = "DbViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DbViewForm";
            this.tabControl1.ResumeLayout(false);
            this.tabTeachers.ResumeLayout(false);
            this.tabTeachers.PerformLayout();
            this.tabGroups.ResumeLayout(false);
            this.tabGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edFacultyId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTeachers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown edDepartment;
        private System.Windows.Forms.DateTimePicker edBirthdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edLastname;
        private System.Windows.Forms.TextBox edFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.Button btnUpdateGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.NumericUpDown edFacultyId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edGroupName;
        private System.Windows.Forms.Label lbGroupName;
        private System.Windows.Forms.DataGridView dgvGroups;
    }
}