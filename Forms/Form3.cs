using Forms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form3 : Form
    {
        WebshopContext context = new WebshopContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Ugyfel uj = new Ugyfel();
            uj.Login = textBoxLogin.Text;
            uj.Email = textBoxEmail.Text;
            uj.Nev = textBoxName.Text;

            context.Ugyfels.Add(uj);
            context.SaveChanges();

            if(this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
            this.Close();

        }

        public bool CheckName(string nev)
        {
            return !string.IsNullOrEmpty(nev);
        }

        public bool CheckEmail(string email)
        {
            Regex r = new Regex("^[a-z0-9]+@[a-z]+\\.[a-z]{2,3}$");
            return r.IsMatch(email);
        }

        private void textBoxLogin_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxLogin, "");
        }

        private void textBoxLogin_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBoxLogin.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxLogin, "A felhasználónév nem lehet üres!");
            };
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxEmail, "");
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckEmail(textBoxEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxEmail, "Érvénytelen e-mail cím");
            };
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, "");
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckName(textBoxName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxName, "A név nem lehet üres");
                
            };
        }
    }
}
