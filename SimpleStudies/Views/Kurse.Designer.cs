namespace SimpleStudies.Views
{
    partial class Kurse
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
            this.LvCourses = new System.Windows.Forms.ListView();
            this.ChId = new System.Windows.Forms.ColumnHeader();
            this.ChName = new System.Windows.Forms.ColumnHeader();
            this.ChDozent = new System.Windows.Forms.ColumnHeader();
            this.ChSemester = new System.Windows.Forms.ColumnHeader();
            this.ChECTS = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbDozent = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.NudSemester = new System.Windows.Forms.NumericUpDown();
            this.NudECTS = new System.Windows.Forms.NumericUpDown();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudECTS)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LvCourses, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 385);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LvCourses
            // 
            this.LvCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChId,
            this.ChName,
            this.ChDozent,
            this.ChSemester,
            this.ChECTS});
            this.LvCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvCourses.FullRowSelect = true;
            this.LvCourses.Location = new System.Drawing.Point(368, 3);
            this.LvCourses.Name = "LvCourses";
            this.LvCourses.Size = new System.Drawing.Size(360, 379);
            this.LvCourses.TabIndex = 0;
            this.LvCourses.UseCompatibleStateImageBehavior = false;
            this.LvCourses.View = System.Windows.Forms.View.Details;
            this.LvCourses.SelectedIndexChanged += new System.EventHandler(this.LvCourses_SelectedIndexChanged);
            // 
            // ChId
            // 
            this.ChId.Text = "Id";
            // 
            // ChName
            // 
            this.ChName.Text = "Name";
            this.ChName.Width = 100;
            // 
            // ChDozent
            // 
            this.ChDozent.Text = "Dozent";
            // 
            // ChSemester
            // 
            this.ChSemester.Text = "Semester";
            // 
            // ChECTS
            // 
            this.ChECTS.Text = "ECTS";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.5F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.CbDozent, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TxtName, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.NudSemester, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.NudECTS, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.BtnCancel, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.BtnEdit, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BtnDisplay, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.16949F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.83051F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(359, 379);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dozent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "ECTS";
            // 
            // CbDozent
            // 
            this.CbDozent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDozent.FormattingEnabled = true;
            this.CbDozent.Location = new System.Drawing.Point(169, 263);
            this.CbDozent.Name = "CbDozent";
            this.CbDozent.Size = new System.Drawing.Size(121, 23);
            this.CbDozent.TabIndex = 7;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(169, 226);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 23);
            this.TxtName.TabIndex = 8;
            // 
            // NudSemester
            // 
            this.NudSemester.Location = new System.Drawing.Point(169, 294);
            this.NudSemester.Name = "NudSemester";
            this.NudSemester.Size = new System.Drawing.Size(120, 23);
            this.NudSemester.TabIndex = 9;
            // 
            // NudECTS
            // 
            this.NudECTS.Location = new System.Drawing.Point(169, 328);
            this.NudECTS.Name = "NudECTS";
            this.NudECTS.Size = new System.Drawing.Size(120, 23);
            this.NudECTS.TabIndex = 10;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(3, 347);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(169, 347);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Abbrechen";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(169, 178);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Ändern";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(3, 178);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "Neu";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(3, 108);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(75, 23);
            this.BtnDisplay.TabIndex = 11;
            this.BtnDisplay.Text = "Anzeigen";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(169, 108);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Löschen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // Kurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Kurse";
            this.Size = new System.Drawing.Size(731, 385);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudECTS)).EndInit();
            this.ResumeLayout(false);

        }

       



        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ColumnHeader columnHeader1;
        private ListView LvCourses;
        private ColumnHeader ChId;
        private ColumnHeader ChName;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Button BtnNew;
        private Button BtnDelete;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox CbDozent;
        private TextBox TxtName;
        private NumericUpDown NudSemester;
        private NumericUpDown NudECTS;
        private Button BtnDisplay;
        private ColumnHeader ChDozent;
        private ColumnHeader ChSemester;
        private ColumnHeader ChECTS;
        private Button BtnSave;
        private Button BtnCancel;
        private Button BtnEdit;
    }
}
