namespace Bases_de_datos___Proyecto_final_v1
{
    partial class Consultar
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
            this.labelConsultar = new System.Windows.Forms.Label();
            this.dgvConsultarEmpresa = new System.Windows.Forms.DataGridView();
            this.btnConsultarPortatil = new System.Windows.Forms.Button();
            this.btnBuscarPortatilNit = new System.Windows.Forms.Button();
            this.lbEmpresaNit = new System.Windows.Forms.Label();
            this.txtEmpresaNit = new System.Windows.Forms.TextBox();
            this.IconoBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelConsultar
            // 
            this.labelConsultar.AutoSize = true;
            this.labelConsultar.BackColor = System.Drawing.Color.Transparent;
            this.labelConsultar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsultar.ForeColor = System.Drawing.Color.White;
            this.labelConsultar.Location = new System.Drawing.Point(171, 9);
            this.labelConsultar.Name = "labelConsultar";
            this.labelConsultar.Size = new System.Drawing.Size(322, 32);
            this.labelConsultar.TabIndex = 2;
            this.labelConsultar.Text = "CONSULTAR PORTATILES";
            this.labelConsultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvConsultarEmpresa
            // 
            this.dgvConsultarEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.dgvConsultarEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarEmpresa.Location = new System.Drawing.Point(24, 175);
            this.dgvConsultarEmpresa.Name = "dgvConsultarEmpresa";
            this.dgvConsultarEmpresa.Size = new System.Drawing.Size(664, 213);
            this.dgvConsultarEmpresa.TabIndex = 3;
            // 
            // btnConsultarPortatil
            // 
            this.btnConsultarPortatil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnConsultarPortatil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultarPortatil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarPortatil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPortatil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPortatil.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPortatil.Location = new System.Drawing.Point(456, 56);
            this.btnConsultarPortatil.Name = "btnConsultarPortatil";
            this.btnConsultarPortatil.Size = new System.Drawing.Size(157, 33);
            this.btnConsultarPortatil.TabIndex = 4;
            this.btnConsultarPortatil.Text = "Consultar Portatiles";
            this.btnConsultarPortatil.UseVisualStyleBackColor = false;
            this.btnConsultarPortatil.Click += new System.EventHandler(this.btnConsultarPortatil_Click_1);
            // 
            // btnBuscarPortatilNit
            // 
            this.btnBuscarPortatilNit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnBuscarPortatilNit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarPortatilNit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPortatilNit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPortatilNit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPortatilNit.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPortatilNit.Location = new System.Drawing.Point(456, 104);
            this.btnBuscarPortatilNit.Name = "btnBuscarPortatilNit";
            this.btnBuscarPortatilNit.Size = new System.Drawing.Size(158, 33);
            this.btnBuscarPortatilNit.TabIndex = 5;
            this.btnBuscarPortatilNit.Text = "BuscarPortatil";
            this.btnBuscarPortatilNit.UseVisualStyleBackColor = false;
            this.btnBuscarPortatilNit.Click += new System.EventHandler(this.btnBuscarPortatilNit_Click);
            // 
            // lbEmpresaNit
            // 
            this.lbEmpresaNit.AutoSize = true;
            this.lbEmpresaNit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpresaNit.ForeColor = System.Drawing.Color.White;
            this.lbEmpresaNit.Location = new System.Drawing.Point(86, 111);
            this.lbEmpresaNit.Name = "lbEmpresaNit";
            this.lbEmpresaNit.Size = new System.Drawing.Size(107, 21);
            this.lbEmpresaNit.TabIndex = 6;
            this.lbEmpresaNit.Text = "Empresa Nit:";
            // 
            // txtEmpresaNit
            // 
            this.txtEmpresaNit.Location = new System.Drawing.Point(216, 111);
            this.txtEmpresaNit.Name = "txtEmpresaNit";
            this.txtEmpresaNit.Size = new System.Drawing.Size(210, 20);
            this.txtEmpresaNit.TabIndex = 7;
            // 
            // IconoBuscar
            // 
            this.IconoBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoBuscar.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.buscar;
            this.IconoBuscar.Location = new System.Drawing.Point(423, 112);
            this.IconoBuscar.Name = "IconoBuscar";
            this.IconoBuscar.Size = new System.Drawing.Size(18, 20);
            this.IconoBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoBuscar.TabIndex = 8;
            this.IconoBuscar.TabStop = false;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.IconoBuscar);
            this.Controls.Add(this.txtEmpresaNit);
            this.Controls.Add(this.lbEmpresaNit);
            this.Controls.Add(this.btnBuscarPortatilNit);
            this.Controls.Add(this.btnConsultarPortatil);
            this.Controls.Add(this.dgvConsultarEmpresa);
            this.Controls.Add(this.labelConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConsultar;
        private System.Windows.Forms.DataGridView dgvConsultarEmpresa;
        private System.Windows.Forms.Button btnConsultarPortatil;
        private System.Windows.Forms.Button btnBuscarPortatilNit;
        private System.Windows.Forms.Label lbEmpresaNit;
        private System.Windows.Forms.TextBox txtEmpresaNit;
        private System.Windows.Forms.PictureBox IconoBuscar;
    }
}