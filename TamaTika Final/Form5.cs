using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamaTika_Final
{
    public partial class FormKelas3 : Form
    {
        public FormKelas3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matematika3 matematika3 = new Matematika3();
            matematika3.Show();
        }
    }
}
