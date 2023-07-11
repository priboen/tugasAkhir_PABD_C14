namespace tugasAkhir
{
    partial class Wali_Murid
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
            this.delwaliBtn = new System.Windows.Forms.Button();
            this.add_updateBtn = new System.Windows.Forms.Button();
            this.tugasAkhirDataSet5 = new tugasAkhir.tugasAkhirDataSet5();
            this.walimuridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wali_muridTableAdapter = new tugasAkhir.tugasAkhirDataSet5TableAdapters.wali_muridTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namawaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pekerjaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuswaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatwaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nISNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.walimuridBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tugasAkhirDataSet6 = new tugasAkhir.tugasAkhirDataSet6();
            this.wali_muridTableAdapter1 = new tugasAkhir.tugasAkhirDataSet6TableAdapters.wali_muridTableAdapter();
            this.clsbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walimuridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walimuridBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.clsbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(246, 9);
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 400);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(795, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 400);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 445);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 5);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.delwaliBtn);
            this.panel5.Controls.Add(this.add_updateBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(790, 76);
            this.panel5.TabIndex = 6;
            // 
            // delwaliBtn
            // 
            this.delwaliBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.delwaliBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delwaliBtn.ForeColor = System.Drawing.Color.White;
            this.delwaliBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delwaliBtn.Location = new System.Drawing.Point(202, 18);
            this.delwaliBtn.Name = "delwaliBtn";
            this.delwaliBtn.Size = new System.Drawing.Size(117, 38);
            this.delwaliBtn.TabIndex = 2;
            this.delwaliBtn.Text = "Hapus Data Wali";
            this.delwaliBtn.UseVisualStyleBackColor = false;
            this.delwaliBtn.Click += new System.EventHandler(this.delwaliBtn_Click);
            // 
            // add_updateBtn
            // 
            this.add_updateBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.add_updateBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_updateBtn.ForeColor = System.Drawing.Color.White;
            this.add_updateBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.add_updateBtn.Location = new System.Drawing.Point(19, 18);
            this.add_updateBtn.Name = "add_updateBtn";
            this.add_updateBtn.Size = new System.Drawing.Size(166, 38);
            this.add_updateBtn.TabIndex = 0;
            this.add_updateBtn.Text = "Tambah/Ubah Data Wali";
            this.add_updateBtn.UseVisualStyleBackColor = false;
            this.add_updateBtn.Click += new System.EventHandler(this.add_updateBtn_Click);
            // 
            // tugasAkhirDataSet5
            // 
            this.tugasAkhirDataSet5.DataSetName = "tugasAkhirDataSet5";
            this.tugasAkhirDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // walimuridBindingSource
            // 
            this.walimuridBindingSource.DataMember = "wali_murid";
            this.walimuridBindingSource.DataSource = this.tugasAkhirDataSet5;
            // 
            // wali_muridTableAdapter
            // 
            this.wali_muridTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIKDataGridViewTextBoxColumn,
            this.namawaliDataGridViewTextBoxColumn,
            this.pekerjaanDataGridViewTextBoxColumn,
            this.statuswaliDataGridViewTextBoxColumn,
            this.alamatwaliDataGridViewTextBoxColumn,
            this.nISNDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.walimuridBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 306);
            this.dataGridView1.TabIndex = 7;
            // 
            // nIKDataGridViewTextBoxColumn
            // 
            this.nIKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nIKDataGridViewTextBoxColumn.DataPropertyName = "NIK";
            this.nIKDataGridViewTextBoxColumn.HeaderText = "NIK";
            this.nIKDataGridViewTextBoxColumn.Name = "nIKDataGridViewTextBoxColumn";
            // 
            // namawaliDataGridViewTextBoxColumn
            // 
            this.namawaliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namawaliDataGridViewTextBoxColumn.DataPropertyName = "nama_wali";
            this.namawaliDataGridViewTextBoxColumn.HeaderText = "Nama Wali Murid";
            this.namawaliDataGridViewTextBoxColumn.Name = "namawaliDataGridViewTextBoxColumn";
            // 
            // pekerjaanDataGridViewTextBoxColumn
            // 
            this.pekerjaanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pekerjaanDataGridViewTextBoxColumn.DataPropertyName = "pekerjaan";
            this.pekerjaanDataGridViewTextBoxColumn.HeaderText = "Pekerjaan";
            this.pekerjaanDataGridViewTextBoxColumn.Name = "pekerjaanDataGridViewTextBoxColumn";
            // 
            // statuswaliDataGridViewTextBoxColumn
            // 
            this.statuswaliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statuswaliDataGridViewTextBoxColumn.DataPropertyName = "status_wali";
            this.statuswaliDataGridViewTextBoxColumn.HeaderText = "Status Wali Murid";
            this.statuswaliDataGridViewTextBoxColumn.Name = "statuswaliDataGridViewTextBoxColumn";
            // 
            // alamatwaliDataGridViewTextBoxColumn
            // 
            this.alamatwaliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alamatwaliDataGridViewTextBoxColumn.DataPropertyName = "alamat_wali";
            this.alamatwaliDataGridViewTextBoxColumn.HeaderText = "Alamat Wali Murid";
            this.alamatwaliDataGridViewTextBoxColumn.Name = "alamatwaliDataGridViewTextBoxColumn";
            this.alamatwaliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nISNDataGridViewTextBoxColumn
            // 
            this.nISNDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nISNDataGridViewTextBoxColumn.DataPropertyName = "NISN";
            this.nISNDataGridViewTextBoxColumn.HeaderText = "NISN";
            this.nISNDataGridViewTextBoxColumn.Name = "nISNDataGridViewTextBoxColumn";
            // 
            // walimuridBindingSource1
            // 
            this.walimuridBindingSource1.DataMember = "wali_murid";
            this.walimuridBindingSource1.DataSource = this.tugasAkhirDataSet6;
            // 
            // tugasAkhirDataSet6
            // 
            this.tugasAkhirDataSet6.DataSetName = "tugasAkhirDataSet6";
            this.tugasAkhirDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wali_muridTableAdapter1
            // 
            this.wali_muridTableAdapter1.ClearBeforeFill = true;
            // 
            // clsbtn
            // 
            this.clsbtn.FlatAppearance.BorderSize = 0;
            this.clsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsbtn.ForeColor = System.Drawing.Color.White;
            this.clsbtn.Location = new System.Drawing.Point(741, 14);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(28, 28);
            this.clsbtn.TabIndex = 6;
            this.clsbtn.Text = "X";
            this.clsbtn.UseVisualStyleBackColor = true;
            this.clsbtn.Click += new System.EventHandler(this.clsbtn_Click);
            // 
            // Wali_Murid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wali_Murid";
            this.Text = "Wali_Murid";
            this.Load += new System.EventHandler(this.Wali_Murid_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walimuridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walimuridBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button delwaliBtn;
        private System.Windows.Forms.Button add_updateBtn;
        private tugasAkhirDataSet5 tugasAkhirDataSet5;
        private System.Windows.Forms.BindingSource walimuridBindingSource;
        private tugasAkhirDataSet5TableAdapters.wali_muridTableAdapter wali_muridTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tugasAkhirDataSet6 tugasAkhirDataSet6;
        private System.Windows.Forms.BindingSource walimuridBindingSource1;
        private tugasAkhirDataSet6TableAdapters.wali_muridTableAdapter wali_muridTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namawaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pekerjaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuswaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatwaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nISNDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button clsbtn;
    }
}