namespace tugasAkhir
{
    partial class mata_pelajaran
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delMataPel = new System.Windows.Forms.Button();
            this.matapelFormBtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matapelajaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tugasAkhirDataSet4 = new tugasAkhir.tugasAkhirDataSet4();
            this.mata_pelajaranTableAdapter = new tugasAkhir.tugasAkhirDataSet4TableAdapters.mata_pelajaranTableAdapter();
            this.idmapelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamapelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tingkatkelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matapelajaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet4)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(967, 73);
            this.panel1.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(350, 20);
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
            this.panel2.Size = new System.Drawing.Size(5, 377);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(962, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 377);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 445);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(957, 5);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.delMataPel);
            this.panel5.Controls.Add(this.matapelFormBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 73);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(957, 76);
            this.panel5.TabIndex = 8;
            // 
            // delMataPel
            // 
            this.delMataPel.BackColor = System.Drawing.Color.SteelBlue;
            this.delMataPel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delMataPel.ForeColor = System.Drawing.Color.White;
            this.delMataPel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delMataPel.Location = new System.Drawing.Point(288, 18);
            this.delMataPel.Name = "delMataPel";
            this.delMataPel.Size = new System.Drawing.Size(186, 38);
            this.delMataPel.TabIndex = 2;
            this.delMataPel.Text = "Hapus Data Mata Pelajaran";
            this.delMataPel.UseVisualStyleBackColor = false;
            this.delMataPel.Click += new System.EventHandler(this.delMataPel_Click);
            // 
            // matapelFormBtn
            // 
            this.matapelFormBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.matapelFormBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matapelFormBtn.ForeColor = System.Drawing.Color.White;
            this.matapelFormBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.matapelFormBtn.Location = new System.Drawing.Point(19, 18);
            this.matapelFormBtn.Name = "matapelFormBtn";
            this.matapelFormBtn.Size = new System.Drawing.Size(225, 38);
            this.matapelFormBtn.TabIndex = 0;
            this.matapelFormBtn.Text = "Tambah/Ubah Data Mata Pelajaran";
            this.matapelFormBtn.UseVisualStyleBackColor = false;
            this.matapelFormBtn.Click += new System.EventHandler(this.matapelFormBtn_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(12, 155);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(943, 283);
            this.panel6.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmapelDataGridViewTextBoxColumn,
            this.namamapelDataGridViewTextBoxColumn,
            this.tingkatkelasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matapelajaranBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(957, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // matapelajaranBindingSource
            // 
            this.matapelajaranBindingSource.DataMember = "mata_pelajaran";
            this.matapelajaranBindingSource.DataSource = this.tugasAkhirDataSet4;
            // 
            // tugasAkhirDataSet4
            // 
            this.tugasAkhirDataSet4.DataSetName = "tugasAkhirDataSet4";
            this.tugasAkhirDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mata_pelajaranTableAdapter
            // 
            this.mata_pelajaranTableAdapter.ClearBeforeFill = true;
            // 
            // idmapelDataGridViewTextBoxColumn
            // 
            this.idmapelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idmapelDataGridViewTextBoxColumn.DataPropertyName = "id_mapel";
            this.idmapelDataGridViewTextBoxColumn.HeaderText = "ID Mata Pelajaran";
            this.idmapelDataGridViewTextBoxColumn.Name = "idmapelDataGridViewTextBoxColumn";
            // 
            // namamapelDataGridViewTextBoxColumn
            // 
            this.namamapelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namamapelDataGridViewTextBoxColumn.DataPropertyName = "nama_mapel";
            this.namamapelDataGridViewTextBoxColumn.HeaderText = "Nama Mata Pelajaran";
            this.namamapelDataGridViewTextBoxColumn.Name = "namamapelDataGridViewTextBoxColumn";
            // 
            // tingkatkelasDataGridViewTextBoxColumn
            // 
            this.tingkatkelasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tingkatkelasDataGridViewTextBoxColumn.DataPropertyName = "tingkat_kelas";
            this.tingkatkelasDataGridViewTextBoxColumn.HeaderText = "Kelas";
            this.tingkatkelasDataGridViewTextBoxColumn.Name = "tingkatkelasDataGridViewTextBoxColumn";
            // 
            // mata_pelajaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mata_pelajaran";
            this.Text = "mata_pelajaran";
            this.Load += new System.EventHandler(this.mata_pelajaran_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matapelajaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button delMataPel;
        private System.Windows.Forms.Button matapelFormBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private tugasAkhirDataSet4 tugasAkhirDataSet4;
        private System.Windows.Forms.BindingSource matapelajaranBindingSource;
        private tugasAkhirDataSet4TableAdapters.mata_pelajaranTableAdapter mata_pelajaranTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmapelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamapelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tingkatkelasDataGridViewTextBoxColumn;
    }
}