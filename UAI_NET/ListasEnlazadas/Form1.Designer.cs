namespace ListasEnlazadas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnPrincipio = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del nodo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnPrincipio
            // 
            this.btnPrincipio.Location = new System.Drawing.Point(184, 162);
            this.btnPrincipio.Name = "btnPrincipio";
            this.btnPrincipio.Size = new System.Drawing.Size(142, 23);
            this.btnPrincipio.TabIndex = 2;
            this.btnPrincipio.Text = "Agregar al principio";
            this.btnPrincipio.UseVisualStyleBackColor = true;
            this.btnPrincipio.Click += new System.EventHandler(this.btnPrincipio_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(184, 203);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(142, 23);
            this.btnFinal.TabIndex = 3;
            this.btnFinal.Text = "Agregar al final";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(28, 31);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 251);
            this.listBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 363);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnPrincipio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnPrincipio;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.ListBox listBox;
    }
}

