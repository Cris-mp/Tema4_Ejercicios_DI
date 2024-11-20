namespace Tema4_Ejercicio5_DI
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
            this.lbxA = new System.Windows.Forms.ListBox();
            this.lbxB = new System.Windows.Forms.ListBox();
            this.txtAnadir = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnAtoB = new System.Windows.Forms.Button();
            this.btbBtoA = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.lblNada = new System.Windows.Forms.Label();
            this.lblElementos = new System.Windows.Forms.Label();
            this.lblIndices = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tool = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbxA
            // 
            this.lbxA.FormattingEnabled = true;
            this.lbxA.Location = new System.Drawing.Point(25, 97);
            this.lbxA.Name = "lbxA";
            this.lbxA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxA.Size = new System.Drawing.Size(120, 95);
            this.lbxA.TabIndex = 2;
            this.tool.SetToolTip(this.lbxA, "Lista de seleccion multiple");
            this.lbxA.SelectedIndexChanged += new System.EventHandler(this.lbxA_SelectedIndexChanged);
            // 
            // lbxB
            // 
            this.lbxB.FormattingEnabled = true;
            this.lbxB.Location = new System.Drawing.Point(256, 97);
            this.lbxB.Name = "lbxB";
            this.lbxB.Size = new System.Drawing.Size(120, 95);
            this.lbxB.TabIndex = 3;
            this.tool.SetToolTip(this.lbxB, "Elementos: 0");
            // 
            // txtAnadir
            // 
            this.txtAnadir.Location = new System.Drawing.Point(35, 28);
            this.txtAnadir.Name = "txtAnadir";
            this.txtAnadir.Size = new System.Drawing.Size(232, 20);
            this.txtAnadir.TabIndex = 0;
            this.tool.SetToolTip(this.txtAnadir, "El texto se añadira a A");
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(25, 78);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(253, 77);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B";
            // 
            // btnAtoB
            // 
            this.btnAtoB.Location = new System.Drawing.Point(25, 199);
            this.btnAtoB.Name = "btnAtoB";
            this.btnAtoB.Size = new System.Drawing.Size(75, 23);
            this.btnAtoB.TabIndex = 4;
            this.btnAtoB.Text = "Traspasar ->";
            this.tool.SetToolTip(this.btnAtoB, "De A a B");
            this.btnAtoB.UseVisualStyleBackColor = true;
            this.btnAtoB.Click += new System.EventHandler(this.btnAtoB_Click);
            // 
            // btbBtoA
            // 
            this.btbBtoA.Location = new System.Drawing.Point(301, 199);
            this.btbBtoA.Name = "btbBtoA";
            this.btbBtoA.Size = new System.Drawing.Size(75, 23);
            this.btbBtoA.TabIndex = 5;
            this.btbBtoA.Text = "<- Traspasar";
            this.tool.SetToolTip(this.btbBtoA, "De B a A");
            this.btbBtoA.UseVisualStyleBackColor = true;
            this.btbBtoA.Click += new System.EventHandler(this.btbBtoA_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(162, 236);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.tool.SetToolTip(this.btnEliminar, "Elimina elementos marcados de la lista A");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(301, 28);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "Añadir";
            this.tool.SetToolTip(this.btnAnadir, "Añadir texto a A");
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // lblNada
            // 
            this.lblNada.AutoSize = true;
            this.lblNada.Location = new System.Drawing.Point(182, 137);
            this.lblNada.Name = "lblNada";
            this.lblNada.Size = new System.Drawing.Size(34, 13);
            this.lblNada.TabIndex = 9;
            this.lblNada.Text = "<-- -->";
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(25, 260);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(68, 13);
            this.lblElementos.TabIndex = 10;
            this.lblElementos.Text = "Elementos: 0";
            this.tool.SetToolTip(this.lblElementos, "Número de elementos en A");
            // 
            // lblIndices
            // 
            this.lblIndices.AutoSize = true;
            this.lblIndices.Location = new System.Drawing.Point(25, 273);
            this.lblIndices.Name = "lblIndices";
            this.lblIndices.Size = new System.Drawing.Size(124, 13);
            this.lblIndices.TabIndex = 11;
            this.lblIndices.Text = "Indices seleccionados: 0";
            this.tool.SetToolTip(this.lblIndices, "Número de elementos seleccionados en A");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAnadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 295);
            this.Controls.Add(this.lblIndices);
            this.Controls.Add(this.lblElementos);
            this.Controls.Add(this.lblNada);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btbBtoA);
            this.Controls.Add(this.btnAtoB);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtAnadir);
            this.Controls.Add(this.lbxB);
            this.Controls.Add(this.lbxA);
            this.Name = "Form1";
            this.Text = "Ejercicico 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxA;
        private System.Windows.Forms.ListBox lbxB;
        private System.Windows.Forms.TextBox txtAnadir;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnAtoB;
        private System.Windows.Forms.Button btbBtoA;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Label lblNada;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.Label lblIndices;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip tool;
    }
}

