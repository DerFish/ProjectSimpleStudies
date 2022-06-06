using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleStudies.Data.Entities;
using SimpleStudies.Data.Providers;
using SimpleStudies.Extensions;
using SimpleStudies.Models;
using SimpleStudies.Models.Enums;

namespace SimpleStudies.Views
{
    public partial class Notenübersicht : UserControl, IView
    {
        private ViewMode mode;
        private Note SelectedElement;

        public Notenübersicht()
        {
            InitializeComponent();

            InitCbs();
            ResetView();
        }

        public int Semester { get; set; }

        public void ResetView()
        {
            BtnSave.Visible = false;
            BtnCancel.Visible = false;

            BtnDisplay.Visible = true;
            BtnDelete.Visible = true;
            BtnEdit.Visible = true;
            BtnNew.Visible = true;

            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;

            cbType.Enabled = false;
            cbCourse.Enabled = false;
            NudGrade.Enabled = false;

            lvGrades.Enabled = true;
            LoadGrades();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetView();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EnterEditMode();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            EnterCreateMode();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SelectedElement.Typ = cbType.Text;
            SelectedElement.KursId = (cbCourse.SelectedItem as Kurs).Id;
            SelectedElement.EndNote = NudGrade.Value;

            if (mode == ViewMode.Edit)
            {
                NoteProvider.Instance.Edit(SelectedElement);
            }
            else if (mode == ViewMode.Create)
            {
                NoteProvider.Instance.Add(SelectedElement);
            }

            ResetView();
        }

        private void EnterCreateMode()
        {
            InitEditOrCreate();
            FillFields(new Note());
            SelectedElement = new Note();
            mode = ViewMode.Create;
        }

        private void EnterEditMode()
        {
            InitEditOrCreate();
            mode = ViewMode.Edit;
        }

        private void FillFields(Note note)
        {
            cbType.Text = note.Typ;

            foreach (var course in cbCourse.Items)
            {
                if ((course as Kurs).Id == note.KursId)
                {
                    cbCourse.SelectedItem = course;
                }
            }

            NudGrade.Value = note.EndNote;
        }

        private void InitCbs()
        {
            cbType.Items.Clear();
            cbType.Items.AddRange(new string[] { "Klausur", "Präsentation" });

            var courses = KursProvider.Instance.GetAll(Semester);
            cbCourse.DisplayMember = "Name";
            cbCourse.ValueMember = "Id";
            cbCourse.Items.AddRange(courses.ToArray()); ;
        }

        private void InitEditOrCreate()
        {
            BtnSave.Visible = true;
            BtnCancel.Visible = true;

            BtnDisplay.Visible = false;
            BtnDelete.Visible = false;
            BtnEdit.Visible = false;
            BtnNew.Visible = false;

            cbCourse.Enabled = true;
            cbType.Enabled = true;
            NudGrade.Enabled = true;

            lvGrades.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvGrades.SelectedItems.Count == 0 || lvGrades.SelectedItems[0] == null)
            {
                FillFields(new Note());
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                SelectedElement = new Note();
                return;
            }

            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            SelectedElement = (lvGrades.SelectedItems[0] as BindableListViewItem<Note>).Data;
            FillFields(SelectedElement);
        }

        private void LoadGrades()
        {
            lvGrades.Items.Clear();

            var grades = NoteProvider.Instance.GetAll(Semester);

            foreach (var grade in grades)
            {
                var lvItem = new string[] { grade.Kurs.Name, grade.Typ, grade.EndNote.ToString() };
                var lv = new BindableListViewItem<Note>(lvItem, grade);

                lvGrades.Items.Add(lv);
            }

            lvGrades.AutoSizeColumnList();
        }
    }
}
