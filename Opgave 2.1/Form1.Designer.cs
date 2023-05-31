namespace Opgave_2._1
{
    partial class Form1
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
            this.dgv_vare = new System.Windows.Forms.DataGridView();
            this.dgv_kunde = new System.Windows.Forms.DataGridView();
            this.varebtn_AEndre = new System.Windows.Forms.Button();
            this.varebtn_Slet = new System.Windows.Forms.Button();
            this.kundebtn_AEndre = new System.Windows.Forms.Button();
            this.kundebtn_Slet = new System.Windows.Forms.Button();
            this.tb_pris = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_varenavn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_stoerrelse = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.varebtn_Opret = new System.Windows.Forms.Button();
            this.tb_cpr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tlf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kundebtn_Opret = new System.Windows.Forms.Button();
            this.tb_efternavn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_fornavn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tb_kundenr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_vareNr = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_KundenriVARE = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kunde)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vare
            // 
            this.dgv_vare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vare.Location = new System.Drawing.Point(620, 408);
            this.dgv_vare.Name = "dgv_vare";
            this.dgv_vare.RowHeadersWidth = 72;
            this.dgv_vare.RowTemplate.Height = 31;
            this.dgv_vare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vare.Size = new System.Drawing.Size(917, 334);
            this.dgv_vare.TabIndex = 111;
            this.dgv_vare.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vare_CellContentDoubleClick);
            // 
            // dgv_kunde
            // 
            this.dgv_kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kunde.Location = new System.Drawing.Point(620, 29);
            this.dgv_kunde.Name = "dgv_kunde";
            this.dgv_kunde.ReadOnly = true;
            this.dgv_kunde.RowHeadersWidth = 72;
            this.dgv_kunde.RowTemplate.Height = 31;
            this.dgv_kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kunde.Size = new System.Drawing.Size(917, 324);
            this.dgv_kunde.TabIndex = 110;
            this.dgv_kunde.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kunde_CellContentClick);
            this.dgv_kunde.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kunde_CellContentDoubleClick);
            // 
            // varebtn_AEndre
            // 
            this.varebtn_AEndre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.varebtn_AEndre.Location = new System.Drawing.Point(431, 614);
            this.varebtn_AEndre.Name = "varebtn_AEndre";
            this.varebtn_AEndre.Size = new System.Drawing.Size(169, 64);
            this.varebtn_AEndre.TabIndex = 109;
            this.varebtn_AEndre.Text = "Ændre";
            this.varebtn_AEndre.UseVisualStyleBackColor = false;
            this.varebtn_AEndre.Click += new System.EventHandler(this.varebtn_AEndre_Click);
            // 
            // varebtn_Slet
            // 
            this.varebtn_Slet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.varebtn_Slet.Location = new System.Drawing.Point(431, 544);
            this.varebtn_Slet.Name = "varebtn_Slet";
            this.varebtn_Slet.Size = new System.Drawing.Size(169, 64);
            this.varebtn_Slet.TabIndex = 108;
            this.varebtn_Slet.Text = "Slet";
            this.varebtn_Slet.UseVisualStyleBackColor = false;
            this.varebtn_Slet.Click += new System.EventHandler(this.varebtn_Slet_Click);
            // 
            // kundebtn_AEndre
            // 
            this.kundebtn_AEndre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kundebtn_AEndre.Location = new System.Drawing.Point(431, 228);
            this.kundebtn_AEndre.Name = "kundebtn_AEndre";
            this.kundebtn_AEndre.Size = new System.Drawing.Size(169, 64);
            this.kundebtn_AEndre.TabIndex = 107;
            this.kundebtn_AEndre.Text = "Ændre";
            this.kundebtn_AEndre.UseVisualStyleBackColor = false;
            this.kundebtn_AEndre.Click += new System.EventHandler(this.kundebtn_AEndre_Click);
            // 
            // kundebtn_Slet
            // 
            this.kundebtn_Slet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kundebtn_Slet.Location = new System.Drawing.Point(431, 158);
            this.kundebtn_Slet.Name = "kundebtn_Slet";
            this.kundebtn_Slet.Size = new System.Drawing.Size(169, 64);
            this.kundebtn_Slet.TabIndex = 106;
            this.kundebtn_Slet.Text = "Slet";
            this.kundebtn_Slet.UseVisualStyleBackColor = false;
            this.kundebtn_Slet.Click += new System.EventHandler(this.kundebtn_Slet_Click);
            // 
            // tb_pris
            // 
            this.tb_pris.Location = new System.Drawing.Point(158, 617);
            this.tb_pris.Name = "tb_pris";
            this.tb_pris.Size = new System.Drawing.Size(252, 29);
            this.tb_pris.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 622);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 102;
            this.label8.Text = "Pris :";
            // 
            // tb_varenavn
            // 
            this.tb_varenavn.Location = new System.Drawing.Point(158, 562);
            this.tb_varenavn.Name = "tb_varenavn";
            this.tb_varenavn.Size = new System.Drawing.Size(252, 29);
            this.tb_varenavn.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 100;
            this.label9.Text = "Produkt navn :";
            // 
            // tb_stoerrelse
            // 
            this.tb_stoerrelse.Location = new System.Drawing.Point(158, 509);
            this.tb_stoerrelse.Name = "tb_stoerrelse";
            this.tb_stoerrelse.Size = new System.Drawing.Size(252, 29);
            this.tb_stoerrelse.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 98;
            this.label10.Text = "Størrelse :";
            // 
            // varebtn_Opret
            // 
            this.varebtn_Opret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.varebtn_Opret.Location = new System.Drawing.Point(431, 474);
            this.varebtn_Opret.Name = "varebtn_Opret";
            this.varebtn_Opret.Size = new System.Drawing.Size(169, 64);
            this.varebtn_Opret.TabIndex = 97;
            this.varebtn_Opret.Text = "Opret Vare";
            this.varebtn_Opret.UseVisualStyleBackColor = false;
            this.varebtn_Opret.Click += new System.EventHandler(this.varebtn_Opret_Click);
            // 
            // tb_cpr
            // 
            this.tb_cpr.Location = new System.Drawing.Point(158, 122);
            this.tb_cpr.Name = "tb_cpr";
            this.tb_cpr.Size = new System.Drawing.Size(252, 29);
            this.tb_cpr.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Cpr nr :";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(158, 302);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(252, 29);
            this.tb_adresse.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 93;
            this.label5.Text = "Adresse :";
            // 
            // tb_tlf
            // 
            this.tb_tlf.Location = new System.Drawing.Point(158, 256);
            this.tb_tlf.Name = "tb_tlf";
            this.tb_tlf.Size = new System.Drawing.Size(252, 29);
            this.tb_tlf.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Tlf nr :";
            // 
            // kundebtn_Opret
            // 
            this.kundebtn_Opret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kundebtn_Opret.Location = new System.Drawing.Point(431, 88);
            this.kundebtn_Opret.Name = "kundebtn_Opret";
            this.kundebtn_Opret.Size = new System.Drawing.Size(169, 64);
            this.kundebtn_Opret.TabIndex = 90;
            this.kundebtn_Opret.Text = "Opret Kunde";
            this.kundebtn_Opret.UseVisualStyleBackColor = false;
            this.kundebtn_Opret.Click += new System.EventHandler(this.kundebtn_Opret_Click);
            // 
            // tb_efternavn
            // 
            this.tb_efternavn.Location = new System.Drawing.Point(158, 210);
            this.tb_efternavn.Name = "tb_efternavn";
            this.tb_efternavn.Size = new System.Drawing.Size(252, 29);
            this.tb_efternavn.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 88;
            this.label2.Text = "Efternavn :";
            // 
            // tb_fornavn
            // 
            this.tb_fornavn.Location = new System.Drawing.Point(158, 165);
            this.tb_fornavn.Name = "tb_fornavn";
            this.tb_fornavn.Size = new System.Drawing.Size(252, 29);
            this.tb_fornavn.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "Fornavn :";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(158, 348);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(252, 29);
            this.tb_Email.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 112;
            this.label4.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 32);
            this.label7.TabIndex = 114;
            this.label7.Text = "Kunde";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 32);
            this.label11.TabIndex = 115;
            this.label11.Text = "Vare";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 673);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 25);
            this.label12.TabIndex = 116;
            this.label12.Text = "Dato :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 673);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 29);
            this.dateTimePicker1.TabIndex = 117;
            // 
            // tb_kundenr
            // 
            this.tb_kundenr.Location = new System.Drawing.Point(158, 78);
            this.tb_kundenr.Name = "tb_kundenr";
            this.tb_kundenr.Size = new System.Drawing.Size(252, 29);
            this.tb_kundenr.TabIndex = 119;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 25);
            this.label13.TabIndex = 118;
            this.label13.Text = "Kundenr :";
            // 
            // tb_vareNr
            // 
            this.tb_vareNr.Location = new System.Drawing.Point(158, 458);
            this.tb_vareNr.Name = "tb_vareNr";
            this.tb_vareNr.Size = new System.Drawing.Size(252, 29);
            this.tb_vareNr.TabIndex = 121;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 462);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 25);
            this.label14.TabIndex = 120;
            this.label14.Text = "Varenr :";
            // 
            // tb_KundenriVARE
            // 
            this.tb_KundenriVARE.Location = new System.Drawing.Point(158, 727);
            this.tb_KundenriVARE.Name = "tb_KundenriVARE";
            this.tb_KundenriVARE.Size = new System.Drawing.Size(252, 29);
            this.tb_KundenriVARE.TabIndex = 123;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 732);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 25);
            this.label15.TabIndex = 122;
            this.label15.Text = "Kundenr :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1832, 883);
            this.Controls.Add(this.tb_KundenriVARE);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_vareNr);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_kundenr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_vare);
            this.Controls.Add(this.dgv_kunde);
            this.Controls.Add(this.varebtn_AEndre);
            this.Controls.Add(this.varebtn_Slet);
            this.Controls.Add(this.kundebtn_AEndre);
            this.Controls.Add(this.kundebtn_Slet);
            this.Controls.Add(this.tb_pris);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_varenavn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_stoerrelse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.varebtn_Opret);
            this.Controls.Add(this.tb_cpr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tlf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kundebtn_Opret);
            this.Controls.Add(this.tb_efternavn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_fornavn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kunde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_vare;
        private System.Windows.Forms.DataGridView dgv_kunde;
        private System.Windows.Forms.Button varebtn_AEndre;
        private System.Windows.Forms.Button varebtn_Slet;
        private System.Windows.Forms.Button kundebtn_AEndre;
        private System.Windows.Forms.Button kundebtn_Slet;
        private System.Windows.Forms.TextBox tb_pris;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_varenavn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_stoerrelse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button varebtn_Opret;
        private System.Windows.Forms.TextBox tb_cpr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tlf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kundebtn_Opret;
        private System.Windows.Forms.TextBox tb_efternavn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_fornavn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_kundenr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_vareNr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_KundenriVARE;
        private System.Windows.Forms.Label label15;
    }
}

