using WinFormsApp.DeansOfficeData;
using WinFormsApp.Views;

namespace WinFormsApp
{
    public partial class LoginForm : Form
    {


        public LoginForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string logStr = LoginTextBox.Text;
            string pwdStr = PwdTextBox.Text;
            using (DeansOfficeContext deansOfficeContext = new())
            {
                var user = deansOfficeContext.Users.FirstOrDefault(x => x.UserName == logStr && x.UserPass == pwdStr);
                if (user != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Hide();
                }
            }

        }
    }
}