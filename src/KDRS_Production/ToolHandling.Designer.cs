
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
            this.SuspendLayout();
            // 
            // btnSelectLog
            // 
            this.btnSelectLog.Location = new System.Drawing.Point(12, 12);
            this.btnSelectLog.Name = "btnSelectLog";
            this.btnSelectLog.Size = new System.Drawing.Size(137, 23);
            this.btnSelectLog.TabIndex = 19;
            this.btnSelectLog.Text = "Choose log file";
            this.btnSelectLog.UseVisualStyleBackColor = true;
            this.btnSelectLog.Click += new System.EventHandler(this.btnSelectLog_Click);
            // 
            // txtBxLogPath
            // 
            this.txtBxLogPath.Location = new System.Drawing.Point(155, 15);
            this.txtBxLogPath.Name = "txtBxLogPath";
            this.txtBxLogPath.Size = new System.Drawing.Size(502, 20);
            this.txtBxLogPath.TabIndex = 18;
            // 
            // btnImportLog
            // 
            this.btnImportLog.Location = new System.Drawing.Point(13, 52);
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
            // ToolHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImportLog);
            this.Controls.Add(this.btnSelectLog);
            this.Controls.Add(this.txtBxLogPath);
            this.Name = "ToolHandling";
            this.Text = "ToolHandling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectLog;
        private System.Windows.Forms.TextBox txtBxLogPath;
        private System.Windows.Forms.Button btnImportLog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}