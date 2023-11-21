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
    public partial class Registo_dados : Form
    {
        private TextBox[] textBoxes;
        private Button[] numberButtons;

        private int selectedTextBoxIndex = 0;

        public Registo_dados()
        {
            InitializeComponent();

            // Estilo botão
            bt_back.FlatAppearance.BorderSize = 0;

            InitializeTextBoxArray(); // Move this here
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Assuming you already have your TextBoxes and Buttons created
            // ...

            // Assuming you have already declared buttons named bt0, bt1, ..., bt9
            numberButtons = new Button[] { bt0, bt1, bt2, bt3, bt4, bt5, bt6, bt7, bt8, bt9 };

            // Attach the event handler (Control_Click) to each textbox and button
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Click += Control_Click;
            }

            foreach (Button button in numberButtons)
            {
                button.Click += Control_Click;
            }
        }

        private void InitializeTextBoxArray()
        {
            // Initialize the textBoxes array with the TextBox instances
            textBoxes = new TextBox[] { txt_temp, txt_pa_1, txt_pa_2, txt_sat, txt_glic, txt_dor };
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                // Clicked on a TextBox
                TextBox clickedTextBox = (TextBox)sender;
                int index = Array.IndexOf(textBoxes, clickedTextBox);

                if (index >= 0)
                {
                    selectedTextBoxIndex = index;
                }
            }
            else if (sender is Button)
            {
                // Clicked on a Button
                Button clickedButton = (Button)sender;

                // Append the clicked number to the text of the selected TextBox
                textBoxes[selectedTextBoxIndex].Text += clickedButton.Text;
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            Ecra_2 menu = new Ecra_2();

            // Fecha o form
            this.Close();
            menu.Show();

            // Fonte do botão
            bt_back.Font = new Font("Arial", 16, FontStyle.Bold);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Registo_dados_Load(object sender, EventArgs e)
        {
            // Hide the success label
            label1.Visible = false;
            label7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            txt_temp.Text = "";
            txt_pa_1.Text = "";
            txt_pa_2.Text = "";
            txt_sat.Text = "";
            txt_glic.Text = "";
            txt_dor.Text = "";
            comboBox1.Text = "";

            // Hide all controls
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }

            // Show the success labels
            label1.Visible = true;
            label7.Visible = true;

            // Set up a timer for 3 seconds
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3000;
            timer.Tick += (s, args) =>
            {
                // Show all controls
                foreach (Control control in Controls)
                {
                    control.Visible = true;
                    // Hide the success labels
                    label1.Visible = false;
                    label7.Visible = false;
                }

                // Stop the timer
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
    }
}