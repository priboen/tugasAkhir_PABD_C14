namespace tugasAkhir
{
    partial class nilaisiswa
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
            this.closebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delnilaiBtn = new System.Windows.Forms.Button();
            this.addnilaiBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idnilaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nISNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmapelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tugasAkhirDataSet7 = new tugasAkhir.tugasAkhirDataSet7();
            this.nilaiTableAdapter = new tugasAkhir.tugasAkhirDataSet7TableAdapters.nilaiTableAdapter();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet7)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1017, 73);
            this.panel1.TabIndex = 1;
            // 
            // closebtn
            // 
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(977, 26);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(28, 28);
            this.closebtn.TabIndex = 6;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 458);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 526);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 5);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1012, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 453);
            this.panel3.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.delnilaiBtn);
            this.panel5.Controls.Add(this.addnilaiBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1007, 76);
            this.panel5.TabIndex = 8;
            // 
            // delnilaiBtn
            // 
            this.delnilaiBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.delnilaiBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delnilaiBtn.ForeColor = System.Drawing.Color.White;
            this.delnilaiBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delnilaiBtn.Location = new System.Drawing.Point(202, 18);
            this.delnilaiBtn.Name = "delnilaiBtn";
            this.delnilaiBtn.Size = new System.Drawing.Size(117, 38);
            this.delnilaiBtn.TabIndex = 2;
            this.delnilaiBtn.Text = "Hapus Data Nilai";
            this.delnilaiBtn.UseVisualStyleBackColor = false;
            this.delnilaiBtn.Click += new System.EventHandler(this.delnilaiBtn_Click);
            // 
            // addnilaiBtn
            // 
            this.addnilaiBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.addnilaiBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnilaiBtn.ForeColor = System.Drawing.Color.White;
            this.addnilaiBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addnilaiBtn.Location = new System.Drawing.Point(19, 18);
            this.addnilaiBtn.Name = "addnilaiBtn";
            this.addnilaiBtn.Size = new System.Drawing.Size(166, 38);
            this.addnilaiBtn.TabIndex = 0;
            this.addnilaiBtn.Text = "Tambah/Ubah Data Nilai";
            this.addnilaiBtn.UseVisualStyleBackColor = false;
            this.addnilaiBtn.Click += new System.EventHandler(this.addnilaiBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1007, 5);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(11, 160);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(994, 359);
            this.panel7.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnilaiDataGridViewTextBoxColumn,
            this.nISNDataGridViewTextBoxColumn,
            this.nilaiDataGridViewTextBoxColumn,
            this.idmapelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nilaiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(994, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // idnilaiDataGridViewTextBoxColumn
            // 
            this.idnilaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idnilaiDataGridViewTextBoxColumn.DataPropertyName = "id_nilai";
            this.idnilaiDataGridViewTextBoxColumn.HeaderText = "ID Nilai";
            this.idnilaiDataGridViewTextBoxColumn.Name = "idnilaiDataGridViewTextBoxColumn";
            // 
            // nISNDataGridViewTextBoxColumn
            // 
            this.nISNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nISNDataGridViewTextBoxColumn.DataPropertyName = "NISN";
            this.nISNDataGridViewTextBoxColumn.HeaderText = "Nomor Induk Siswa Nasional";
            this.nISNDataGridViewTextBoxColumn.Name = "nISNDataGridViewTextBoxColumn";
            // 
            // nilaiDataGridViewTextBoxColumn
            // 
            this.nilaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nilaiDataGridViewTextBoxColumn.DataPropertyName = "nilai";
            this.nilaiDataGridViewTextBoxColumn.HeaderText = "Nilai Siswa";
            this.nilaiDataGridViewTextBoxColumn.Name = "nilaiDataGridViewTextBoxColumn";
            // 
            // idmapelDataGridViewTextBoxColumn
            // 
            this.idmapelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idmapelDataGridViewTextBoxColumn.DataPropertyName = "id_mapel";
            this.idmapelDataGridViewTextBoxColumn.HeaderText = "ID Mata Pelajaran";
            this.idmapelDataGridViewTextBoxColumn.Name = "idmapelDataGridViewTextBoxColumn";
            // 
            // nilaiBindingSource
            // 
            this.nilaiBindingSource.DataMember = "nilai";
            this.nilaiBindingSource.DataSource = this.tugasAkhirDataSet7;
            // 
            // tugasAkhirDataSet7
            // 
            this.tugasAkhirDataSet7.DataSetName = "tugasAkhirDataSet7";
            this.tugasAkhirDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nilaiTableAdapter
            // 
            this.nilaiTableAdapter.ClearBeforeFill = true;
            // 
            // nilaisiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 531);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nilaisiswa";
            this.Text = "nilaisiswa";
            this.Load += new System.EventHandler(this.nilaisiswa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nilaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button delnilaiBtn;
        private System.Windows.Forms.Button addnilaiBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tugasAkhirDataSet7 tugasAkhirDataSet7;
        private System.Windows.Forms.BindingSource nilaiBindingSource;
        private tugasAkhirDataSet7TableAdapters.nilaiTableAdapter nilaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnilaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nISNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmapelDataGridViewTextBoxColumn;
    }
}