using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relogio_saude
{
    public partial class Alarme_medicacao : Form
    {
        // Obtém o primeiro formulário aberto (você pode personalizar isso conforme necessário)
        //Form formularioAberto = Application.OpenForms[1];

        Pag_inicial inicio = new Pag_inicial();
        Ecra_2 menu = new Ecra_2();
        lanterna flash = new lanterna();
        Registo_dados registo = new Registo_dados();

        string form_aberto;

        public Alarme_medicacao(string text)
        {
            InitializeComponent();
            form_aberto = text;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (form_aberto == "Pag_inicial")
            {
                this.Close();
                inicio.Show();
            }
            else if (form_aberto == "Ecra_2")
            {
                this.Close();
                menu.Show();
            }
            else if (form_aberto == "lanterna")
            {
                this.Close();
                flash.Show();
            }
            else if (form_aberto == "Registo_dados")
            {
                this.Close();
                registo.Show();
            }
            else if (form_aberto == "Alarme_higiene")
            {
                this.Close();
                inicio.Show();
            }
            else if (form_aberto == "Alarme_paciente")
            {
                this.Close();
                inicio.Show();
            }
        }

        private void Alarme_medicacao_Load(object sender, EventArgs e)
        {

        }
    }
}
