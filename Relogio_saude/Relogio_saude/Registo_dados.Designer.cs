namespace Relogio_saude
{
    partial class Registo_dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registo_dados));
            this.bt_back = new System.Windows.Forms.Button();
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.txt_pa_1 = new System.Windows.Forms.TextBox();
            this.txt_pa_2 = new System.Windows.Forms.TextBox();
            this.txt_sat = new System.Windows.Forms.TextBox();
            this.txt_glic = new System.Windows.Forms.TextBox();
            this.txt_dor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.Color.Transparent;
            this.bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(125, 230);
            this.bt_back.Margin = new System.Windows.Forms.Padding(2);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(100, 39);
            this.bt_back.TabIndex = 2;
            this.bt_back.Text = "< Voltar";
            this.bt_back.UseVisualStyleBackColor = false;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // txt_temp
            // 
            this.txt_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_temp.Location = new System.Drawing.Point(355, 280);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(100, 35);
            this.txt_temp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Temperatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pressão Arterial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Saturação Oxigenio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Glicemia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dor";
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(125, 568);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(40, 32);
            this.bt0.TabIndex = 16;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(171, 568);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(40, 32);
            this.bt1.TabIndex = 17;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(217, 568);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(40, 32);
            this.bt2.TabIndex = 18;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(263, 568);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(40, 32);
            this.bt3.TabIndex = 19;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.button5_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(309, 568);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(40, 32);
            this.bt4.TabIndex = 20;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(309, 606);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(40, 32);
            this.bt9.TabIndex = 25;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(263, 606);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(40, 32);
            this.bt8.TabIndex = 24;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(217, 606);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(40, 32);
            this.bt7.TabIndex = 23;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(171, 606);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(40, 32);
            this.bt6.TabIndex = 22;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(125, 606);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(40, 32);
            this.bt5.TabIndex = 21;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            // 
            // txt_pa_1
            // 
            this.txt_pa_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pa_1.Location = new System.Drawing.Point(355, 327);
            this.txt_pa_1.Name = "txt_pa_1";
            this.txt_pa_1.Size = new System.Drawing.Size(100, 35);
            this.txt_pa_1.TabIndex = 26;
            // 
            // txt_pa_2
            // 
            this.txt_pa_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pa_2.Location = new System.Drawing.Point(355, 368);
            this.txt_pa_2.Name = "txt_pa_2";
            this.txt_pa_2.Size = new System.Drawing.Size(100, 35);
            this.txt_pa_2.TabIndex = 27;
            // 
            // txt_sat
            // 
            this.txt_sat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sat.Location = new System.Drawing.Point(355, 418);
            this.txt_sat.Name = "txt_sat";
            this.txt_sat.Size = new System.Drawing.Size(100, 35);
            this.txt_sat.TabIndex = 28;
            // 
            // txt_glic
            // 
            this.txt_glic.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_glic.Location = new System.Drawing.Point(355, 470);
            this.txt_glic.Name = "txt_glic";
            this.txt_glic.Size = new System.Drawing.Size(100, 35);
            this.txt_glic.TabIndex = 29;
            // 
            // txt_dor
            // 
            this.txt_dor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dor.Location = new System.Drawing.Point(355, 518);
            this.txt_dor.Name = "txt_dor";
            this.txt_dor.Size = new System.Drawing.Size(100, 35);
            this.txt_dor.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 70);
            this.button1.TabIndex = 31;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manuel Rio",
            "Joana Costa",
            "Pedro Matos",
            "Luis Severo"});
            this.comboBox1.Location = new System.Drawing.Point(233, 230);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 39);
            this.comboBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 33;
            this.label1.Text = "Dados Guardados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(172, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 39);
            this.label7.TabIndex = 34;
            this.label7.Text = "com sucesso!";
            // 
            // Registo_dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(554, 847);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_dor);
            this.Controls.Add(this.txt_glic);
            this.Controls.Add(this.txt_sat);
            this.Controls.Add(this.txt_pa_2);
            this.Controls.Add(this.txt_pa_1);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_temp);
            this.Controls.Add(this.bt_back);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registo_dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registo_dados";
            this.Load += new System.EventHandler(this.Registo_dados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.TextBox txt_pa_1;
        private System.Windows.Forms.TextBox txt_pa_2;
        private System.Windows.Forms.TextBox txt_sat;
        private System.Windows.Forms.TextBox txt_glic;
        private System.Windows.Forms.TextBox txt_dor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}