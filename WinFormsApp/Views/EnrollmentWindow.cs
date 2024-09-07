using Microsoft.EntityFrameworkCore;
using WinFormsApp.DeansOfficeData;

namespace WinFormsApp.Views
{
    public partial class EnrollmentsWindow : Form
    {
        Student? student = null;

        public EnrollmentsWindow(int index)
        {
            InitializeComponent();

            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                var students = context.Students.Include(student => student.Ens).ToList();

                student = students[index];

                this.label2.Text = student.Surname + " " + student.Sname + " " + student.LastName;
                this.label4.Text = student.GroupName;

                var enses = student.Ens.ToList();



                var EnsesList = new List<string>();
                foreach (var item in enses)
                {
                    string[] row = new string[]
                        {
                            item.Edate.ToString("dd.MM.yyyy"),item.Reason
                        };

                    StudentStatusesListView.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void updateData(object sender, EventArgs e)
        {
            StudentStatusesListView.Items.Clear();
            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                var stud = context.Students.Include(s => s.Ens).First(s => s.SId == student.SId);
                var enses = stud.Ens.ToList();

                var EnsesList = new List<string>();
                foreach (var item in enses)
                {
                    string[] row = new string[]
                        {
                            item.Edate.ToString("dd.MM.yyyy"),item.Reason
                        };

                    StudentStatusesListView.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void PlusEnrollmentButton_Click(object sender, EventArgs e)
        {
            EnrollmentForm enrollmentForm = new EnrollmentForm(student);
            enrollmentForm.FormClosed += updateData;
            enrollmentForm.ShowDialog();
        }

        private void MinusEnrollmentButton_Click(object sender, EventArgs e)
        {
            var selected = StudentStatusesListView.FocusedItem;

            if (selected == null)
            {
                return;
            }

            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                var stud = context.Students.Include(s => s.Ens).First(s => s.SId == student.SId);
                var enses = stud.Ens.ToList();

                var delEns = enses[selected.Index];

                context.Remove(delEns);
                context.SaveChanges();
            }

            updateData(null, null);
        }
    }
}
