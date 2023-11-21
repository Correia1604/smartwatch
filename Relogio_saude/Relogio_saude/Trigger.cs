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
    public partial class Trigger : Form
    {
        private string lastOpenedFormName = "";

        //Import Forms
        Pag_inicial inicio = new Pag_inicial();
        Ecra_2 menu = new Ecra_2();
        lanterna flash = new lanterna();
        Registo_dados registo = new Registo_dados();


        public Trigger()
        {
            InitializeComponent();
        }

        private void Trigger_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Import do form inicial
            Pag_inicial inicio = new Pag_inicial();
            inicio.Show();
        }

        private void bt_higiene_Click(object sender, EventArgs e)
        {
            // Check if any of the specified forms is open and close it
            lastOpenedFormName = CloseFormIfOpen<Pag_inicial>() ??
                                 CloseFormIfOpen<Ecra_2>() ??
                                 CloseFormIfOpen<lanterna>() ??
                                 CloseFormIfOpen<Registo_dados>() ??
                                 CloseFormIfOpen<Alarme_paciente>() ??
                                 CloseFormIfOpen<Alarme_medicacao>();

            // Update label with the last opened form name
            label1.Text = lastOpenedFormName;

            Alarme_higiene alarme_higiene = new Alarme_higiene(label1.Text);
            alarme_higiene.Show();
        }

        private string CloseFormIfOpen<T>() where T : Form
        {
            string formName = null;

            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == typeof(T) && !openForm.IsDisposed)
                {
                    formName = openForm.Name;
                    openForm.Close();
                    break; // Assuming you want to close only one instance if there are multiple
                }
            }

            return formName;
        }

        private void bt_medicacao_Click(object sender, EventArgs e)
        {
            // Check if any of the specified forms is open and close it
            lastOpenedFormName = CloseFormIfOpen<Pag_inicial>() ??
                                 CloseFormIfOpen<Ecra_2>() ??
                                 CloseFormIfOpen<lanterna>() ??
                                 CloseFormIfOpen<Registo_dados>() ??
                                 CloseFormIfOpen<Alarme_paciente>() ??
                                 CloseFormIfOpen<Alarme_higiene>();

            // Update label with the last opened form name
            label1.Text = lastOpenedFormName;

            Alarme_medicacao alarme_medicacao = new Alarme_medicacao(label1.Text);
            alarme_medicacao.Show();
        }

        private void bt_paciente_Click(object sender, EventArgs e)
        {
            // Check if any of the specified forms is open and close it
            lastOpenedFormName = CloseFormIfOpen<Pag_inicial>() ??
                                 CloseFormIfOpen<Ecra_2>() ??
                                 CloseFormIfOpen<lanterna>() ??
                                 CloseFormIfOpen<Registo_dados>() ??
                                 CloseFormIfOpen<Alarme_medicacao>() ??
                                 CloseFormIfOpen<Alarme_higiene>();

            // Update label with the last opened form name
            label1.Text = lastOpenedFormName;

            Alarme_paciente alarme_paciente = new Alarme_paciente(label1.Text);
            alarme_paciente.Show();
        }
    }

}
