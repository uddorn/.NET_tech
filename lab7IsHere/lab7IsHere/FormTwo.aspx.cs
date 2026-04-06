using System;
using System.IO;
using System.Web.UI;
using System.Xml.Linq;

namespace lab7IsHere
{
    public partial class FormTwo : System.Web.UI.Page
    {
        private const int MaxAttempts = 3;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["Attempts"] = 0;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int attempts = (int)(ViewState["Attempts"] ?? 0);

            string loginFilePath = Server.MapPath("~/Login.txt");
            string passFilePath = Server.MapPath("~/Pass.txt");
            string dataFilePath = Server.MapPath("~/Userdata.txt");

            if (!File.Exists(loginFilePath) || !File.Exists(passFilePath))
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Помилка сервера: Файли login.txt або pass.txt не знайдені!";
                return;
            }

            string validLogin = File.ReadAllText(loginFilePath).Trim();
            string validPass = File.ReadAllText(passFilePath).Trim();

            string userLogin = txtLogin.Text.Trim();
            string userPass = txtPassword.Text;

            if (userLogin == validLogin && userPass == validPass)
            {
                string userData = $"Дата: {DateTime.Now}, Прізвище: {txtSurname.Text}, Ім'я: {txtName.Text}{Environment.NewLine}";

                File.AppendAllText(dataFilePath, userData);

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Реєстрація успішно завершена! Дані збережено.";

                ViewState["Attempts"] = 0;
            }
            else
            {
                attempts++;
                ViewState["Attempts"] = attempts;
                lblMessage.ForeColor = System.Drawing.Color.Red;

                if (attempts >= MaxAttempts)
                {
                    lblMessage.Text = "Перевищено ліміт спроб! Форму заблоковано.";
                    btnSubmit.Enabled = false;
                }
                else
                {
                    lblMessage.Text = $"Невірний логін або пароль! Залишилось спроб: {MaxAttempts - attempts}";
                }
            }
        }
    }
}