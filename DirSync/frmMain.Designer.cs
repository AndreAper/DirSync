namespace DirSync
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSourceFolder = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForce = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDestFolder = new System.Windows.Forms.TextBox();
            this.btnSelectDest = new System.Windows.Forms.Button();
            this.chkBtnEnabled = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chkBxOverwrite = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // tbxSourceFolder
            // 
            this.tbxSourceFolder.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSourceFolder.Location = new System.Drawing.Point(96, 10);
            this.tbxSourceFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSourceFolder.Name = "tbxSourceFolder";
            this.tbxSourceFolder.Size = new System.Drawing.Size(284, 27);
            this.tbxSourceFolder.TabIndex = 1;
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.AutoSize = true;
            this.btnSelectSource.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectSource.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelectSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSource.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSource.Location = new System.Drawing.Point(392, 7);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(90, 31);
            this.btnSelectSource.TabIndex = 2;
            this.btnSelectSource.Text = "Select";
            this.btnSelectSource.UseVisualStyleBackColor = false;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "hh:mm:ss";
            this.dtpTime.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(96, 85);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(104, 27);
            this.dtpTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time";
            // 
            // btnForce
            // 
            this.btnForce.AutoSize = true;
            this.btnForce.BackColor = System.Drawing.SystemColors.Control;
            this.btnForce.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnForce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForce.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForce.Location = new System.Drawing.Point(323, 81);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(57, 31);
            this.btnForce.TabIndex = 2;
            this.btnForce.Text = "Force";
            this.btnForce.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnForce.UseVisualStyleBackColor = false;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination";
            // 
            // tbxDestFolder
            // 
            this.tbxDestFolder.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDestFolder.Location = new System.Drawing.Point(96, 47);
            this.tbxDestFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxDestFolder.Name = "tbxDestFolder";
            this.tbxDestFolder.Size = new System.Drawing.Size(284, 27);
            this.tbxDestFolder.TabIndex = 1;
            // 
            // btnSelectDest
            // 
            this.btnSelectDest.AutoSize = true;
            this.btnSelectDest.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectDest.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSelectDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDest.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDest.Location = new System.Drawing.Point(392, 44);
            this.btnSelectDest.Name = "btnSelectDest";
            this.btnSelectDest.Size = new System.Drawing.Size(90, 31);
            this.btnSelectDest.TabIndex = 2;
            this.btnSelectDest.Text = "Select";
            this.btnSelectDest.UseVisualStyleBackColor = false;
            this.btnSelectDest.Click += new System.EventHandler(this.btnSelectDest_Click);
            // 
            // chkBtnEnabled
            // 
            this.chkBtnEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBtnEnabled.BackColor = System.Drawing.Color.Crimson;
            this.chkBtnEnabled.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.chkBtnEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkBtnEnabled.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBtnEnabled.ForeColor = System.Drawing.Color.White;
            this.chkBtnEnabled.Location = new System.Drawing.Point(392, 81);
            this.chkBtnEnabled.Name = "chkBtnEnabled";
            this.chkBtnEnabled.Size = new System.Drawing.Size(90, 31);
            this.chkBtnEnabled.TabIndex = 4;
            this.chkBtnEnabled.Text = "Disabled";
            this.chkBtnEnabled.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkBtnEnabled.UseVisualStyleBackColor = false;
            this.chkBtnEnabled.CheckedChanged += new System.EventHandler(this.chkBtnEnabled_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chkBxOverwrite
            // 
            this.chkBxOverwrite.AutoSize = true;
            this.chkBxOverwrite.Location = new System.Drawing.Point(219, 91);
            this.chkBxOverwrite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBxOverwrite.Name = "chkBxOverwrite";
            this.chkBxOverwrite.Size = new System.Drawing.Size(71, 17);
            this.chkBxOverwrite.TabIndex = 5;
            this.chkBxOverwrite.Text = "Overwrite";
            this.chkBxOverwrite.UseVisualStyleBackColor = true;
            this.chkBxOverwrite.CheckedChanged += new System.EventHandler(this.chkBxOverwrite_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "DirSync running";
            this.notifyIcon.BalloonTipTitle = "DirSync";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DirSync";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 126);
            this.Controls.Add(this.chkBxOverwrite);
            this.Controls.Add(this.chkBtnEnabled);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnForce);
            this.Controls.Add(this.btnSelectDest);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.tbxDestFolder);
            this.Controls.Add(this.tbxSourceFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "DirSync";
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSourceFolder;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnForce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDestFolder;
        private System.Windows.Forms.Button btnSelectDest;
        private System.Windows.Forms.CheckBox chkBtnEnabled;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox chkBxOverwrite;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

