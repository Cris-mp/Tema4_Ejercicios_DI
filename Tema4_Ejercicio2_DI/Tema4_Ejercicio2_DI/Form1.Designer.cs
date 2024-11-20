namespace Tema4_Ejercicio2_DI
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
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.txtAzul = new System.Windows.Forms.TextBox();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnFondo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ptbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(64, 46);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(100, 20);
            this.txtRojo.TabIndex = 0;
            this.txtRojo.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtAzul
            // 
            this.txtAzul.Location = new System.Drawing.Point(181, 46);
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.Size = new System.Drawing.Size(100, 20);
            this.txtAzul.TabIndex = 1;
            this.txtAzul.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(297, 46);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(100, 20);
            this.txtVerde.TabIndex = 2;
            this.txtVerde.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(438, 46);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            this.btnColor.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnColor.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(64, 27);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(29, 13);
            this.lblRojo.TabIndex = 4;
            this.lblRojo.Text = "Rojo";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(181, 26);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(27, 13);
            this.lblAzul.TabIndex = 5;
            this.lblAzul.Text = "Azul";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Location = new System.Drawing.Point(297, 27);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(35, 13);
            this.lblVerde.TabIndex = 6;
            this.lblVerde.Text = "Verde";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(64, 103);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(333, 20);
            this.txtPath.TabIndex = 7;
            this.txtPath.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(64, 87);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 8;
            this.lblPath.Text = "Path";
            // 
            // btnFondo
            // 
            this.btnFondo.Location = new System.Drawing.Point(438, 103);
            this.btnFondo.Name = "btnFondo";
            this.btnFondo.Size = new System.Drawing.Size(75, 23);
            this.btnFondo.TabIndex = 9;
            this.btnFondo.Text = "Fondo";
            this.btnFondo.UseVisualStyleBackColor = true;
            this.btnFondo.Click += new System.EventHandler(this.btnFondo_Click);
            this.btnFondo.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnFondo.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(64, 400);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(181, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // ptbImagen
            // 
            this.ptbImagen.Location = new System.Drawing.Point(64, 142);
            this.ptbImagen.Name = "ptbImagen";
            this.ptbImagen.Size = new System.Drawing.Size(449, 241);
            this.ptbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImagen.TabIndex = 12;
            this.ptbImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.ptbImagen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFondo);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtRojo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diseño";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.TextBox txtAzul;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnFondo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox ptbImagen;
    }
}

