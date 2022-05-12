
namespace blokzinciriekrani
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
            this.gonderen = new System.Windows.Forms.Label();
            this.alici = new System.Windows.Forms.Label();
            this.ParayiAktar = new System.Windows.Forms.Button();
            this.gondereninAdi = new System.Windows.Forms.TextBox();
            this.AlicininAdi = new System.Windows.Forms.TextBox();
            this.coin = new System.Windows.Forms.Label();
            this.gonderilenpara = new System.Windows.Forms.TextBox();
            this.gonderilenparamiktar = new System.Windows.Forms.Label();
            this.butunaktarimlar = new System.Windows.Forms.RichTextBox();
            this.aktarim = new System.Windows.Forms.Label();
            this.gecerlimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gonderen
            // 
            this.gonderen.AutoSize = true;
            this.gonderen.Location = new System.Drawing.Point(32, 70);
            this.gonderen.Name = "gonderen";
            this.gonderen.Size = new System.Drawing.Size(72, 17);
            this.gonderen.TabIndex = 0;
            this.gonderen.Text = "Gönderen";
            // 
            // alici
            // 
            this.alici.AutoSize = true;
            this.alici.Location = new System.Drawing.Point(32, 127);
            this.alici.Name = "alici";
            this.alici.Size = new System.Drawing.Size(33, 17);
            this.alici.TabIndex = 3;
            this.alici.Text = "Alıcı";
            // 
            // ParayiAktar
            // 
            this.ParayiAktar.Location = new System.Drawing.Point(92, 267);
            this.ParayiAktar.Name = "ParayiAktar";
            this.ParayiAktar.Size = new System.Drawing.Size(127, 28);
            this.ParayiAktar.TabIndex = 4;
            this.ParayiAktar.Text = "Parayı Aktar";
            this.ParayiAktar.UseVisualStyleBackColor = true;
            this.ParayiAktar.Click += new System.EventHandler(this.ParayiAktar_Click);
            // 
            // gondereninAdi
            // 
            this.gondereninAdi.Location = new System.Drawing.Point(186, 70);
            this.gondereninAdi.Name = "gondereninAdi";
            this.gondereninAdi.Size = new System.Drawing.Size(100, 22);
            this.gondereninAdi.TabIndex = 5;
            this.gondereninAdi.Text = "Hüseyin";
            // 
            // AlicininAdi
            // 
            this.AlicininAdi.Location = new System.Drawing.Point(186, 124);
            this.AlicininAdi.Name = "AlicininAdi";
            this.AlicininAdi.Size = new System.Drawing.Size(100, 22);
            this.AlicininAdi.TabIndex = 6;
            this.AlicininAdi.Text = "Tuba";
            // 
            // coin
            // 
            this.coin.AutoSize = true;
            this.coin.Location = new System.Drawing.Point(107, 26);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(65, 17);
            this.coin.TabIndex = 7;
            this.coin.Text = "twobCoin";
            // 
            // gonderilenpara
            // 
            this.gonderilenpara.Location = new System.Drawing.Point(92, 219);
            this.gonderilenpara.Name = "gonderilenpara";
            this.gonderilenpara.Size = new System.Drawing.Size(118, 22);
            this.gonderilenpara.TabIndex = 8;
            this.gonderilenpara.Text = "10";
            // 
            // gonderilenparamiktar
            // 
            this.gonderilenparamiktar.AutoSize = true;
            this.gonderilenparamiktar.Location = new System.Drawing.Point(98, 183);
            this.gonderilenparamiktar.Name = "gonderilenparamiktar";
            this.gonderilenparamiktar.Size = new System.Drawing.Size(112, 17);
            this.gonderilenparamiktar.TabIndex = 9;
            this.gonderilenparamiktar.Text = "Gönderilen Para";
            // 
            // butunaktarimlar
            // 
            this.butunaktarimlar.Location = new System.Drawing.Point(568, 12);
            this.butunaktarimlar.Name = "butunaktarimlar";
            this.butunaktarimlar.ReadOnly = true;
            this.butunaktarimlar.Size = new System.Drawing.Size(441, 521);
            this.butunaktarimlar.TabIndex = 10;
            this.butunaktarimlar.Text = "";
            // 
            // aktarim
            // 
            this.aktarim.AutoSize = true;
            this.aktarim.Location = new System.Drawing.Point(19, 381);
            this.aktarim.Name = "aktarim";
            this.aktarim.Size = new System.Drawing.Size(0, 17);
            this.aktarim.TabIndex = 11;
            // 
            // gecerlimi
            // 
            this.gecerlimi.Location = new System.Drawing.Point(92, 328);
            this.gecerlimi.Name = "gecerlimi";
            this.gecerlimi.Size = new System.Drawing.Size(127, 32);
            this.gecerlimi.TabIndex = 12;
            this.gecerlimi.Text = "Geçerli mi ?";
            this.gecerlimi.UseVisualStyleBackColor = true;
            this.gecerlimi.Click += new System.EventHandler(this.gecerlimi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 545);
            this.Controls.Add(this.gecerlimi);
            this.Controls.Add(this.aktarim);
            this.Controls.Add(this.butunaktarimlar);
            this.Controls.Add(this.gonderilenparamiktar);
            this.Controls.Add(this.gonderilenpara);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.AlicininAdi);
            this.Controls.Add(this.gondereninAdi);
            this.Controls.Add(this.ParayiAktar);
            this.Controls.Add(this.alici);
            this.Controls.Add(this.gonderen);
            this.Name = "Form1";
            this.Text = "Blok Zinciri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gonderen;
        private System.Windows.Forms.Label alici;
        private System.Windows.Forms.Button ParayiAktar;
        private System.Windows.Forms.TextBox gondereninAdi;
        private System.Windows.Forms.TextBox AlicininAdi;
        private System.Windows.Forms.Label coin;
        private System.Windows.Forms.TextBox gonderilenpara;
        private System.Windows.Forms.Label gonderilenparamiktar;
        private System.Windows.Forms.RichTextBox butunaktarimlar;
        private System.Windows.Forms.Label aktarim;
        private System.Windows.Forms.Button gecerlimi;
    }
}

