namespace KDRS_Production
{
    partial class Form1
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
            this.txtbxInPath = new System.Windows.Forms.TextBox();
            this.txtBxOutPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenEventLog = new System.Windows.Forms.Button();
            this.pnlEventLog = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxPackID = new System.Windows.Forms.TextBox();
            this.bntSaveEvent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBxStatus = new System.Windows.Forms.ComboBox();
            this.txtBxComments = new System.Windows.Forms.TextBox();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.txtBxEventTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaveMetadata = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnLogMeta = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBxPackageID = new System.Windows.Forms.TextBox();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.txtBxInfoXmlPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectInfoXml = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnExpLog = new System.Windows.Forms.Button();
            this.cmbBxLogContent = new System.Windows.Forms.ComboBox();
            this.pnlEventLog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxInPath
            // 
            this.txtbxInPath.Location = new System.Drawing.Point(109, 103);
            this.txtbxInPath.Name = "txtbxInPath";
            this.txtbxInPath.Size = new System.Drawing.Size(502, 20);
            this.txtbxInPath.TabIndex = 0;
            // 
            // txtBxOutPath
            // 
            this.txtBxOutPath.Location = new System.Drawing.Point(109, 151);
            this.txtBxOutPath.Name = "txtBxOutPath";
            this.txtBxOutPath.Size = new System.Drawing.Size(502, 20);
            this.txtBxOutPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "In path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Work path";
            // 
            // btnOpenEventLog
            // 
            this.btnOpenEventLog.Location = new System.Drawing.Point(109, 194);
            this.btnOpenEventLog.Name = "btnOpenEventLog";
            this.btnOpenEventLog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenEventLog.TabIndex = 4;
            this.btnOpenEventLog.Text = "Log event";
            this.btnOpenEventLog.UseVisualStyleBackColor = true;
            this.btnOpenEventLog.Click += new System.EventHandler(this.btnOpenEventLog_Click);
            // 
            // pnlEventLog
            // 
            this.pnlEventLog.Controls.Add(this.label7);
            this.pnlEventLog.Controls.Add(this.txtBxPackID);
            this.pnlEventLog.Controls.Add(this.bntSaveEvent);
            this.pnlEventLog.Controls.Add(this.label6);
            this.pnlEventLog.Controls.Add(this.label5);
            this.pnlEventLog.Controls.Add(this.label4);
            this.pnlEventLog.Controls.Add(this.label3);
            this.pnlEventLog.Controls.Add(this.cbBxStatus);
            this.pnlEventLog.Controls.Add(this.txtBxComments);
            this.pnlEventLog.Controls.Add(this.txtBxDescription);
            this.pnlEventLog.Controls.Add(this.txtBxEventTime);
            this.pnlEventLog.Location = new System.Drawing.Point(109, 224);
            this.pnlEventLog.Name = "pnlEventLog";
            this.pnlEventLog.Size = new System.Drawing.Size(235, 356);
            this.pnlEventLog.TabIndex = 5;
            this.pnlEventLog.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Log Tag";
            // 
            // txtBxPackID
            // 
            this.txtBxPackID.Location = new System.Drawing.Point(4, 30);
            this.txtBxPackID.Name = "txtBxPackID";
            this.txtBxPackID.Size = new System.Drawing.Size(228, 20);
            this.txtBxPackID.TabIndex = 9;
            // 
            // bntSaveEvent
            // 
            this.bntSaveEvent.Location = new System.Drawing.Point(4, 318);
            this.bntSaveEvent.Name = "bntSaveEvent";
            this.bntSaveEvent.Size = new System.Drawing.Size(117, 23);
            this.bntSaveEvent.TabIndex = 8;
            this.bntSaveEvent.Text = "Save event";
            this.bntSaveEvent.UseVisualStyleBackColor = true;
            this.bntSaveEvent.Click += new System.EventHandler(this.bntSaveEvent_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Desription";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Timestamp";
            // 
            // cbBxStatus
            // 
            this.cbBxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxStatus.FormattingEnabled = true;
            this.cbBxStatus.Location = new System.Drawing.Point(4, 188);
            this.cbBxStatus.Name = "cbBxStatus";
            this.cbBxStatus.Size = new System.Drawing.Size(228, 21);
            this.cbBxStatus.TabIndex = 3;
            // 
            // txtBxComments
            // 
            this.txtBxComments.Location = new System.Drawing.Point(4, 245);
            this.txtBxComments.Multiline = true;
            this.txtBxComments.Name = "txtBxComments";
            this.txtBxComments.Size = new System.Drawing.Size(227, 65);
            this.txtBxComments.TabIndex = 2;
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(4, 132);
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(228, 20);
            this.txtBxDescription.TabIndex = 1;
            // 
            // txtBxEventTime
            // 
            this.txtBxEventTime.Location = new System.Drawing.Point(4, 82);
            this.txtBxEventTime.Name = "txtBxEventTime";
            this.txtBxEventTime.Size = new System.Drawing.Size(228, 20);
            this.txtBxEventTime.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSaveMetadata);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(421, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 356);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Avtalenr";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btnSaveMetadata
            // 
            this.btnSaveMetadata.Location = new System.Drawing.Point(4, 318);
            this.btnSaveMetadata.Name = "btnSaveMetadata";
            this.btnSaveMetadata.Size = new System.Drawing.Size(117, 23);
            this.btnSaveMetadata.TabIndex = 8;
            this.btnSaveMetadata.Text = "Save metadata";
            this.btnSaveMetadata.UseVisualStyleBackColor = true;
            this.btnSaveMetadata.Click += new System.EventHandler(this.btnSaveMetadata_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kontaktperson";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Arkivskaper";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(4, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 20);
            this.textBox4.TabIndex = 0;
            // 
            // btnLogMeta
            // 
            this.btnLogMeta.Location = new System.Drawing.Point(421, 194);
            this.btnLogMeta.Name = "btnLogMeta";
            this.btnLogMeta.Size = new System.Drawing.Size(102, 23);
            this.btnLogMeta.TabIndex = 6;
            this.btnLogMeta.Text = "Import Metadata";
            this.btnLogMeta.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Package ID";
            // 
            // txtBxPackageID
            // 
            this.txtBxPackageID.Location = new System.Drawing.Point(109, 47);
            this.txtBxPackageID.Name = "txtBxPackageID";
            this.txtBxPackageID.Size = new System.Drawing.Size(502, 20);
            this.txtBxPackageID.TabIndex = 8;
            // 
            // btnImportXml
            // 
            this.btnImportXml.Location = new System.Drawing.Point(109, 650);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(137, 31);
            this.btnImportXml.TabIndex = 10;
            this.btnImportXml.Text = "Import info.xml";
            this.btnImportXml.UseVisualStyleBackColor = true;
            this.btnImportXml.Click += new System.EventHandler(this.btnImportXml_Click);
            // 
            // txtBxInfoXmlPath
            // 
            this.txtBxInfoXmlPath.Location = new System.Drawing.Point(109, 624);
            this.txtBxInfoXmlPath.Name = "txtBxInfoXmlPath";
            this.txtBxInfoXmlPath.Size = new System.Drawing.Size(502, 20);
            this.txtBxInfoXmlPath.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectInfoXml
            // 
            this.btnSelectInfoXml.Location = new System.Drawing.Point(109, 595);
            this.btnSelectInfoXml.Name = "btnSelectInfoXml";
            this.btnSelectInfoXml.Size = new System.Drawing.Size(137, 23);
            this.btnSelectInfoXml.TabIndex = 12;
            this.btnSelectInfoXml.Text = "Choose info.xml";
            this.btnSelectInfoXml.UseVisualStyleBackColor = true;
            this.btnSelectInfoXml.Click += new System.EventHandler(this.btnSelectInfoXml_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(106, 707);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 13;
            // 
            // btnExpLog
            // 
            this.btnExpLog.Location = new System.Drawing.Point(651, 40);
            this.btnExpLog.Name = "btnExpLog";
            this.btnExpLog.Size = new System.Drawing.Size(137, 32);
            this.btnExpLog.TabIndex = 14;
            this.btnExpLog.Text = "Export log";
            this.btnExpLog.UseVisualStyleBackColor = true;
            this.btnExpLog.Click += new System.EventHandler(this.btnExpLog_Click);
            // 
            // cmbBxLogContent
            // 
            this.cmbBxLogContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxLogContent.FormattingEnabled = true;
            this.cmbBxLogContent.Location = new System.Drawing.Point(651, 84);
            this.cmbBxLogContent.Name = "cmbBxLogContent";
            this.cmbBxLogContent.Size = new System.Drawing.Size(137, 21);
            this.cmbBxLogContent.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 805);
            this.Controls.Add(this.cmbBxLogContent);
            this.Controls.Add(this.btnExpLog);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSelectInfoXml);
            this.Controls.Add(this.txtBxInfoXmlPath);
            this.Controls.Add(this.btnImportXml);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBxPackageID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogMeta);
            this.Controls.Add(this.pnlEventLog);
            this.Controls.Add(this.btnOpenEventLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxOutPath);
            this.Controls.Add(this.txtbxInPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlEventLog.ResumeLayout(false);
            this.pnlEventLog.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxInPath;
        private System.Windows.Forms.TextBox txtBxOutPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenEventLog;
        private System.Windows.Forms.Panel pnlEventLog;
        protected internal System.Windows.Forms.TextBox txtBxEventTime;
        private System.Windows.Forms.TextBox txtBxDescription;
        private System.Windows.Forms.TextBox txtBxComments;
        private System.Windows.Forms.ComboBox cbBxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntSaveEvent;
        private System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.TextBox txtBxPackID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSaveMetadata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        protected internal System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnLogMeta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBxPackageID;
        private System.Windows.Forms.Button btnImportXml;
        private System.Windows.Forms.TextBox txtBxInfoXmlPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectInfoXml;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnExpLog;
        private System.Windows.Forms.ComboBox cmbBxLogContent;
    }
}

