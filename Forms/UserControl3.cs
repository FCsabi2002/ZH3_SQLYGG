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
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();
            KurzusSzures();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KurzusSzures();
        }
        private void KurzusSzures()
        {
            var kurzus = from x in context.Courses
                         where x.Name.Contains(textBox1.Text)
                         select x;

            listBox1.DataSource = kurzus.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kivalaszt = (Course)listBox1.SelectedItem;

            var adatok = from x in context.Lessons
                         where kivalaszt.CourseSk == x.CourseFk
                         select new
                         {
                             Course = x.CourseFkNavigation.Name,
                             Instructor = x.InstructorFkNavigation.Name,
                             Day = x.DayFkNavigation.Name,
                             Time = x.TimeFkNavigation.Name,
                             Room = x.RoomFkNavigation.Name,
                         };

            dataGridView1.DataSource = adatok.ToList();

        }
    }
}
