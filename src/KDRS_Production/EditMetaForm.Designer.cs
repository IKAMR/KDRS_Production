namespace KDRS_Production
{
    partial class EditMetaForm
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnSelectInfoXml = new System.Windows.Forms.Button();
            this.txtBxInfoXmlPath = new System.Windows.Forms.TextBox();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.btnSaveMeta = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLogEdit = new System.Windows.Forms.Button();
            this.txtBxWorkArea = new System.Windows.Forms.TextBox();
            this.btnChooseWorkArea = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 163);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(54, 13);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "Error label";
            // 
            // btnSelectInfoXml
            // 
            this.btnSelectInfoXml.Location = new System.Drawing.Point(12, 12);
            this.btnSelectInfoXml.Name = "btnSelectInfoXml";
            this.btnSelectInfoXml.Size = new System.Drawing.Size(137, 23);
            this.btnSelectInfoXml.TabIndex = 17;
            this.btnSelectInfoXml.Text = "Choose info.xml";
            this.btnSelectInfoXml.UseVisualStyleBackColor = true;
            this.btnSelectInfoXml.Click += new System.EventHandler(this.btnSelectInfoXml_Click);
            // 
            // txtBxInfoXmlPath
            // 
            this.txtBxInfoXmlPath.Location = new System.Drawing.Point(155, 15);
            this.txtBxInfoXmlPath.Name = "txtBxInfoXmlPath";
            this.txtBxInfoXmlPath.Size = new System.Drawing.Size(502, 20);
            this.txtBxInfoXmlPath.TabIndex = 16;
            // 
            // btnImportXml
            // 
            this.btnImportXml.Location = new System.Drawing.Point(12, 70);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(137, 31);
            this.btnImportXml.TabIndex = 15;
            this.btnImportXml.Text = "Import info.xml";
            this.btnImportXml.UseVisualStyleBackColor = true;
            this.btnImportXml.Click += new System.EventHandler(this.btnImportXml_Click);
            // 
            // btnSaveMeta
            // 
            this.btnSaveMeta.Enabled = false;
            this.btnSaveMeta.Location = new System.Drawing.Point(12, 107);
            this.btnSaveMeta.Name = "btnSaveMeta";
            this.btnSaveMeta.Size = new System.Drawing.Size(137, 33);
            this.btnSaveMeta.TabIndex = 14;
            this.btnSaveMeta.Text = "Save changes";
            this.btnSaveMeta.UseVisualStyleBackColor = true;
            this.btnSaveMeta.Click += new System.EventHandler(this.btnSaveMeta_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLogEdit
            // 
            this.btnLogEdit.Location = new System.Drawing.Point(155, 107);
            this.btnLogEdit.Name = "btnLogEdit";
            this.btnLogEdit.Size = new System.Drawing.Size(122, 33);
            this.btnLogEdit.TabIndex = 19;
            this.btnLogEdit.Text = "Log edit";
            this.btnLogEdit.UseVisualStyleBackColor = true;
            // 
            // txtBxWorkArea
            // 
            this.txtBxWorkArea.Location = new System.Drawing.Point(155, 44);
            this.txtBxWorkArea.Name = "txtBxWorkArea";
            this.txtBxWorkArea.Size = new System.Drawing.Size(502, 20);
            this.txtBxWorkArea.TabIndex = 20;
            // 
            // btnChooseWorkArea
            // 
            this.btnChooseWorkArea.Location = new System.Drawing.Point(12, 41);
            this.btnChooseWorkArea.Name = "btnChooseWorkArea";
            this.btnChooseWorkArea.Size = new System.Drawing.Size(137, 23);
            this.btnChooseWorkArea.TabIndex = 21;
            this.btnChooseWorkArea.Text = "Choose work area";
            this.btnChooseWorkArea.UseVisualStyleBackColor = true;
            this.btnChooseWorkArea.Click += new System.EventHandler(this.btnChooseWorkArea_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.AutoScroll = true;
            this.pnlInfo.Location = new System.Drawing.Point(12, 199);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(648, 239);
            this.pnlInfo.TabIndex = 22;
            // 
            // EditMetaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnChooseWorkArea);
            this.Controls.Add(this.txtBxWorkArea);
            this.Controls.Add(this.btnLogEdit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSelectInfoXml);
            this.Controls.Add(this.txtBxInfoXmlPath);
            this.Controls.Add(this.btnImportXml);
            this.Controls.Add(this.btnSaveMeta);
            this.Name = "EditMetaForm";
            this.Text = "EditMetaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSelectInfoXml;
        private System.Windows.Forms.TextBox txtBxInfoXmlPath;
        private System.Windows.Forms.Button btnImportXml;
        private System.Windows.Forms.Button btnSaveMeta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLogEdit;
        private System.Windows.Forms.TextBox txtBxWorkArea;
        private System.Windows.Forms.Button btnChooseWorkArea;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel pnlInfo;
    }
}