namespace EncodingTool
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBaseDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseDirectories = new System.Windows.Forms.Button();
            this.txtbox1 = new EncodingTool.txtbox();
            this.dlgBrowseDirectories = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtbox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.16931F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.2328F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 420);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.txtBaseDirectory);
            this.panel1.Controls.Add(this.btnBrowseDirectories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 45);
            this.panel1.TabIndex = 5;
            // 
            // txtBaseDirectory
            // 
            this.txtBaseDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaseDirectory.Location = new System.Drawing.Point(3, 4);
            this.txtBaseDirectory.Name = "txtBaseDirectory";
            this.txtBaseDirectory.Size = new System.Drawing.Size(474, 20);
            this.txtBaseDirectory.TabIndex = 3;
            // 
            // btnBrowseDirectories
            // 
            this.btnBrowseDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDirectories.Location = new System.Drawing.Point(483, 3);
            this.btnBrowseDirectories.Name = "btnBrowseDirectories";
            this.btnBrowseDirectories.Size = new System.Drawing.Size(30, 21);
            this.btnBrowseDirectories.TabIndex = 4;
            this.btnBrowseDirectories.Text = "....";
            this.btnBrowseDirectories.UseVisualStyleBackColor = true;
            this.btnBrowseDirectories.Click += new System.EventHandler(this.btnBrowseDirectories_Click);
            // 
            // txtbox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtbox1, 2);
            this.txtbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox1.Location = new System.Drawing.Point(3, 54);
            this.txtbox1.Name = "txtbox1";
            this.tableLayoutPanel1.SetRowSpan(this.txtbox1, 2);
            this.txtbox1.Size = new System.Drawing.Size(516, 363);
            this.txtbox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 420);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private txtbox txtbox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBaseDirectory;
        private System.Windows.Forms.Button btnBrowseDirectories;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowseDirectories;
    }
}

