namespace Tema4_Ejercicio6_DI
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
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnAceptarPin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(34, 44);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 0;
            // 
            // btnAceptarPin
            // 
            this.btnAceptarPin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptarPin.Location = new System.Drawing.Point(47, 80);
            this.btnAceptarPin.Name = "btnAceptarPin";
            this.btnAceptarPin.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPin.TabIndex = 1;
            this.btnAceptarPin.Text = "Aceptar";
            this.btnAceptarPin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inserte PIN";
            // 
            // Form2
            // 
            this.AcceptButton = this.btnAceptarPin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptarPin);
            this.Controls.Add(this.txtPin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "PIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptarPin;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPin;
    }
}