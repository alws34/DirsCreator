namespace DirsCreator
{
    partial class FolderCreatorUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateFolders = new System.Windows.Forms.Button();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxHowMany = new System.Windows.Forms.TextBox();
            this.lblHowMany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(8, 32);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(27, 13);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Root Folder Path";
            // 
            // btnCreateFolders
            // 
            this.btnCreateFolders.Location = new System.Drawing.Point(119, 55);
            this.btnCreateFolders.Name = "btnCreateFolders";
            this.btnCreateFolders.Size = new System.Drawing.Size(75, 20);
            this.btnCreateFolders.TabIndex = 16;
            this.btnCreateFolders.Text = "Create";
            this.btnCreateFolders.UseVisualStyleBackColor = true;
            this.btnCreateFolders.Click += new System.EventHandler(this.btnCreateFolders_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFileDialog.Location = new System.Drawing.Point(361, 3);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(43, 23);
            this.btnOpenFileDialog.TabIndex = 15;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(119, 3);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(236, 20);
            this.textBoxFolderPath.TabIndex = 13;
            this.textBoxFolderPath.TextChanged += new System.EventHandler(this.textBoxFolderPath_TextChanged);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(119, 29);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(132, 20);
            this.textBoxType.TabIndex = 14;
            // 
            // textBoxHowMany
            // 
            this.textBoxHowMany.Location = new System.Drawing.Point(318, 29);
            this.textBoxHowMany.Name = "textBoxHowMany";
            this.textBoxHowMany.Size = new System.Drawing.Size(37, 20);
            this.textBoxHowMany.TabIndex = 19;
            // 
            // lblHowMany
            // 
            this.lblHowMany.AutoSize = true;
            this.lblHowMany.Location = new System.Drawing.Point(257, 32);
            this.lblHowMany.Name = "lblHowMany";
            this.lblHowMany.Size = new System.Drawing.Size(55, 13);
            this.lblHowMany.TabIndex = 20;
            this.lblHowMany.Text = "HowMany";
            // 
            // FolderCreatorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lblHowMany);
            this.Controls.Add(this.textBoxHowMany);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateFolders);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxFolderPath);
            this.Name = "FolderCreatorUserControl";
            this.Size = new System.Drawing.Size(411, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateFolders;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxHowMany;
        private System.Windows.Forms.Label lblHowMany;
    }
}
