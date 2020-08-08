using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystemApp
{
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }
        int edit = 0;
        public virtual void addBtn_Click(object sender, EventArgs e)
        {
            MainProgram.resetEnable(leftPanel);
            edit = 0;
        }

        public virtual void editBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainProgram.controlEnable(leftPanel);
        }

        public virtual void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public virtual void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
