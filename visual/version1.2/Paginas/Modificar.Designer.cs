namespace Bases_de_datos___Proyecto_final_v1.Paginas
{
    partial class Modificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTablas = new System.Windows.Forms.Label();
            this.txtConsultar = new System.Windows.Forms.TextBox();
            this.bntConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.labelOpciones = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModificar = new System.Windows.Forms.TextBox();
            this.btbEditar = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite la tabla donde desea modificar los datos";
            // 
            // labelTablas
            // 
            this.labelTablas.AutoSize = true;
            this.labelTablas.BackColor = System.Drawing.Color.Transparent;
            this.labelTablas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTablas.ForeColor = System.Drawing.Color.White;
            this.labelTablas.Location = new System.Drawing.Point(12, 24);
            this.labelTablas.Name = "labelTablas";
            this.labelTablas.Size = new System.Drawing.Size(70, 23);
            this.labelTablas.TabIndex = 6;
            this.labelTablas.Text = "Tablas";
            this.labelTablas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtConsultar
            // 
            this.txtConsultar.Location = new System.Drawing.Point(396, 106);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(156, 20);
            this.txtConsultar.TabIndex = 8;
            // 
            // bntConsultar
            // 
            this.bntConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bntConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntConsultar.FlatAppearance.BorderSize = 0;
            this.bntConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.bntConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConsultar.ForeColor = System.Drawing.Color.White;
            this.bntConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntConsultar.Location = new System.Drawing.Point(558, 100);
            this.bntConsultar.Name = "bntConsultar";
            this.bntConsultar.Size = new System.Drawing.Size(106, 30);
            this.bntConsultar.TabIndex = 10;
            this.bntConsultar.Text = "Consultar";
            this.bntConsultar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "1. Tabla Empresa                  2. Tabla Portatil";
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(44, 139);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(557, 176);
            this.dgvConsultas.TabIndex = 22;
            // 
            // labelOpciones
            // 
            this.labelOpciones.AutoSize = true;
            this.labelOpciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpciones.ForeColor = System.Drawing.Color.White;
            this.labelOpciones.Location = new System.Drawing.Point(12, 327);
            this.labelOpciones.Name = "labelOpciones";
            this.labelOpciones.Size = new System.Drawing.Size(84, 21);
            this.labelOpciones.TabIndex = 23;
            this.labelOpciones.Text = "Opciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(373, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(373, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(373, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Elija la Opcione que desa Modificar";
            // 
            // txtModificar
            // 
            this.txtModificar.Location = new System.Drawing.Point(301, 431);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(156, 20);
            this.txtModificar.TabIndex = 31;
            // 
            // btbEditar
            // 
            this.btbEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btbEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btbEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbEditar.FlatAppearance.BorderSize = 0;
            this.btbEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btbEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbEditar.ForeColor = System.Drawing.Color.White;
            this.btbEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbEditar.Location = new System.Drawing.Point(463, 422);
            this.btbEditar.Name = "btbEditar";
            this.btbEditar.Size = new System.Drawing.Size(106, 30);
            this.btbEditar.TabIndex = 32;
            this.btbEditar.Text = "Editar";
            this.btbEditar.UseVisualStyleBackColor = false;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(413, 480);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(156, 20);
            this.txt1.TabIndex = 33;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(413, 506);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(156, 20);
            this.txt2.TabIndex = 34;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(413, 532);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(156, 20);
            this.txt3.TabIndex = 35;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(575, 522);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 30);
            this.btnModificar.TabIndex = 36;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Transaction = null;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(700, 574);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btbEditar);
            this.Controls.Add(this.txtModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelOpciones);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntConsultar);
            this.Controls.Add(this.txtConsultar);
            this.Controls.Add(this.labelTablas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar";
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTablas;
        private System.Windows.Forms.TextBox txtConsultar;
        private System.Windows.Forms.Button bntConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Label labelOpciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModificar;
        private System.Windows.Forms.Button btbEditar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnModificar;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
    }
}