namespace LFTT_ProyectoParcial1
{
    partial class Agregar
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomcantxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.album_can = new System.Windows.Forms.TextBox();
            this.art_can = new System.Windows.Forms.TextBox();
            this.anio_can = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.duracion_can = new System.Windows.Forms.TextBox();
            this.gen_can = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(498, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe el nombre de la cancion a agregar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomcantxt
            // 
            this.nomcantxt.Location = new System.Drawing.Point(127, 95);
            this.nomcantxt.Name = "nomcantxt";
            this.nomcantxt.Size = new System.Drawing.Size(305, 20);
            this.nomcantxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 3;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(59, 98);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(47, 13);
            this.nombre.TabIndex = 4;
            this.nombre.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Album:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Artista:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Año:";
            // 
            // album_can
            // 
            this.album_can.Location = new System.Drawing.Point(127, 141);
            this.album_can.Name = "album_can";
            this.album_can.Size = new System.Drawing.Size(289, 20);
            this.album_can.TabIndex = 8;
            this.album_can.TextChanged += new System.EventHandler(this.album_can_TextChanged);
            // 
            // art_can
            // 
            this.art_can.Location = new System.Drawing.Point(127, 189);
            this.art_can.Name = "art_can";
            this.art_can.Size = new System.Drawing.Size(206, 20);
            this.art_can.TabIndex = 9;
            this.art_can.TextChanged += new System.EventHandler(this.art_can_TextChanged);
            // 
            // anio_can
            // 
            this.anio_can.Location = new System.Drawing.Point(127, 267);
            this.anio_can.Name = "anio_can";
            this.anio_can.Size = new System.Drawing.Size(129, 20);
            this.anio_can.TabIndex = 10;
            this.anio_can.TextChanged += new System.EventHandler(this.anio_can_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Duracion:";
            // 
            // duracion_can
            // 
            this.duracion_can.Location = new System.Drawing.Point(127, 227);
            this.duracion_can.Name = "duracion_can";
            this.duracion_can.Size = new System.Drawing.Size(74, 20);
            this.duracion_can.TabIndex = 12;
            // 
            // gen_can
            // 
            this.gen_can.Location = new System.Drawing.Point(348, 236);
            this.gen_can.Name = "gen_can";
            this.gen_can.Size = new System.Drawing.Size(205, 20);
            this.gen_can.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Genero:";
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LFTT_ProyectoParcial1.Properties.Resources.fondo_5_proyectp;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gen_can);
            this.Controls.Add(this.duracion_can);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.anio_can);
            this.Controls.Add(this.art_can);
            this.Controls.Add(this.album_can);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomcantxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomcantxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox album_can;
        private System.Windows.Forms.TextBox art_can;
        private System.Windows.Forms.TextBox anio_can;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox duracion_can;
        private System.Windows.Forms.TextBox gen_can;
        private System.Windows.Forms.Label label7;
    }
}