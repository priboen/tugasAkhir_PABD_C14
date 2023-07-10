namespace tugasAkhir
{
    partial class hapus_mapel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clsbtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNamaPel = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.Label();
            this.delbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.clsbtn);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 57);
            this.panel1.TabIndex = 6;
            // 
            // clsbtn
            // 
            this.clsbtn.FlatAppearance.BorderSize = 0;
            this.clsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsbtn.ForeColor = System.Drawing.Color.White;
            this.clsbtn.Location = new System.Drawing.Point(660, 15);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(30, 30);
            this.clsbtn.TabIndex = 7;
            this.clsbtn.Text = "X";
            this.clsbtn.UseVisualStyleBackColor = true;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(165, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(342, 33);
            this.label10.TabIndex = 6;
            this.label10.Text = "Hapus Data Mata Pelajaran";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nama Mata Pelajaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Mata Pelajaran";
            // 
            // cbxNamaPel
            // 
            this.cbxNamaPel.FormattingEnabled = true;
            this.cbxNamaPel.Location = new System.Drawing.Point(221, 104);
            this.cbxNamaPel.Name = "cbxNamaPel";
            this.cbxNamaPel.Size = new System.Drawing.Size(346, 21);
            this.cbxNamaPel.TabIndex = 12;
            this.cbxNamaPel.SelectedIndexChanged += new System.EventHandler(this.cbxNamaPel_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(217, 150);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(64, 20);
            this.txtID.TabIndex = 13;
            this.txtID.Text = "idmapel";
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.delbtn.FlatAppearance.BorderSize = 0;
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.ForeColor = System.Drawing.Color.White;
            this.delbtn.Location = new System.Drawing.Point(290, 220);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(111, 40);
            this.delbtn.TabIndex = 14;
            this.delbtn.Text = "Hapus";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // hapus_mapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 333);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbxNamaPel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hapus_mapel";
            this.Text = "hapus_mapel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clsbtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxNamaPel;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button delbtn;
    }
}