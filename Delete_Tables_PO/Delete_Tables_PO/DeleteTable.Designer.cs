namespace Delete_Tables_PO
{
    partial class DeleteTable
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
			this.groupDelete = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbAddTable = new System.Windows.Forms.CheckBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbDatabase = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rdAccount = new System.Windows.Forms.RadioButton();
			this.rdPO = new System.Windows.Forms.RadioButton();
			this.rdFO = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxWhere = new System.Windows.Forms.TextBox();
			this.checkBoxDeleteWhere = new System.Windows.Forms.CheckBox();
			this.groupBoxDeleteWhere = new System.Windows.Forms.GroupBox();
			this.groupDelete.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBoxDeleteWhere.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupDelete
			// 
			this.groupDelete.Controls.Add(this.groupBoxDeleteWhere);
			this.groupDelete.Controls.Add(this.label1);
			this.groupDelete.Controls.Add(this.checkBoxDeleteWhere);
			this.groupDelete.Controls.Add(this.cbAddTable);
			this.groupDelete.Controls.Add(this.btnStart);
			this.groupDelete.Controls.Add(this.btnBack);
			this.groupDelete.Controls.Add(this.txtTableName);
			this.groupDelete.Controls.Add(this.label6);
			this.groupDelete.Controls.Add(this.label5);
			this.groupDelete.Controls.Add(this.cbDatabase);
			this.groupDelete.Enabled = false;
			this.groupDelete.Location = new System.Drawing.Point(12, 107);
			this.groupDelete.Name = "groupDelete";
			this.groupDelete.Size = new System.Drawing.Size(580, 348);
			this.groupDelete.TabIndex = 0;
			this.groupDelete.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 31;
			this.label1.Text = "Option";
			// 
			// cbAddTable
			// 
			this.cbAddTable.AutoSize = true;
			this.cbAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAddTable.Location = new System.Drawing.Point(160, 62);
			this.cbAddTable.Name = "cbAddTable";
			this.cbAddTable.Size = new System.Drawing.Size(103, 24);
			this.cbAddTable.TabIndex = 24;
			this.cbAddTable.Text = "Add Table";
			this.cbAddTable.UseVisualStyleBackColor = true;
			this.cbAddTable.CheckedChanged += new System.EventHandler(this.cbAddTable_CheckedChanged);
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(440, 254);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 37);
			this.btnStart.TabIndex = 30;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(333, 254);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 37);
			this.btnBack.TabIndex = 29;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// txtTableName
			// 
			this.txtTableName.Enabled = false;
			this.txtTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTableName.Location = new System.Drawing.Point(160, 112);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.Size = new System.Drawing.Size(355, 27);
			this.txtTableName.TabIndex = 25;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(32, 119);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 20);
			this.label6.TabIndex = 28;
			this.label6.Text = "Table Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 20);
			this.label5.TabIndex = 26;
			this.label5.Text = "Database";
			// 
			// cbDatabase
			// 
			this.cbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDatabase.FormattingEnabled = true;
			this.cbDatabase.Location = new System.Drawing.Point(160, 19);
			this.cbDatabase.Name = "cbDatabase";
			this.cbDatabase.Size = new System.Drawing.Size(355, 28);
			this.cbDatabase.TabIndex = 27;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rdAccount);
			this.groupBox2.Controls.Add(this.rdPO);
			this.groupBox2.Controls.Add(this.rdFO);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(580, 89);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// rdAccount
			// 
			this.rdAccount.AutoSize = true;
			this.rdAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdAccount.Location = new System.Drawing.Point(420, 31);
			this.rdAccount.Name = "rdAccount";
			this.rdAccount.Size = new System.Drawing.Size(111, 24);
			this.rdAccount.TabIndex = 35;
			this.rdAccount.Text = "Accountant";
			this.rdAccount.UseVisualStyleBackColor = true;
			this.rdAccount.CheckedChanged += new System.EventHandler(this.rdAccount_CheckedChanged);
			// 
			// rdPO
			// 
			this.rdPO.AutoSize = true;
			this.rdPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdPO.Location = new System.Drawing.Point(298, 31);
			this.rdPO.Name = "rdPO";
			this.rdPO.Size = new System.Drawing.Size(51, 24);
			this.rdPO.TabIndex = 34;
			this.rdPO.Text = "PO";
			this.rdPO.UseVisualStyleBackColor = true;
			this.rdPO.CheckedChanged += new System.EventHandler(this.rdPO_CheckedChanged);
			// 
			// rdFO
			// 
			this.rdFO.AutoSize = true;
			this.rdFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdFO.Location = new System.Drawing.Point(186, 33);
			this.rdFO.Name = "rdFO";
			this.rdFO.Size = new System.Drawing.Size(50, 24);
			this.rdFO.TabIndex = 33;
			this.rdFO.Text = "FO";
			this.rdFO.UseVisualStyleBackColor = true;
			this.rdFO.CheckedChanged += new System.EventHandler(this.rdFO_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 20);
			this.label2.TabIndex = 32;
			this.label2.Text = "Database Type";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(124, 35);
			this.textBoxName.Multiline = true;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(121, 27);
			this.textBoxName.TabIndex = 32;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(26, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 20);
			this.label3.TabIndex = 33;
			this.label3.Text = "Table";
			// 
			// textBoxWhere
			// 
			this.textBoxWhere.Location = new System.Drawing.Point(262, 35);
			this.textBoxWhere.Multiline = true;
			this.textBoxWhere.Name = "textBoxWhere";
			this.textBoxWhere.Size = new System.Drawing.Size(247, 27);
			this.textBoxWhere.TabIndex = 35;
			// 
			// checkBoxDeleteWhere
			// 
			this.checkBoxDeleteWhere.AutoSize = true;
			this.checkBoxDeleteWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxDeleteWhere.Location = new System.Drawing.Point(355, 62);
			this.checkBoxDeleteWhere.Name = "checkBoxDeleteWhere";
			this.checkBoxDeleteWhere.Size = new System.Drawing.Size(131, 24);
			this.checkBoxDeleteWhere.TabIndex = 24;
			this.checkBoxDeleteWhere.Text = "Delete Where";
			this.checkBoxDeleteWhere.UseVisualStyleBackColor = true;
			this.checkBoxDeleteWhere.CheckedChanged += new System.EventHandler(this.checkBoxDeleteWhere_CheckedChanged);
			// 
			// groupBoxDeleteWhere
			// 
			this.groupBoxDeleteWhere.Controls.Add(this.label3);
			this.groupBoxDeleteWhere.Controls.Add(this.textBoxName);
			this.groupBoxDeleteWhere.Controls.Add(this.textBoxWhere);
			this.groupBoxDeleteWhere.Enabled = false;
			this.groupBoxDeleteWhere.Location = new System.Drawing.Point(6, 148);
			this.groupBoxDeleteWhere.Name = "groupBoxDeleteWhere";
			this.groupBoxDeleteWhere.Size = new System.Drawing.Size(568, 100);
			this.groupBoxDeleteWhere.TabIndex = 37;
			this.groupBoxDeleteWhere.TabStop = false;
			// 
			// DeleteTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 467);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupDelete);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DeleteTable";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delete Tables";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteTable_FormClosed);
			this.groupDelete.ResumeLayout(false);
			this.groupDelete.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBoxDeleteWhere.ResumeLayout(false);
			this.groupBoxDeleteWhere.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAddTable;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdAccount;
        private System.Windows.Forms.RadioButton rdPO;
        private System.Windows.Forms.RadioButton rdFO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxWhere;
		private System.Windows.Forms.CheckBox checkBoxDeleteWhere;
		private System.Windows.Forms.GroupBox groupBoxDeleteWhere;
    }
}

