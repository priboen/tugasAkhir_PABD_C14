namespace tugasAkhir
{
    partial class addNilai
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNilaiSiswa = new System.Windows.Forms.TextBox();
            this.cbxNISN = new System.Windows.Forms.ComboBox();
            this.cbxMapel = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.idNilai = new System.Windows.Forms.Label();
            this.NISNlabel = new System.Windows.Forms.Label();
            this.idMapel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 57);
            this.panel1.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(758, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(30, 30);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(249, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(323, 33);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tambah/Ubah Nilai Siswa";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 393);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(807, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 393);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 445);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(802, 5);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Nilai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Siswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nilai Siswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama Mata Pelajaran";
            // 
            // txtNilaiSiswa
            // 
            this.txtNilaiSiswa.Location = new System.Drawing.Point(267, 247);
            this.txtNilaiSiswa.Name = "txtNilaiSiswa";
            this.txtNilaiSiswa.Size = new System.Drawing.Size(424, 20);
            this.txtNilaiSiswa.TabIndex = 10;
            // 
            // cbxNISN
            // 
            this.cbxNISN.FormattingEnabled = true;
            this.cbxNISN.Location = new System.Drawing.Point(267, 164);
            this.cbxNISN.Name = "cbxNISN";
            this.cbxNISN.Size = new System.Drawing.Size(218, 21);
            this.cbxNISN.TabIndex = 27;
            this.cbxNISN.SelectedIndexChanged += new System.EventHandler(this.cbxNISN_SelectedIndexChanged);
            // 
            // cbxMapel
            // 
            this.cbxMapel.FormattingEnabled = true;
            this.cbxMapel.Location = new System.Drawing.Point(267, 295);
            this.cbxMapel.Name = "cbxMapel";
            this.cbxMapel.Size = new System.Drawing.Size(218, 21);
            this.cbxMapel.TabIndex = 28;
            this.cbxMapel.SelectedIndexChanged += new System.EventHandler(this.cbxMapel_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(267, 374);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(113, 37);
            this.saveBtn.TabIndex = 29;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(459, 374);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(113, 37);
            this.ClearBtn.TabIndex = 30;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // idNilai
            // 
            this.idNilai.AutoSize = true;
            this.idNilai.Location = new System.Drawing.Point(267, 117);
            this.idNilai.Name = "idNilai";
            this.idNilai.Size = new System.Drawing.Size(41, 13);
            this.idNilai.TabIndex = 31;
            this.idNilai.Text = "ID Nilai";
            // 
            // NISNlabel
            // 
            this.NISNlabel.AutoSize = true;
            this.NISNlabel.Location = new System.Drawing.Point(267, 192);
            this.NISNlabel.Name = "NISNlabel";
            this.NISNlabel.Size = new System.Drawing.Size(33, 13);
            this.NISNlabel.TabIndex = 32;
            this.NISNlabel.Text = "NISN";
            // 
            // idMapel
            // 
            this.idMapel.AutoSize = true;
            this.idMapel.Location = new System.Drawing.Point(264, 326);
            this.idMapel.Name = "idMapel";
            this.idMapel.Size = new System.Drawing.Size(92, 13);
            this.idMapel.TabIndex = 33;
            this.idMapel.Text = "ID Mata Pelajaran";
            // 
            // addNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.idMapel);
            this.Controls.Add(this.NISNlabel);
            this.Controls.Add(this.idNilai);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cbxMapel);
            this.Controls.Add(this.cbxNISN);
            this.Controls.Add(this.txtNilaiSiswa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addNilai";
            this.Text = "addNilai";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNilaiSiswa;
        private System.Windows.Forms.ComboBox cbxNISN;
        private System.Windows.Forms.ComboBox cbxMapel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label idNilai;
        private System.Windows.Forms.Label NISNlabel;
        private System.Windows.Forms.Label idMapel;
    }
}