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
            this.CbDozent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.NudSemester = new System.Windows.Forms.NumericUpDown();
            this.NudECTS = new System.Windows.Forms.NumericUpDown();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.41414F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.58586F));
            this.tableLayoutPanel1.Controls.Add(this.LvCourses, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.LvCourses.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LvCourses.FullRowSelect = true;
            this.LvCourses.Location = new System.Drawing.Point(305, 3);
            this.LvCourses.Name = "LvCourses";
            this.LvCourses.Size = new System.Drawing.Size(423, 379);
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
            this.tableLayoutPanel2.Controls.Add(this.CbDozent, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.TxtName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.NudSemester, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.NudECTS, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.BtnNew, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnDisplay, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnCancel, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnSave, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnEdit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 379);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // CbDozent
            // 
            this.CbDozent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CbDozent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDozent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbDozent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbDozent.FormattingEnabled = true;
            this.CbDozent.Location = new System.Drawing.Point(140, 123);
            this.CbDozent.Name = "CbDozent";
            this.CbDozent.Size = new System.Drawing.Size(153, 33);
            this.CbDozent.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dozent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "ECTS";
            // 
            // TxtName
            // 
            this.TxtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtName.Location = new System.Drawing.Point(140, 83);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(153, 33);
            this.TxtName.TabIndex = 8;
            // 
            // NudSemester
            // 
            this.NudSemester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NudSemester.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NudSemester.Location = new System.Drawing.Point(140, 163);
            this.NudSemester.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudSemester.Name = "NudSemester";
            this.NudSemester.Size = new System.Drawing.Size(153, 33);
            this.NudSemester.TabIndex = 9;
            this.NudSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudECTS
            // 
            this.NudECTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NudECTS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NudECTS.Location = new System.Drawing.Point(140, 203);
            this.NudECTS.Name = "NudECTS";
            this.NudECTS.Size = new System.Drawing.Size(153, 33);
            this.NudECTS.TabIndex = 10;
            // 
            // BtnNew
            // 
            this.BtnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNew.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNew.Location = new System.Drawing.Point(3, 43);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(131, 34);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "Neu";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDisplay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDisplay.Location = new System.Drawing.Point(3, 3);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(131, 34);
            this.BtnDisplay.TabIndex = 11;
            this.BtnDisplay.Text = "Anzeigen";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(140, 243);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(153, 34);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Abbrechen";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(3, 243);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(131, 34);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Speichern";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(140, 43);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(153, 34);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Löschen";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEdit.Location = new System.Drawing.Point(140, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(153, 34);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Ändern";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
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
        private Button BtnNew;
        private Button BtnDelete;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
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
        private ComboBox CbDozent;
    }
}
