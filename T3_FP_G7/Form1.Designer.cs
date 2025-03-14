namespace T3_FP_G7
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
            this.label1 = new System.Windows.Forms.Label();
            this.G7_btn_MenuMascotas = new System.Windows.Forms.Button();
            this.btn_Menu_Numeros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal del T3 - Grupo 7";
            // 
            // G7_btn_MenuMascotas
            // 
            this.G7_btn_MenuMascotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G7_btn_MenuMascotas.Location = new System.Drawing.Point(228, 279);
            this.G7_btn_MenuMascotas.Name = "G7_btn_MenuMascotas";
            this.G7_btn_MenuMascotas.Size = new System.Drawing.Size(138, 48);
            this.G7_btn_MenuMascotas.TabIndex = 1;
            this.G7_btn_MenuMascotas.Text = "Programa Mascotas";
            this.G7_btn_MenuMascotas.UseVisualStyleBackColor = true;
            this.G7_btn_MenuMascotas.Click += new System.EventHandler(this.G7_btn_MenuMascotas_Click);
            // 
            // btn_Menu_Numeros
            // 
            this.btn_Menu_Numeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu_Numeros.Location = new System.Drawing.Point(228, 347);
            this.btn_Menu_Numeros.Name = "btn_Menu_Numeros";
            this.btn_Menu_Numeros.Size = new System.Drawing.Size(138, 50);
            this.btn_Menu_Numeros.TabIndex = 2;
            this.btn_Menu_Numeros.Text = "Programa Numeros";
            this.btn_Menu_Numeros.UseVisualStyleBackColor = true;
            this.btn_Menu_Numeros.Click += new System.EventHandler(this.btn_Menu_Numeros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::T3_FP_G7.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(160, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(619, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Menu_Numeros);
            this.Controls.Add(this.G7_btn_MenuMascotas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button G7_btn_MenuMascotas;
        private System.Windows.Forms.Button btn_Menu_Numeros;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

