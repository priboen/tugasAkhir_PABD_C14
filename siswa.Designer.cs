namespace tugasAkhir
{
    partial class siswa
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
            this.label2 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delSiswa = new System.Windows.Forms.Button();
            this.siswaformBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nISNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohportuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatsiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tugasAkhirDataSet2 = new tugasAkhir.tugasAkhirDataSet2();
            this.siswaTableAdapter = new tugasAkhir.tugasAkhirDataSet2TableAdapters.SiswaTableAdapter();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 50);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(282, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "SD Negeri 1 Nanang";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closebtn
            // 
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(821, 12);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(28, 28);
            this.closebtn.TabIndex = 5;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 482);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(856, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 482);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 527);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(851, 5);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.delSiswa);
            this.panel5.Controls.Add(this.siswaformBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(851, 76);
            this.panel5.TabIndex = 5;
            // 
            // delSiswa
            // 
            this.delSiswa.BackColor = System.Drawing.Color.SteelBlue;
            this.delSiswa.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delSiswa.ForeColor = System.Drawing.Color.White;
            this.delSiswa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delSiswa.Location = new System.Drawing.Point(202, 18);
            this.delSiswa.Name = "delSiswa";
            this.delSiswa.Size = new System.Drawing.Size(117, 38);
            this.delSiswa.TabIndex = 2;
            this.delSiswa.Text = "Hapus Data Siswa";
            this.delSiswa.UseVisualStyleBackColor = false;
            this.delSiswa.Click += new System.EventHandler(this.delSiswa_Click);
            // 
            // siswaformBtn
            // 
            this.siswaformBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.siswaformBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siswaformBtn.ForeColor = System.Drawing.Color.White;
            this.siswaformBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.siswaformBtn.Location = new System.Drawing.Point(19, 18);
            this.siswaformBtn.Name = "siswaformBtn";
            this.siswaformBtn.Size = new System.Drawing.Size(166, 38);
            this.siswaformBtn.TabIndex = 0;
            this.siswaformBtn.Text = "Tambah/Ubah Data Siswa";
            this.siswaformBtn.UseVisualStyleBackColor = false;
            this.siswaformBtn.Click += new System.EventHandler(this.siswaformBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(851, 5);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(12, 132);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(837, 389);
            this.panel7.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nISNDataGridViewTextBoxColumn,
            this.namaSiswaDataGridViewTextBoxColumn,
            this.jeniskelDataGridViewTextBoxColumn,
            this.tgllahirDataGridViewTextBoxColumn,
            this.nohportuDataGridViewTextBoxColumn,
            this.alamatsiswaDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siswaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // nISNDataGridViewTextBoxColumn
            // 
            this.nISNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nISNDataGridViewTextBoxColumn.DataPropertyName = "NISN";
            this.nISNDataGridViewTextBoxColumn.HeaderText = "NISN";
            this.nISNDataGridViewTextBoxColumn.Name = "nISNDataGridViewTextBoxColumn";
            // 
            // namaSiswaDataGridViewTextBoxColumn
            // 
            this.namaSiswaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaSiswaDataGridViewTextBoxColumn.DataPropertyName = "Nama_Siswa";
            this.namaSiswaDataGridViewTextBoxColumn.HeaderText = "Nama Siswa";
            this.namaSiswaDataGridViewTextBoxColumn.Name = "namaSiswaDataGridViewTextBoxColumn";
            // 
            // jeniskelDataGridViewTextBoxColumn
            // 
            this.jeniskelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jeniskelDataGridViewTextBoxColumn.DataPropertyName = "jenis_kel";
            this.jeniskelDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.jeniskelDataGridViewTextBoxColumn.Name = "jeniskelDataGridViewTextBoxColumn";
            // 
            // tgllahirDataGridViewTextBoxColumn
            // 
            this.tgllahirDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.HeaderText = "Tanggal Lahir";
            this.tgllahirDataGridViewTextBoxColumn.Name = "tgllahirDataGridViewTextBoxColumn";
            // 
            // nohportuDataGridViewTextBoxColumn
            // 
            this.nohportuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nohportuDataGridViewTextBoxColumn.DataPropertyName = "nohp_ortu";
            this.nohportuDataGridViewTextBoxColumn.HeaderText = "No HP Orang Tua";
            this.nohportuDataGridViewTextBoxColumn.Name = "nohportuDataGridViewTextBoxColumn";
            // 
            // alamatsiswaDataGridViewTextBoxColumn
            // 
            this.alamatsiswaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alamatsiswaDataGridViewTextBoxColumn.DataPropertyName = "alamat_siswa";
            this.alamatsiswaDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatsiswaDataGridViewTextBoxColumn.Name = "alamatsiswaDataGridViewTextBoxColumn";
            this.alamatsiswaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "Staff TU yang menginput";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "Siswa";
            this.siswaBindingSource.DataSource = this.tugasAkhirDataSet2;
            // 
            // tugasAkhirDataSet2
            // 
            this.tugasAkhirDataSet2.DataSetName = "tugasAkhirDataSet2";
            this.tugasAkhirDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 532);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "siswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siswa";
            this.Load += new System.EventHandler(this.siswa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button delSiswa;
        private System.Windows.Forms.Button siswaformBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button closebtn;
        private tugasAkhirDataSet2 tugasAkhirDataSet2;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private tugasAkhirDataSet2TableAdapters.SiswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nISNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohportuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatsiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}