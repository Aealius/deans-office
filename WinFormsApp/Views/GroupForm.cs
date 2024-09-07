using Microsoft.EntityFrameworkCore;
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
    public partial class GroupForm : Form
    {
        List<int> years = Enumerable.Range(DateTime.Now.Year - 15, 16).OrderByDescending(x => x).ToList();
        GroupsOfUni? group = null;
        bool _isNew = true;
        public GroupForm(int index, bool isNew)
        {
            InitializeComponent();
            _isNew = isNew;

            if (!_isNew)
            {
                using (DeansOfficeContext context = new DeansOfficeContext())
                {
                    var groups = context.GroupsOfUnis.ToList();

                    group = groups[index];

                    this.GroupNameTextBox.Text = group.NameOfGroup.ToString();
                    this.SpecialityTextBox.Text = group.Speciality.ToString();



                    // TODO
                    // это индекс если что нужного года
                    var ind = years.IndexOf(group.YearOfCreation);
                    //

                    this.yearComboBox.SelectedItem = group.YearOfCreation;
                }
            }
        }

        private void SaveGroupButton_Click(object sender, EventArgs e)
        {
            using (DeansOfficeContext context = new DeansOfficeContext())
            {
                if (_isNew)
                {
                    GroupsOfUni newGroup = new();
                    newGroup.NameOfGroup = GroupNameTextBox.Text;
                    newGroup.Speciality = SpecialityTextBox.Text;
                    newGroup.YearOfCreation = int.Parse(yearComboBox.SelectedItem.ToString());
                    context.GroupsOfUnis.Add(newGroup);
                    context.SaveChanges();
                }
                else
                {
                    using (MySqlConnection connection = new("server=127.0.0.1;uid=root;pwd=12345;database=deans_office"))
                    {
                        connection.Open();
                        using(MySqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "UPDATE `deans_office`.`groups_of_uni` SET `name_of_group` = '" 
                                + GroupNameTextBox.Text + "', `speciality` = '"
                                + SpecialityTextBox.Text + "', `year_of_creation` = "
                                + yearComboBox.SelectedItem.ToString()
                                + " WHERE (`id` = '" + group.Id.ToString() + "')";
                            command.ExecuteNonQuery();
                        }
                    }
                }
                this.Close();
            }
        }

        private void GroupForm_OnLoad(object sender, EventArgs e)
        {
            yearComboBox.DataSource = years;
        }
    }
}
