namespace Week6Zif1
{
    partial class Formzif1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.pictureBoxPallete = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBlackBlocks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPallete)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(12, 23);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(77, 23);
            this.btnFilePath.TabIndex = 9;
            this.btnFilePath.Text = "Dir File";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // pictureBoxPallete
            // 
            this.pictureBoxPallete.Location = new System.Drawing.Point(95, 23);
            this.pictureBoxPallete.Name = "pictureBoxPallete";
            this.pictureBoxPallete.Size = new System.Drawing.Size(88, 23);
            this.pictureBoxPallete.TabIndex = 10;
            this.pictureBoxPallete.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Color Pallete";
            // 
            // lblBlackBlocks
            // 
            this.lblBlackBlocks.AutoSize = true;
            this.lblBlackBlocks.Location = new System.Drawing.Point(188, 7);
            this.lblBlackBlocks.Name = "lblBlackBlocks";
            this.lblBlackBlocks.Size = new System.Drawing.Size(76, 13);
            this.lblBlackBlocks.TabIndex = 12;
            this.lblBlackBlocks.Text = "lblBlackBlocks";
            // 
            // Formzif1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 202);
            this.Controls.Add(this.lblBlackBlocks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPallete);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Formzif1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPallete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.PictureBox pictureBoxPallete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBlackBlocks;
    }
}

