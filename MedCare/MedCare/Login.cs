using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Focus();
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
        }
    }
}
