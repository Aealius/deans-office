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
    public partial class StudentForm : Form
    {
        Student? student = null;
        bool _isNew = true;
        public StudentForm(int index, bool isNew)
        {
            InitializeComponent();

            _isNew = isNew;

            if (!_isNew)
            {
                using (DeansOfficeContext context = new DeansOfficeContext())
                {
                    var students = context.Students.ToList();

                    student = students[index];

                    this.StudentNameTextBox.Text = student.Sname.ToString();
                    this.StudentLastNameTextBox.Text = student.LastName.ToString();
                    this.StudentSurnameTextBox.Text = student.Surname.ToString();
                    this.BirthYearDateTimePicker.Value = student.BirthYear;
                    this.AddressTextBox.Text = student.Address.ToString();
                    this.RecBookTextBox.Text = student.RecBook.ToString();



                    // TODO
                    // группу присвоить
                    //
                }
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            using (DeansOfficeContext context = new())
            {
                var listOfGroups = context.GroupsOfUnis.ToList();

                var listOfGrNames = new List<string>();

                foreach (var group in listOfGroups)
                {
                    listOfGrNames.Add(group.NameOfGroup);
                }

                StudentGroupComboBox.DataSource = listOfGrNames;

                //StudentGroupComboBox.DisplayMember = "NameOfGroup";

                //StudentGroupComboBox.ValueMember = "Id";
            }
        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                if (_isNew)
                {
                    Student newStudent = new();
                    newStudent.Sname = StudentNameTextBox.Text;
                    newStudent.Surname = StudentSurnameTextBox.Text;
                    newStudent.LastName = StudentLastNameTextBox.Text;
                    newStudent.Address = AddressTextBox.Text;
                    newStudent.RecBook = RecBookTextBox.Text;
                    newStudent.BirthYear = BirthYearDateTimePicker.Value;
                   
                    newStudent.GroupName = StudentGroupComboBox.SelectedItem.ToString();

                    context.Students.Add(newStudent);
                    context.SaveChanges();
                }
                else
                {
                    student.Sname = StudentNameTextBox.Text;
                    student.Surname = StudentSurnameTextBox.Text;
                    student.LastName = StudentLastNameTextBox.Text;
                    student.Address = AddressTextBox.Text;
                    student.RecBook = RecBookTextBox.Text;
                    student.BirthYear = BirthYearDateTimePicker.Value;
                    student.GroupName = StudentGroupComboBox.SelectedItem.ToString();

                    ///dfdfdfassssssssssssssssssss

                    context.Students.Update(student);
                    context.SaveChanges();
                }
                this.Close();
            }
        }
    }
}
