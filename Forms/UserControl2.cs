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
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
            lessonBindingSource.DataSource = context.Lessons.ToList();
            courseBindingSource.DataSource = context.Courses.ToList();
            instructorBindingSource.DataSource = context.Instructors.ToList();
            dayBindingSource.DataSource = context.Days.ToList();
            timeBindingSource.DataSource = context.Times.ToList();
            roomBindingSource.DataSource = context.Rooms.ToList();

        }
    }
}
