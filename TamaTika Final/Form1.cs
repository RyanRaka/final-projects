using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TamaTika_Final
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            
            progressBar1.Value = 0;
            progressBar1.Maximum = 300;

        
            for (int i = 0; i <= 300; i += 30)
            {
                progressBar1.Value = i;
                await Task.Delay(300); 
            }

         
            FormKelas formKelas = new FormKelas();
            formKelas.Show();
        }


    }
}
