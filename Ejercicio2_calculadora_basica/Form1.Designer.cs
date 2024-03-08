namespace Ejercicio2_calculadora_basica
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
            this.lbl_valor2 = new System.Windows.Forms.Label();
            this.txt_valor1 = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_suma = new System.Windows.Forms.Label();
            this.lbl_resta = new System.Windows.Forms.Label();
            this.lbl_valor1 = new System.Windows.Forms.Label();
            this.txt_valor2 = new System.Windows.Forms.TextBox();
            this.lbl_multi = new System.Windows.Forms.Label();
            this.lbl_divi = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.txt_multi = new System.Windows.Forms.TextBox();
            this.txt_resta = new System.Windows.Forms.TextBox();
            this.txt_suma = new System.Windows.Forms.TextBox();
            this.txt_divi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_valor2
            // 
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor2.Location = new System.Drawing.Point(346, 34);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(53, 19);
            this.lbl_valor2.TabIndex = 0;
            this.lbl_valor2.Text = "Valor2";
            // 
            // txt_valor1
            // 
            this.txt_valor1.Location = new System.Drawing.Point(163, 56);
            this.txt_valor1.Name = "txt_valor1";
            this.txt_valor1.Size = new System.Drawing.Size(100, 20);
            this.txt_valor1.TabIndex = 1;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.Lime;
            this.btn_calcular.Location = new System.Drawing.Point(125, 258);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(93, 31);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_suma
            // 
            this.lbl_suma.AutoSize = true;
            this.lbl_suma.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_suma.Location = new System.Drawing.Point(39, 150);
            this.lbl_suma.Name = "lbl_suma";
            this.lbl_suma.Size = new System.Drawing.Size(46, 19);
            this.lbl_suma.TabIndex = 3;
            this.lbl_suma.Text = "Suma";
            // 
            // lbl_resta
            // 
            this.lbl_resta.AutoSize = true;
            this.lbl_resta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resta.Location = new System.Drawing.Point(187, 150);
            this.lbl_resta.Name = "lbl_resta";
            this.lbl_resta.Size = new System.Drawing.Size(45, 19);
            this.lbl_resta.TabIndex = 4;
            this.lbl_resta.Text = "Resta";
            // 
            // lbl_valor1
            // 
            this.lbl_valor1.AutoSize = true;
            this.lbl_valor1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor1.Location = new System.Drawing.Point(187, 34);
            this.lbl_valor1.Name = "lbl_valor1";
            this.lbl_valor1.Size = new System.Drawing.Size(53, 19);
            this.lbl_valor1.TabIndex = 5;
            this.lbl_valor1.Text = "Valor1";
            // 
            // txt_valor2
            // 
            this.txt_valor2.Location = new System.Drawing.Point(325, 56);
            this.txt_valor2.Name = "txt_valor2";
            this.txt_valor2.Size = new System.Drawing.Size(100, 20);
            this.txt_valor2.TabIndex = 6;
            // 
            // lbl_multi
            // 
            this.lbl_multi.AutoSize = true;
            this.lbl_multi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multi.Location = new System.Drawing.Point(322, 150);
            this.lbl_multi.Name = "lbl_multi";
            this.lbl_multi.Size = new System.Drawing.Size(103, 19);
            this.lbl_multi.TabIndex = 7;
            this.lbl_multi.Text = "Multiplicacion";
            // 
            // lbl_divi
            // 
            this.lbl_divi.AutoSize = true;
            this.lbl_divi.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_divi.Location = new System.Drawing.Point(486, 150);
            this.lbl_divi.Name = "lbl_divi";
            this.lbl_divi.Size = new System.Drawing.Size(62, 19);
            this.lbl_divi.TabIndex = 8;
            this.lbl_divi.Text = "Division";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_cerrar.Location = new System.Drawing.Point(350, 258);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(93, 31);
            this.btn_cerrar.TabIndex = 9;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Yellow;
            this.btn_limpiar.Location = new System.Drawing.Point(241, 258);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(93, 31);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // txt_multi
            // 
            this.txt_multi.Location = new System.Drawing.Point(325, 176);
            this.txt_multi.Name = "txt_multi";
            this.txt_multi.Size = new System.Drawing.Size(100, 20);
            this.txt_multi.TabIndex = 11;
            // 
            // txt_resta
            // 
            this.txt_resta.Location = new System.Drawing.Point(163, 176);
            this.txt_resta.Name = "txt_resta";
            this.txt_resta.Size = new System.Drawing.Size(100, 20);
            this.txt_resta.TabIndex = 12;
            // 
            // txt_suma
            // 
            this.txt_suma.Location = new System.Drawing.Point(12, 176);
            this.txt_suma.Name = "txt_suma";
            this.txt_suma.Size = new System.Drawing.Size(100, 20);
            this.txt_suma.TabIndex = 13;
            // 
            // txt_divi
            // 
            this.txt_divi.Location = new System.Drawing.Point(467, 176);
            this.txt_divi.Name = "txt_divi";
            this.txt_divi.Size = new System.Drawing.Size(100, 20);
            this.txt_divi.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(595, 324);
            this.Controls.Add(this.txt_divi);
            this.Controls.Add(this.txt_suma);
            this.Controls.Add(this.txt_resta);
            this.Controls.Add(this.txt_multi);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_divi);
            this.Controls.Add(this.lbl_multi);
            this.Controls.Add(this.txt_valor2);
            this.Controls.Add(this.lbl_valor1);
            this.Controls.Add(this.lbl_resta);
            this.Controls.Add(this.lbl_suma);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_valor1);
            this.Controls.Add(this.lbl_valor2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_valor2;
        private System.Windows.Forms.TextBox txt_valor1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_suma;
        private System.Windows.Forms.Label lbl_resta;
        private System.Windows.Forms.Label lbl_valor1;
        private System.Windows.Forms.TextBox txt_valor2;
        private System.Windows.Forms.Label lbl_multi;
        private System.Windows.Forms.Label lbl_divi;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.TextBox txt_multi;
        private System.Windows.Forms.TextBox txt_resta;
        private System.Windows.Forms.TextBox txt_suma;
        private System.Windows.Forms.TextBox txt_divi;
    }
}

