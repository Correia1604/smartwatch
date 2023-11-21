namespace Relogio_saude
{
    partial class Ecra_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ecra_2));
            this.bt_lanterna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_chamar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_lanterna
            // 
            this.bt_lanterna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.bt_lanterna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_lanterna.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lanterna.Location = new System.Drawing.Point(117, 311);
            this.bt_lanterna.Name = "bt_lanterna";
            this.bt_lanterna.Size = new System.Drawing.Size(163, 120);
            this.bt_lanterna.TabIndex = 0;
            this.bt_lanterna.Text = "Lanterna";
            this.bt_lanterna.UseVisualStyleBackColor = false;
            this.bt_lanterna.Click += new System.EventHandler(this.bt_lanterna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bloquear";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_chamar
            // 
            this.bt_chamar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.bt_chamar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chamar.Location = new System.Drawing.Point(300, 311);
            this.bt_chamar.Name = "bt_chamar";
            this.bt_chamar.Size = new System.Drawing.Size(163, 120);
            this.bt_chamar.TabIndex = 2;
            this.bt_chamar.Text = "Chamar";
            this.bt_chamar.UseVisualStyleBackColor = false;
            this.bt_chamar.Click += new System.EventHandler(this.bt_chamar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(117, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registar dados";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ecra_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(554, 847);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_chamar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_lanterna);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ecra_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecra_2";
            this.Load += new System.EventHandler(this.Ecra_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_lanterna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_chamar;
        private System.Windows.Forms.Button button1;
    }
}