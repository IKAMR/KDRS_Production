
namespace KDRS_Production
{
    partial class ToolHandling
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
            this.btnSelectLog = new System.Windows.Forms.Button();
            this.txtBxLogPath = new System.Windows.Forms.TextBox();
            this.btnImportLog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.a = new System.Windows.Forms.Panel();
            this.txtBxPackageID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comBxToolSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxTargetFolder = new System.Windows.Forms.TextBox();
            this.btnChooseTargetFolder = new System.Windows.Forms.Button();
            this.txtBxResultFolder = new System.Windows.Forms.TextBox();
            this.btnChooseResultFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlDroid = new System.Windows.Forms.Panel();
            this.txtBxDroidInfo = new System.Windows.Forms.TextBox();
            this.btnRunDroid = new System.Windows.Forms.Button();
            this.txtBxDroidJar = new System.Windows.Forms.TextBox();
            this.btnChooseDroidJar = new System.Windows.Forms.Button();
            this.lblToolError = new System.Windows.Forms.Label();
            this.btnChkDocFiles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListMissFiles = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.a.SuspendLayout();
            this.pnlDroid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectLog
            // 
            this.btnSelectLog.Location = new System.Drawing.Point(16, 5);
            this.btnSelectLog.Name = "btnSelectLog";
            this.btnSelectLog.Size = new System.Drawing.Size(137, 23);
            this.btnSelectLog.TabIndex = 19;
            this.btnSelectLog.Text = "Choose log file";
            this.btnSelectLog.UseVisualStyleBackColor = true;
            this.btnSelectLog.Click += new System.EventHandler(this.btnSelectLog_Click);
            // 
            // txtBxLogPath
            // 
            this.txtBxLogPath.Location = new System.Drawing.Point(159, 8);
            this.txtBxLogPath.Name = "txtBxLogPath";
            this.txtBxLogPath.Size = new System.Drawing.Size(502, 20);
            this.txtBxLogPath.TabIndex = 18;
            // 
            // btnImportLog
            // 
            this.btnImportLog.Location = new System.Drawing.Point(17, 45);
            this.btnImportLog.Name = "btnImportLog";
            this.btnImportLog.Size = new System.Drawing.Size(109, 35);
            this.btnImportLog.TabIndex = 20;
            this.btnImportLog.Text = "Import log";
            this.btnImportLog.UseVisualStyleBackColor = true;
            this.btnImportLog.Click += new System.EventHandler(this.btnImportLog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // a
            // 
            this.a.Controls.Add(this.btnImportLog);
            this.a.Controls.Add(this.txtBxLogPath);
            this.a.Controls.Add(this.btnSelectLog);
            this.a.Location = new System.Drawing.Point(10, 251);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(675, 92);
            this.a.TabIndex = 21;
            // 
            // txtBxPackageID
            // 
            this.txtBxPackageID.Location = new System.Drawing.Point(153, 22);
            this.txtBxPackageID.Name = "txtBxPackageID";
            this.txtBxPackageID.Size = new System.Drawing.Size(502, 20);
            this.txtBxPackageID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Package ID";
            // 
            // comBxToolSelect
            // 
            this.comBxToolSelect.FormattingEnabled = true;
            this.comBxToolSelect.Location = new System.Drawing.Point(79, 104);
            this.comBxToolSelect.Name = "comBxToolSelect";
            this.comBxToolSelect.Size = new System.Drawing.Size(223, 21);
            this.comBxToolSelect.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select tool";
            // 
            // txtBxTargetFolder
            // 
            this.txtBxTargetFolder.Location = new System.Drawing.Point(153, 48);
            this.txtBxTargetFolder.Name = "txtBxTargetFolder";
            this.txtBxTargetFolder.Size = new System.Drawing.Size(502, 20);
            this.txtBxTargetFolder.TabIndex = 21;
            // 
            // btnChooseTargetFolder
            // 
            this.btnChooseTargetFolder.Location = new System.Drawing.Point(10, 45);
            this.btnChooseTargetFolder.Name = "btnChooseTargetFolder";
            this.btnChooseTargetFolder.Size = new System.Drawing.Size(137, 23);
            this.btnChooseTargetFolder.TabIndex = 22;
            this.btnChooseTargetFolder.Text = "Choose Target folder";
            this.btnChooseTargetFolder.UseVisualStyleBackColor = true;
            this.btnChooseTargetFolder.Click += new System.EventHandler(this.btnChooseTargetFolder_Click);
            // 
            // txtBxResultFolder
            // 
            this.txtBxResultFolder.Location = new System.Drawing.Point(153, 74);
            this.txtBxResultFolder.Name = "txtBxResultFolder";
            this.txtBxResultFolder.Size = new System.Drawing.Size(502, 20);
            this.txtBxResultFolder.TabIndex = 25;
            // 
            // btnChooseResultFolder
            // 
            this.btnChooseResultFolder.Location = new System.Drawing.Point(10, 71);
            this.btnChooseResultFolder.Name = "btnChooseResultFolder";
            this.btnChooseResultFolder.Size = new System.Drawing.Size(137, 23);
            this.btnChooseResultFolder.TabIndex = 26;
            this.btnChooseResultFolder.Text = "Choose result folder";
            this.btnChooseResultFolder.UseVisualStyleBackColor = true;
            this.btnChooseResultFolder.Click += new System.EventHandler(this.btnChooseResultFolder_Click);
            // 
            // pnlDroid
            // 
            this.pnlDroid.Controls.Add(this.txtBxDroidInfo);
            this.pnlDroid.Controls.Add(this.btnRunDroid);
            this.pnlDroid.Controls.Add(this.txtBxDroidJar);
            this.pnlDroid.Controls.Add(this.btnChooseDroidJar);
            this.pnlDroid.Location = new System.Drawing.Point(10, 145);
            this.pnlDroid.Name = "pnlDroid";
            this.pnlDroid.Size = new System.Drawing.Size(675, 100);
            this.pnlDroid.TabIndex = 27;
            // 
            // txtBxDroidInfo
            // 
            this.txtBxDroidInfo.Location = new System.Drawing.Point(148, 40);
            this.txtBxDroidInfo.Multiline = true;
            this.txtBxDroidInfo.Name = "txtBxDroidInfo";
            this.txtBxDroidInfo.ReadOnly = true;
            this.txtBxDroidInfo.Size = new System.Drawing.Size(494, 31);
            this.txtBxDroidInfo.TabIndex = 31;
            // 
            // btnRunDroid
            // 
            this.btnRunDroid.Location = new System.Drawing.Point(5, 34);
            this.btnRunDroid.Name = "btnRunDroid";
            this.btnRunDroid.Size = new System.Drawing.Size(137, 31);
            this.btnRunDroid.TabIndex = 30;
            this.btnRunDroid.Text = "Run Droid";
            this.btnRunDroid.UseVisualStyleBackColor = true;
            this.btnRunDroid.Click += new System.EventHandler(this.btnRunDroid_Click);
            // 
            // txtBxDroidJar
            // 
            this.txtBxDroidJar.Location = new System.Drawing.Point(148, 6);
            this.txtBxDroidJar.Name = "txtBxDroidJar";
            this.txtBxDroidJar.Size = new System.Drawing.Size(494, 20);
            this.txtBxDroidJar.TabIndex = 28;
            // 
            // btnChooseDroidJar
            // 
            this.btnChooseDroidJar.Location = new System.Drawing.Point(5, 4);
            this.btnChooseDroidJar.Name = "btnChooseDroidJar";
            this.btnChooseDroidJar.Size = new System.Drawing.Size(137, 23);
            this.btnChooseDroidJar.TabIndex = 29;
            this.btnChooseDroidJar.Text = "Choose Droid jar";
            this.btnChooseDroidJar.UseVisualStyleBackColor = true;
            this.btnChooseDroidJar.Click += new System.EventHandler(this.btnChooseDroidJar_Click);
            // 
            // lblToolError
            // 
            this.lblToolError.AutoSize = true;
            this.lblToolError.ForeColor = System.Drawing.Color.Red;
            this.lblToolError.Location = new System.Drawing.Point(12, 474);
            this.lblToolError.Name = "lblToolError";
            this.lblToolError.Size = new System.Drawing.Size(54, 13);
            this.lblToolError.TabIndex = 28;
            this.lblToolError.Text = "Error label";
            // 
            // btnChkDocFiles
            // 
            this.btnChkDocFiles.Location = new System.Drawing.Point(5, 3);
            this.btnChkDocFiles.Name = "btnChkDocFiles";
            this.btnChkDocFiles.Size = new System.Drawing.Size(137, 31);
            this.btnChkDocFiles.TabIndex = 32;
            this.btnChkDocFiles.Text = "Check doc files";
            this.btnChkDocFiles.UseVisualStyleBackColor = true;
            this.btnChkDocFiles.Click += new System.EventHandler(this.btnChkMissFiles_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListMissFiles);
            this.panel1.Controls.Add(this.btnChkDocFiles);
            this.panel1.Location = new System.Drawing.Point(10, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 106);
            this.panel1.TabIndex = 33;
            // 
            // btnListMissFiles
            // 
            this.btnListMissFiles.Location = new System.Drawing.Point(5, 40);
            this.btnListMissFiles.Name = "btnListMissFiles";
            this.btnListMissFiles.Size = new System.Drawing.Size(137, 31);
            this.btnListMissFiles.TabIndex = 33;
            this.btnListMissFiles.Text = "List missing doc files";
            this.btnListMissFiles.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(576, 474);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 13);
            this.progressBar1.TabIndex = 34;
            // 
            // ToolHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblToolError);
            this.Controls.Add(this.pnlDroid);
            this.Controls.Add(this.txtBxResultFolder);
            this.Controls.Add(this.btnChooseResultFolder);
            this.Controls.Add(this.txtBxTargetFolder);
            this.Controls.Add(this.btnChooseTargetFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comBxToolSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxPackageID);
            this.Controls.Add(this.a);
            this.Controls.Add(this.panel1);
            this.Name = "ToolHandling";
            this.Text = "ToolHandling";
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.pnlDroid.ResumeLayout(false);
            this.pnlDroid.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectLog;
        private System.Windows.Forms.TextBox txtBxLogPath;
        private System.Windows.Forms.Button btnImportLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel a;
        private System.Windows.Forms.TextBox txtBxPackageID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBxToolSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxTargetFolder;
        private System.Windows.Forms.Button btnChooseTargetFolder;
        private System.Windows.Forms.TextBox txtBxResultFolder;
        private System.Windows.Forms.Button btnChooseResultFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel pnlDroid;
        private System.Windows.Forms.Button btnRunDroid;
        private System.Windows.Forms.TextBox txtBxDroidJar;
        private System.Windows.Forms.Button btnChooseDroidJar;
        private System.Windows.Forms.Label lblToolError;
        private System.Windows.Forms.TextBox txtBxDroidInfo;
        private System.Windows.Forms.Button btnChkDocFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListMissFiles;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}