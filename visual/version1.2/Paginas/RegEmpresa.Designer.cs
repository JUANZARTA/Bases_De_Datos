namespace Bases_de_datos___Proyecto_final_v1
{
    partial class RegEmpresa
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
            this.labelRegEmp = new System.Windows.Forms.Label();
            this.labelNit = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCreacion = new System.Windows.Forms.Label();
            this.btnGuardar_1 = new System.Windows.Forms.Button();
            this.txtempresaNit = new System.Windows.Forms.TextBox();
            this.txtempresaNombre = new System.Windows.Forms.TextBox();
            this.IconoEmpresa = new System.Windows.Forms.PictureBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegEmp
            // 
            this.labelRegEmp.AutoSize = true;
            this.labelRegEmp.BackColor = System.Drawing.Color.Transparent;
            this.labelRegEmp.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegEmp.ForeColor = System.Drawing.Color.White;
            this.labelRegEmp.Location = new System.Drawing.Point(200, 9);
            this.labelRegEmp.Name = "labelRegEmp";
            this.labelRegEmp.Size = new System.Drawing.Size(278, 32);
            this.labelRegEmp.TabIndex = 0;
            this.labelRegEmp.Text = "REGISTRAR EMPRESA";
            this.labelRegEmp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNit
            // 
            this.labelNit.AutoSize = true;
            this.labelNit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNit.ForeColor = System.Drawing.Color.White;
            this.labelNit.Location = new System.Drawing.Point(12, 108);
            this.labelNit.Name = "labelNit";
            this.labelNit.Size = new System.Drawing.Size(36, 21);
            this.labelNit.TabIndex = 1;
            this.labelNit.Text = "Nit:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(12, 139);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(77, 21);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelCreacion
            // 
            this.labelCreacion.AutoSize = true;
            this.labelCreacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreacion.ForeColor = System.Drawing.Color.White;
            this.labelCreacion.Location = new System.Drawing.Point(12, 172);
            this.labelCreacion.Name = "labelCreacion";
            this.labelCreacion.Size = new System.Drawing.Size(164, 21);
            this.labelCreacion.TabIndex = 3;
            this.labelCreacion.Text = "Fecha de Creacion:";
            // 
            // btnGuardar_1
            // 
            this.btnGuardar_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnGuardar_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar_1.FlatAppearance.BorderSize = 0;
            this.btnGuardar_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnGuardar_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar_1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar_1.ForeColor = System.Drawing.Color.White;
            this.btnGuardar_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar_1.Location = new System.Drawing.Point(525, 342);
            this.btnGuardar_1.Name = "btnGuardar_1";
            this.btnGuardar_1.Size = new System.Drawing.Size(149, 30);
            this.btnGuardar_1.TabIndex = 4;
            this.btnGuardar_1.Text = "Guardar";
            this.btnGuardar_1.UseVisualStyleBackColor = false;
            this.btnGuardar_1.Click += new System.EventHandler(this.btnGuardar_1_Click);
            // 
            // txtempresaNit
            // 
            this.txtempresaNit.Location = new System.Drawing.Point(182, 109);
            this.txtempresaNit.Name = "txtempresaNit";
            this.txtempresaNit.Size = new System.Drawing.Size(200, 20);
            this.txtempresaNit.TabIndex = 6;
            // 
            // txtempresaNombre
            // 
            this.txtempresaNombre.Location = new System.Drawing.Point(182, 142);
            this.txtempresaNombre.Name = "txtempresaNombre";
            this.txtempresaNombre.Size = new System.Drawing.Size(200, 20);
            this.txtempresaNombre.TabIndex = 7;
            // 
            // IconoEmpresa
            // 
            this.IconoEmpresa.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.empresa;
            this.IconoEmpresa.Location = new System.Drawing.Point(506, 155);
            this.IconoEmpresa.Name = "IconoEmpresa";
            this.IconoEmpresa.Size = new System.Drawing.Size(180, 180);
            this.IconoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoEmpresa.TabIndex = 5;
            this.IconoEmpresa.TabStop = false;
            //this.IconoEmpresa.Click += new System.EventHandler(this.IconoEmpresa_Click);
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(182, 172);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.txtFechaCreacion.TabIndex = 9;
            // 
            // RegEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtempresaNombre);
            this.Controls.Add(this.txtempresaNit);
            this.Controls.Add(this.IconoEmpresa);
            this.Controls.Add(this.btnGuardar_1);
            this.Controls.Add(this.labelCreacion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNit);
            this.Controls.Add(this.labelRegEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegEmpresa";
            this.Text = "RegEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.IconoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegEmp;
        private System.Windows.Forms.Label labelNit;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCreacion;
        private System.Windows.Forms.Button btnGuardar_1;
        private System.Windows.Forms.PictureBox IconoEmpresa;
        private System.Windows.Forms.TextBox txtempresaNit;
        private System.Windows.Forms.TextBox txtempresaNombre;
        private System.Windows.Forms.TextBox txtFechaCreacion;
    }
}