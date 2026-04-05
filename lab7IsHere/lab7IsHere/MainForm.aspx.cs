using System;
using System.Linq;
using System.Text.RegularExpressions; 
using System.Collections.Generic;     

namespace lab7IsHere
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string surname = TextBox1.Text.Trim();
            string name = TextBox2.Text.Trim();
            string patronymic = TextBox3.Text.Trim();
            string email = TextBox4.Text.Trim();

            List<string> emptyFields = new List<string>();

            if (string.IsNullOrEmpty(surname)) emptyFields.Add("Прізвище");
            if (string.IsNullOrEmpty(name)) emptyFields.Add("Ім'я");
            if (string.IsNullOrEmpty(patronymic)) emptyFields.Add("По батькові");
            if (string.IsNullOrEmpty(email)) emptyFields.Add("Email");

            if (emptyFields.Count > 0)
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Помилка: Будь ласка, заповніть наступні поля: " + string.Join(", ", emptyFields) + "!";
                return;
            }

            string[] words = { surname, name, patronymic };

            string thirdWord = words[2];

            int surnameLength = surname.Count(char.IsLetter);

            string shortestWord = words.OrderBy(w => w.Length).First();

            bool isEmailValid = false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!string.IsNullOrEmpty(email) && Regex.IsMatch(email, emailPattern))
            {
                isEmailValid = true;
            }

            Label1.ForeColor = System.Drawing.Color.DarkGreen;
            Label1.Text = $"<strong>Третє слово:</strong> {thirdWord} <br/>" +
                          $"<strong>Кількість літер у прізвищі:</strong> {surnameLength} <br/>" +
                          $"<strong>Найкоротше слово:</strong> {shortestWord} <br/>" +
                          $"<strong>Чи є введений текст email адресою?</strong> {(isEmailValid ? "Так, це email" : "Ні, формат некоректний")}";
        }
    }
}