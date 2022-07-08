namespace TC_Kimlik_Api_Ornegi
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoy = new System.Windows.Forms.Label();
            this.lblyil = new System.Windows.Forms.Label();
            this.lblcvv = new System.Windows.Forms.Label();
            this.lblson = new System.Windows.Forms.Label();
            this.lblkredi = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtyil = new System.Windows.Forms.TextBox();
            this.txtcvv = new System.Windows.Forms.TextBox();
            this.txtson = new System.Windows.Forms.TextBox();
            this.txtkredi = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(36, 279);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(30, 16);
            this.lblad.TabIndex = 1;
            this.lblad.Text = "Ad :";
            // 
            // lblsoy
            // 
            this.lblsoy.AutoSize = true;
            this.lblsoy.Location = new System.Drawing.Point(36, 329);
            this.lblsoy.Name = "lblsoy";
            this.lblsoy.Size = new System.Drawing.Size(53, 16);
            this.lblsoy.TabIndex = 2;
            this.lblsoy.Text = "Soyad :";
            // 
            // lblyil
            // 
            this.lblyil.AutoSize = true;
            this.lblyil.Location = new System.Drawing.Point(36, 384);
            this.lblyil.Name = "lblyil";
            this.lblyil.Size = new System.Drawing.Size(28, 16);
            this.lblyil.TabIndex = 3;
            this.lblyil.Text = "Yıl :";
            // 
            // lblcvv
            // 
            this.lblcvv.AutoSize = true;
            this.lblcvv.Location = new System.Drawing.Point(366, 224);
            this.lblcvv.Name = "lblcvv";
            this.lblcvv.Size = new System.Drawing.Size(36, 16);
            this.lblcvv.TabIndex = 4;
            this.lblcvv.Text = "Cvv :";
            // 
            // lblson
            // 
            this.lblson.AutoSize = true;
            this.lblson.Location = new System.Drawing.Point(366, 274);
            this.lblson.Name = "lblson";
            this.lblson.Size = new System.Drawing.Size(90, 16);
            this.lblson.TabIndex = 5;
            this.lblson.Text = "Son Kullanım :";
            // 
            // lblkredi
            // 
            this.lblkredi.AutoSize = true;
            this.lblkredi.Location = new System.Drawing.Point(366, 329);
            this.lblkredi.Name = "lblkredi";
            this.lblkredi.Size = new System.Drawing.Size(86, 16);
            this.lblkredi.TabIndex = 6;
            this.lblkredi.Text = "Kredi Miktarı :";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(36, 224);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(88, 16);
            this.lbltc.TabIndex = 7;
            this.lbltc.Text = "Tc Kimlik No :";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(146, 221);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(155, 22);
            this.txttc.TabIndex = 8;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(146, 276);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(155, 22);
            this.txtad.TabIndex = 9;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(146, 329);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(155, 22);
            this.txtsoyad.TabIndex = 10;
            // 
            // txtyil
            // 
            this.txtyil.Location = new System.Drawing.Point(146, 381);
            this.txtyil.Name = "txtyil";
            this.txtyil.Size = new System.Drawing.Size(155, 22);
            this.txtyil.TabIndex = 11;
            // 
            // txtcvv
            // 
            this.txtcvv.Location = new System.Drawing.Point(466, 224);
            this.txtcvv.Name = "txtcvv";
            this.txtcvv.Size = new System.Drawing.Size(155, 22);
            this.txtcvv.TabIndex = 12;
            // 
            // txtson
            // 
            this.txtson.Location = new System.Drawing.Point(466, 271);
            this.txtson.Name = "txtson";
            this.txtson.Size = new System.Drawing.Size(155, 22);
            this.txtson.TabIndex = 13;
            // 
            // txtkredi
            // 
            this.txtkredi.Location = new System.Drawing.Point(466, 326);
            this.txtkredi.Name = "txtkredi";
            this.txtkredi.Size = new System.Drawing.Size(155, 22);
            this.txtkredi.TabIndex = 14;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(88, 445);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(113, 41);
            this.btnekle.TabIndex = 15;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(289, 445);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(113, 41);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Location = new System.Drawing.Point(496, 445);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(113, 41);
            this.btngüncelle.TabIndex = 17;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(713, 533);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtkredi);
            this.Controls.Add(this.txtson);
            this.Controls.Add(this.txtcvv);
            this.Controls.Add(this.txtyil);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.lblkredi);
            this.Controls.Add(this.lblson);
            this.Controls.Add(this.lblcvv);
            this.Controls.Add(this.lblyil);
            this.Controls.Add(this.lblsoy);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblsoy;
        private System.Windows.Forms.Label lblyil;
        private System.Windows.Forms.Label lblcvv;
        private System.Windows.Forms.Label lblson;
        private System.Windows.Forms.Label lblkredi;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.TextBox txtcvv;
        private System.Windows.Forms.TextBox txtson;
        private System.Windows.Forms.TextBox txtkredi;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        public System.Windows.Forms.TextBox txttc;
        public System.Windows.Forms.TextBox txtad;
        public System.Windows.Forms.TextBox txtsoyad;
        public System.Windows.Forms.TextBox txtyil;
    }
}