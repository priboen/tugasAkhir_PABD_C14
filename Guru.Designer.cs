namespace tugasAkhir
{
    partial class Guru
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delGuru = new System.Windows.Forms.Button();
            this.guruFormBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.tugasAkhirDataSet3 = new tugasAkhir.tugasAkhirDataSet3();
            this.guruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guruTableAdapter = new tugasAkhir.tugasAkhirDataSet3TableAdapters.guruTableAdapter();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaguruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpguruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatguruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 73);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(955, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 483);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 483);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 551);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 5);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.delGuru);
            this.panel5.Controls.Add(this.guruFormBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(950, 76);
            this.panel5.TabIndex = 6;
            // 
            // delGuru
            // 
            this.delGuru.BackColor = System.Drawing.Color.SteelBlue;
            this.delGuru.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delGuru.ForeColor = System.Drawing.Color.White;
            this.delGuru.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delGuru.Location = new System.Drawing.Point(202, 18);
            this.delGuru.Name = "delGuru";
            this.delGuru.Size = new System.Drawing.Size(117, 38);
            this.delGuru.TabIndex = 2;
            this.delGuru.Text = "Hapus Data Guru";
            this.delGuru.UseVisualStyleBackColor = false;
            this.delGuru.Click += new System.EventHandler(this.delGuru_Click);
            // 
            // guruFormBtn
            // 
            this.guruFormBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.guruFormBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guruFormBtn.ForeColor = System.Drawing.Color.White;
            this.guruFormBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.guruFormBtn.Location = new System.Drawing.Point(19, 18);
            this.guruFormBtn.Name = "guruFormBtn";
            this.guruFormBtn.Size = new System.Drawing.Size(166, 38);
            this.guruFormBtn.TabIndex = 0;
            this.guruFormBtn.Text = "Tambah/Ubah Data Guru";
            this.guruFormBtn.UseVisualStyleBackColor = false;
            this.guruFormBtn.Click += new System.EventHandler(this.guruFormBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(950, 5);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(12, 160);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(936, 384);
            this.panel7.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIPDataGridViewTextBoxColumn,
            this.namaguruDataGridViewTextBoxColumn,
            this.jeniskelDataGridViewTextBoxColumn,
            this.nohpguruDataGridViewTextBoxColumn,
            this.alamatguruDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.guruBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(936, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(344, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 33);
            this.label2.TabIndex = 5;
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
            this.closebtn.Location = new System.Drawing.Point(920, 26);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(28, 28);
            this.closebtn.TabIndex = 6;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // tugasAkhirDataSet3
            // 
            this.tugasAkhirDataSet3.DataSetName = "tugasAkhirDataSet3";
            this.tugasAkhirDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guruBindingSource
            // 
            this.guruBindingSource.DataMember = "guru";
            this.guruBindingSource.DataSource = this.tugasAkhirDataSet3;
            // 
            // guruTableAdapter
            // 
            this.guruTableAdapter.ClearBeforeFill = true;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // namaguruDataGridViewTextBoxColumn
            // 
            this.namaguruDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaguruDataGridViewTextBoxColumn.DataPropertyName = "nama_guru";
            this.namaguruDataGridViewTextBoxColumn.HeaderText = "Nama Guru";
            this.namaguruDataGridViewTextBoxColumn.Name = "namaguruDataGridViewTextBoxColumn";
            // 
            // jeniskelDataGridViewTextBoxColumn
            // 
            this.jeniskelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jeniskelDataGridViewTextBoxColumn.DataPropertyName = "jenis_kel";
            this.jeniskelDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.jeniskelDataGridViewTextBoxColumn.Name = "jeniskelDataGridViewTextBoxColumn";
            // 
            // nohpguruDataGridViewTextBoxColumn
            // 
            this.nohpguruDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nohpguruDataGridViewTextBoxColumn.DataPropertyName = "nohp_guru";
            this.nohpguruDataGridViewTextBoxColumn.HeaderText = "No HandPhone";
            this.nohpguruDataGridViewTextBoxColumn.Name = "nohpguruDataGridViewTextBoxColumn";
            // 
            // alamatguruDataGridViewTextBoxColumn
            // 
            this.alamatguruDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alamatguruDataGridViewTextBoxColumn.DataPropertyName = "alamat_guru";
            this.alamatguruDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatguruDataGridViewTextBoxColumn.Name = "alamatguruDataGridViewTextBoxColumn";
            this.alamatguruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Guru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 556);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Guru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guru";
            this.Load += new System.EventHandler(this.Guru_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guruBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button delGuru;
        private System.Windows.Forms.Button guruFormBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closebtn;
        private tugasAkhirDataSet3 tugasAkhirDataSet3;
        private System.Windows.Forms.BindingSource guruBindingSource;
        private tugasAkhirDataSet3TableAdapters.guruTableAdapter guruTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaguruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpguruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatguruDataGridViewTextBoxColumn;
    }
}