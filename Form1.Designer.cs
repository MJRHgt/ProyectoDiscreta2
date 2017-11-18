namespace ProyectoDiscreta2
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
            this.Calcular_Btm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calcular_Btm
            // 
            this.Calcular_Btm.Location = new System.Drawing.Point(12, 219);
            this.Calcular_Btm.Name = "Calcular_Btm";
            this.Calcular_Btm.Size = new System.Drawing.Size(115, 30);
            this.Calcular_Btm.TabIndex = 0;
            this.Calcular_Btm.Text = "Calcular";
            this.Calcular_Btm.UseVisualStyleBackColor = true;
            this.Calcular_Btm.Click += new System.EventHandler(this.Calcular_Btm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Calcular_Btm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calcular_Btm;
    }
}

