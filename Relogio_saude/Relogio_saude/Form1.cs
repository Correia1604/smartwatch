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
    public partial class Pag_inicial : Form
    {
        public Pag_inicial()
        {
            InitializeComponent();
        }

        private void Pag_inicial_Load(object sender, EventArgs e)
        {
            //Definir horas ecra inicial
            horas.Text = string.Format("{0:HH:mm tt}", DateTime.Now);
            horas.Font = new Font("Arial", 60, FontStyle.Bold);
        }

        private void lb_unlock_Click(object sender, EventArgs e)
        {
            //Import de forms
            Ecra_2 ecra_2_open = new Ecra_2();
            Pag_inicial ecra_1_close = new Pag_inicial();

            //Abrir menu principal do relógio e fechar ecrã de bolqueio
            ecra_2_open.Show();
            this.Close();
        }
    }
}
