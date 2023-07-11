namespace tugasAkhir
{
    partial class delete_jadpel
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delbtn = new System.Windows.Forms.Button();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.namaMP = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(663, 57);
            this.panel1.TabIndex = 6;
            // 
            // clsbtn
            // 
            this.clsbtn.FlatAppearance.BorderSize = 0;
            this.clsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clsbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsbtn.ForeColor = System.Drawing.Color.White;
            this.clsbtn.Location = new System.Drawing.Point(625, 12);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(30, 30);
            this.clsbtn.TabIndex = 7;
            this.clsbtn.Text = "X";
            this.clsbtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(158, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(318, 33);
            this.label10.TabIndex = 6;
            this.label10.Text = "Hapus Jadwal Pelajaraan";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 236);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(658, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 236);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 288);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(653, 5);
            this.panel4.TabIndex = 9;
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.delbtn.FlatAppearance.BorderSize = 0;
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.ForeColor = System.Drawing.Color.White;
            this.delbtn.Location = new System.Drawing.Point(279, 201);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(111, 40);
            this.delbtn.TabIndex = 18;
            this.delbtn.Text = "Hapus";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // cbxID
            // 
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(259, 122);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(346, 21);
            this.cbxID.TabIndex = 16;
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Mata Pelajaran";
            // 
            // namaMP
            // 
            this.namaMP.AutoSize = true;
            this.namaMP.Location = new System.Drawing.Point(259, 150);
            this.namaMP.Name = "namaMP";
            this.namaMP.Size = new System.Drawing.Size(109, 13);
            this.namaMP.TabIndex = 19;
            this.namaMP.Text = "Nama Mata Pelajaran";
            // 
            // delete_jadpel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 293);
            this.Controls.Add(this.namaMP);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.cbxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete_jadpel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delete_jadpel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clsbtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label namaMP;
    }
}