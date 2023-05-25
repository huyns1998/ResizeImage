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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrWDivH = new System.Windows.Forms.NumericUpDown();
            this.nmrX = new System.Windows.Forms.NumericUpDown();
            this.nmrY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrWDivH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.btnProcess.Location = new System.Drawing.Point(12, 320);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(133, 23);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process Image";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // nmrRatio
            // 
            this.nmrRatio.Location = new System.Drawing.Point(13, 179);
            this.nmrRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrRatio.Name = "nmrRatio";
            this.nmrRatio.Size = new System.Drawing.Size(84, 23);
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
            this.label1.Location = new System.Drawing.Point(105, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Logo size (%)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Width/Height";
            // 
            // nmrWDivH
            // 
            this.nmrWDivH.DecimalPlaces = 2;
            this.nmrWDivH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmrWDivH.Location = new System.Drawing.Point(13, 209);
            this.nmrWDivH.Name = "nmrWDivH";
            this.nmrWDivH.Size = new System.Drawing.Size(84, 23);
            this.nmrWDivH.TabIndex = 13;
            this.nmrWDivH.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.nmrWDivH.ValueChanged += new System.EventHandler(this.nmrWDivH_ValueChanged);
            // 
            // nmrX
            // 
            this.nmrX.Location = new System.Drawing.Point(13, 238);
            this.nmrX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmrX.Name = "nmrX";
            this.nmrX.Size = new System.Drawing.Size(83, 23);
            this.nmrX.TabIndex = 14;
            // 
            // nmrY
            // 
            this.nmrY.Location = new System.Drawing.Point(12, 267);
            this.nmrY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nmrY.Name = "nmrY";
            this.nmrY.Size = new System.Drawing.Size(85, 23);
            this.nmrY.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "X (from bottom left)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y (from bottom left)";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(628, 30);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(220, 228);
            this.picLogo.TabIndex = 18;
            this.picLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 412);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrY);
            this.Controls.Add(this.nmrX);
            this.Controls.Add(this.nmrWDivH);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.nmrWDivH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private NumericUpDown nmrWDivH;
        private NumericUpDown nmrX;
        private NumericUpDown nmrY;
        private Label label3;
        private Label label4;
        private PictureBox picLogo;
    }
}