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
            this.checkBoxCleanUpload = new System.Windows.Forms.CheckBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInstructions = new System.Windows.Forms.Label();
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
            this.buttonUpload.Location = new System.Drawing.Point(276, 286);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(100, 38);
            this.buttonUpload.TabIndex = 5;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // labelHexFile
            // 
            this.labelHexFile.AutoSize = true;
            this.labelHexFile.Location = new System.Drawing.Point(146, 203);
            this.labelHexFile.Name = "labelHexFile";
            this.labelHexFile.Size = new System.Drawing.Size(48, 13);
            this.labelHexFile.TabIndex = 2;
            this.labelHexFile.Text = "Hex File:";
            // 
            // textBoxHexFile
            // 
            this.textBoxHexFile.Location = new System.Drawing.Point(210, 200);
            this.textBoxHexFile.Name = "textBoxHexFile";
            this.textBoxHexFile.Size = new System.Drawing.Size(261, 20);
            this.textBoxHexFile.TabIndex = 3;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(477, 198);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(25, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelSerialPort
            // 
            this.labelSerialPort.AutoSize = true;
            this.labelSerialPort.Location = new System.Drawing.Point(146, 166);
            this.labelSerialPort.Name = "labelSerialPort";
            this.labelSerialPort.Size = new System.Drawing.Size(58, 13);
            this.labelSerialPort.TabIndex = 0;
            this.labelSerialPort.Text = "Serial Port:";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(210, 163);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(75, 21);
            this.comboBoxSerialPort.TabIndex = 1;
            this.comboBoxSerialPort.DropDown += new System.EventHandler(this.comboBoxSerialPort_DropDown);
            // 
            // checkBoxCleanUpload
            // 
            this.checkBoxCleanUpload.AutoSize = true;
            this.checkBoxCleanUpload.Checked = true;
            this.checkBoxCleanUpload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCleanUpload.Location = new System.Drawing.Point(212, 238);
            this.checkBoxCleanUpload.Name = "checkBoxCleanUpload";
            this.checkBoxCleanUpload.Size = new System.Drawing.Size(88, 17);
            this.checkBoxCleanUpload.TabIndex = 6;
            this.checkBoxCleanUpload.Text = "Clean upload";
            this.checkBoxCleanUpload.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(144, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(298, 29);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "x-OSC Firmware Uploader";
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(146, 68);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(196, 65);
            this.labelInstructions.TabIndex = 8;
            this.labelInstructions.Text = "1. Select serial port and firmware hex file\r\n\r\n2. Click upload button\r\n\r\n3. Power" +
                " cycle x-OSC to start upload";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 342);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.checkBoxCleanUpload);
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
        private System.Windows.Forms.CheckBox checkBoxCleanUpload;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInstructions;
    }
}

