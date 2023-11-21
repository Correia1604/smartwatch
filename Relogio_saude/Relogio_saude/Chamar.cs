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
    public partial class Chamar : Form
    {
        string chamado = "";

        public Chamar()
        {
            InitializeComponent();

            //Estilo botão
            bt_back.FlatAppearance.BorderSize = 0;
        }

        private void Chamar_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
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

        private void label1_Click(object sender, EventArgs e)
        {
            chamado = comboBox1.Text;
            comboBox1.Text = "";
            comboBox2.Text = "";
            label2.Show();
            label3.Show();
            if (chamado.Length > 3)
            {
                if(chamado[2] == 'ª')
                {
                    label2.Text = chamado;
                    label3.Text = " foi chamada!";
                }
                else if(chamado[3] == 'ª')
                {
                    label2.Text = chamado;
                    label3.Text = " foi chamada!";
                } else
                {
                    label2.Text = chamado;
                    label3.Text = " foi chamado!";
                }
            }

        }
    }
}
