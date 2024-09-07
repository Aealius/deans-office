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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void EditGroupButton_Click(object sender, EventArgs e)
        {
            var selected = this.GroupListView.FocusedItem;

            if (selected == null)
            {
                return;
            }

            GroupForm groupForm = new GroupForm(selected.Index, false);
            groupForm.FormClosed += SetData; //присваивание ивента окну
            groupForm.ShowDialog();
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            var selected = this.StudentListView.FocusedItem;

            if (selected == null)
            {
                return;
            }

            EnrollmentsWindow enrollmentsWindow = new EnrollmentsWindow(selected.Index);
            enrollmentsWindow.ShowDialog();
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            var selected = this.StudentListView.FocusedItem;

            if (selected == null)
            {
                return;
            }

            PassWindow passWindow = new PassWindow(selected.Index);
            passWindow.ShowDialog();
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            var selected = this.StudentListView.FocusedItem;

            if (selected == null)
            {
                return;
            }

            StudentForm studentForm = new StudentForm(selected.Index, false);
            studentForm.FormClosed += SetData; 
            studentForm.ShowDialog();
        }

        private void PlusGroupButton_Click(object sender, EventArgs e)
        {
            GroupForm group = new GroupForm(0, true);
            group.Tag = this;
            group.FormClosed += SetData; 
            group.ShowDialog();
        }

        private void MinusGroupButton_Click(object sender, EventArgs e)
        {
            var selected = GroupListView.FocusedItem;

            if (selected == null)
            {
                return;
            }

            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                var groups = context.GroupsOfUnis.ToList();
                context.GroupsOfUnis.Remove(groups[selected.Index]);
                context.SaveChanges();
                SetData(null, null);

            }
        }

        private void PlusStudentButton_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm(0, true);
            studentForm.Tag = this;
            studentForm.FormClosed += SetData; //присваивание ивента окну
            studentForm.ShowDialog();

        }

        private void MinusStudentButton_Click(object sender, EventArgs e)
        {
            var selected = StudentListView.FocusedItem;

            if (selected == null)
            {
                return;
            }

            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                var students = context.Students.ToList();
                context.Students.Remove(students[selected.Index]);
                context.SaveChanges();
                SetData(null, null);
            }
        }

        private void MainWindow_OnLoad(object sender, EventArgs e)
        {
            SetData(null, null);
        }

        private void SetData(object sender, EventArgs e)
        {
            StudentListView.Items.Clear();
            GroupListView.Items.Clear();
            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                try
                {
                    foreach (GroupsOfUni groups in context.GroupsOfUnis.ToList())
                    {
                        string[] row = new string[]
                        {
                            groups.NameOfGroup, groups.Speciality, groups.YearOfCreation.ToString()
                        };
                        GroupListView.Items.Add(new ListViewItem(row));
                    }
                    foreach (Student student in context.Students.ToList())
                    {
                        string[] row = new string[]
                        {
                            student.Surname, student.Sname, student.LastName, student.BirthYear.ToString("dd.MM.yyyy"), student.Address.ToString(),
                            student.RecBook.ToString(), student.GroupName.ToString()
                        };
                        StudentListView.Items.Add(new ListViewItem(row));
                    }
                }
                catch (Exception) { }
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
