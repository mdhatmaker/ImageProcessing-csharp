namespace BitmapFilters
{
    partial class MainForm
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.picSource = new System.Windows.Forms.Panel();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.picOutput = new System.Windows.Forms.Panel();
            this.btnLoadSource = new System.Windows.Forms.Button();
            this.rdGrayscale = new System.Windows.Forms.RadioButton();
            this.rdTransparency = new System.Windows.Forms.RadioButton();
            this.rdSepia = new System.Windows.Forms.RadioButton();
            this.rdNegative = new System.Windows.Forms.RadioButton();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.picSource);
            this.grbInput.Location = new System.Drawing.Point(12, 12);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(272, 280);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Input Source";
            // 
            // picSource
            // 
            this.picSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Location = new System.Drawing.Point(11, 19);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(250, 250);
            this.picSource.TabIndex = 0;
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.picOutput);
            this.grbOutput.Location = new System.Drawing.Point(301, 12);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(272, 280);
            this.grbOutput.TabIndex = 1;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Filtered Output";
            // 
            // picOutput
            // 
            this.picOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOutput.Location = new System.Drawing.Point(11, 19);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(250, 250);
            this.picOutput.TabIndex = 0;
            // 
            // btnLoadSource
            // 
            this.btnLoadSource.Location = new System.Drawing.Point(12, 298);
            this.btnLoadSource.Name = "btnLoadSource";
            this.btnLoadSource.Size = new System.Drawing.Size(110, 23);
            this.btnLoadSource.TabIndex = 2;
            this.btnLoadSource.Text = "Load Source";
            this.btnLoadSource.UseVisualStyleBackColor = true;
            this.btnLoadSource.Click += new System.EventHandler(this.btnLoadSource_Click);
            // 
            // rdGrayscale
            // 
            this.rdGrayscale.AutoSize = true;
            this.rdGrayscale.Checked = true;
            this.rdGrayscale.Location = new System.Drawing.Point(245, 301);
            this.rdGrayscale.Name = "rdGrayscale";
            this.rdGrayscale.Size = new System.Drawing.Size(72, 17);
            this.rdGrayscale.TabIndex = 3;
            this.rdGrayscale.TabStop = true;
            this.rdGrayscale.Text = "Grayscale";
            this.rdGrayscale.UseVisualStyleBackColor = true;
            this.rdGrayscale.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdTransparency
            // 
            this.rdTransparency.AutoSize = true;
            this.rdTransparency.Location = new System.Drawing.Point(323, 301);
            this.rdTransparency.Name = "rdTransparency";
            this.rdTransparency.Size = new System.Drawing.Size(90, 17);
            this.rdTransparency.TabIndex = 4;
            this.rdTransparency.Text = "Transparency";
            this.rdTransparency.UseVisualStyleBackColor = true;
            this.rdTransparency.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdSepia
            // 
            this.rdSepia.AutoSize = true;
            this.rdSepia.Location = new System.Drawing.Point(493, 301);
            this.rdSepia.Name = "rdSepia";
            this.rdSepia.Size = new System.Drawing.Size(80, 17);
            this.rdSepia.TabIndex = 6;
            this.rdSepia.Text = "Sepia Tone";
            this.rdSepia.UseVisualStyleBackColor = true;
            this.rdSepia.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdNegative
            // 
            this.rdNegative.AutoSize = true;
            this.rdNegative.Location = new System.Drawing.Point(419, 301);
            this.rdNegative.Name = "rdNegative";
            this.rdNegative.Size = new System.Drawing.Size(68, 17);
            this.rdNegative.TabIndex = 5;
            this.rdNegative.Text = "Negative";
            this.rdNegative.UseVisualStyleBackColor = true;
            this.rdNegative.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 333);
            this.Controls.Add(this.rdSepia);
            this.Controls.Add(this.rdNegative);
            this.Controls.Add(this.rdTransparency);
            this.Controls.Add(this.rdGrayscale);
            this.Controls.Add(this.btnLoadSource);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Filters";
            this.grbInput.ResumeLayout(false);
            this.grbOutput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Panel picSource;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.Panel picOutput;
        private System.Windows.Forms.Button btnLoadSource;
        private System.Windows.Forms.RadioButton rdGrayscale;
        private System.Windows.Forms.RadioButton rdTransparency;
        private System.Windows.Forms.RadioButton rdSepia;
        private System.Windows.Forms.RadioButton rdNegative;
    }
}

