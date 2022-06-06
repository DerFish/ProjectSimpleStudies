namespace SimpleStudies.Views
{
    partial class NewsFeed
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
            this.FlpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // FlpMain
            // 
            this.FlpMain.AutoScroll = true;
            this.FlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlpMain.Location = new System.Drawing.Point(0, 0);
            this.FlpMain.Name = "FlpMain";
            this.FlpMain.Size = new System.Drawing.Size(1100, 630);
            this.FlpMain.TabIndex = 0;
            // 
            // NewsFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.FlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewsFeed";
            this.Size = new System.Drawing.Size(1100, 630);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel FlpMain;
    }
}