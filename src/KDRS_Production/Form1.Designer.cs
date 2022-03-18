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
            this.btnGetTimeStamp = new System.Windows.Forms.Button();
            this.chkBxSelectFromTemplate = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bntSaveEvent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBxStatus = new System.Windows.Forms.ComboBox();
            this.txtBxComments = new System.Windows.Forms.TextBox();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.txtBxEventTime = new System.Windows.Forms.TextBox();
            this.cbBxSelectEvent = new System.Windows.Forms.ComboBox();
            this.txtBxLogTag = new System.Windows.Forms.TextBox();
            this.btnEditMeta = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBxPackageID = new System.Windows.Forms.TextBox();
            this.btnImportXml = new System.Windows.Forms.Button();
            this.txtBxInfoXmlPath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectInfoXml = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnExpLog = new System.Windows.Forms.Button();
            this.cmbBxLogContent = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnToolHandling = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxUser = new System.Windows.Forms.TextBox();
            this.pnlEventLog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxInPath
            // 
            this.txtbxInPath.Location = new System.Drawing.Point(6, 88);
            this.txtbxInPath.Name = "txtbxInPath";
            this.txtbxInPath.Size = new System.Drawing.Size(502, 20);
            this.txtbxInPath.TabIndex = 0;
            // 
            // txtBxOutPath
            // 
            this.txtBxOutPath.Location = new System.Drawing.Point(6, 139);
            this.txtBxOutPath.Name = "txtBxOutPath";
            this.txtBxOutPath.Size = new System.Drawing.Size(502, 20);
            this.txtBxOutPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quarantine path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Work path";
            // 
            // btnOpenEventLog
            // 
            this.btnOpenEventLog.Location = new System.Drawing.Point(3, 179);
            this.btnOpenEventLog.Name = "btnOpenEventLog";
            this.btnOpenEventLog.Size = new System.Drawing.Size(75, 23);
            this.btnOpenEventLog.TabIndex = 4;
            this.btnOpenEventLog.Text = "Log event";
            this.btnOpenEventLog.UseVisualStyleBackColor = true;
            this.btnOpenEventLog.Click += new System.EventHandler(this.btnOpenEventLog_Click);
            // 
            // pnlEventLog
            // 
            this.pnlEventLog.AutoSize = true;
            this.pnlEventLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlEventLog.Controls.Add(this.label8);
            this.pnlEventLog.Controls.Add(this.txtBxUser);
            this.pnlEventLog.Controls.Add(this.btnGetTimeStamp);
            this.pnlEventLog.Controls.Add(this.chkBxSelectFromTemplate);
            this.pnlEventLog.Controls.Add(this.label7);
            this.pnlEventLog.Controls.Add(this.bntSaveEvent);
            this.pnlEventLog.Controls.Add(this.label6);
            this.pnlEventLog.Controls.Add(this.label5);
            this.pnlEventLog.Controls.Add(this.label4);
            this.pnlEventLog.Controls.Add(this.label3);
            this.pnlEventLog.Controls.Add(this.cbBxStatus);
            this.pnlEventLog.Controls.Add(this.txtBxComments);
            this.pnlEventLog.Controls.Add(this.txtBxDescription);
            this.pnlEventLog.Controls.Add(this.txtBxEventTime);
            this.pnlEventLog.Controls.Add(this.cbBxSelectEvent);
            this.pnlEventLog.Controls.Add(this.txtBxLogTag);
            this.pnlEventLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEventLog.Location = new System.Drawing.Point(0, 205);
            this.pnlEventLog.Name = "pnlEventLog";
            this.pnlEventLog.Size = new System.Drawing.Size(848, 371);
            this.pnlEventLog.TabIndex = 5;
            this.pnlEventLog.Visible = false;
            // 
            // btnGetTimeStamp
            // 
            this.btnGetTimeStamp.Location = new System.Drawing.Point(148, 122);
            this.btnGetTimeStamp.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetTimeStamp.Name = "btnGetTimeStamp";
            this.btnGetTimeStamp.Size = new System.Drawing.Size(83, 20);
            this.btnGetTimeStamp.TabIndex = 17;
            this.btnGetTimeStamp.Text = "Get timestamp";
            this.btnGetTimeStamp.UseVisualStyleBackColor = true;
            this.btnGetTimeStamp.Click += new System.EventHandler(this.btnGetTimeStamp_Click);
            // 
            // chkBxSelectFromTemplate
            // 
            this.chkBxSelectFromTemplate.AutoSize = true;
            this.chkBxSelectFromTemplate.Location = new System.Drawing.Point(109, 56);
            this.chkBxSelectFromTemplate.Name = "chkBxSelectFromTemplate";
            this.chkBxSelectFromTemplate.Size = new System.Drawing.Size(122, 17);
            this.chkBxSelectFromTemplate.TabIndex = 11;
            this.chkBxSelectFromTemplate.Text = "Select from template";
            this.chkBxSelectFromTemplate.UseVisualStyleBackColor = true;
            this.chkBxSelectFromTemplate.CheckedChanged += new System.EventHandler(this.chkBxSelectFromTemplate_CheckedChanged);
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
            // bntSaveEvent
            // 
            this.bntSaveEvent.Location = new System.Drawing.Point(4, 345);
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
            this.label6.Location = new System.Drawing.Point(4, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Desription";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Timestamp";
            // 
            // cbBxStatus
            // 
            this.cbBxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxStatus.FormattingEnabled = true;
            this.cbBxStatus.Location = new System.Drawing.Point(4, 215);
            this.cbBxStatus.Name = "cbBxStatus";
            this.cbBxStatus.Size = new System.Drawing.Size(228, 21);
            this.cbBxStatus.TabIndex = 3;
            // 
            // txtBxComments
            // 
            this.txtBxComments.Location = new System.Drawing.Point(4, 272);
            this.txtBxComments.Multiline = true;
            this.txtBxComments.Name = "txtBxComments";
            this.txtBxComments.Size = new System.Drawing.Size(227, 65);
            this.txtBxComments.TabIndex = 2;
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(4, 159);
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(228, 20);
            this.txtBxDescription.TabIndex = 1;
            // 
            // txtBxEventTime
            // 
            this.txtBxEventTime.Location = new System.Drawing.Point(4, 97);
            this.txtBxEventTime.Name = "txtBxEventTime";
            this.txtBxEventTime.Size = new System.Drawing.Size(228, 20);
            this.txtBxEventTime.TabIndex = 0;
            // 
            // cbBxSelectEvent
            // 
            this.cbBxSelectEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxSelectEvent.FormattingEnabled = true;
            this.cbBxSelectEvent.Location = new System.Drawing.Point(4, 30);
            this.cbBxSelectEvent.Name = "cbBxSelectEvent";
            this.cbBxSelectEvent.Size = new System.Drawing.Size(228, 21);
            this.cbBxSelectEvent.TabIndex = 16;
            this.cbBxSelectEvent.Visible = false;
            this.cbBxSelectEvent.SelectedIndexChanged += new System.EventHandler(this.cbBxSelectEvent_SelectedIndexChanged);
            // 
            // txtBxLogTag
            // 
            this.txtBxLogTag.Location = new System.Drawing.Point(4, 30);
            this.txtBxLogTag.Name = "txtBxLogTag";
            this.txtBxLogTag.Size = new System.Drawing.Size(228, 20);
            this.txtBxLogTag.TabIndex = 9;
            // 
            // btnEditMeta
            // 
            this.btnEditMeta.Location = new System.Drawing.Point(0, 102);
            this.btnEditMeta.Name = "btnEditMeta";
            this.btnEditMeta.Size = new System.Drawing.Size(137, 33);
            this.btnEditMeta.TabIndex = 6;
            this.btnEditMeta.Text = "Edit Metadata";
            this.btnEditMeta.UseVisualStyleBackColor = true;
            this.btnEditMeta.Click += new System.EventHandler(this.btnEditMeta_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Package ID";
            // 
            // txtBxPackageID
            // 
            this.txtBxPackageID.Location = new System.Drawing.Point(6, 35);
            this.txtBxPackageID.Name = "txtBxPackageID";
            this.txtBxPackageID.Size = new System.Drawing.Size(502, 20);
            this.txtBxPackageID.TabIndex = 8;
            // 
            // btnImportXml
            // 
            this.btnImportXml.Location = new System.Drawing.Point(0, 65);
            this.btnImportXml.Name = "btnImportXml";
            this.btnImportXml.Size = new System.Drawing.Size(137, 31);
            this.btnImportXml.TabIndex = 10;
            this.btnImportXml.Text = "Import info.xml";
            this.btnImportXml.UseVisualStyleBackColor = true;
            this.btnImportXml.Click += new System.EventHandler(this.btnImportXml_Click);
            // 
            // txtBxInfoXmlPath
            // 
            this.txtBxInfoXmlPath.Location = new System.Drawing.Point(0, 39);
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
            this.btnSelectInfoXml.Location = new System.Drawing.Point(0, 10);
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
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(1, 149);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(54, 13);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Error label";
            // 
            // btnExpLog
            // 
            this.btnExpLog.Location = new System.Drawing.Point(542, 12);
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
            this.cmbBxLogContent.Location = new System.Drawing.Point(542, 50);
            this.cmbBxLogContent.Name = "cmbBxLogContent";
            this.cmbBxLogContent.Size = new System.Drawing.Size(137, 21);
            this.cmbBxLogContent.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditMeta);
            this.panel1.Controls.Add(this.btnImportXml);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.txtBxInfoXmlPath);
            this.panel1.Controls.Add(this.btnSelectInfoXml);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 576);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 172);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnToolHandling);
            this.panel2.Controls.Add(this.btnExpLog);
            this.panel2.Controls.Add(this.cmbBxLogContent);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnOpenEventLog);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtBxPackageID);
            this.panel2.Controls.Add(this.txtBxOutPath);
            this.panel2.Controls.Add(this.txtbxInPath);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 205);
            this.panel2.TabIndex = 17;
            // 
            // btnToolHandling
            // 
            this.btnToolHandling.Location = new System.Drawing.Point(685, 12);
            this.btnToolHandling.Name = "btnToolHandling";
            this.btnToolHandling.Size = new System.Drawing.Size(137, 32);
            this.btnToolHandling.TabIndex = 16;
            this.btnToolHandling.Text = "Run tool/Import log";
            this.btnToolHandling.UseVisualStyleBackColor = true;
            this.btnToolHandling.Click += new System.EventHandler(this.btnToolHandling_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "User";
            // 
            // txtBxUser
            // 
            this.txtBxUser.Location = new System.Drawing.Point(262, 30);
            this.txtBxUser.Name = "txtBxUser";
            this.txtBxUser.Size = new System.Drawing.Size(228, 20);
            this.txtBxUser.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 840);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlEventLog);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlEventLog.ResumeLayout(false);
            this.pnlEventLog.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        protected internal System.Windows.Forms.TextBox txtBxLogTag;
        private System.Windows.Forms.Button btnEditMeta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBxPackageID;
        private System.Windows.Forms.Button btnImportXml;
        private System.Windows.Forms.TextBox txtBxInfoXmlPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectInfoXml;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnExpLog;
        private System.Windows.Forms.ComboBox cmbBxLogContent;
        private System.Windows.Forms.CheckBox chkBxSelectFromTemplate;
        private System.Windows.Forms.ComboBox cbBxSelectEvent;
        private System.Windows.Forms.Button btnGetTimeStamp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnToolHandling;
        private System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.TextBox txtBxUser;
    }
}

