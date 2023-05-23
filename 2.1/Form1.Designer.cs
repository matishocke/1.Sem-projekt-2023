namespace _2._1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_savevare = new System.Windows.Forms.Button();
            this.tb_cpr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tlf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_savename = new System.Windows.Forms.Button();
            this.tb_efternavn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgv_kunde = new System.Windows.Forms.DataGridView();
            this.dgv_vare = new System.Windows.Forms.DataGridView();
            this.shocknet_dk_db_shockDataSet = new _2._1.shocknet_dk_db_shockDataSet();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new _2._1.shocknet_dk_db_shockDataSetTableAdapters.kundeTableAdapter();
            this.kundeNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shocknet_dk_db_shockDataSet1 = new _2._1.shocknet_dk_db_shockDataSet1();
            this.vareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vareTableAdapter = new _2._1.shocknet_dk_db_shockDataSet1TableAdapters.VareTableAdapter();
            this.varenrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storrelseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vareNavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kunde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shocknet_dk_db_shockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shocknet_dk_db_shockDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 29);
            this.textBox1.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Vare nr :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 575);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 29);
            this.textBox2.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 579);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Pris :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 520);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 29);
            this.textBox3.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 524);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Produkt navn :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(213, 467);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 29);
            this.textBox4.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Størrelse :";
            // 
            // btn_savevare
            // 
            this.btn_savevare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_savevare.Location = new System.Drawing.Point(444, 415);
            this.btn_savevare.Name = "btn_savevare";
            this.btn_savevare.Size = new System.Drawing.Size(140, 49);
            this.btn_savevare.TabIndex = 43;
            this.btn_savevare.Text = "Gem vare";
            this.btn_savevare.UseVisualStyleBackColor = false;
            // 
            // tb_cpr
            // 
            this.tb_cpr.Location = new System.Drawing.Point(162, 24);
            this.tb_cpr.Name = "tb_cpr";
            this.tb_cpr.Size = new System.Drawing.Size(192, 29);
            this.tb_cpr.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cpr nr :";
            // 
            // tb_adresse
            // 
            this.tb_adresse.Location = new System.Drawing.Point(162, 291);
            this.tb_adresse.Name = "tb_adresse";
            this.tb_adresse.Size = new System.Drawing.Size(192, 29);
            this.tb_adresse.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Adresse :";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(162, 236);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(192, 29);
            this.tb_email.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Email :";
            // 
            // tb_tlf
            // 
            this.tb_tlf.Location = new System.Drawing.Point(162, 183);
            this.tb_tlf.Name = "tb_tlf";
            this.tb_tlf.Size = new System.Drawing.Size(192, 29);
            this.tb_tlf.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tlf nr :";
            // 
            // btn_savename
            // 
            this.btn_savename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_savename.Location = new System.Drawing.Point(370, 24);
            this.btn_savename.Name = "btn_savename";
            this.btn_savename.Size = new System.Drawing.Size(140, 51);
            this.btn_savename.TabIndex = 30;
            this.btn_savename.Text = "Gem navn";
            this.btn_savename.UseVisualStyleBackColor = false;
            // 
            // tb_efternavn
            // 
            this.tb_efternavn.Location = new System.Drawing.Point(162, 129);
            this.tb_efternavn.Name = "tb_efternavn";
            this.tb_efternavn.Size = new System.Drawing.Size(192, 29);
            this.tb_efternavn.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Efternavn :";
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(162, 77);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(192, 29);
            this.tb_firstname.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fornavn :";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_delete.Location = new System.Drawing.Point(370, 82);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(140, 52);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "Slet";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(370, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 48);
            this.button3.TabIndex = 53;
            this.button3.Text = "Ændre";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(444, 555);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 52);
            this.button4.TabIndex = 55;
            this.button4.Text = "Ændre";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(444, 485);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 50);
            this.button5.TabIndex = 54;
            this.button5.Text = "Slet";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dgv_kunde
            // 
            this.dgv_kunde.AutoGenerateColumns = false;
            this.dgv_kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kunde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kundeNrDataGridViewTextBoxColumn,
            this.fornavnDataGridViewTextBoxColumn,
            this.efternavnDataGridViewTextBoxColumn,
            this.telefonNrDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.cprnummerDataGridViewTextBoxColumn});
            this.dgv_kunde.DataSource = this.kundeBindingSource;
            this.dgv_kunde.Location = new System.Drawing.Point(551, 24);
            this.dgv_kunde.Name = "dgv_kunde";
            this.dgv_kunde.RowHeadersWidth = 72;
            this.dgv_kunde.RowTemplate.Height = 31;
            this.dgv_kunde.Size = new System.Drawing.Size(964, 322);
            this.dgv_kunde.TabIndex = 56;
            // 
            // dgv_vare
            // 
            this.dgv_vare.AutoGenerateColumns = false;
            this.dgv_vare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varenrDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn,
            this.storrelseDataGridViewTextBoxColumn,
            this.vareNavnDataGridViewTextBoxColumn});
            this.dgv_vare.DataSource = this.vareBindingSource;
            this.dgv_vare.Location = new System.Drawing.Point(605, 373);
            this.dgv_vare.Name = "dgv_vare";
            this.dgv_vare.RowHeadersWidth = 72;
            this.dgv_vare.RowTemplate.Height = 31;
            this.dgv_vare.Size = new System.Drawing.Size(910, 280);
            this.dgv_vare.TabIndex = 57;
            // 
            // shocknet_dk_db_shockDataSet
            // 
            this.shocknet_dk_db_shockDataSet.DataSetName = "shocknet_dk_db_shockDataSet";
            this.shocknet_dk_db_shockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "kunde";
            this.kundeBindingSource.DataSource = this.shocknet_dk_db_shockDataSet;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // kundeNrDataGridViewTextBoxColumn
            // 
            this.kundeNrDataGridViewTextBoxColumn.DataPropertyName = "kundeNr";
            this.kundeNrDataGridViewTextBoxColumn.HeaderText = "kundeNr";
            this.kundeNrDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.kundeNrDataGridViewTextBoxColumn.Name = "kundeNrDataGridViewTextBoxColumn";
            this.kundeNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornavnDataGridViewTextBoxColumn
            // 
            this.fornavnDataGridViewTextBoxColumn.DataPropertyName = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.HeaderText = "Fornavn";
            this.fornavnDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.fornavnDataGridViewTextBoxColumn.Name = "fornavnDataGridViewTextBoxColumn";
            // 
            // efternavnDataGridViewTextBoxColumn
            // 
            this.efternavnDataGridViewTextBoxColumn.DataPropertyName = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.HeaderText = "Efternavn";
            this.efternavnDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.efternavnDataGridViewTextBoxColumn.Name = "efternavnDataGridViewTextBoxColumn";
            // 
            // telefonNrDataGridViewTextBoxColumn
            // 
            this.telefonNrDataGridViewTextBoxColumn.DataPropertyName = "TelefonNr";
            this.telefonNrDataGridViewTextBoxColumn.HeaderText = "TelefonNr";
            this.telefonNrDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.telefonNrDataGridViewTextBoxColumn.Name = "telefonNrDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // cprnummerDataGridViewTextBoxColumn
            // 
            this.cprnummerDataGridViewTextBoxColumn.DataPropertyName = "cprnummer";
            this.cprnummerDataGridViewTextBoxColumn.HeaderText = "cprnummer";
            this.cprnummerDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.cprnummerDataGridViewTextBoxColumn.Name = "cprnummerDataGridViewTextBoxColumn";
            // 
            // shocknet_dk_db_shockDataSet1
            // 
            this.shocknet_dk_db_shockDataSet1.DataSetName = "shocknet_dk_db_shockDataSet1";
            this.shocknet_dk_db_shockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vareBindingSource
            // 
            this.vareBindingSource.DataMember = "Vare";
            this.vareBindingSource.DataSource = this.shocknet_dk_db_shockDataSet1;
            // 
            // vareTableAdapter
            // 
            this.vareTableAdapter.ClearBeforeFill = true;
            // 
            // varenrDataGridViewTextBoxColumn
            // 
            this.varenrDataGridViewTextBoxColumn.DataPropertyName = "Varenr";
            this.varenrDataGridViewTextBoxColumn.HeaderText = "Varenr";
            this.varenrDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.varenrDataGridViewTextBoxColumn.Name = "varenrDataGridViewTextBoxColumn";
            this.varenrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "Pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "Pris";
            this.prisDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            // 
            // storrelseDataGridViewTextBoxColumn
            // 
            this.storrelseDataGridViewTextBoxColumn.DataPropertyName = "Storrelse";
            this.storrelseDataGridViewTextBoxColumn.HeaderText = "Storrelse";
            this.storrelseDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.storrelseDataGridViewTextBoxColumn.Name = "storrelseDataGridViewTextBoxColumn";
            // 
            // vareNavnDataGridViewTextBoxColumn
            // 
            this.vareNavnDataGridViewTextBoxColumn.DataPropertyName = "VareNavn";
            this.vareNavnDataGridViewTextBoxColumn.HeaderText = "VareNavn";
            this.vareNavnDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.vareNavnDataGridViewTextBoxColumn.Name = "vareNavnDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 719);
            this.Controls.Add(this.dgv_vare);
            this.Controls.Add(this.dgv_kunde);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_savevare);
            this.Controls.Add(this.tb_cpr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_adresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_tlf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_savename);
            this.Controls.Add(this.tb_efternavn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kunde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shocknet_dk_db_shockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shocknet_dk_db_shockDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_savevare;
        private System.Windows.Forms.TextBox tb_cpr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tlf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_savename;
        private System.Windows.Forms.TextBox tb_efternavn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgv_kunde;
        private System.Windows.Forms.DataGridView dgv_vare;
        private shocknet_dk_db_shockDataSet shocknet_dk_db_shockDataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private shocknet_dk_db_shockDataSetTableAdapters.kundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundeNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprnummerDataGridViewTextBoxColumn;
        private shocknet_dk_db_shockDataSet1 shocknet_dk_db_shockDataSet1;
        private System.Windows.Forms.BindingSource vareBindingSource;
        private shocknet_dk_db_shockDataSet1TableAdapters.VareTableAdapter vareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varenrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storrelseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vareNavnDataGridViewTextBoxColumn;
    }
}

