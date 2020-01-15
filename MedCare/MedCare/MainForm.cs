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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MakniButtonHover();
        }

        private void MakniButtonHover()
        {
            btnPocetna.FlatAppearance.MouseOverBackColor = btnPocetna.BackColor;
            btnPocetna.BackColorChanged += (s, e) => {
                btnPocetna.FlatAppearance.MouseOverBackColor = btnPocetna.BackColor;
            };
            btnPacijenti.FlatAppearance.MouseOverBackColor = btnPacijenti.BackColor;
            btnPacijenti.BackColorChanged += (s, e) => {
                btnPacijenti.FlatAppearance.MouseOverBackColor = btnPacijenti.BackColor;
            };
            btnLijekovi.FlatAppearance.MouseOverBackColor = btnLijekovi.BackColor;
            btnLijekovi.BackColorChanged += (s, e) => {
                btnLijekovi.FlatAppearance.MouseOverBackColor = btnLijekovi.BackColor;
            };
            btnLijecnici.FlatAppearance.MouseOverBackColor = btnLijecnici.BackColor;
            btnLijecnici.BackColorChanged += (s, e) => {
                btnLijecnici.FlatAppearance.MouseOverBackColor = btnLijecnici.BackColor;
            };
            btnLogout.FlatAppearance.MouseOverBackColor = btnLogout.BackColor;
            btnLogout.BackColorChanged += (s, e) => {
                btnLogout.FlatAppearance.MouseOverBackColor = btnLogout.BackColor;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            trakica.Height = btnPocetna.Height;
            trakica.Top = btnPocetna.Top;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnPocetna.Font = new Font(btnPocetna.Font.FontFamily, 13, FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnPocetna.Font = new Font(btnPocetna.Font.FontFamily, 11, FontStyle.Bold);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnPacijenti.Font = new Font(btnPacijenti.Font.FontFamily, 13, FontStyle.Bold);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btnPacijenti.Font = new Font(btnPacijenti.Font.FontFamily, 11, FontStyle.Bold);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            btnLijekovi.Font = new Font(btnLijekovi.Font.FontFamily, 13, FontStyle.Bold);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btnLijekovi.Font = new Font(btnLijekovi.Font.FontFamily, 11, FontStyle.Bold);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            btnLijecnici.Font = new Font(btnLijecnici.Font.FontFamily, 13, FontStyle.Bold);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            btnLijecnici.Font = new Font(btnLijecnici.Font.FontFamily, 11, FontStyle.Bold);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.Font = new Font(btnLogout.Font.FontFamily, 13, FontStyle.Bold);

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.Font = new Font(btnLogout.Font.FontFamily, 11, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trakica.Top = btnPacijenti.Top;
            trakica.Height = btnPacijenti.Height;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trakica.Top = btnLijekovi.Top;
            trakica.Height = btnLijekovi.Height;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trakica.Top = btnLijecnici.Top;
            trakica.Height = btnLijecnici.Height;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
