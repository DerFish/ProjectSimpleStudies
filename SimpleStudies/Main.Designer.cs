namespace SimpleStudies
{
    partial class Main
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LbLTitle = new System.Windows.Forms.Label();
            this.ScMain = new System.Windows.Forms.SplitContainer();
            this.SpNav = new SimpleStudies.Views.Sitepanel();
            this.BtnSidepanel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScMain)).BeginInit();
            this.ScMain.Panel2.SuspendLayout();
            this.ScMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Controls.Add(this.LbLTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ScMain, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnSidepanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1297, 804);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LbLTitle
            // 
            this.LbLTitle.AutoSize = true;
            this.LbLTitle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbLTitle.Location = new System.Drawing.Point(3, 0);
            this.LbLTitle.Name = "LbLTitle";
            this.LbLTitle.Size = new System.Drawing.Size(893, 80);
            this.LbLTitle.TabIndex = 2;
            this.LbLTitle.Text = "Wilkommen zu Simple Studies";
            // 
            // ScMain
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ScMain, 2);
            this.ScMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScMain.Location = new System.Drawing.Point(3, 83);
            this.ScMain.Name = "ScMain";
            // 
            // ScMain.Panel2
            // 
            this.ScMain.Panel2.Controls.Add(this.SpNav);
            this.ScMain.Size = new System.Drawing.Size(1291, 718);
            this.ScMain.SplitterDistance = 1109;
            this.ScMain.TabIndex = 4;
            // 
            // SpNav
            // 
            this.SpNav.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpNav.Location = new System.Drawing.Point(0, 0);
            this.SpNav.Margin = new System.Windows.Forms.Padding(7);
            this.SpNav.Name = "SpNav";
            this.SpNav.Size = new System.Drawing.Size(178, 718);
            this.SpNav.TabIndex = 0;
            // 
            // BtnSidepanel
            // 
            this.BtnSidepanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSidepanel.Location = new System.Drawing.Point(1152, 0);
            this.BtnSidepanel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSidepanel.Name = "BtnSidepanel";
            this.BtnSidepanel.Size = new System.Drawing.Size(145, 80);
            this.BtnSidepanel.TabIndex = 3;
            this.BtnSidepanel.Text = "_";
            this.BtnSidepanel.UseVisualStyleBackColor = true;
            this.BtnSidepanel.Click += new System.EventHandler(this.BtnSidepanel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1297, 804);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "SimpleStudies";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ScMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScMain)).EndInit();
            this.ScMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label LbLTitle;
        private Button BtnSidepanel;
        private SplitContainer ScMain;
        private Views.Sitepanel SpNav;
    }
}