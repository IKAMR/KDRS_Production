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
            this.bntSaveEvent = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBxStatus = new System.Windows.Forms.ComboBox();
            this.txtBxComments = new System.Windows.Forms.TextBox();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.txtBxEventTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBxPackID = new System.Windows.Forms.TextBox();
            this.pnlEventLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxInPath
            // 
            this.txtbxInPath.Location = new System.Drawing.Point(109, 65);
            this.txtbxInPath.Name = "txtbxInPath";
            this.txtbxInPath.Size = new System.Drawing.Size(502, 20);
            this.txtbxInPath.TabIndex = 0;
            // 
            // txtBxOutPath
            // 
            this.txtBxOutPath.Location = new System.Drawing.Point(109, 113);
            this.txtBxOutPath.Name = "txtBxOutPath";
            this.txtBxOutPath.Size = new System.Drawing.Size(502, 20);
            this.txtBxOutPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "In path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Out path";
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
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Comments";
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
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Package ID";
            // 
            // txtBxPackID
            // 
            this.txtBxPackID.Location = new System.Drawing.Point(4, 30);
            this.txtBxPackID.Name = "txtBxPackID";
            this.txtBxPackID.Size = new System.Drawing.Size(228, 20);
            this.txtBxPackID.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
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
    }
}

