namespace x_OSC_Firmware_Uploader
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.labelHexFile = new System.Windows.Forms.Label();
            this.textBoxHexFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelSerialPort = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(140, 342);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Enabled = false;
            this.buttonUpload.Location = new System.Drawing.Point(407, 307);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 5;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // labelHexFile
            // 
            this.labelHexFile.AutoSize = true;
            this.labelHexFile.Location = new System.Drawing.Point(146, 178);
            this.labelHexFile.Name = "labelHexFile";
            this.labelHexFile.Size = new System.Drawing.Size(48, 13);
            this.labelHexFile.TabIndex = 2;
            this.labelHexFile.Text = "Hex File:";
            // 
            // textBoxHexFile
            // 
            this.textBoxHexFile.Location = new System.Drawing.Point(210, 175);
            this.textBoxHexFile.Name = "textBoxHexFile";
            this.textBoxHexFile.Size = new System.Drawing.Size(241, 20);
            this.textBoxHexFile.TabIndex = 3;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(457, 173);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // labelSerialPort
            // 
            this.labelSerialPort.AutoSize = true;
            this.labelSerialPort.Location = new System.Drawing.Point(146, 133);
            this.labelSerialPort.Name = "labelSerialPort";
            this.labelSerialPort.Size = new System.Drawing.Size(58, 13);
            this.labelSerialPort.TabIndex = 0;
            this.labelSerialPort.Text = "Serial Port:";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(210, 130);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(75, 21);
            this.comboBoxSerialPort.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 342);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.labelSerialPort);
            this.Controls.Add(this.labelHexFile);
            this.Controls.Add(this.textBoxHexFile);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Label labelHexFile;
        private System.Windows.Forms.TextBox textBoxHexFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelSerialPort;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
    }
}

