namespace Mekteb
{
    partial class frmMekteb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMekteb));
            this.pcbSagird = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbMuellim = new System.Windows.Forms.PictureBox();
            this.txtNomre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSagird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMuellim)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbSagird
            // 
            this.pcbSagird.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSagird.Image = ((System.Drawing.Image)(resources.GetObject("pcbSagird.Image")));
            this.pcbSagird.Location = new System.Drawing.Point(33, 31);
            this.pcbSagird.Name = "pcbSagird";
            this.pcbSagird.Size = new System.Drawing.Size(78, 76);
            this.pcbSagird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSagird.TabIndex = 0;
            this.pcbSagird.TabStop = false;
            this.pcbSagird.Click += new System.EventHandler(this.pcbSagird_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şagird";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müəllim";
            // 
            // pcbMuellim
            // 
            this.pcbMuellim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMuellim.Image = ((System.Drawing.Image)(resources.GetObject("pcbMuellim.Image")));
            this.pcbMuellim.Location = new System.Drawing.Point(206, 31);
            this.pcbMuellim.Name = "pcbMuellim";
            this.pcbMuellim.Size = new System.Drawing.Size(78, 76);
            this.pcbMuellim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMuellim.TabIndex = 4;
            this.pcbMuellim.TabStop = false;
            this.pcbMuellim.Click += new System.EventHandler(this.pcbMuellim_Click);
            // 
            // txtNomre
            // 
            this.txtNomre.Location = new System.Drawing.Point(33, 166);
            this.txtNomre.Name = "txtNomre";
            this.txtNomre.Size = new System.Drawing.Size(251, 20);
            this.txtNomre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nömrə:";
            // 
            // frmMekteb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(318, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomre);
            this.Controls.Add(this.pcbMuellim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbSagird);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMekteb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbSagird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMuellim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbSagird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbMuellim;
        private System.Windows.Forms.TextBox txtNomre;
        private System.Windows.Forms.Label label3;
    }
}

