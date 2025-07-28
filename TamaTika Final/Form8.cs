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
    public partial class FormKelas6 : Form
    {
        public FormKelas6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Matematika6 matematika6 = new Matematika6();
            matematika6.Show();
        }
    }
}
