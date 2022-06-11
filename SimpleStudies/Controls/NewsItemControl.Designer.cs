namespace SimpleStudies.Controls
{
    partial class NewsItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PbMain = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblAbstract = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PbMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblAbstract, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 193);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PbMain
            // 
            this.PbMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbMain.Location = new System.Drawing.Point(3, 3);
            this.PbMain.Name = "PbMain";
            this.PbMain.Size = new System.Drawing.Size(234, 114);
            this.PbMain.TabIndex = 0;
            this.PbMain.TabStop = false;
            this.PbMain.WaitOnLoad = true;
            this.PbMain.Click += new System.EventHandler(this.PbMain_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(3, 120);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(234, 42);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "label1";
            this.LblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // LblAbstract
            // 
            this.LblAbstract.AutoSize = true;
            this.LblAbstract.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblAbstract.Location = new System.Drawing.Point(3, 162);
            this.LblAbstract.Name = "LblAbstract";
            this.LblAbstract.Size = new System.Drawing.Size(38, 13);
            this.LblAbstract.TabIndex = 2;
            this.LblAbstract.Text = "label1";
            // 
            // NewsItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NewsItemControl";
            this.Size = new System.Drawing.Size(240, 193);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox PbMain;
        private Label LblTitle;
        private Label LblAbstract;
    }
}
