using Forms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form2 : Form
    {
        WebshopContext context = new WebshopContext();
        public Form2()
        {
            InitializeComponent();
            Listazas();
        }

        public void Listazas()
        {
            var felhasznalok = from x in context.Ugyfels
                               select new Ugyfelek
                               {
                                   Login = x.Login,
                                   Email = x.Email,
                                   Name = x.Nev,
                               };
            ugyfelekBindingSource.DataSource = felhasznalok.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var id = ((Ugyfelek)ugyfelekBindingSource.Current).Login;

            var torlendo = (from x in context.Ugyfels
                            where x.Login == id
                            select x).FirstOrDefault();

            if (MessageBox.Show("Bizosan törölni szeretne?", "Megerősítés", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                context.Ugyfels.Remove(torlendo);
                context.SaveChanges();
                Listazas();

            }

          

        }
    }
}
