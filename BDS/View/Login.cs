using BDS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f = new Home();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void uttonCadastrodeUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastroUs f = new CadastroUs();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
