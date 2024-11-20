namespace Tema4_Ejercicio3_DI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pbFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFondo
            // 
            this.pbFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFondo.Location = new System.Drawing.Point(0, 0);
            this.pbFondo.Name = "pbFondo";
            this.pbFondo.Size = new System.Drawing.Size(362, 324);
            this.pbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFondo.TabIndex = 0;
            this.pbFondo.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(362, 324);
            this.Controls.Add(this.pbFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFondo;
    }
}