using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relogio_saude
{
    public partial class lanterna : Form
    {
        public lanterna()
        {
            InitializeComponent();

            //Estilo botão
            bt_back.FlatAppearance.BorderSize = 0;
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Ecra_2 menu = new Ecra_2();

            //Fecha o form
            this.Close();
            menu.Show();

            //Fonte do botão
            bt_back.Font = new Font("Arial", 16, FontStyle.Bold);
        }

        private void lanterna_Load(object sender, EventArgs e)
        {

        }
    }
}
