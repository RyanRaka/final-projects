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
    public partial class FormKelas : Form
    {
        public FormKelas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKelas1 formKelas1 = new FormKelas1();
            formKelas1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKelas2 formKelas2 = new FormKelas2();
            formKelas2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormKelas3 formKelas3 = new FormKelas3();
            formKelas3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormKelas4 formKelas4 = new FormKelas4();
            formKelas4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormKelas5 formKelas5 = new FormKelas5();
            formKelas5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormKelas6 formKelas6 = new FormKelas6();
            formKelas6.Show();
        }
    }
}
