namespace Bases_de_datos___Proyecto_final_v1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.IconoBuscar = new System.Windows.Forms.PictureBox();
            this.IconoPortatil = new System.Windows.Forms.PictureBox();
            this.IconoEmpresa = new System.Windows.Forms.PictureBox();
            this.btnConsultarPor = new System.Windows.Forms.Button();
            this.btnRegistrarPor = new System.Windows.Forms.Button();
            this.btnRegistrarEmp = new System.Windows.Forms.Button();
            this.iconoLogo = new System.Windows.Forms.PictureBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.IconoRestaurar = new System.Windows.Forms.PictureBox();
            this.IconoMinimizar = new System.Windows.Forms.PictureBox();
            this.IconoCerrar = new System.Windows.Forms.PictureBox();
            this.IconoMaximizar = new System.Windows.Forms.PictureBox();
            this.IconoMenu = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.timerFecha = new System.Windows.Forms.Timer(this.components);
            this.panelLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoPortatil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLogo)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.IconoBuscar);
            this.panelLateral.Controls.Add(this.IconoPortatil);
            this.panelLateral.Controls.Add(this.IconoEmpresa);
            this.panelLateral.Controls.Add(this.btnConsultarPor);
            this.panelLateral.Controls.Add(this.btnRegistrarPor);
            this.panelLateral.Controls.Add(this.btnRegistrarEmp);
            this.panelLateral.Controls.Add(this.iconoLogo);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 450);
            this.panelLateral.TabIndex = 0;
            // 
            // IconoBuscar
            // 
            this.IconoBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoBuscar.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.buscar;
            this.IconoBuscar.Location = new System.Drawing.Point(3, 324);
            this.IconoBuscar.Name = "IconoBuscar";
            this.IconoBuscar.Size = new System.Drawing.Size(30, 30);
            this.IconoBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoBuscar.TabIndex = 6;
            this.IconoBuscar.TabStop = false;
            this.IconoBuscar.Click += new System.EventHandler(this.IconoBuscar_Click);
            // 
            // IconoPortatil
            // 
            this.IconoPortatil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoPortatil.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.portatil;
            this.IconoPortatil.Location = new System.Drawing.Point(3, 278);
            this.IconoPortatil.Name = "IconoPortatil";
            this.IconoPortatil.Size = new System.Drawing.Size(30, 30);
            this.IconoPortatil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoPortatil.TabIndex = 5;
            this.IconoPortatil.TabStop = false;
            this.IconoPortatil.Click += new System.EventHandler(this.IconoPortatil_Click);
            // 
            // IconoEmpresa
            // 
            this.IconoEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoEmpresa.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.empresa;
            this.IconoEmpresa.Location = new System.Drawing.Point(3, 227);
            this.IconoEmpresa.Name = "IconoEmpresa";
            this.IconoEmpresa.Size = new System.Drawing.Size(30, 30);
            this.IconoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoEmpresa.TabIndex = 4;
            this.IconoEmpresa.TabStop = false;
            this.IconoEmpresa.Click += new System.EventHandler(this.IconoEmpresa_Click);
            // 
            // btnConsultarPor
            // 
            this.btnConsultarPor.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarPor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultarPor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarPor.FlatAppearance.BorderSize = 0;
            this.btnConsultarPor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnConsultarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPor.ForeColor = System.Drawing.Color.White;
            this.btnConsultarPor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPor.Location = new System.Drawing.Point(39, 324);
            this.btnConsultarPor.Name = "btnConsultarPor";
            this.btnConsultarPor.Size = new System.Drawing.Size(164, 30);
            this.btnConsultarPor.TabIndex = 3;
            this.btnConsultarPor.Text = "Consultar Portatiles";
            this.btnConsultarPor.UseVisualStyleBackColor = false;
            this.btnConsultarPor.Click += new System.EventHandler(this.btnConsultarPor_Click);
            // 
            // btnRegistrarPor
            // 
            this.btnRegistrarPor.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarPor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrarPor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPor.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRegistrarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPor.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPor.Location = new System.Drawing.Point(39, 278);
            this.btnRegistrarPor.Name = "btnRegistrarPor";
            this.btnRegistrarPor.Size = new System.Drawing.Size(164, 30);
            this.btnRegistrarPor.TabIndex = 2;
            this.btnRegistrarPor.Text = "Registrar  Portatil";
            this.btnRegistrarPor.UseVisualStyleBackColor = false;
            this.btnRegistrarPor.Click += new System.EventHandler(this.btnRegistrarPor_Click);
            // 
            // btnRegistrarEmp
            // 
            this.btnRegistrarEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrarEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarEmp.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRegistrarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEmp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmp.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarEmp.Location = new System.Drawing.Point(39, 227);
            this.btnRegistrarEmp.Name = "btnRegistrarEmp";
            this.btnRegistrarEmp.Size = new System.Drawing.Size(161, 30);
            this.btnRegistrarEmp.TabIndex = 1;
            this.btnRegistrarEmp.Text = "Registrar Empresa";
            this.btnRegistrarEmp.UseVisualStyleBackColor = false;
            this.btnRegistrarEmp.Click += new System.EventHandler(this.registrarEmp_Click);
            // 
            // iconoLogo
            // 
            this.iconoLogo.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.Logo_2;
            this.iconoLogo.Location = new System.Drawing.Point(0, 0);
            this.iconoLogo.Name = "iconoLogo";
            this.iconoLogo.Size = new System.Drawing.Size(200, 169);
            this.iconoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoLogo.TabIndex = 0;
            this.iconoLogo.TabStop = false;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.PanelSuperior.Controls.Add(this.labelHora);
            this.PanelSuperior.Controls.Add(this.labelFecha);
            this.PanelSuperior.Controls.Add(this.IconoRestaurar);
            this.PanelSuperior.Controls.Add(this.IconoMinimizar);
            this.PanelSuperior.Controls.Add(this.IconoCerrar);
            this.PanelSuperior.Controls.Add(this.IconoMaximizar);
            this.PanelSuperior.Controls.Add(this.IconoMenu);
            this.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSuperior.Location = new System.Drawing.Point(200, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(700, 50);
            this.PanelSuperior.TabIndex = 1;
            this.PanelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelSuperior_MouseDown);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.White;
            this.labelHora.Location = new System.Drawing.Point(259, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(96, 33);
            this.labelHora.TabIndex = 5;
            this.labelHora.Text = "label1";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(230, 28);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(65, 22);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "label1";
            // 
            // IconoRestaurar
            // 
            this.IconoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoRestaurar.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.maximizar;
            this.IconoRestaurar.Location = new System.Drawing.Point(654, 0);
            this.IconoRestaurar.Name = "IconoRestaurar";
            this.IconoRestaurar.Size = new System.Drawing.Size(20, 20);
            this.IconoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoRestaurar.TabIndex = 4;
            this.IconoRestaurar.TabStop = false;
            this.IconoRestaurar.Visible = false;
            this.IconoRestaurar.Click += new System.EventHandler(this.IconoRestaurar_Click);
            // 
            // IconoMinimizar
            // 
            this.IconoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMinimizar.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.minimizar;
            this.IconoMinimizar.Location = new System.Drawing.Point(628, 0);
            this.IconoMinimizar.Name = "IconoMinimizar";
            this.IconoMinimizar.Size = new System.Drawing.Size(20, 20);
            this.IconoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMinimizar.TabIndex = 3;
            this.IconoMinimizar.TabStop = false;
            this.IconoMinimizar.Click += new System.EventHandler(this.IconoMinimizar_Click);
            // 
            // IconoCerrar
            // 
            this.IconoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoCerrar.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.cerrar;
            this.IconoCerrar.Location = new System.Drawing.Point(680, 0);
            this.IconoCerrar.Name = "IconoCerrar";
            this.IconoCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoCerrar.TabIndex = 2;
            this.IconoCerrar.TabStop = false;
            this.IconoCerrar.Click += new System.EventHandler(this.IconoCerrar_Click);
            // 
            // IconoMaximizar
            // 
            this.IconoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMaximizar.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.maximizar;
            this.IconoMaximizar.Location = new System.Drawing.Point(654, 0);
            this.IconoMaximizar.Name = "IconoMaximizar";
            this.IconoMaximizar.Size = new System.Drawing.Size(20, 20);
            this.IconoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMaximizar.TabIndex = 1;
            this.IconoMaximizar.TabStop = false;
            this.IconoMaximizar.Click += new System.EventHandler(this.IconoMaximizar_Click);
            // 
            // IconoMenu
            // 
            this.IconoMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconoMenu.Image = global::Bases_de_datos___Proyecto_final_v1.Properties.Resources.menu;
            this.IconoMenu.Location = new System.Drawing.Point(6, 9);
            this.IconoMenu.Name = "IconoMenu";
            this.IconoMenu.Size = new System.Drawing.Size(25, 35);
            this.IconoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconoMenu.TabIndex = 0;
            this.IconoMenu.TabStop = false;
            this.IconoMenu.Click += new System.EventHandler(this.IconMenu_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(700, 400);
            this.panelContenedor.TabIndex = 4;
            // 
            // timerFecha
            // 
            this.timerFecha.Enabled = true;
            this.timerFecha.Tick += new System.EventHandler(this.timerFecha_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Centaury";
            this.panelLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoPortatil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLogo)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox IconoMenu;
        private System.Windows.Forms.PictureBox iconoLogo;
        private System.Windows.Forms.PictureBox IconoMinimizar;
        private System.Windows.Forms.PictureBox IconoCerrar;
        private System.Windows.Forms.PictureBox IconoMaximizar;
        private System.Windows.Forms.PictureBox IconoRestaurar;
        private System.Windows.Forms.Button btnRegistrarEmp;
        private System.Windows.Forms.PictureBox IconoBuscar;
        private System.Windows.Forms.PictureBox IconoEmpresa;
        private System.Windows.Forms.Button btnConsultarPor;
        private System.Windows.Forms.Button btnRegistrarPor;
        private System.Windows.Forms.PictureBox IconoPortatil;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timerFecha;
        private System.Windows.Forms.Label labelFecha;
    }
}

