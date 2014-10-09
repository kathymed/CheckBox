namespace AppNavegadoresWeb
{
    partial class Navegadores
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
            this.chkChrome = new System.Windows.Forms.CheckBox();
            this.chkMozilla = new System.Windows.Forms.CheckBox();
            this.chkOpera = new System.Windows.Forms.CheckBox();
            this.btnMostar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkChrome
            // 
            this.chkChrome.AutoEllipsis = true;
            this.chkChrome.AutoSize = true;
            this.chkChrome.Location = new System.Drawing.Point(26, 36);
            this.chkChrome.Name = "chkChrome";
            this.chkChrome.Size = new System.Drawing.Size(62, 17);
            this.chkChrome.TabIndex = 0;
            this.chkChrome.Text = "Chrome";
            this.chkChrome.UseVisualStyleBackColor = true;
            // 
            // chkMozilla
            // 
            this.chkMozilla.AutoSize = true;
            this.chkMozilla.Location = new System.Drawing.Point(227, 36);
            this.chkMozilla.Name = "chkMozilla";
            this.chkMozilla.Size = new System.Drawing.Size(92, 17);
            this.chkMozilla.TabIndex = 1;
            this.chkMozilla.Text = "Mozilla Firefox";
            this.chkMozilla.UseVisualStyleBackColor = true;
            // 
            // chkOpera
            // 
            this.chkOpera.AutoSize = true;
            this.chkOpera.Location = new System.Drawing.Point(138, 82);
            this.chkOpera.Name = "chkOpera";
            this.chkOpera.Size = new System.Drawing.Size(55, 17);
            this.chkOpera.TabIndex = 2;
            this.chkOpera.Text = "Opera";
            this.chkOpera.UseVisualStyleBackColor = true;
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(68, 168);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(75, 23);
            this.btnMostar.TabIndex = 3;
            this.btnMostar.Text = "Mostrar Navegadores";
            this.btnMostar.UseVisualStyleBackColor = true;
            this.btnMostar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResultado.Location = new System.Drawing.Point(195, 168);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // Navegadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 375);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.chkOpera);
            this.Controls.Add(this.chkMozilla);
            this.Controls.Add(this.chkChrome);
            this.Name = "Navegadores";
            this.Text = "Navegadores Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkChrome;
        private System.Windows.Forms.CheckBox chkOpera;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.CheckBox chkMozilla;
        private System.Windows.Forms.Label lblResultado;
    }
}

