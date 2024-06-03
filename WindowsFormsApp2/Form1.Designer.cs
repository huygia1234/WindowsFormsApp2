namespace WindowsFormsApp2
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
            this.btnChuvi = new System.Windows.Forms.Button();
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnDientich = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chuvi = new System.Windows.Forms.RadioButton();
            this.Dientich = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChuvi
            // 
            this.btnChuvi.Location = new System.Drawing.Point(73, 230);
            this.btnChuvi.Name = "btnChuvi";
            this.btnChuvi.Size = new System.Drawing.Size(75, 23);
            this.btnChuvi.TabIndex = 0;
            this.btnChuvi.Text = "Chu vi";
            this.btnChuvi.UseVisualStyleBackColor = true;
            this.btnChuvi.Click += new System.EventHandler(this.btnChuvi_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(56, 39);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(13, 13);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(56, 88);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(13, 13);
            this.lblb.TabIndex = 2;
            this.lblb.Text = "b";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(141, 36);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(141, 81);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 4;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(141, 128);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(56, 135);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(54, 13);
            this.lblKQ.TabIndex = 6;
            this.lblKQ.Text = "KET QUA";
            // 
            // btnDientich
            // 
            this.btnDientich.Location = new System.Drawing.Point(275, 230);
            this.btnDientich.Name = "btnDientich";
            this.btnDientich.Size = new System.Drawing.Size(75, 23);
            this.btnDientich.TabIndex = 7;
            this.btnDientich.Text = "DIEN TICH";
            this.btnDientich.UseVisualStyleBackColor = true;
            this.btnDientich.Click += new System.EventHandler(this.btnDientich_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(275, 288);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "THOÁT ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dientich);
            this.groupBox1.Controls.Add(this.Chuvi);
            this.groupBox1.Location = new System.Drawing.Point(483, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Chuvi
            // 
            this.Chuvi.AutoSize = true;
            this.Chuvi.Location = new System.Drawing.Point(18, 19);
            this.Chuvi.Name = "Chuvi";
            this.Chuvi.Size = new System.Drawing.Size(52, 17);
            this.Chuvi.TabIndex = 0;
            this.Chuvi.TabStop = true;
            this.Chuvi.Text = "Chuvi";
            this.Chuvi.UseVisualStyleBackColor = true;
            this.Chuvi.CheckedChanged += new System.EventHandler(this.Chuvi_CheckedChanged);
            // 
            // Dientich
            // 
            this.Dientich.AutoSize = true;
            this.Dientich.Location = new System.Drawing.Point(18, 42);
            this.Dientich.Name = "Dientich";
            this.Dientich.Size = new System.Drawing.Size(64, 17);
            this.Dientich.TabIndex = 1;
            this.Dientich.TabStop = true;
            this.Dientich.Text = "Dientich";
            this.Dientich.UseVisualStyleBackColor = true;
            this.Dientich.CheckedChanged += new System.EventHandler(this.Dientich_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDientich);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.btnChuvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChuvi;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnDientich;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Dientich;
        private System.Windows.Forms.RadioButton Chuvi;
    }
}

