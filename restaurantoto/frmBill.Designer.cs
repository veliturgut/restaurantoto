namespace restaurantoto
{
    partial class frmBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIndirim = new System.Windows.Forms.CheckBox();
            this.gbIndirim = new System.Windows.Forms.GroupBox();
            this.txtIndirimTutari = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblKdv = new System.Windows.Forms.Label();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.rbKrediKarti = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btncikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblAdisyonId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbIndirim.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkIndirim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(654, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özel İndirim";
            // 
            // chkIndirim
            // 
            this.chkIndirim.AutoSize = true;
            this.chkIndirim.Location = new System.Drawing.Point(24, 41);
            this.chkIndirim.Name = "chkIndirim";
            this.chkIndirim.Size = new System.Drawing.Size(242, 40);
            this.chkIndirim.TabIndex = 0;
            this.chkIndirim.Text = "İndirim Uygula";
            this.chkIndirim.UseVisualStyleBackColor = true;
            this.chkIndirim.CheckedChanged += new System.EventHandler(this.chkIndirim_CheckedChanged);
            // 
            // gbIndirim
            // 
            this.gbIndirim.BackColor = System.Drawing.Color.Transparent;
            this.gbIndirim.Controls.Add(this.txtIndirimTutari);
            this.gbIndirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbIndirim.ForeColor = System.Drawing.Color.White;
            this.gbIndirim.Location = new System.Drawing.Point(930, 83);
            this.gbIndirim.Name = "gbIndirim";
            this.gbIndirim.Size = new System.Drawing.Size(245, 149);
            this.gbIndirim.TabIndex = 1;
            this.gbIndirim.TabStop = false;
            this.gbIndirim.Text = "Özel Aktivite";
            this.gbIndirim.Visible = false;
            // 
            // txtIndirimTutari
            // 
            this.txtIndirimTutari.Location = new System.Drawing.Point(26, 63);
            this.txtIndirimTutari.Name = "txtIndirimTutari";
            this.txtIndirimTutari.Size = new System.Drawing.Size(188, 41);
            this.txtIndirimTutari.TabIndex = 0;
            this.txtIndirimTutari.TextChanged += new System.EventHandler(this.txtIndirimTutari_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lblOdenecek);
            this.groupBox3.Controls.Add(this.lblToplamTutar);
            this.groupBox3.Controls.Add(this.lblKdv);
            this.groupBox3.Controls.Add(this.lblIndirim);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 251);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ödeme Bilgileri";
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Location = new System.Drawing.Point(241, 200);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(33, 36);
            this.lblOdenecek.TabIndex = 11;
            this.lblOdenecek.Text = "0";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(241, 155);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(33, 36);
            this.lblToplamTutar.TabIndex = 10;
            this.lblToplamTutar.Text = "0";
            // 
            // lblKdv
            // 
            this.lblKdv.AutoSize = true;
            this.lblKdv.Location = new System.Drawing.Point(241, 97);
            this.lblKdv.Name = "lblKdv";
            this.lblKdv.Size = new System.Drawing.Size(33, 36);
            this.lblKdv.TabIndex = 9;
            this.lblKdv.Text = "0";
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(241, 44);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(33, 36);
            this.lblIndirim.TabIndex = 8;
            this.lblIndirim.Text = "0";
            this.lblIndirim.TextChanged += new System.EventHandler(this.lblIndirim_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 36);
            this.label8.TabIndex = 7;
            this.label8.Text = "TL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "TL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ara Toplam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "KDV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "İndirim";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rbTicket);
            this.groupBox4.Controls.Add(this.rbKrediKarti);
            this.groupBox4.Controls.Add(this.rbNakit);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(425, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 251);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ödeme Türü";
            // 
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Location = new System.Drawing.Point(24, 164);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(121, 40);
            this.rbTicket.TabIndex = 2;
            this.rbTicket.TabStop = true;
            this.rbTicket.Text = "Ticket";
            this.rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbKrediKarti
            // 
            this.rbKrediKarti.AutoSize = true;
            this.rbKrediKarti.Location = new System.Drawing.Point(24, 97);
            this.rbKrediKarti.Name = "rbKrediKarti";
            this.rbKrediKarti.Size = new System.Drawing.Size(186, 40);
            this.rbKrediKarti.TabIndex = 1;
            this.rbKrediKarti.TabStop = true;
            this.rbKrediKarti.Text = "Kredi Kartı";
            this.rbKrediKarti.UseVisualStyleBackColor = true;
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(24, 40);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(109, 40);
            this.rbNakit.TabIndex = 0;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.HideSelection = false;
            this.lvUrunler.Location = new System.Drawing.Point(13, 62);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(614, 243);
            this.lvUrunler.TabIndex = 2;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Urun Adı";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adet";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UrunId";
            this.columnHeader3.Width = 127;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SatisId";
            this.columnHeader5.Width = 127;
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Red;
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Location = new System.Drawing.Point(164, 568);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(133, 65);
            this.btncikis.TabIndex = 27;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.Blue;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(13, 568);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(133, 65);
            this.btnGeriDon.TabIndex = 26;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // lblAdisyonId
            // 
            this.lblAdisyonId.AutoSize = true;
            this.lblAdisyonId.BackColor = System.Drawing.Color.Transparent;
            this.lblAdisyonId.ForeColor = System.Drawing.Color.Maroon;
            this.lblAdisyonId.Location = new System.Drawing.Point(183, 25);
            this.lblAdisyonId.Name = "lblAdisyonId";
            this.lblAdisyonId.Size = new System.Drawing.Size(21, 17);
            this.lblAdisyonId.TabIndex = 28;
            this.lblAdisyonId.Text = "ID";
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 645);
            this.Controls.Add(this.lblAdisyonId);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lvUrunler);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbIndirim);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbIndirim.ResumeLayout(false);
            this.gbIndirim.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIndirim;
        private System.Windows.Forms.GroupBox gbIndirim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblOdenecek;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblKdv;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton rbKrediKarti;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblAdisyonId;
        private System.Windows.Forms.TextBox txtIndirimTutari;
    }
}