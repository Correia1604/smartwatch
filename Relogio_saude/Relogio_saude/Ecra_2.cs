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
    public partial class Ecra_2 : Form
    {

        public Ecra_2()
        {
            InitializeComponent();
        }

        private void Ecra_2_Load(object sender, EventArgs e)
        {

        }

        private void bt_lanterna_Click(object sender, EventArgs e)
        {
            Pag_inicial inicio = new Pag_inicial();
            Ecra_2 ecra_2 = new Ecra_2();

            //Abrir lanterna (função bt lanterna)
            lanterna flash = new lanterna();
            flash.Show();

            inicio.Close();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Fechar form
            this.Close();

            //Voltar a pag inicial
            Pag_inicial inicio = new Pag_inicial();
            inicio.Show();
        }

        private void bt_chamar_Click(object sender, EventArgs e)
        {
            Chamar chamar = new Chamar();

            this.Close();
            chamar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registo_dados registo = new Registo_dados();

            this.Close();
            registo.Show();
        }

    }
}
