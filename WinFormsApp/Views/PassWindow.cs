using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.DeansOfficeData;

namespace WinFormsApp.Views
{
    public partial class PassWindow : Form
    {
        Student? student = null;

        public PassWindow(int index)
        {
            InitializeComponent();

            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                var students = context.Students.Include(student => student.Passes).ToList();

                student = students[index];

                this.label2.Text = student.Surname + " " + student.Sname + " " + student.LastName;
                this.label4.Text = student.GroupName;

                var passes = student.Passes.ToList();

                var passesList = new List<string>();
                foreach (var item in passes)
                {
                    string[] row = new string[]
                        {
                            item.SkippedDate.ToString("dd.MM.yyyy"),item.Reason
                        };

                    StudentPassesListView.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void PlusPassButton_Click(object sender, EventArgs e)
        {
            var selected = StudentPassesListView.FocusedItem;

            PassForm passForm = new PassForm(student);
            passForm.FormClosed += updateData; //присваивание ивента окну
            passForm.ShowDialog();
        }

        private void updateData(object sender, EventArgs e)
        {
            StudentPassesListView.Items.Clear();
            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                var stud = context.Students.Include(s => s.Passes).First(s => s.SId == student.SId);
                var passes = stud.Passes.ToList();

                var passesList = new List<string>();
                foreach (var item in passes)
                {
                    string[] row = new string[]
                        {
                            item.SkippedDate.ToString("dd.MM.yyyy"),item.Reason
                        };

                    StudentPassesListView.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void MinusPassButton_Click(object sender, EventArgs e)
        {
            var selected = StudentPassesListView.FocusedItem;

            if (selected == null)
            {
                return;
            }

            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                var stud = context.Students.Include(s => s.Passes).First(s => s.SId == student.SId);
                var passes = stud.Passes.ToList();

                var delPass = passes[selected.Index];

                context.Remove(delPass);
                context.SaveChanges();
            }

            updateData(null, null);
        }
    }
}
