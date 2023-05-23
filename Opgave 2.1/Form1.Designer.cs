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
            this.tb_varenr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kunde)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_vare
            // 
            this.dgv_vare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vare.Location = new System.Drawing.Point(1248, 366);
            this.dgv_vare.Name = "dgv_vare";
            this.dgv_vare.RowHeadersWidth = 72;
            this.dgv_vare.RowTemplate.Height = 31;
            this.dgv_vare.Size = new System.Drawing.Size(1000, 400);
            this.dgv_vare.TabIndex = 111;
            // 
            // dgv_kunde
            // 
            this.dgv_kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kunde.Location = new System.Drawing.Point(12, 366);
            this.dgv_kunde.Name = "dgv_kunde";
            this.dgv_kunde.RowHeadersWidth = 72;
            this.dgv_kunde.RowTemplate.Height = 31;
            this.dgv_kunde.Size = new System.Drawing.Size(1000, 400);
            this.dgv_kunde.TabIndex = 110;
            // 
            // varebtn_AEndre
            // 
            this.varebtn_AEndre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.varebtn_AEndre.Location = new System.Drawing.Point(1746, 176);
            this.varebtn_AEndre.Name = "varebtn_AEndre";
            this.varebtn_AEndre.Size = new System.Drawing.Size(184, 67);
            this.varebtn_AEndre.TabIndex = 109;
            this.varebtn_AEndre.Text = "Ændre";
            this.varebtn_AEndre.UseVisualStyleBackColor = false;
            // 
            // varebtn_Slet
            // 
            this.varebtn_Slet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.varebtn_Slet.Location = new System.Drawing.Point(1746, 103);
            this.varebtn_Slet.Name = "varebtn_Slet";
            this.varebtn_Slet.Size = new System.Drawing.Size(184, 67);
            this.varebtn_Slet.TabIndex = 108;
            this.varebtn_Slet.Text = "Slet";
            this.varebtn_Slet.UseVisualStyleBackColor = false;
            // 
            // kundebtn_AEndre
            // 
            this.kundebtn_AEndre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kundebtn_AEndre.Location = new System.Drawing.Point(470, 176);
            this.kundebtn_AEndre.Name = "kundebtn_AEndre";
            this.kundebtn_AEndre.Size = new System.Drawing.Size(184, 67);
            this.kundebtn_AEndre.TabIndex = 107;
            this.kundebtn_AEndre.Text = "Ændre";
            this.kundebtn_AEndre.UseVisualStyleBackColor = false;
            // 
            // kundebtn_Slet
            // 
            this.kundebtn_Slet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kundebtn_Slet.Location = new System.Drawing.Point(470, 103);
            this.kundebtn_Slet.Name = "kundebtn_Slet";
            this.kundebtn_Slet.Size = new System.Drawing.Size(184, 67);
            this.kundebtn_Slet.TabIndex = 106;
            this.kundebtn_Slet.Text = "Slet";
            this.kundebtn_Slet.UseVisualStyleBackColor = false;
            // 
            // tb_varenr
            // 
            this.tb_varenr.Location = new System.Drawing.Point(1441, 30);
            this.tb_varenr.Name = "tb_varenr";
            this.tb_varenr.Size = new System.Drawing.Size(275, 31);
            this.tb_varenr.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1242, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 104;
            this.label7.Text = "Vare nr :";
            // 
            // tb_pris
            // 
            this.tb_pris.Location = new System.Drawing.Point(1441, 200);
            this.tb_pris.Name = "tb_pris";
            this.tb_pris.Size = new System.Drawing.Size(275, 31);
            this.tb_pris.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1242, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 102;
            this.label8.Text = "Pris :";
            // 
            // tb_varenavn
            // 
            this.tb_varenavn.Location = new System.Drawing.Point(1441, 143);
            this.tb_varenavn.Name = "tb_varenavn";
            this.tb_varenavn.Size = new System.Drawing.Size(275, 31);
            this.tb_varenavn.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1242, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 100;
            this.label9.Text = "Produkt navn :";
            // 
            // tb_stoerrelse
            // 
            this.tb_stoerrelse.Location = new System.Drawing.Point(1441, 87);
            this.tb_stoerrelse.Name = "tb_stoerrelse";
            this.tb_stoerrelse.Size = new System.Drawing.Size(275, 31);
            this.tb_stoerrelse.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1242, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 98;
            this.label10.Text = "Størrelse :";
            // 
            // varebtn_Opret
            // 
            this.varebtn_Opret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.varebtn_Opret.Location = new System.Drawing.Point(1746, 30);
            this.varebtn_Opret.Name = "varebtn_Opret";
            this.varebtn_Opret.Size = new System.Drawing.Size(184, 67);
            this.varebtn_Opret.TabIndex = 97;
            this.varebtn_Opret.Text = "Opret Vare";
            this.varebtn_Opret.UseVisualStyleBackColor = false;
            // 
            // tb_cpr
            // 
            this.tb_cpr.Location = new System.Drawing.Point(155, 30);
            this.tb_cpr.Name = "tb_cpr";
            this.tb_cpr.Size = new System.Drawing.Size(275, 31);
            this.tb_cpr.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Cpr nr :";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(155, 252);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(275, 31);
            this.tb_adresse.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 93;
            this.label5.Text = "Adresse :";
            // 
            // tb_tlf
            // 
            this.tb_tlf.Location = new System.Drawing.Point(155, 196);
            this.tb_tlf.Name = "tb_tlf";
            this.tb_tlf.Size = new System.Drawing.Size(275, 31);
            this.tb_tlf.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 91;
            this.label3.Text = "Tlf nr :";
            // 
            // kundebtn_Opret
            // 
            this.kundebtn_Opret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kundebtn_Opret.Location = new System.Drawing.Point(470, 30);
            this.kundebtn_Opret.Name = "kundebtn_Opret";
            this.kundebtn_Opret.Size = new System.Drawing.Size(184, 67);
            this.kundebtn_Opret.TabIndex = 90;
            this.kundebtn_Opret.Text = "Opret Kunde";
            this.kundebtn_Opret.UseVisualStyleBackColor = false;
            // 
            // tb_efternavn
            // 
            this.tb_efternavn.Location = new System.Drawing.Point(155, 139);
            this.tb_efternavn.Name = "tb_efternavn";
            this.tb_efternavn.Size = new System.Drawing.Size(275, 31);
            this.tb_efternavn.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 88;
            this.label2.Text = "Efternavn :";
            // 
            // tb_fornavn
            // 
            this.tb_fornavn.Location = new System.Drawing.Point(155, 85);
            this.tb_fornavn.Name = "tb_fornavn";
            this.tb_fornavn.Size = new System.Drawing.Size(275, 31);
            this.tb_fornavn.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "Fornavn :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1999, 920);
            this.Controls.Add(this.dgv_vare);
            this.Controls.Add(this.dgv_kunde);
            this.Controls.Add(this.varebtn_AEndre);
            this.Controls.Add(this.varebtn_Slet);
            this.Controls.Add(this.kundebtn_AEndre);
            this.Controls.Add(this.kundebtn_Slet);
            this.Controls.Add(this.tb_varenr);
            this.Controls.Add(this.label7);
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
        private System.Windows.Forms.TextBox tb_varenr;
        private System.Windows.Forms.Label label7;
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
    }
}

