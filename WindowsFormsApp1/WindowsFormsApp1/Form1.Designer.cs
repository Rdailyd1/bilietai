namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bilietai = new System.Windows.Forms.Label();
            this.po_10 = new System.Windows.Forms.Label();
            this.kiekis_po10 = new System.Windows.Forms.Label();
            this.kiekis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_skaicius = new System.Windows.Forms.TextBox();
            this.btn_sukurti = new System.Windows.Forms.Button();
            this.po_15 = new System.Windows.Forms.Label();
            this.po_20 = new System.Windows.Forms.Label();
            this.kiekis_po20 = new System.Windows.Forms.Label();
            this.kiekis_po15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(81, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORGANIZACIJA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_bilietai
            // 
            this.tb_bilietai.AutoSize = true;
            this.tb_bilietai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.tb_bilietai.ForeColor = System.Drawing.Color.Maroon;
            this.tb_bilietai.Location = new System.Drawing.Point(85, 51);
            this.tb_bilietai.Name = "tb_bilietai";
            this.tb_bilietai.Size = new System.Drawing.Size(50, 18);
            this.tb_bilietai.TabIndex = 1;
            this.tb_bilietai.Text = "Bilietai";
            // 
            // po_10
            // 
            this.po_10.AutoSize = true;
            this.po_10.Location = new System.Drawing.Point(85, 73);
            this.po_10.Name = "po_10";
            this.po_10.Size = new System.Drawing.Size(65, 13);
            this.po_10.TabIndex = 2;
            this.po_10.Text = "1. Po 10 eur";
            // 
            // kiekis_po10
            // 
            this.kiekis_po10.AutoSize = true;
            this.kiekis_po10.Location = new System.Drawing.Point(215, 73);
            this.kiekis_po10.Name = "kiekis_po10";
            this.kiekis_po10.Size = new System.Drawing.Size(13, 13);
            this.kiekis_po10.TabIndex = 3;
            this.kiekis_po10.Text = "0";
            // 
            // kiekis
            // 
            this.kiekis.AutoSize = true;
            this.kiekis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.kiekis.ForeColor = System.Drawing.Color.Maroon;
            this.kiekis.Location = new System.Drawing.Point(212, 51);
            this.kiekis.Name = "kiekis";
            this.kiekis.Size = new System.Drawing.Size(48, 18);
            this.kiekis.TabIndex = 4;
            this.kiekis.Text = "Kiekis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Įrašykite bilieto tipą (Nr.)";
            // 
            // tb_skaicius
            // 
            this.tb_skaicius.Location = new System.Drawing.Point(207, 154);
            this.tb_skaicius.Name = "tb_skaicius";
            this.tb_skaicius.Size = new System.Drawing.Size(61, 20);
            this.tb_skaicius.TabIndex = 6;
            // 
            // btn_sukurti
            // 
            this.btn_sukurti.Location = new System.Drawing.Point(91, 204);
            this.btn_sukurti.Name = "btn_sukurti";
            this.btn_sukurti.Size = new System.Drawing.Size(118, 23);
            this.btn_sukurti.TabIndex = 7;
            this.btn_sukurti.Text = "Sukurti";
            this.btn_sukurti.UseVisualStyleBackColor = true;
            this.btn_sukurti.Click += new System.EventHandler(this.btnsukurti_Click);
            // 
            // po_15
            // 
            this.po_15.AutoSize = true;
            this.po_15.Location = new System.Drawing.Point(85, 99);
            this.po_15.Name = "po_15";
            this.po_15.Size = new System.Drawing.Size(65, 13);
            this.po_15.TabIndex = 8;
            this.po_15.Text = "2. Po 15 eur";
            // 
            // po_20
            // 
            this.po_20.AutoSize = true;
            this.po_20.Location = new System.Drawing.Point(85, 123);
            this.po_20.Name = "po_20";
            this.po_20.Size = new System.Drawing.Size(65, 13);
            this.po_20.TabIndex = 9;
            this.po_20.Text = "3. Po 20 eur";
            // 
            // kiekis_po20
            // 
            this.kiekis_po20.AutoSize = true;
            this.kiekis_po20.Location = new System.Drawing.Point(215, 123);
            this.kiekis_po20.Name = "kiekis_po20";
            this.kiekis_po20.Size = new System.Drawing.Size(13, 13);
            this.kiekis_po20.TabIndex = 10;
            this.kiekis_po20.Text = "0";
            // 
            // kiekis_po15
            // 
            this.kiekis_po15.AutoSize = true;
            this.kiekis_po15.Location = new System.Drawing.Point(215, 99);
            this.kiekis_po15.Name = "kiekis_po15";
            this.kiekis_po15.Size = new System.Drawing.Size(13, 13);
            this.kiekis_po15.TabIndex = 11;
            this.kiekis_po15.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 588);
            this.Controls.Add(this.kiekis_po15);
            this.Controls.Add(this.kiekis_po20);
            this.Controls.Add(this.po_20);
            this.Controls.Add(this.po_15);
            this.Controls.Add(this.btn_sukurti);
            this.Controls.Add(this.tb_skaicius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kiekis);
            this.Controls.Add(this.kiekis_po10);
            this.Controls.Add(this.po_10);
            this.Controls.Add(this.tb_bilietai);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bilietai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tb_bilietai;
        private System.Windows.Forms.Label po_10;
        private System.Windows.Forms.Label kiekis_po10;
        private System.Windows.Forms.Label kiekis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_skaicius;
        private System.Windows.Forms.Button btn_sukurti;
        private System.Windows.Forms.Label po_15;
        private System.Windows.Forms.Label po_20;
        private System.Windows.Forms.Label kiekis_po20;
        private System.Windows.Forms.Label kiekis_po15;
    }
}

