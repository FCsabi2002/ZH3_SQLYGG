using Forms.Models;
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
    public partial class UserControl1 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl1()
        {
            InitializeComponent();
            TanarSzures();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TanarSzures();
        }

        private void TanarSzures()
        {
            var tanar = from x in context.Instructors
                        where x.Name.Contains(textBox1.Text)
                        select x;

            listBox1.DataSource = tanar.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kivalasztott = (Instructor)listBox1.SelectedItem;

            var adatok = from x in context.Instructors
                         where x.InstructorSk == kivalasztott.InstructorSk
                         select new Tanar
                         {
                             Name = x.Name,
                             Status = x.StatusFkNavigation.Name,
                             Employement = x.EmployementFkNavigation.Name,
                         };

            tanarBindingSource.DataSource = adatok.ToList();
        }
    }
}
