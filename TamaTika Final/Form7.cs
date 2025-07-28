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
    public partial class FormKelas5 : Form
    {
        public FormKelas5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matematika5 matematika5 = new Matematika5();
            matematika5.Show();
        }
    }
}
