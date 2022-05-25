namespace SimpleStudies.Views
{
    partial class LernplanHinzufügen
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
            this.textThema = new System.Windows.Forms.TextBox();
            this.textDatum = new System.Windows.Forms.TextBox();
            this.textZeit = new System.Windows.Forms.TextBox();
            this.textAbgabedatum = new System.Windows.Forms.TextBox();
            this.buttonAdd2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textThema
            // 
            this.textThema.Location = new System.Drawing.Point(53, 199);
            this.textThema.Multiline = true;
            this.textThema.Name = "textThema";
            this.textThema.PlaceholderText = "Thema:";
            this.textThema.Size = new System.Drawing.Size(573, 146);
            this.textThema.TabIndex = 11;
            // 
            // textDatum
            // 
            this.textDatum.Location = new System.Drawing.Point(53, 32);
            this.textDatum.Name = "textDatum";
            this.textDatum.PlaceholderText = "Datum:";
            this.textDatum.Size = new System.Drawing.Size(179, 27);
            this.textDatum.TabIndex = 12;
            // 
            // textZeit
            // 
            this.textZeit.Location = new System.Drawing.Point(53, 84);
            this.textZeit.Name = "textZeit";
            this.textZeit.PlaceholderText = "Zeit:";
            this.textZeit.Size = new System.Drawing.Size(179, 27);
            this.textZeit.TabIndex = 13;
            // 
            // textAbgabedatum
            // 
            this.textAbgabedatum.Location = new System.Drawing.Point(53, 133);
            this.textAbgabedatum.Name = "textAbgabedatum";
            this.textAbgabedatum.PlaceholderText = "Abgabedatum:";
            this.textAbgabedatum.Size = new System.Drawing.Size(180, 27);
            this.textAbgabedatum.TabIndex = 14;
            // 
            // buttonAdd2
            // 
            this.buttonAdd2.Location = new System.Drawing.Point(678, 381);
            this.buttonAdd2.Name = "buttonAdd2";
            this.buttonAdd2.Size = new System.Drawing.Size(110, 38);
            this.buttonAdd2.TabIndex = 15;
            this.buttonAdd2.Text = "Add";
            this.buttonAdd2.UseVisualStyleBackColor = true;
            this.buttonAdd2.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // LernplanHinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd2);
            this.Controls.Add(this.textAbgabedatum);
            this.Controls.Add(this.textZeit);
            this.Controls.Add(this.textDatum);
            this.Controls.Add(this.textThema);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "LernplanHinzufügen";
            this.Text = "LernplanHinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textThema;
        private TextBox textDatum;
        private TextBox textZeit;
        private TextBox textAbgabedatum;
        private Button buttonAdd2;
    }
}