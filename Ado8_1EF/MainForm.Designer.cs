namespace Ado8_1EF
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
            this.dgvPeoples = new System.Windows.Forms.DataGridView();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.colPersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactTypeInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edPersonBirthdate = new System.Windows.Forms.DateTimePicker();
            this.btnPersonAdd = new System.Windows.Forms.Button();
            this.edPersonLastname = new System.Windows.Forms.TextBox();
            this.edPersonFirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edContactValue = new System.Windows.Forms.TextBox();
            this.edContactTypeInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnContactAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeoples)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeoples
            // 
            this.dgvPeoples.AllowUserToAddRows = false;
            this.dgvPeoples.AllowUserToDeleteRows = false;
            this.dgvPeoples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeoples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeoples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeoples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPersonId,
            this.colPersonFirstname,
            this.colPersonLastname,
            this.colPersonBirth});
            this.dgvPeoples.Location = new System.Drawing.Point(12, 12);
            this.dgvPeoples.MultiSelect = false;
            this.dgvPeoples.Name = "dgvPeoples";
            this.dgvPeoples.ReadOnly = true;
            this.dgvPeoples.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeoples.Size = new System.Drawing.Size(490, 387);
            this.dgvPeoples.TabIndex = 0;
            this.dgvPeoples.SelectionChanged += new System.EventHandler(this.dgvPeoples_SelectionChanged);
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContactId,
            this.colContactTypeInfo,
            this.colContactValue});
            this.dgvContacts.Location = new System.Drawing.Point(508, 12);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(253, 387);
            this.dgvContacts.TabIndex = 1;
            // 
            // colPersonId
            // 
            this.colPersonId.DataPropertyName = "Id";
            this.colPersonId.HeaderText = "Id";
            this.colPersonId.Name = "colPersonId";
            this.colPersonId.ReadOnly = true;
            this.colPersonId.Visible = false;
            // 
            // colPersonFirstname
            // 
            this.colPersonFirstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPersonFirstname.DataPropertyName = "Firstname";
            this.colPersonFirstname.FillWeight = 104.3147F;
            this.colPersonFirstname.HeaderText = "Firstname";
            this.colPersonFirstname.Name = "colPersonFirstname";
            this.colPersonFirstname.ReadOnly = true;
            // 
            // colPersonLastname
            // 
            this.colPersonLastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPersonLastname.DataPropertyName = "Lastname";
            this.colPersonLastname.FillWeight = 104.3147F;
            this.colPersonLastname.HeaderText = "Lastname";
            this.colPersonLastname.Name = "colPersonLastname";
            this.colPersonLastname.ReadOnly = true;
            // 
            // colPersonBirth
            // 
            this.colPersonBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPersonBirth.DataPropertyName = "Birth";
            this.colPersonBirth.FillWeight = 91.37056F;
            this.colPersonBirth.HeaderText = "Birth";
            this.colPersonBirth.Name = "colPersonBirth";
            this.colPersonBirth.ReadOnly = true;
            // 
            // colContactId
            // 
            this.colContactId.DataPropertyName = "Id";
            this.colContactId.HeaderText = "Id";
            this.colContactId.Name = "colContactId";
            this.colContactId.ReadOnly = true;
            this.colContactId.Visible = false;
            // 
            // colContactTypeInfo
            // 
            this.colContactTypeInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactTypeInfo.DataPropertyName = "TypeInfo";
            this.colContactTypeInfo.HeaderText = "TypeInfo";
            this.colContactTypeInfo.Name = "colContactTypeInfo";
            this.colContactTypeInfo.ReadOnly = true;
            // 
            // colContactValue
            // 
            this.colContactValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactValue.DataPropertyName = "Value";
            this.colContactValue.FillWeight = 200F;
            this.colContactValue.HeaderText = "Value";
            this.colContactValue.Name = "colContactValue";
            this.colContactValue.ReadOnly = true;
            // 
            // edPersonBirthdate
            // 
            this.edPersonBirthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edPersonBirthdate.Location = new System.Drawing.Point(313, 408);
            this.edPersonBirthdate.Name = "edPersonBirthdate";
            this.edPersonBirthdate.Size = new System.Drawing.Size(115, 20);
            this.edPersonBirthdate.TabIndex = 16;
            // 
            // btnPersonAdd
            // 
            this.btnPersonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPersonAdd.Location = new System.Drawing.Point(316, 434);
            this.btnPersonAdd.Name = "btnPersonAdd";
            this.btnPersonAdd.Size = new System.Drawing.Size(112, 23);
            this.btnPersonAdd.TabIndex = 15;
            this.btnPersonAdd.Text = "Add";
            this.btnPersonAdd.UseVisualStyleBackColor = true;
            this.btnPersonAdd.Click += new System.EventHandler(this.btnPersonAdd_Click);
            // 
            // edPersonLastname
            // 
            this.edPersonLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edPersonLastname.Location = new System.Drawing.Point(77, 434);
            this.edPersonLastname.Name = "edPersonLastname";
            this.edPersonLastname.Size = new System.Drawing.Size(158, 20);
            this.edPersonLastname.TabIndex = 14;
            // 
            // edPersonFirstname
            // 
            this.edPersonFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edPersonFirstname.Location = new System.Drawing.Point(77, 408);
            this.edPersonFirstname.Name = "edPersonFirstname";
            this.edPersonFirstname.Size = new System.Drawing.Size(158, 20);
            this.edPersonFirstname.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lastename";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Firstname";
            // 
            // edContactValue
            // 
            this.edContactValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edContactValue.Location = new System.Drawing.Point(570, 434);
            this.edContactValue.Name = "edContactValue";
            this.edContactValue.Size = new System.Drawing.Size(110, 20);
            this.edContactValue.TabIndex = 20;
            // 
            // edContactTypeInfo
            // 
            this.edContactTypeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edContactTypeInfo.Location = new System.Drawing.Point(570, 408);
            this.edContactTypeInfo.Name = "edContactTypeInfo";
            this.edContactTypeInfo.Size = new System.Drawing.Size(110, 20);
            this.edContactTypeInfo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type Info";
            // 
            // btnContactAdd
            // 
            this.btnContactAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContactAdd.Location = new System.Drawing.Point(686, 406);
            this.btnContactAdd.Name = "btnContactAdd";
            this.btnContactAdd.Size = new System.Drawing.Size(75, 23);
            this.btnContactAdd.TabIndex = 21;
            this.btnContactAdd.Text = "Add";
            this.btnContactAdd.UseVisualStyleBackColor = true;
            this.btnContactAdd.Click += new System.EventHandler(this.btnContactAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 461);
            this.Controls.Add(this.btnContactAdd);
            this.Controls.Add(this.edContactValue);
            this.Controls.Add(this.edContactTypeInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edPersonBirthdate);
            this.Controls.Add(this.btnPersonAdd);
            this.Controls.Add(this.edPersonLastname);
            this.Controls.Add(this.edPersonFirstname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvContacts);
            this.Controls.Add(this.dgvPeoples);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EF - Model First";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeoples)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeoples;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactTypeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactValue;
        private System.Windows.Forms.DateTimePicker edPersonBirthdate;
        private System.Windows.Forms.Button btnPersonAdd;
        private System.Windows.Forms.TextBox edPersonLastname;
        private System.Windows.Forms.TextBox edPersonFirstname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edContactValue;
        private System.Windows.Forms.TextBox edContactTypeInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContactAdd;
    }
}

