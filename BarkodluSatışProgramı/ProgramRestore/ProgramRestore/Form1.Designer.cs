namespace ProgramRestore
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
            this.tDosya = new System.Windows.Forms.TextBox();
            this.bYukle = new System.Windows.Forms.Button();
            this.bYedekSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tDosya
            // 
            this.tDosya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tDosya.Location = new System.Drawing.Point(12, 47);
            this.tDosya.Name = "tDosya";
            this.tDosya.Size = new System.Drawing.Size(367, 30);
            this.tDosya.TabIndex = 0;
            // 
            // bYukle
            // 
            this.bYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bYukle.Location = new System.Drawing.Point(385, 94);
            this.bYukle.Name = "bYukle";
            this.bYukle.Size = new System.Drawing.Size(139, 56);
            this.bYukle.TabIndex = 1;
            this.bYukle.Text = "YÜKLE";
            this.bYukle.UseVisualStyleBackColor = true;
            this.bYukle.Click += new System.EventHandler(this.bYukle_Click);
            // 
            // bYedekSec
            // 
            this.bYedekSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bYedekSec.Location = new System.Drawing.Point(385, 41);
            this.bYedekSec.Name = "bYedekSec";
            this.bYedekSec.Size = new System.Drawing.Size(139, 40);
            this.bYedekSec.TabIndex = 2;
            this.bYedekSec.Text = "Yedek Seç";
            this.bYedekSec.UseVisualStyleBackColor = true;
            this.bYedekSec.Click += new System.EventHandler(this.bYedekSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "En son aldığınız yedeği seçiniz...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bu işlemi yaptığınız zaman mevcut\r\nveriler silinecek. Yedeğinizdeki \r\nbilgiler yü" +
    "klenecektir.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bYedekSec);
            this.Controls.Add(this.bYukle);
            this.Controls.Add(this.tDosya);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkodlu Satış Programı Yedekten Yükleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDosya;
        private System.Windows.Forms.Button bYukle;
        private System.Windows.Forms.Button bYedekSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

