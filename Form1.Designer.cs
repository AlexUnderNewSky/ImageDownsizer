namespace Homework
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
            browseButton = new Button();
            originalPictureBox = new PictureBox();
            downsizeButton = new Button();
            downscaledPictureBox = new PictureBox();
            scaleTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)downscaledPictureBox).BeginInit();
            SuspendLayout();
            // 
            // browseButton
            // 
            browseButton.Location = new Point(41, 327);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(179, 89);
            browseButton.TabIndex = 3;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // originalPictureBox
            // 
            originalPictureBox.BorderStyle = BorderStyle.FixedSingle;
            originalPictureBox.Location = new Point(12, 12);
            originalPictureBox.Name = "originalPictureBox";
            originalPictureBox.Size = new Size(380, 271);
            originalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            originalPictureBox.TabIndex = 4;
            originalPictureBox.TabStop = false;
            // 
            // downsizeButton
            // 
            downsizeButton.Location = new Point(583, 327);
            downsizeButton.Name = "downsizeButton";
            downsizeButton.Size = new Size(179, 89);
            downsizeButton.TabIndex = 5;
            downsizeButton.Text = "Downsize";
            downsizeButton.UseVisualStyleBackColor = true;
            downsizeButton.Click += downsizeButton_Click;
            // 
            // downscaledPictureBox
            // 
            downscaledPictureBox.BorderStyle = BorderStyle.FixedSingle;
            downscaledPictureBox.Location = new Point(408, 12);
            downscaledPictureBox.Name = "downscaledPictureBox";
            downscaledPictureBox.Size = new Size(380, 271);
            downscaledPictureBox.TabIndex = 6;
            downscaledPictureBox.TabStop = false;
            // 
            // scaleTextBox
            // 
            scaleTextBox.Location = new Point(232, 370);
            scaleTextBox.Name = "scaleTextBox";
            scaleTextBox.Size = new Size(176, 23);
            scaleTextBox.TabIndex = 7;
            scaleTextBox.TextChanged += scaleTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(226, 347);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 8;
            label1.Text = "Please enter scaling factor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(scaleTextBox);
            Controls.Add(downscaledPictureBox);
            Controls.Add(downsizeButton);
            Controls.Add(originalPictureBox);
            Controls.Add(browseButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)originalPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)downscaledPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button browseButton;
        private PictureBox originalPictureBox;
        private Button downsizeButton;
        private PictureBox downscaledPictureBox;
        private TextBox scaleTextBox;
        private Label label1;
    }
}
