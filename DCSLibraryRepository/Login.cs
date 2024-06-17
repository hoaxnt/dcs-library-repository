using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace DCSLibraryRepository
{
    public partial class LoginForm : MaterialForm
    {
        private string path = @"C:\ProgramData\DCSlogs";
        private string logfile = "accs.txt";
        

        public LoginForm()
        {
            this.MaximizeBox = false;

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green700, TextShade.WHITE);
        }

        private void ShowPasswordPressed(object sender, EventArgs e)
        {
            PasswordField.UseSystemPasswordChar = false;
        }

        private void LoginPressed(object sender, EventArgs e)
        {
            ValidateCredentials(UsernameField.Text, PasswordField.Text);
        }

        private bool ValidateCredentials(string username, string password)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(logfile))
            {
                File.Create(logfile);
            }

            string[] accounts = File.ReadAllLines(Path.Combine(path, logfile));
            foreach (string account in accounts)
            {
                string[] credentials = account.Split(':');
                if (credentials[0] == username && credentials[1] == password)
                {
                    //Scan info here
                    InvalidLabel.Visible = false;
                    //////
                    return true;
                }
            }
            InvalidLabel.Visible = true;
            return false;
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            
        }
    }
}