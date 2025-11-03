namespace LFTT_ProyectoParcial1
{
    partial class Principal
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
            this.labelnom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IrAgregar = new System.Windows.Forms.Button();
            this.IrConsultar = new System.Windows.Forms.Button();
            this.IrBorrar = new System.Windows.Forms.Button();
            this.salida = new System.Windows.Forms.Button();
            this.NombrePlay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnom.Location = new System.Drawing.Point(412, 31);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(0, 42);
            this.labelnom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Cancion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultar Cancion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "BORRAR CANCION";
            // 
            // IrAgregar
            // 
            this.IrAgregar.Location = new System.Drawing.Point(116, 151);
            this.IrAgregar.Name = "IrAgregar";
            this.IrAgregar.Size = new System.Drawing.Size(103, 51);
            this.IrAgregar.TabIndex = 5;
            this.IrAgregar.Text = "IR";
            this.IrAgregar.UseVisualStyleBackColor = true;
            this.IrAgregar.Click += new System.EventHandler(this.IrAgregar_Click);
            // 
            // IrConsultar
            // 
            this.IrConsultar.Location = new System.Drawing.Point(601, 151);
            this.IrConsultar.Name = "IrConsultar";
            this.IrConsultar.Size = new System.Drawing.Size(102, 41);
            this.IrConsultar.TabIndex = 6;
            this.IrConsultar.Text = "IR";
            this.IrConsultar.UseVisualStyleBackColor = true;
            this.IrConsultar.Click += new System.EventHandler(this.IrConsultar_Click);
            // 
            // IrBorrar
            // 
            this.IrBorrar.Location = new System.Drawing.Point(358, 263);
            this.IrBorrar.Name = "IrBorrar";
            this.IrBorrar.Size = new System.Drawing.Size(106, 53);
            this.IrBorrar.TabIndex = 8;
            this.IrBorrar.Text = "IR";
            this.IrBorrar.UseVisualStyleBackColor = true;
            this.IrBorrar.Click += new System.EventHandler(this.IrBorrar_Click);
            // 
            // salida
            // 
            this.salida.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salida.Location = new System.Drawing.Point(348, 359);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(136, 53);
            this.salida.TabIndex = 9;
            this.salida.Text = "SALIR";
            this.salida.UseVisualStyleBackColor = true;
            this.salida.Click += new System.EventHandler(this.salida_Click);
            // 
            // NombrePlay
            // 
            this.NombrePlay.AutoSize = true;
            this.NombrePlay.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePlay.Location = new System.Drawing.Point(141, 31);
            this.NombrePlay.Name = "NombrePlay";
            this.NombrePlay.Size = new System.Drawing.Size(49, 36);
            this.NombrePlay.TabIndex = 10;
            this.NombrePlay.Text = "lol";
            this.NombrePlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFTT_ProyectoParcial1.Properties.Resources.fondo_proyecto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NombrePlay);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.IrBorrar);
            this.Controls.Add(this.IrConsultar);
            this.Controls.Add(this.IrAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnom);
            this.Name = "Principal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IrAgregar;
        private System.Windows.Forms.Button IrConsultar;
        private System.Windows.Forms.Button IrBorrar;
        private System.Windows.Forms.Button salida;
        private System.Windows.Forms.Label NombrePlay;
    }
}