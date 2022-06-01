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
    public partial class E_Mail_Adressen : UserControl
    {
        private ViewMode mode;
        private Dozent SelectedElement;

        public E_Mail_Adressen()
        {
            InitializeComponent();
            this.Load += E_Mail_Adressen_Load;

            mode = ViewMode.Normal;

            ResetView();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ResetView();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            EnterCreateMode();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EnterEditMode();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SelectedElement.Name = TxtName.Text;
            SelectedElement.Email = TxtMail.Text;

            if (mode == ViewMode.Edit)
            {
                DozentProvider.Instance.Edit(SelectedElement);
            }
            else if (mode == ViewMode.Create)
            {
                DozentProvider.Instance.Add(SelectedElement);
            }

            ResetView();
        }

        private void E_Mail_Adressen_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void EnterCreateMode()
        {
            InitEditOrCreate();
            FillFields(new Dozent());
            mode = ViewMode.Create;
        }

        private void EnterEditMode()
        {
            InitEditOrCreate();
            mode = ViewMode.Edit;
        }

        private void FillFields(Dozent dozent)
        {
            TxtName.Text = dozent.Name;
            TxtMail.Text = dozent.Email;
        }

        private void InitEditOrCreate()
        {
            BtnSave.Visible = true;
            BtnCancel.Visible = true;

            BtnRefresh.Visible = false;
            BtnDelete.Visible = false;
            BtnEdit.Visible = false;
            BtnCreate.Visible = false;

            TxtName.Enabled = true;
            TxtMail.Enabled = true;

            LvLecturer.Enabled = false;
        }

        private void LoadData()
        {
            LvLecturer.Items.Clear();

            var lecturers = DozentProvider.Instance.GetAll();

            foreach (var lecturer in lecturers)
            {
                var lvItem = new string[] { lecturer.Id.ToString(), lecturer.Name, lecturer.Email };
                var lv = new BindableListViewItem<Dozent>(lvItem, lecturer);

                LvLecturer.Items.Add(lv);
            }

            LvLecturer.AutoSizeColumnList();
        }

        private void LvLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LvLecturer.SelectedItems.Count == 0 || LvLecturer.SelectedItems[0] == null)
            {
                FillFields(new Dozent());
                BtnEdit.Enabled = false;
                BtnDelete.Enabled = false;
                SelectedElement = new Dozent();
                return;
            }

            BtnEdit.Enabled = true;
            BtnDelete.Enabled = true;
            SelectedElement = (LvLecturer.SelectedItems[0] as BindableListViewItem<Dozent>).Data;
            FillFields(SelectedElement);
        }

        private void ResetView()
        {
            BtnSave.Visible = false;
            BtnCancel.Visible = false;

            BtnRefresh.Visible = true;
            BtnDelete.Visible = true;
            BtnEdit.Visible = true;
            BtnCreate.Visible = true;

            BtnEdit.Enabled = false;
            BtnDelete.Enabled = false;

            TxtName.Enabled = false;
            TxtMail.Enabled = false;

            LvLecturer.Enabled = true;
            LoadData();
        }
    }
}
