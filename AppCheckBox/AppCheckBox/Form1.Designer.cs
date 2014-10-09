namespace AppCheckBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkIngles = new System.Windows.Forms.CheckBox();
            this.chkFrances = new System.Windows.Forms.CheckBox();
            this.chkAleman = new System.Windows.Forms.CheckBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkIngles
            // 
            this.chkIngles.AutoSize = true;
            this.chkIngles.Location = new System.Drawing.Point(25, 32);
            this.chkIngles.Name = "chkIngles";
            this.chkIngles.Size = new System.Drawing.Size(54, 17);
            this.chkIngles.TabIndex = 0;
            this.chkIngles.Text = "Inglés";
            this.chkIngles.UseVisualStyleBackColor = true;
            // 
            // chkFrances
            // 
            this.chkFrances.AutoSize = true;
            this.chkFrances.Location = new System.Drawing.Point(25, 69);
            this.chkFrances.Name = "chkFrances";
            this.chkFrances.Size = new System.Drawing.Size(64, 17);
            this.chkFrances.TabIndex = 1;
            this.chkFrances.Text = "Francés";
            this.chkFrances.UseVisualStyleBackColor = true;
            // 
            // chkAleman
            // 
            this.chkAleman.AutoSize = true;
            this.chkAleman.Location = new System.Drawing.Point(25, 106);
            this.chkAleman.Name = "chkAleman";
            this.chkAleman.Size = new System.Drawing.Size(61, 17);
            this.chkAleman.TabIndex = 2;
            this.chkAleman.Text = "Alemán";
            this.chkAleman.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(25, 161);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Idiomas";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.chkAleman);
            this.Controls.Add(this.chkFrances);
            this.Controls.Add(this.chkIngles);
            this.Name = "Form1";
            this.Text = "Programa Idiomas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIngles;
        private System.Windows.Forms.CheckBox chkFrances;
        private System.Windows.Forms.CheckBox chkAleman;
        private System.Windows.Forms.Button btnMostrar;
    }
}

