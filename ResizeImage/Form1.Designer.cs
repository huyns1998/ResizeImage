namespace ResizeImage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtImageFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseImageFolder = new System.Windows.Forms.Button();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.btnBrowseLogo = new System.Windows.Forms.Button();
            this.btnFrame = new System.Windows.Forms.Button();
            this.txtFrame = new System.Windows.Forms.TextBox();
            this.txtResultFolder = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.nmrRatio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImageFolder
            // 
            this.txtImageFolder.Enabled = false;
            this.txtImageFolder.Location = new System.Drawing.Point(12, 31);
            this.txtImageFolder.Name = "txtImageFolder";
            this.txtImageFolder.Size = new System.Drawing.Size(423, 23);
            this.txtImageFolder.TabIndex = 0;
            // 
            // btnBrowseImageFolder
            // 
            this.btnBrowseImageFolder.Location = new System.Drawing.Point(441, 30);
            this.btnBrowseImageFolder.Name = "btnBrowseImageFolder";
            this.btnBrowseImageFolder.Size = new System.Drawing.Size(133, 23);
            this.btnBrowseImageFolder.TabIndex = 1;
            this.btnBrowseImageFolder.Text = "Browse Image folder";
            this.btnBrowseImageFolder.UseVisualStyleBackColor = true;
            this.btnBrowseImageFolder.Click += new System.EventHandler(this.btnBrowseImageFolder_Click);
            // 
            // txtLogo
            // 
            this.txtLogo.Enabled = false;
            this.txtLogo.Location = new System.Drawing.Point(12, 67);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(423, 23);
            this.txtLogo.TabIndex = 2;
            // 
            // btnBrowseLogo
            // 
            this.btnBrowseLogo.Location = new System.Drawing.Point(441, 67);
            this.btnBrowseLogo.Name = "btnBrowseLogo";
            this.btnBrowseLogo.Size = new System.Drawing.Size(133, 23);
            this.btnBrowseLogo.TabIndex = 3;
            this.btnBrowseLogo.Text = "Browse Logo file";
            this.btnBrowseLogo.UseVisualStyleBackColor = true;
            this.btnBrowseLogo.Click += new System.EventHandler(this.btnBrowseLogo_Click);
            // 
            // btnFrame
            // 
            this.btnFrame.Location = new System.Drawing.Point(441, 105);
            this.btnFrame.Name = "btnFrame";
            this.btnFrame.Size = new System.Drawing.Size(133, 23);
            this.btnFrame.TabIndex = 4;
            this.btnFrame.Text = "Browse Frame file";
            this.btnFrame.UseVisualStyleBackColor = true;
            this.btnFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // txtFrame
            // 
            this.txtFrame.Enabled = false;
            this.txtFrame.Location = new System.Drawing.Point(12, 105);
            this.txtFrame.Name = "txtFrame";
            this.txtFrame.Size = new System.Drawing.Size(423, 23);
            this.txtFrame.TabIndex = 5;
            // 
            // txtResultFolder
            // 
            this.txtResultFolder.Enabled = false;
            this.txtResultFolder.Location = new System.Drawing.Point(12, 143);
            this.txtResultFolder.Name = "txtResultFolder";
            this.txtResultFolder.Size = new System.Drawing.Size(423, 23);
            this.txtResultFolder.TabIndex = 6;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(441, 142);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(133, 23);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Browse result foder";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(327, 181);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(108, 23);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process Image";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // nmrRatio
            // 
            this.nmrRatio.Location = new System.Drawing.Point(12, 181);
            this.nmrRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrRatio.Name = "nmrRatio";
            this.nmrRatio.Size = new System.Drawing.Size(82, 23);
            this.nmrRatio.TabIndex = 9;
            this.nmrRatio.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Logo/frame(%)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrRatio);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtResultFolder);
            this.Controls.Add(this.txtFrame);
            this.Controls.Add(this.btnFrame);
            this.Controls.Add(this.btnBrowseLogo);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.btnBrowseImageFolder);
            this.Controls.Add(this.txtImageFolder);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image processing";
            ((System.ComponentModel.ISupportInitialize)(this.nmrRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtImageFolder;
        private Button btnBrowseImageFolder;
        private TextBox txtLogo;
        private Button btnBrowseLogo;
        private Button btnFrame;
        private TextBox txtFrame;
        private TextBox txtResultFolder;
        private Button btnResult;
        private Button btnProcess;
        private NumericUpDown nmrRatio;
        private Label label1;
    }
}