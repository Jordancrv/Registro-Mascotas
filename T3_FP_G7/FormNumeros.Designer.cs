namespace T3_FP_G7
{
    partial class FormNumeros
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.G7_txt_num = new System.Windows.Forms.TextBox();
            this.G7_btn_registrar_num = new System.Windows.Forms.Button();
            this.G7_dtgv_numeros = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar_numero = new System.Windows.Forms.Button();
            this.G7_btnOrdenar = new System.Windows.Forms.Button();
            this.G7_BTNbuscar = new System.Windows.Forms.Button();
            this.G7_TXTbuscar = new System.Windows.Forms.TextBox();
            this.G7_botonOrdenarAscendeten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.G7_dtgv_numeros)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(584, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Programa de Numeros - UPN - Grupo 7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingresar Numero";
            // 
            // G7_txt_num
            // 
            this.G7_txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G7_txt_num.Location = new System.Drawing.Point(178, 128);
            this.G7_txt_num.Name = "G7_txt_num";
            this.G7_txt_num.Size = new System.Drawing.Size(100, 24);
            this.G7_txt_num.TabIndex = 15;
            // 
            // G7_btn_registrar_num
            // 
            this.G7_btn_registrar_num.Location = new System.Drawing.Point(169, 173);
            this.G7_btn_registrar_num.Name = "G7_btn_registrar_num";
            this.G7_btn_registrar_num.Size = new System.Drawing.Size(114, 41);
            this.G7_btn_registrar_num.TabIndex = 16;
            this.G7_btn_registrar_num.Text = "Registrar Numero";
            this.G7_btn_registrar_num.UseVisualStyleBackColor = true;
            this.G7_btn_registrar_num.Click += new System.EventHandler(this.btn_registrar_num_Click);
            // 
            // G7_dtgv_numeros
            // 
            this.G7_dtgv_numeros.AllowUserToDeleteRows = false;
            this.G7_dtgv_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.G7_dtgv_numeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.G7_dtgv_numeros.Location = new System.Drawing.Point(412, 128);
            this.G7_dtgv_numeros.Name = "G7_dtgv_numeros";
            this.G7_dtgv_numeros.ReadOnly = true;
            this.G7_dtgv_numeros.RowHeadersWidth = 51;
            this.G7_dtgv_numeros.Size = new System.Drawing.Size(144, 187);
            this.G7_dtgv_numeros.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // btn_eliminar_numero
            // 
            this.btn_eliminar_numero.Location = new System.Drawing.Point(169, 232);
            this.btn_eliminar_numero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_eliminar_numero.Name = "btn_eliminar_numero";
            this.btn_eliminar_numero.Size = new System.Drawing.Size(114, 41);
            this.btn_eliminar_numero.TabIndex = 18;
            this.btn_eliminar_numero.Text = "Eliminar Numero";
            this.btn_eliminar_numero.UseVisualStyleBackColor = true;
            this.btn_eliminar_numero.Click += new System.EventHandler(this.btn_eliminar_numero_Click);
            // 
            // G7_btnOrdenar
            // 
            this.G7_btnOrdenar.Location = new System.Drawing.Point(169, 289);
            this.G7_btnOrdenar.Name = "G7_btnOrdenar";
            this.G7_btnOrdenar.Size = new System.Drawing.Size(114, 42);
            this.G7_btnOrdenar.TabIndex = 19;
            this.G7_btnOrdenar.Text = "Ordenar Descendentemente";
            this.G7_btnOrdenar.UseVisualStyleBackColor = true;
            this.G7_btnOrdenar.Click += new System.EventHandler(this.G7_btnOrdenar_Click);
            // 
            // G7_BTNbuscar
            // 
            this.G7_BTNbuscar.Location = new System.Drawing.Point(369, 331);
            this.G7_BTNbuscar.Name = "G7_BTNbuscar";
            this.G7_BTNbuscar.Size = new System.Drawing.Size(114, 41);
            this.G7_BTNbuscar.TabIndex = 20;
            this.G7_BTNbuscar.Text = "Buscar Número";
            this.G7_BTNbuscar.UseVisualStyleBackColor = true;
            this.G7_BTNbuscar.Click += new System.EventHandler(this.G7_BTNbuscar_Click);
            // 
            // G7_TXTbuscar
            // 
            this.G7_TXTbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.G7_TXTbuscar.Location = new System.Drawing.Point(500, 338);
            this.G7_TXTbuscar.Name = "G7_TXTbuscar";
            this.G7_TXTbuscar.Size = new System.Drawing.Size(88, 24);
            this.G7_TXTbuscar.TabIndex = 21;
            // 
            // G7_botonOrdenarAscendeten
            // 
            this.G7_botonOrdenarAscendeten.Location = new System.Drawing.Point(169, 348);
            this.G7_botonOrdenarAscendeten.Name = "G7_botonOrdenarAscendeten";
            this.G7_botonOrdenarAscendeten.Size = new System.Drawing.Size(114, 41);
            this.G7_botonOrdenarAscendeten.TabIndex = 22;
            this.G7_botonOrdenarAscendeten.Text = "Ordenar Ascendente";
            this.G7_botonOrdenarAscendeten.UseVisualStyleBackColor = true;
            this.G7_botonOrdenarAscendeten.Click += new System.EventHandler(this.G7_botonOrdenarAscendeten_Click);
            // 
            // FormNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(716, 435);
            this.Controls.Add(this.G7_botonOrdenarAscendeten);
            this.Controls.Add(this.G7_TXTbuscar);
            this.Controls.Add(this.G7_BTNbuscar);
            this.Controls.Add(this.G7_btnOrdenar);
            this.Controls.Add(this.btn_eliminar_numero);
            this.Controls.Add(this.G7_btn_registrar_num);
            this.Controls.Add(this.G7_txt_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.G7_dtgv_numeros);
            this.Controls.Add(this.label5);
            this.Name = "FormNumeros";
            this.Text = "FormNumeros";
            ((System.ComponentModel.ISupportInitialize)(this.G7_dtgv_numeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox G7_txt_num;
        private System.Windows.Forms.Button G7_btn_registrar_num;
        private System.Windows.Forms.DataGridView G7_dtgv_numeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btn_eliminar_numero;
        private System.Windows.Forms.Button G7_btnOrdenar;
        private System.Windows.Forms.Button G7_BTNbuscar;
        private System.Windows.Forms.TextBox G7_TXTbuscar;
        private System.Windows.Forms.Button G7_botonOrdenarAscendeten;
    }
}