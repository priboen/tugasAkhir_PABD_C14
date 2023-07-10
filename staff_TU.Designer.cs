namespace tugasAkhir
{
    partial class staff_TU
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delStaff = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohpTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tugasAkhirDataSet1 = new tugasAkhir.tugasAkhirDataSet1();
            this.tugasAkhirDataSet = new tugasAkhir.tugasAkhirDataSet();
            this.staffTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staff_TUTableAdapter = new tugasAkhir.tugasAkhirDataSetTableAdapters.Staff_TUTableAdapter();
            this.staffTUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staff_TUTableAdapter1 = new tugasAkhir.tugasAkhirDataSet1TableAdapters.Staff_TUTableAdapter();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTUBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 49);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(358, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "SD Negeri 1 Nanang";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(982, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 529);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1023, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 529);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 573);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1018, 5);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.delStaff);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(5, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1018, 71);
            this.panel5.TabIndex = 4;
            // 
            // delStaff
            // 
            this.delStaff.BackColor = System.Drawing.Color.SteelBlue;
            this.delStaff.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delStaff.ForeColor = System.Drawing.Color.White;
            this.delStaff.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.delStaff.Location = new System.Drawing.Point(192, 17);
            this.delStaff.Name = "delStaff";
            this.delStaff.Size = new System.Drawing.Size(117, 38);
            this.delStaff.TabIndex = 2;
            this.delStaff.Text = "Hapus Staff";
            this.delStaff.UseVisualStyleBackColor = false;
            this.delStaff.Click += new System.EventHandler(this.delStaff_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(20, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tambah/Ubah Staff";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 120);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1018, 5);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(12, 131);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1005, 436);
            this.panel7.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIPDataGridViewTextBoxColumn,
            this.namaTUDataGridViewTextBoxColumn,
            this.nohpTUDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.alamat_staff});
            this.dataGridView1.DataSource = this.staffTUBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1005, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.FillWeight = 50F;
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // namaTUDataGridViewTextBoxColumn
            // 
            this.namaTUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaTUDataGridViewTextBoxColumn.DataPropertyName = "nama_TU";
            this.namaTUDataGridViewTextBoxColumn.FillWeight = 70F;
            this.namaTUDataGridViewTextBoxColumn.HeaderText = "Nama Staff";
            this.namaTUDataGridViewTextBoxColumn.Name = "namaTUDataGridViewTextBoxColumn";
            // 
            // nohpTUDataGridViewTextBoxColumn
            // 
            this.nohpTUDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nohpTUDataGridViewTextBoxColumn.DataPropertyName = "nohp_TU";
            this.nohpTUDataGridViewTextBoxColumn.HeaderText = "No Handphone";
            this.nohpTUDataGridViewTextBoxColumn.Name = "nohpTUDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 50F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // alamat_staff
            // 
            this.alamat_staff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alamat_staff.DataPropertyName = "alamat_staff";
            this.alamat_staff.HeaderText = "Alamat";
            this.alamat_staff.Name = "alamat_staff";
            this.alamat_staff.ReadOnly = true;
            // 
            // staffTUBindingSource2
            // 
            this.staffTUBindingSource2.DataMember = "Staff_TU";
            this.staffTUBindingSource2.DataSource = this.tugasAkhirDataSet1;
            // 
            // tugasAkhirDataSet1
            // 
            this.tugasAkhirDataSet1.DataSetName = "tugasAkhirDataSet1";
            this.tugasAkhirDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tugasAkhirDataSet
            // 
            this.tugasAkhirDataSet.DataSetName = "tugasAkhirDataSet";
            this.tugasAkhirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTUBindingSource
            // 
            this.staffTUBindingSource.DataMember = "Staff_TU";
            this.staffTUBindingSource.DataSource = this.tugasAkhirDataSet;
            // 
            // staff_TUTableAdapter
            // 
            this.staff_TUTableAdapter.ClearBeforeFill = true;
            // 
            // staffTUBindingSource1
            // 
            this.staffTUBindingSource1.DataMember = "Staff_TU";
            this.staffTUBindingSource1.DataSource = this.tugasAkhirDataSet;
            // 
            // staff_TUTableAdapter1
            // 
            this.staff_TUTableAdapter1.ClearBeforeFill = true;
            // 
            // staff_TU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 578);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staff_TU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staff_TU";
            this.Load += new System.EventHandler(this.staff_TU_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tugasAkhirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTUBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button delStaff;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private tugasAkhirDataSet tugasAkhirDataSet;
        private System.Windows.Forms.BindingSource staffTUBindingSource;
        private tugasAkhirDataSetTableAdapters.Staff_TUTableAdapter staff_TUTableAdapter;
        private System.Windows.Forms.BindingSource staffTUBindingSource1;
        private tugasAkhirDataSet1 tugasAkhirDataSet1;
        private System.Windows.Forms.BindingSource staffTUBindingSource2;
        private tugasAkhirDataSet1TableAdapters.Staff_TUTableAdapter staff_TUTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohpTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat_staff;
    }
}