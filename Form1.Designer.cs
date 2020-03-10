namespace programacionII_estadistica
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
            this.BtncalcularMedia = new System.Windows.Forms.Button();
            this.lblserie = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btncalcularestandar = new System.Windows.Forms.Button();
            this.btncalculartipica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtncalcularMedia
            // 
            this.BtncalcularMedia.Location = new System.Drawing.Point(19, 108);
            this.BtncalcularMedia.Name = "BtncalcularMedia";
            this.BtncalcularMedia.Size = new System.Drawing.Size(113, 23);
            this.BtncalcularMedia.TabIndex = 0;
            this.BtncalcularMedia.Text = "Calcular Aritmetica";
            this.BtncalcularMedia.UseVisualStyleBackColor = true;
            this.BtncalcularMedia.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(31, 31);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(42, 13);
            this.lblserie.TabIndex = 1;
            this.lblserie.Text = "SERIE ";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(31, 68);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(14, 13);
            this.lblrespuesta.TabIndex = 2;
            this.lblrespuesta.Text = "X";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(112, 28);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(100, 20);
            this.txtserie.TabIndex = 3;
            // 
            // btncalcularestandar
            // 
            this.btncalcularestandar.Location = new System.Drawing.Point(138, 108);
            this.btncalcularestandar.Name = "btncalcularestandar";
            this.btncalcularestandar.Size = new System.Drawing.Size(98, 23);
            this.btncalcularestandar.TabIndex = 4;
            this.btncalcularestandar.Text = "Calcular Estandar";
            this.btncalcularestandar.UseVisualStyleBackColor = true;
            this.btncalcularestandar.Click += new System.EventHandler(this.btncalcularestandar_Click);
            // 
            // btncalculartipica
            // 
            this.btncalculartipica.Location = new System.Drawing.Point(242, 108);
            this.btncalculartipica.Name = "btncalculartipica";
            this.btncalculartipica.Size = new System.Drawing.Size(124, 23);
            this.btncalculartipica.TabIndex = 5;
            this.btncalculartipica.Text = "Calcular Tipica";
            this.btncalculartipica.UseVisualStyleBackColor = true;
            this.btncalculartipica.Click += new System.EventHandler(this.btncalculartipica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 323);
            this.Controls.Add(this.btncalculartipica);
            this.Controls.Add(this.btncalcularestandar);
            this.Controls.Add(this.txtserie);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblserie);
            this.Controls.Add(this.BtncalcularMedia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtncalcularMedia;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btncalcularestandar;
        private System.Windows.Forms.Button btncalculartipica;
    }
}

