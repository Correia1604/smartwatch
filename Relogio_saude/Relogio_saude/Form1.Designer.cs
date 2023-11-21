namespace Relogio_saude
{
    partial class Pag_inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pag_inicial));
            this.horas = new System.Windows.Forms.Label();
            this.lb_unlock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.Location = new System.Drawing.Point(171, 358);
            this.horas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(118, 42);
            this.horas.TabIndex = 0;
            this.horas.Text = "label1";
            // 
            // lb_unlock
            // 
            this.lb_unlock.AutoSize = true;
            this.lb_unlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.lb_unlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_unlock.Location = new System.Drawing.Point(141, 586);
            this.lb_unlock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_unlock.Name = "lb_unlock";
            this.lb_unlock.Size = new System.Drawing.Size(298, 55);
            this.lb_unlock.TabIndex = 2;
            this.lb_unlock.Text = "Desbloquear";
            this.lb_unlock.Click += new System.EventHandler(this.lb_unlock_Click);
            // 
            // Pag_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(554, 847);
            this.Controls.Add(this.lb_unlock);
            this.Controls.Add(this.horas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Pag_inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pag_inicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label horas;
        private System.Windows.Forms.Label lb_unlock;
    }
}

