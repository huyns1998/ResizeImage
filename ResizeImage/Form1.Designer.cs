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
            txtImageFolder = new TextBox();
            btnBrowseImageFolder = new Button();
            txtLogo = new TextBox();
            btnBrowseLogo = new Button();
            btnFrame = new Button();
            txtFrame = new TextBox();
            txtResultFolder = new TextBox();
            btnResult = new Button();
            btnProcess = new Button();
            nmrRatio = new NumericUpDown();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            nmrWDivH = new NumericUpDown();
            nmrX = new NumericUpDown();
            nmrY = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            picLogo = new PictureBox();
            btnReset = new Button();
            btnBack = new Button();
            btnForward = new Button();
            panel1 = new Panel();
            rdoDraw = new RadioButton();
            rdoFill = new RadioButton();
            nmrTime = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrRatio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrWDivH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrTime).BeginInit();
            SuspendLayout();
            // 
            // txtImageFolder
            // 
            txtImageFolder.Enabled = false;
            txtImageFolder.Location = new Point(12, 31);
            txtImageFolder.Name = "txtImageFolder";
            txtImageFolder.Size = new Size(423, 23);
            txtImageFolder.TabIndex = 0;
            // 
            // btnBrowseImageFolder
            // 
            btnBrowseImageFolder.Location = new Point(441, 30);
            btnBrowseImageFolder.Name = "btnBrowseImageFolder";
            btnBrowseImageFolder.Size = new Size(133, 23);
            btnBrowseImageFolder.TabIndex = 1;
            btnBrowseImageFolder.Text = "Browse Image folder";
            btnBrowseImageFolder.UseVisualStyleBackColor = true;
            btnBrowseImageFolder.Click += btnBrowseImageFolder_Click;
            // 
            // txtLogo
            // 
            txtLogo.Enabled = false;
            txtLogo.Location = new Point(12, 67);
            txtLogo.Name = "txtLogo";
            txtLogo.Size = new Size(423, 23);
            txtLogo.TabIndex = 2;
            // 
            // btnBrowseLogo
            // 
            btnBrowseLogo.Location = new Point(441, 67);
            btnBrowseLogo.Name = "btnBrowseLogo";
            btnBrowseLogo.Size = new Size(133, 23);
            btnBrowseLogo.TabIndex = 3;
            btnBrowseLogo.Text = "Browse Logo file";
            btnBrowseLogo.UseVisualStyleBackColor = true;
            btnBrowseLogo.Click += btnBrowseLogo_Click;
            // 
            // btnFrame
            // 
            btnFrame.Location = new Point(441, 105);
            btnFrame.Name = "btnFrame";
            btnFrame.Size = new Size(133, 23);
            btnFrame.TabIndex = 4;
            btnFrame.Text = "Browse Frame file";
            btnFrame.UseVisualStyleBackColor = true;
            btnFrame.Click += btnFrame_Click;
            // 
            // txtFrame
            // 
            txtFrame.Enabled = false;
            txtFrame.Location = new Point(12, 105);
            txtFrame.Name = "txtFrame";
            txtFrame.Size = new Size(423, 23);
            txtFrame.TabIndex = 5;
            // 
            // txtResultFolder
            // 
            txtResultFolder.Enabled = false;
            txtResultFolder.Location = new Point(12, 143);
            txtResultFolder.Name = "txtResultFolder";
            txtResultFolder.Size = new Size(423, 23);
            txtResultFolder.TabIndex = 6;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(441, 142);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(133, 23);
            btnResult.TabIndex = 7;
            btnResult.Text = "Browse result foder";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(12, 344);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(133, 23);
            btnProcess.TabIndex = 8;
            btnProcess.Text = "Process Image";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // nmrRatio
            // 
            nmrRatio.Location = new Point(13, 179);
            nmrRatio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrRatio.Name = "nmrRatio";
            nmrRatio.Size = new Size(84, 23);
            nmrRatio.TabIndex = 9;
            nmrRatio.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 182);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 10;
            label1.Text = "Logo size (%)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 215);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 12;
            label2.Text = "Width/Height";
            // 
            // nmrWDivH
            // 
            nmrWDivH.DecimalPlaces = 2;
            nmrWDivH.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nmrWDivH.Location = new Point(13, 209);
            nmrWDivH.Name = "nmrWDivH";
            nmrWDivH.Size = new Size(84, 23);
            nmrWDivH.TabIndex = 13;
            nmrWDivH.Value = new decimal(new int[] { 8, 0, 0, 65536 });
            nmrWDivH.ValueChanged += nmrWDivH_ValueChanged;
            // 
            // nmrX
            // 
            nmrX.Location = new Point(13, 238);
            nmrX.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nmrX.Name = "nmrX";
            nmrX.Size = new Size(83, 23);
            nmrX.TabIndex = 14;
            // 
            // nmrY
            // 
            nmrY.Location = new Point(12, 267);
            nmrY.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nmrY.Name = "nmrY";
            nmrY.Size = new Size(85, 23);
            nmrY.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 244);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 16;
            label3.Text = "X (from bottom left)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 269);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 17;
            label4.Text = "Y (from bottom left)";
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(628, 58);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(554, 520);
            picLogo.TabIndex = 18;
            picLogo.TabStop = false;
            picLogo.MouseClick += picLogo_MouseClick;
            picLogo.MouseDown += picLogo_MouseDown;
            picLogo.MouseLeave += picLogo_MouseLeave;
            picLogo.MouseMove += picLogo_MouseMove;
            picLogo.MouseUp += picLogo_MouseUp;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(761, 602);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(99, 23);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset Logo";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.left_arrow;
            btnBack.Location = new Point(923, 603);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(53, 23);
            btnBack.TabIndex = 20;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnForward
            // 
            btnForward.Image = Properties.Resources.right_arrows;
            btnForward.Location = new Point(982, 603);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(52, 23);
            btnForward.TabIndex = 21;
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(rdoDraw);
            panel1.Controls.Add(rdoFill);
            panel1.Location = new Point(628, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 26);
            panel1.TabIndex = 22;
            // 
            // rdoDraw
            // 
            rdoDraw.AutoSize = true;
            rdoDraw.Location = new Point(65, 3);
            rdoDraw.Name = "rdoDraw";
            rdoDraw.Size = new Size(52, 19);
            rdoDraw.TabIndex = 1;
            rdoDraw.TabStop = true;
            rdoDraw.Text = "Draw";
            rdoDraw.UseVisualStyleBackColor = true;
            rdoDraw.CheckedChanged += rdoDraw_CheckedChanged;
            // 
            // rdoFill
            // 
            rdoFill.AutoSize = true;
            rdoFill.Checked = true;
            rdoFill.Location = new Point(8, 3);
            rdoFill.Name = "rdoFill";
            rdoFill.Size = new Size(40, 19);
            rdoFill.TabIndex = 0;
            rdoFill.TabStop = true;
            rdoFill.Text = "Fill";
            rdoFill.UseVisualStyleBackColor = true;
            rdoFill.CheckedChanged += rdoFill_CheckedChanged;
            // 
            // nmrTime
            // 
            nmrTime.Location = new Point(12, 296);
            nmrTime.Name = "nmrTime";
            nmrTime.Size = new Size(85, 23);
            nmrTime.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 299);
            label5.Name = "label5";
            label5.Size = new Size(169, 15);
            label5.TabIndex = 24;
            label5.Text = "Time show per image (second)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 668);
            Controls.Add(label5);
            Controls.Add(nmrTime);
            Controls.Add(panel1);
            Controls.Add(btnForward);
            Controls.Add(btnBack);
            Controls.Add(btnReset);
            Controls.Add(picLogo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nmrY);
            Controls.Add(nmrX);
            Controls.Add(nmrWDivH);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nmrRatio);
            Controls.Add(btnProcess);
            Controls.Add(btnResult);
            Controls.Add(txtResultFolder);
            Controls.Add(txtFrame);
            Controls.Add(btnFrame);
            Controls.Add(btnBrowseLogo);
            Controls.Add(txtLogo);
            Controls.Add(btnBrowseImageFolder);
            Controls.Add(txtImageFolder);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image processing";
            ((System.ComponentModel.ISupportInitialize)nmrRatio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrWDivH).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrY).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnReset;
        private Button btnBack;
        private Button btnForward;
        private Panel panel1;
        private RadioButton rdoFill;
        private RadioButton rdoDraw;
        private NumericUpDown nmrTime;
        private Label label5;
    }
}