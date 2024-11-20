namespace Tema4_Ejercicio3_DI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNuevaImagen = new System.Windows.Forms.Button();
            this.chkModal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnNuevaImagen
            // 
            this.btnNuevaImagen.Location = new System.Drawing.Point(90, 63);
            this.btnNuevaImagen.Name = "btnNuevaImagen";
            this.btnNuevaImagen.Size = new System.Drawing.Size(104, 23);
            this.btnNuevaImagen.TabIndex = 0;
            this.btnNuevaImagen.Text = "Nueva Imagen";
            this.btnNuevaImagen.UseVisualStyleBackColor = true;
            this.btnNuevaImagen.Click += new System.EventHandler(this.btnNuevaImagen_Click);
            // 
            // chkModal
            // 
            this.chkModal.AutoSize = true;
            this.chkModal.Location = new System.Drawing.Point(139, 92);
            this.chkModal.Name = "chkModal";
            this.chkModal.Size = new System.Drawing.Size(55, 17);
            this.chkModal.TabIndex = 1;
            this.chkModal.Text = "Modal";
            this.chkModal.UseVisualStyleBackColor = true;
            this.chkModal.CheckedChanged += new System.EventHandler(this.chkModal_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 202);
            this.Controls.Add(this.chkModal);
            this.Controls.Add(this.btnNuevaImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Visor de imágenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaImagen;
        private System.Windows.Forms.CheckBox chkModal;
    }
}

