namespace Ado4_1
{
    partial class MainForm4_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProviderList = new System.Windows.Forms.ComboBox();
            this.btnGetProvider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edConnectionString = new System.Windows.Forms.TextBox();
            this.edSqlQuery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.btnExecuteAsync = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select provider";
            // 
            // cmbProviderList
            // 
            this.cmbProviderList.FormattingEnabled = true;
            this.cmbProviderList.Location = new System.Drawing.Point(91, 12);
            this.cmbProviderList.Name = "cmbProviderList";
            this.cmbProviderList.Size = new System.Drawing.Size(237, 21);
            this.cmbProviderList.TabIndex = 1;
            this.cmbProviderList.SelectedIndexChanged += new System.EventHandler(this.cmbProviderList_SelectedIndexChanged);
            // 
            // btnGetProvider
            // 
            this.btnGetProvider.Location = new System.Drawing.Point(334, 10);
            this.btnGetProvider.Name = "btnGetProvider";
            this.btnGetProvider.Size = new System.Drawing.Size(155, 23);
            this.btnGetProvider.TabIndex = 2;
            this.btnGetProvider.Text = "Get provider";
            this.btnGetProvider.UseVisualStyleBackColor = true;
            this.btnGetProvider.Click += new System.EventHandler(this.btnGetProvider_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection string";
            // 
            // edConnectionString
            // 
            this.edConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edConnectionString.Location = new System.Drawing.Point(12, 64);
            this.edConnectionString.Name = "edConnectionString";
            this.edConnectionString.ReadOnly = true;
            this.edConnectionString.Size = new System.Drawing.Size(562, 20);
            this.edConnectionString.TabIndex = 4;
            // 
            // edSqlQuery
            // 
            this.edSqlQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edSqlQuery.Enabled = false;
            this.edSqlQuery.Location = new System.Drawing.Point(10, 117);
            this.edSqlQuery.Name = "edSqlQuery";
            this.edSqlQuery.Size = new System.Drawing.Size(403, 20);
            this.edSqlQuery.TabIndex = 5;
            this.edSqlQuery.TextChanged += new System.EventHandler(this.edSqlQuery_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter query";
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(419, 115);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(155, 23);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(10, 143);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(564, 295);
            this.dgvView.TabIndex = 8;
            // 
            // btnExecuteAsync
            // 
            this.btnExecuteAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecuteAsync.Enabled = false;
            this.btnExecuteAsync.Location = new System.Drawing.Point(419, 91);
            this.btnExecuteAsync.Name = "btnExecuteAsync";
            this.btnExecuteAsync.Size = new System.Drawing.Size(155, 23);
            this.btnExecuteAsync.TabIndex = 11;
            this.btnExecuteAsync.Text = "Execute Async Query";
            this.btnExecuteAsync.UseVisualStyleBackColor = true;
            this.btnExecuteAsync.Click += new System.EventHandler(this.btnExecuteAsync_Click);
            // 
            // MainForm4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.btnExecuteAsync);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edSqlQuery);
            this.Controls.Add(this.edConnectionString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetProvider);
            this.Controls.Add(this.cmbProviderList);
            this.Controls.Add(this.label1);
            this.Name = "MainForm4_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ado - Test DbProviderFactory";
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProviderList;
        private System.Windows.Forms.Button btnGetProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edConnectionString;
        private System.Windows.Forms.TextBox edSqlQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnExecuteAsync;
    }
}

