namespace Images
{
    partial class ImageAppForm
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
            this.dlgOpenImageFile = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnRevertImage = new System.Windows.Forms.Button();
            this.btnApplyEffect = new System.Windows.Forms.Button();
            this.pnlEffectName = new System.Windows.Forms.Panel();
            this.slider = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlEffectName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgOpenImageFile
            // 
            this.dlgOpenImageFile.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnLoadImage);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveImage);
            this.flowLayoutPanel1.Controls.Add(this.btnRevertImage);
            this.flowLayoutPanel1.Controls.Add(this.btnApplyEffect);
            this.flowLayoutPanel1.Controls.Add(this.pnlEffectName);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1094, 158);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.Location = new System.Drawing.Point(4, 5);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(170, 40);
            this.btnLoadImage.TabIndex = 1;
            this.btnLoadImage.Text = "Load Image...";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImage.Location = new System.Drawing.Point(182, 5);
            this.btnSaveImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(170, 40);
            this.btnSaveImage.TabIndex = 6;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnRevertImage
            // 
            this.btnRevertImage.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevertImage.Location = new System.Drawing.Point(360, 5);
            this.btnRevertImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRevertImage.Name = "btnRevertImage";
            this.btnRevertImage.Size = new System.Drawing.Size(170, 40);
            this.btnRevertImage.TabIndex = 7;
            this.btnRevertImage.Text = "Revert";
            this.btnRevertImage.UseVisualStyleBackColor = true;
            this.btnRevertImage.Click += new System.EventHandler(this.btnRevertImage_Click);
            // 
            // btnApplyEffect
            // 
            this.btnApplyEffect.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyEffect.Location = new System.Drawing.Point(538, 5);
            this.btnApplyEffect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyEffect.Name = "btnApplyEffect";
            this.btnApplyEffect.Size = new System.Drawing.Size(170, 40);
            this.btnApplyEffect.TabIndex = 4;
            this.btnApplyEffect.Text = "Apply Effect:";
            this.btnApplyEffect.UseVisualStyleBackColor = true;
            this.btnApplyEffect.Click += new System.EventHandler(this.btnApplyEffect_Click);
            // 
            // pnlEffectName
            // 
            this.pnlEffectName.Controls.Add(this.slider);
            this.pnlEffectName.Controls.Add(this.comboBox1);
            this.pnlEffectName.Location = new System.Drawing.Point(716, 5);
            this.pnlEffectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEffectName.Name = "pnlEffectName";
            this.pnlEffectName.Size = new System.Drawing.Size(314, 97);
            this.pnlEffectName.TabIndex = 5;
            // 
            // slider
            // 
            this.slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider.Location = new System.Drawing.Point(4, 40);
            this.slider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slider.Maximum = 20;
            this.slider.Minimum = 1;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(304, 69);
            this.slider.TabIndex = 4;
            this.slider.Value = 1;
            this.slider.ValueChanged += new System.EventHandler(this.slider_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 0);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 789);
            this.panel1.TabIndex = 4;
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(1094, 789);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // ImageAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 947);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImageAppForm";
            this.Text = "Image Test";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlEffectName.ResumeLayout(false);
            this.pnlEffectName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpenImageFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnApplyEffect;
        private System.Windows.Forms.Panel pnlEffectName;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnRevertImage;
    }
}

