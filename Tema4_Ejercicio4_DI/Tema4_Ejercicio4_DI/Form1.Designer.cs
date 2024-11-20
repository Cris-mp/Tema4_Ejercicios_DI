namespace Tema4_Ejercicio4_DI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOperando1 = new System.Windows.Forms.TextBox();
            this.txtOperando2 = new System.Windows.Forms.TextBox();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbResta = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbDivision = new System.Windows.Forms.RadioButton();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOperando1
            // 
            this.txtOperando1.Location = new System.Drawing.Point(35, 43);
            this.txtOperando1.Name = "txtOperando1";
            this.txtOperando1.Size = new System.Drawing.Size(100, 20);
            this.txtOperando1.TabIndex = 0;
            this.txtOperando1.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // txtOperando2
            // 
            this.txtOperando2.Location = new System.Drawing.Point(160, 43);
            this.txtOperando2.Name = "txtOperando2";
            this.txtOperando2.Size = new System.Drawing.Size(100, 20);
            this.txtOperando2.TabIndex = 1;
            this.txtOperando2.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Location = new System.Drawing.Point(141, 46);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(13, 13);
            this.lblSigno.TabIndex = 2;
            this.lblSigno.Text = "+";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(266, 46);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "=";
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Checked = true;
            this.rbSuma.Location = new System.Drawing.Point(15, 20);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(31, 17);
            this.rbSuma.TabIndex = 0;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "+";
            this.rbSuma.UseVisualStyleBackColor = true;
            this.rbSuma.CheckedChanged += new System.EventHandler(this.operacion_CheckedChanged);
            // 
            // rbResta
            // 
            this.rbResta.AutoSize = true;
            this.rbResta.Location = new System.Drawing.Point(15, 43);
            this.rbResta.Name = "rbResta";
            this.rbResta.Size = new System.Drawing.Size(28, 17);
            this.rbResta.TabIndex = 1;
            this.rbResta.Text = "-";
            this.rbResta.UseVisualStyleBackColor = true;
            this.rbResta.CheckedChanged += new System.EventHandler(this.operacion_CheckedChanged);
            // 
            // rbMultiplicacion
            // 
            this.rbMultiplicacion.AutoSize = true;
            this.rbMultiplicacion.Location = new System.Drawing.Point(15, 66);
            this.rbMultiplicacion.Name = "rbMultiplicacion";
            this.rbMultiplicacion.Size = new System.Drawing.Size(30, 17);
            this.rbMultiplicacion.TabIndex = 2;
            this.rbMultiplicacion.Text = "x";
            this.rbMultiplicacion.UseVisualStyleBackColor = true;
            this.rbMultiplicacion.CheckedChanged += new System.EventHandler(this.operacion_CheckedChanged);
            // 
            // rbDivision
            // 
            this.rbDivision.AutoSize = true;
            this.rbDivision.Location = new System.Drawing.Point(15, 87);
            this.rbDivision.Name = "rbDivision";
            this.rbDivision.Size = new System.Drawing.Size(36, 17);
            this.rbDivision.TabIndex = 3;
            this.rbDivision.Text = "·/·";
            this.rbDivision.UseVisualStyleBackColor = true;
            this.rbDivision.CheckedChanged += new System.EventHandler(this.operacion_CheckedChanged);
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.rbSuma);
            this.gbOperaciones.Controls.Add(this.rbDivision);
            this.gbOperaciones.Controls.Add(this.rbMultiplicacion);
            this.gbOperaciones.Controls.Add(this.rbResta);
            this.gbOperaciones.Location = new System.Drawing.Point(35, 69);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(123, 114);
            this.gbOperaciones.TabIndex = 2;
            this.gbOperaciones.TabStop = false;
            // 
            // btnOperacion
            // 
            this.btnOperacion.Location = new System.Drawing.Point(185, 160);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(75, 23);
            this.btnOperacion.TabIndex = 3;
            this.btnOperacion.Text = "Operar";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOperacion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 203);
            this.Controls.Add(this.btnOperacion);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.txtOperando2);
            this.Controls.Add(this.txtOperando1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.gbOperaciones.ResumeLayout(false);
            this.gbOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperando1;
        private System.Windows.Forms.TextBox txtOperando2;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.RadioButton rbResta;
        private System.Windows.Forms.RadioButton rbMultiplicacion;
        private System.Windows.Forms.RadioButton rbDivision;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Timer timer1;
    }
}

