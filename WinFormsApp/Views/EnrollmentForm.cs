using MySql.Data.MySqlClient;
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
    public partial class EnrollmentForm : Form
    {
        Student? student = null;

        public EnrollmentForm(Student std)
        {
            InitializeComponent();
            
            student = std;
            this.label2.Text = student.Surname + " " + student.Sname + " " + student.LastName;
            this.label4.Text = student.GroupName;
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            string[] strings = { "зачислен", "отчислен" };
            statusComboBox.DataSource = strings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var env = new Enrollment();
            env.Reason = statusComboBox.Text;
            env.Edate = dateTimePicker1.Value;

            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                context.Enrollments.Add(env);
                context.SaveChanges();

                using (MySqlConnection connection = new("server=127.0.0.1;uid=root;pwd=12345;database=deans_office"))
                {
                    connection.Open();
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO `deans_office`.`students_enrollments` (`student_id`, `en_id`) VALUES ('" +
                            student.SId.ToString() + "', '" + env.Id.ToString() + "');";
                        command.ExecuteNonQuery();
                    }
                }
            }
            this.Close();
        }
    }
}
