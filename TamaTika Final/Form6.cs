using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TamaTika_NEW;

namespace TamaTika_Final
{
    public partial class FormKelas4 : Form
    {
        public FormKelas4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Matematika4 matematika4 = new Matematika4();
            matematika4.Show();
        }
    }
}
