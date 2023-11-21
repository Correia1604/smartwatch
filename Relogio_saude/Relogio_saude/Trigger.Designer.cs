namespace Relogio_saude
{
    partial class Trigger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trigger));
            this.button2 = new System.Windows.Forms.Button();
            this.bt_higiene = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_medicacao = new System.Windows.Forms.Button();
            this.bt_paciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Abrir relógio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_higiene
            // 
            this.bt_higiene.Location = new System.Drawing.Point(70, 60);
            this.bt_higiene.Name = "bt_higiene";
            this.bt_higiene.Size = new System.Drawing.Size(111, 31);
            this.bt_higiene.TabIndex = 2;
            this.bt_higiene.Text = "Alarme Higiene";
            this.bt_higiene.UseVisualStyleBackColor = true;
            this.bt_higiene.Click += new System.EventHandler(this.bt_higiene_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // bt_medicacao
            // 
            this.bt_medicacao.Location = new System.Drawing.Point(70, 107);
            this.bt_medicacao.Name = "bt_medicacao";
            this.bt_medicacao.Size = new System.Drawing.Size(111, 31);
            this.bt_medicacao.TabIndex = 4;
            this.bt_medicacao.Text = "Alarme Medicação";
            this.bt_medicacao.UseVisualStyleBackColor = true;
            this.bt_medicacao.Click += new System.EventHandler(this.bt_medicacao_Click);
            // 
            // bt_paciente
            // 
            this.bt_paciente.Location = new System.Drawing.Point(70, 157);
            this.bt_paciente.Name = "bt_paciente";
            this.bt_paciente.Size = new System.Drawing.Size(111, 31);
            this.bt_paciente.TabIndex = 5;
            this.bt_paciente.Text = "Alarme Paciente";
            this.bt_paciente.UseVisualStyleBackColor = true;
            this.bt_paciente.Click += new System.EventHandler(this.bt_paciente_Click);
            // 
            // Trigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(253, 209);
            this.Controls.Add(this.bt_paciente);
            this.Controls.Add(this.bt_medicacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_higiene);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Trigger";
            this.Text = "Trigger";
            this.Load += new System.EventHandler(this.Trigger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_higiene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_medicacao;
        private System.Windows.Forms.Button bt_paciente;
    }
}