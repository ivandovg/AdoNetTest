namespace Ado10_1EF
{
    partial class MainFormCore
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
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvTraining = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerson
            // 
            this.dgvPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Location = new System.Drawing.Point(12, 12);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowTemplate.Height = 25;
            this.dgvPerson.Size = new System.Drawing.Size(536, 237);
            this.dgvPerson.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(473, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvTraining
            // 
            this.dgvTraining.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraining.Location = new System.Drawing.Point(12, 255);
            this.dgvTraining.Name = "dgvTraining";
            this.dgvTraining.RowTemplate.Height = 25;
            this.dgvTraining.Size = new System.Drawing.Size(536, 167);
            this.dgvTraining.TabIndex = 2;
            // 
            // MainFormCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 463);
            this.Controls.Add(this.dgvTraining);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvPerson);
            this.Name = "MainFormCore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EF Core Test";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvPerson;
        private Button btnSave;
        private DataGridView dgvTraining;
    }
}