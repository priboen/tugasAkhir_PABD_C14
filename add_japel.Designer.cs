namespace tugasAkhir
{
    partial class add_japel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idMapel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdJPTXT = new System.Windows.Forms.TextBox();
            this.cbxKelas = new System.Windows.Forms.ComboBox();
            this.cbxNamaMapel = new System.Windows.Forms.ComboBox();
            this.jamtxt = new System.Windows.Forms.TextBox();
            this.cbxGuru = new System.Windows.Forms.ComboBox();
            this.NIPtxt = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tugasAkhirDataSet9 = new tugasAkhir.tugasAkhirDataSet9();
            this.guruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guruTableAdapter = new tugasAkhir.tugasAkhirDataSet9TableAdapters.guruTableAdapter();
            this.cbxHari = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 57);
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
            this.label10.Location = new System.Drawing.Point(209, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(395, 33);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tambah/Ubah Jadwal Pelajaran";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 445);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(795, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 445);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Jadwal Pelajaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Mata Pelajaran";
            // 
            // idMapel
            // 
            this.idMapel.AutoSize = true;
            this.idMapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idMapel.Location = new System.Drawing.Point(291, 174);
            this.idMapel.Name = "idMapel";
            this.idMapel.Size = new System.Drawing.Size(92, 13);
            this.idMapel.TabIndex = 7;
            this.idMapel.Text = "ID Mata Pelajaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kelas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hari";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Jam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Guru Pengampu";
            // 
            // IdJPTXT
            // 
            this.IdJPTXT.Location = new System.Drawing.Point(294, 98);
            this.IdJPTXT.Name = "IdJPTXT";
            this.IdJPTXT.Size = new System.Drawing.Size(424, 20);
            this.IdJPTXT.TabIndex = 12;
            // 
            // cbxKelas
            // 
            this.cbxKelas.FormattingEnabled = true;
            this.cbxKelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbxKelas.Location = new System.Drawing.Point(294, 208);
            this.cbxKelas.Name = "cbxKelas";
            this.cbxKelas.Size = new System.Drawing.Size(121, 21);
            this.cbxKelas.TabIndex = 14;
            // 
            // cbxNamaMapel
            // 
            this.cbxNamaMapel.FormattingEnabled = true;
            this.cbxNamaMapel.Location = new System.Drawing.Point(294, 139);
            this.cbxNamaMapel.Name = "cbxNamaMapel";
            this.cbxNamaMapel.Size = new System.Drawing.Size(424, 21);
            this.cbxNamaMapel.TabIndex = 15;
            this.cbxNamaMapel.SelectedIndexChanged += new System.EventHandler(this.cbxNamaMapel_SelectedIndexChanged);
            // 
            // jamtxt
            // 
            this.jamtxt.Location = new System.Drawing.Point(294, 288);
            this.jamtxt.Name = "jamtxt";
            this.jamtxt.Size = new System.Drawing.Size(131, 20);
            this.jamtxt.TabIndex = 17;
            // 
            // cbxGuru
            // 
            this.cbxGuru.FormattingEnabled = true;
            this.cbxGuru.Location = new System.Drawing.Point(294, 326);
            this.cbxGuru.Name = "cbxGuru";
            this.cbxGuru.Size = new System.Drawing.Size(424, 21);
            this.cbxGuru.TabIndex = 18;
            this.cbxGuru.SelectedIndexChanged += new System.EventHandler(this.cbxGuru_SelectedIndexChanged);
            // 
            // NIPtxt
            // 
            this.NIPtxt.AutoSize = true;
            this.NIPtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIPtxt.Location = new System.Drawing.Point(291, 364);
            this.NIPtxt.Name = "NIPtxt";
            this.NIPtxt.Size = new System.Drawing.Size(25, 13);
            this.NIPtxt.TabIndex = 19;
            this.NIPtxt.Text = "NIP";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 497);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 5);
            this.panel4.TabIndex = 20;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(424, 427);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(113, 37);
            this.updateBtn.TabIndex = 31;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(265, 427);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(113, 37);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tugasAkhirDataSet9
            // 
            this.tugasAkhirDataSet9.DataSetName = "tugasAkhirDataSet9";
            this.tugasAkhirDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guruBindingSource
            // 
            this.guruBindingSource.DataMember = "guru";
            this.guruBindingSource.DataSource = this.tugasAkhirDataSet9;
            // 
            // guruTableAdapter
            // 
            this.guruTableAdapter.ClearBeforeFill = true;
            // 
            // cbxHari
            // 
            this.cbxHari.FormattingEnabled = true;
            this.cbxHari.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu"});
            this.cbxHari.Location = new System.Drawing.Point(294, 250);
            this.cbxHari.Name = "cbxHari";
            this.cbxHari.Size = new System.Drawing.Size(121, 21);
            this.cbxHari.TabIndex = 32;
            // 
            // add_japel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.cbxHari);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.NIPtxt);
            this.Controls.Add(this.cbxGuru);
            this.Controls.Add(this.jamtxt);
            this.Controls.Add(this.cbxNamaMapel);
            this.Controls.Add(this.cbxKelas);
            this.Controls.Add(this.IdJPTXT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idMapel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_japel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_japel";
            this.Load += new System.EventHandler(this.add_japel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idMapel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdJPTXT;
        private System.Windows.Forms.ComboBox cbxKelas;
        private System.Windows.Forms.ComboBox cbxNamaMapel;
        private System.Windows.Forms.TextBox jamtxt;
        private System.Windows.Forms.ComboBox cbxGuru;
        private System.Windows.Forms.Label NIPtxt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private tugasAkhirDataSet9 tugasAkhirDataSet9;
        private System.Windows.Forms.BindingSource guruBindingSource;
        private tugasAkhirDataSet9TableAdapters.guruTableAdapter guruTableAdapter;
        private System.Windows.Forms.ComboBox cbxHari;
    }
}