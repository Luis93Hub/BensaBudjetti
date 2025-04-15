namespace Funktiot_Bensankulutus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtVälimatka = new TextBox();
            txtP_Kulutus = new TextBox();
            label2 = new Label();
            txtBensiiniHinta = new TextBox();
            label3 = new Label();
            btnLaske = new Button();
            txtTulostus = new TextBox();
            rdLKm = new RadioButton();
            rdL100km = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 40);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Etäisyys";
            // 
            // txtVälimatka
            // 
            txtVälimatka.Location = new Point(137, 37);
            txtVälimatka.Name = "txtVälimatka";
            txtVälimatka.Size = new Size(52, 23);
            txtVälimatka.TabIndex = 1;
            // 
            // txtP_Kulutus
            // 
            txtP_Kulutus.Location = new Point(303, 55);
            txtP_Kulutus.Name = "txtP_Kulutus";
            txtP_Kulutus.Size = new Size(52, 23);
            txtP_Kulutus.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 37);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 2;
            label2.Text = "Polttoaineen kulutus";
            // 
            // txtBensiiniHinta
            // 
            txtBensiiniHinta.Location = new Point(137, 83);
            txtBensiiniHinta.Name = "txtBensiiniHinta";
            txtBensiiniHinta.Size = new Size(52, 23);
            txtBensiiniHinta.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 86);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 4;
            label3.Text = "Polttoaineen litrahinta";
            // 
            // btnLaske
            // 
            btnLaske.Location = new Point(11, 133);
            btnLaske.Name = "btnLaske";
            btnLaske.Size = new Size(75, 23);
            btnLaske.TabIndex = 6;
            btnLaske.Text = "Laske";
            btnLaske.UseVisualStyleBackColor = true;
            btnLaske.Click += btnLaske_Click;
            // 
            // txtTulostus
            // 
            txtTulostus.BorderStyle = BorderStyle.None;
            txtTulostus.Enabled = false;
            txtTulostus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTulostus.Location = new Point(93, 137);
            txtTulostus.Name = "txtTulostus";
            txtTulostus.Size = new Size(318, 19);
            txtTulostus.TabIndex = 7;
            txtTulostus.Text = "Tulokset";
            txtTulostus.TextAlign = HorizontalAlignment.Center;
            // 
            // rdLKm
            // 
            rdLKm.AutoSize = true;
            rdLKm.Location = new Point(261, 84);
            rdLKm.Name = "rdLKm";
            rdLKm.Size = new Size(54, 19);
            rdLKm.TabIndex = 8;
            rdLKm.TabStop = true;
            rdLKm.Text = "L\\Km";
            toolTip1.SetToolTip(rdLKm, "\"Esimerkki: 0.065 (litraa/km)\"");
            rdLKm.UseVisualStyleBackColor = true;
            // 
            // rdL100km
            // 
            rdL100km.AutoSize = true;
            rdL100km.Location = new Point(321, 84);
            rdL100km.Name = "rdL100km";
            rdL100km.Size = new Size(72, 19);
            rdL100km.TabIndex = 9;
            rdL100km.TabStop = true;
            rdL100km.Text = "L\\100Km";
            toolTip2.SetToolTip(rdL100km, "\"Esimerkki: 6.5 (litraa/100km)\"");
            rdL100km.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 40);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 10;
            label4.Text = "Km";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 86);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 11;
            label5.Text = "€";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 181);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(rdL100km);
            Controls.Add(rdLKm);
            Controls.Add(txtTulostus);
            Controls.Add(btnLaske);
            Controls.Add(txtBensiiniHinta);
            Controls.Add(label3);
            Controls.Add(txtP_Kulutus);
            Controls.Add(label2);
            Controls.Add(txtVälimatka);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bensan Kulutus";
            WindowState = FormWindowState.Minimized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVälimatka;
        private TextBox txtP_Kulutus;
        private Label label2;
        private TextBox txtBensiiniHinta;
        private Label label3;
        private Button btnLaske;
        private TextBox txtTulostus;
        private RadioButton rdLKm;
        private RadioButton rdL100km;
        private Label label4;
        private Label label5;
        private ToolTip toolTip2;
        private ToolTip toolTip1;
    }
}
