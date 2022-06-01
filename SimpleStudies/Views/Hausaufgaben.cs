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
    public partial class Hausaufgaben : UserControl
    {
        private ViewMode mode;
        private Hausaufgabe SelectedElement;

        public Hausaufgaben()
        {
            InitializeComponent();

            this.Load += Hausaufgaben_Load;

            mode = ViewMode.Normal;

            ResetView();
            FillStatus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetView();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            LoadHomework();
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
            SelectedElement.KursId = (CbCourses.SelectedItem as Kurs).Id;
            SelectedElement.StatusId = CbStatus.SelectedIndex;
            SelectedElement.Beschreibung = TxtDescription.Text;
            SelectedElement.Notizen = TxtNotes.Text;
            SelectedElement.Deadline = GetNullableDtpValue(DtpDeadline);
            SelectedElement.GeplantAm = GetNullableDtpValue(DtpPlannedAt);

            if (mode == ViewMode.Edit)
            {
                HausaufgabeProvider.Instance.Edit(SelectedElement);
            }
            else if (mode == ViewMode.Create)
            {
                HausaufgabeProvider.Instance.Add(SelectedElement);
            }

            ResetView();
        }

        private void CbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedElement == null)
            {
                return;
            }

            SelectedElement.StatusId = CbStatus.SelectedIndex;
        }

        private void EnterCreateMode()
        {
            InitEditOrCreate();
            FillFields(new Hausaufgabe());
            SelectedElement = new Hausaufgabe();
            mode = ViewMode.Create;
        }

        private void EnterEditMode()
        {
            InitEditOrCreate();
            mode = ViewMode.Edit;
        }

        private void FillFields(Hausaufgabe selectedElement)
        {
            TxtDescription.Text = selectedElement.Beschreibung;
            TxtNotes.Text = selectedElement.Notizen;

            DtpDeadline.Value = selectedElement.Deadline ?? DtpDeadline.MinDate;
            DtpPlannedAt.Value = selectedElement.GeplantAm ?? DtpPlannedAt.MinDate;

            CbStatus.SelectedIndex = selectedElement.StatusId;

            foreach (var course in CbCourses.Items)
            {
                if ((course as Kurs).Id == selectedElement.KursId)
                {
                    CbCourses.SelectedItem = course;
                }
            }
        }

        private void FillStatus()
        {
            CbStatus.Items.Clear();
            CbStatus.Items.Add("");
            CbStatus.Items.Add("ToDo");
            CbStatus.Items.Add("In Bearbeitung");
            CbStatus.Items.Add("Abgeschlossen");
        }

        private DateTime? GetNullableDtpValue(DateTimePicker dtp)
        {
            return (dtp.Checked && dtp.Value != dtp.MinDate) ? (DateTime?)dtp.Value : null;
        }

        private void Hausaufgaben_Load(object? sender, EventArgs e)
        {
            // Use ValueChanged to decide if the value should be displayed:
            DtpDeadline.ValueChanged += (s, e) => { DtpDeadline.CustomFormat = (DtpDeadline.Checked && DtpDeadline.Value != DtpDeadline.MinDate) ? "dd.MM.yyyy" : " "; };
            DtpPlannedAt.ValueChanged += (s, e) => { DtpPlannedAt.CustomFormat = (DtpPlannedAt.Checked && DtpPlannedAt.Value != DtpPlannedAt.MinDate) ? "dd.MM.yyyy" : " "; };

            LoadKurse();
        }

        private void InitEditOrCreate()
        {
            BtnSave.Visible = true;
            BtnCancel.Visible = true;

            BtnDisplay.Visible = false;
            BtnDelete.Visible = false;
            BtnEdit.Visible = false;
            BtnNew.Visible = false;

            CbCourses.Enabled = true;
            CbStatus.Enabled = true;
            TxtDescription.Enabled = true;
            TxtNotes.Enabled = true;
            DtpDeadline.Enabled = true;
            DtpPlannedAt.Enabled = true;

            LvHomework.Enabled = false;
        }

        private void LoadHomework()
        {
            LvHomework.Items.Clear();

            var homeworks = HausaufgabeProvider.Instance.GetAll();

            foreach (var homework in homeworks)
            {
                var lvItem = new string[] { homework.Kurs.Name, homework.Beschreibung, homework.StatusId.ToString(), homework.Deadline?.ToString(), homework.GeplantAm?.ToString(), homework.Notizen };
                var lv = new BindableListViewItem<Hausaufgabe>(lvItem, homework);

                LvHomework.Items.Add(lv);
            }

            LvHomework.AutoSizeColumnList();
        }

        private void LoadKurse()
        {
            var courses = KursProvider.Instance.GetAll();
            CbCourses.DisplayMember = "Name";
            CbCourses.ValueMember = "Id";
            CbCourses.Items.AddRange(courses.ToArray()); ;
        }

        private void LvHomework_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvHomework.SelectedItems.Count == 0 || LvHomework.SelectedItems[0] == null)
            {
                FillFields(new Hausaufgabe());
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                SelectedElement = new Hausaufgabe();
                return;
            }

            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            SelectedElement = (LvHomework.SelectedItems[0] as BindableListViewItem<Hausaufgabe>).Data;
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

            CbCourses.Enabled = false;
            CbStatus.Enabled = false;
            TxtDescription.Enabled = false;
            TxtNotes.Enabled = false;
            DtpDeadline.Enabled = false;
            DtpPlannedAt.Enabled = false;

            LvHomework.Enabled = true;
            LoadHomework();
        }
    }
}
