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
using SimpleStudies.Models;
using SimpleStudies.Models.Enums;

namespace SimpleStudies.Views
{
    public partial class Kurse : UserControl
    {
        private ViewMode mode;
        private Kurs SelectedElement;

        public Kurse()
        {
            InitializeComponent();
            this.Load += Kurse_Load;

            mode = ViewMode.Normal;

            ResetView();
        }

        private void AutoSizeColumnList(ListView listView)
        {
            //Prevents flickering
            listView.BeginUpdate();
            for (int i = 0; i <= listView.Columns.Count - 1; i++)
            {
                listView.Columns[i].Width = -2;
            }

            listView.EndUpdate();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetView();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            LoadCourses();
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
            SelectedElement.Name = TxtName.Text;
            SelectedElement.DozentId = (CbDozent.SelectedItem as Dozent).Id;
            SelectedElement.Semester = (int)NudSemester.Value;
            SelectedElement.ECTS = (int)NudECTS.Value;

            if (mode == ViewMode.Edit)
            {
                KursProvider.Instance.Edit(SelectedElement);
            }
            else if (mode == ViewMode.Create)
            {
                KursProvider.Instance.Add(SelectedElement);
            }

            ResetView();
        }

        private void EnterCreateMode()
        {
            InitEditOrCreate();
            FillFields(new Kurs());
            mode = ViewMode.Create;
        }

        private void EnterEditMode()
        {
            InitEditOrCreate();
            mode = ViewMode.Edit;
        }

        private void FillFields(Kurs data)
        {
            TxtName.Text = data.Name;

            foreach (var doz in CbDozent.Items)
            {
                if ((doz as Dozent).Id == data.DozentId)
                {
                    CbDozent.SelectedItem = doz;
                }
            }

            NudSemester.Value = data.Semester;
            NudECTS.Value = data.ECTS;
        }

        private void InitEditOrCreate()
        {
            BtnSave.Visible = true;
            BtnCancel.Visible = true;

            BtnDisplay.Visible = false;
            BtnDelete.Visible = false;
            BtnEdit.Visible = false;
            BtnNew.Visible = false;

            TxtName.Enabled = true;
            CbDozent.Enabled = true;
            NudSemester.Enabled = true;
            NudECTS.Enabled = true;

            LvCourses.Enabled = false;
        }

        private void Kurse_Load(object sender, EventArgs e)
        {
            LoadDozenten();
        }

        private void LoadCourses()
        {
            LvCourses.Items.Clear();

            var courses = KursProvider.Instance.GetAll();

            foreach (var course in courses)
            {
                var lvItem = new string[] { course.Id.ToString(), course.Name, course.Dozent.Name, course.Semester.ToString(), course.ECTS.ToString() };
                var lv = new BindableListViewItem<Kurs>(lvItem, course);
                lv.Tag = course;

                LvCourses.Items.Add(lv);
            }

            AutoSizeColumnList(LvCourses);
        }

        private void LoadDozenten()
        {
            var dozenten = DozentProvider.Instance.GetAll();
            CbDozent.DisplayMember = "Name";
            CbDozent.ValueMember = "Id";
            CbDozent.Items.AddRange(dozenten.ToArray());
        }

        private void LvCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvCourses.SelectedItems.Count == 0 || LvCourses.SelectedItems[0] == null)
            {
                FillFields(new Kurs());
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                SelectedElement = new Kurs();
                return;
            }

            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            SelectedElement = (LvCourses.SelectedItems[0] as BindableListViewItem<Kurs>).Data;
            FillFields(SelectedElement);
        }

        private void ResetView()
        {
            BtnSave.Visible = false;
            BtnCancel.Visible = false;

            BtnDisplay.Visible = true;
            BtnDelete.Visible = true;
            BtnEdit.Visible = true;
            BtnNew.Visible = true;

            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;

            TxtName.Enabled = false;
            CbDozent.Enabled = false;
            NudSemester.Enabled = false;
            NudECTS.Enabled = false;

            LvCourses.Enabled = true;
            LoadCourses();
        }
    }
}
