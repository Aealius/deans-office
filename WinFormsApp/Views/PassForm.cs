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
    public partial class PassForm : Form
    {
        Student _student;
        public PassForm(Student std)
        {
            InitializeComponent();
            _student = std;
            this.label2.Text = _student.Surname + " " + _student.Sname + " " + _student.LastName;
            this.label4.Text = _student.GroupName;
        }

        private void PassForm_Load(object sender, EventArgs e)
        {
            string[] strings = { "заявление", "справка", "неуважительная", "?" };
            PassComboBox.DataSource = strings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pass = new Pass();
            pass.Reason = PassComboBox.Text;
            pass.SkippedDate = dateTimePicker1.Value;

            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                context.Passes.Add(pass);
                context.SaveChanges();

                using (MySqlConnection connection = new("server=127.0.0.1;uid=root;pwd=12345;database=deans_office"))
                {
                    connection.Open();
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "INSERT INTO `deans_office`.`students_passes` (`student_id`, `pass_id`) VALUES ('" +
                            _student.SId.ToString() + "', '" + pass.Id.ToString() + "');";
                        command.ExecuteNonQuery();
                    }
                }
            }
            this.Close();
        }
    }
}
