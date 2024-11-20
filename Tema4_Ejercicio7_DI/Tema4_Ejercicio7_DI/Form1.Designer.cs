namespace Tema4_Ejercicio7_DI
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
            this.cbxAlumno = new System.Windows.Forms.ComboBox();
            this.cbxAsignatura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tlp = new System.Windows.Forms.ToolTip(this.components);
            this.lblMaxMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxAlumno
            // 
            this.cbxAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlumno.FormattingEnabled = true;
            this.cbxAlumno.Location = new System.Drawing.Point(90, 26);
            this.cbxAlumno.Name = "cbxAlumno";
            this.cbxAlumno.Size = new System.Drawing.Size(121, 21);
            this.cbxAlumno.TabIndex = 0;
            this.cbxAlumno.SelectedIndexChanged += new System.EventHandler(this.cbx_SelectedIndexChanged);
            // 
            // cbxAsignatura
            // 
            this.cbxAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAsignatura.FormattingEnabled = true;
            this.cbxAsignatura.Location = new System.Drawing.Point(305, 26);
            this.cbxAsignatura.Name = "cbxAsignatura";
            this.cbxAsignatura.Size = new System.Drawing.Size(121, 21);
            this.cbxAsignatura.TabIndex = 1;
            this.cbxAsignatura.SelectedIndexChanged += new System.EventHandler(this.cbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asignatura: ";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(40, 333);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(24, 13);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "info";
            // 
            // lblMaxMin
            // 
            this.lblMaxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxMin.AutoSize = true;
            this.lblMaxMin.Location = new System.Drawing.Point(447, 333);
            this.lblMaxMin.Name = "lblMaxMin";
            this.lblMaxMin.Size = new System.Drawing.Size(44, 13);
            this.lblMaxMin.TabIndex = 5;
            this.lblMaxMin.Text = "MaxMin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 401);
            this.Controls.Add(this.lblMaxMin);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAsignatura);
            this.Controls.Add(this.cbxAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Aula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAlumno;
        private System.Windows.Forms.ComboBox cbxAsignatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolTip tlp;
        private System.Windows.Forms.Label lblMaxMin;
    }
}

