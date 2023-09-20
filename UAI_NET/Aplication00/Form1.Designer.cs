namespace Aplication00
{
    partial class FormInicio
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
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.chbAire = new System.Windows.Forms.CheckBox();
            this.chbABS = new System.Windows.Forms.CheckBox();
            this.chbEstabilidad = new System.Windows.Forms.CheckBox();
            this.btnCheckBox = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.btnOpcion = new System.Windows.Forms.Button();
            this.lblCheckBox = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(283, 40);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 0;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(37, 86);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(117, 83);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(283, 81);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(97, 23);
            this.btnCopiar.TabIndex = 5;
            this.btnCopiar.Text = "Copiar Numero";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // chbAire
            // 
            this.chbAire.AutoSize = true;
            this.chbAire.Location = new System.Drawing.Point(40, 129);
            this.chbAire.Name = "chbAire";
            this.chbAire.Size = new System.Drawing.Size(118, 17);
            this.chbAire.TabIndex = 6;
            this.chbAire.Text = "Aire Acondicionado";
            this.chbAire.UseVisualStyleBackColor = true;
            // 
            // chbABS
            // 
            this.chbABS.AutoSize = true;
            this.chbABS.Location = new System.Drawing.Point(40, 153);
            this.chbABS.Name = "chbABS";
            this.chbABS.Size = new System.Drawing.Size(47, 17);
            this.chbABS.TabIndex = 7;
            this.chbABS.Text = "ABS";
            this.chbABS.UseVisualStyleBackColor = true;
            // 
            // chbEstabilidad
            // 
            this.chbEstabilidad.AutoSize = true;
            this.chbEstabilidad.Location = new System.Drawing.Point(40, 177);
            this.chbEstabilidad.Name = "chbEstabilidad";
            this.chbEstabilidad.Size = new System.Drawing.Size(127, 17);
            this.chbEstabilidad.TabIndex = 8;
            this.chbEstabilidad.Text = "Control de estabilidad";
            this.chbEstabilidad.UseVisualStyleBackColor = true;
            // 
            // btnCheckBox
            // 
            this.btnCheckBox.Location = new System.Drawing.Point(40, 215);
            this.btnCheckBox.Name = "btnCheckBox";
            this.btnCheckBox.Size = new System.Drawing.Size(75, 23);
            this.btnCheckBox.TabIndex = 9;
            this.btnCheckBox.Text = "Agregar";
            this.btnCheckBox.UseVisualStyleBackColor = true;
            this.btnCheckBox.Click += new System.EventHandler(this.btnCheckBox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn3);
            this.groupBox1.Controls.Add(this.rbtn2);
            this.groupBox1.Controls.Add(this.rbtn1);
            this.groupBox1.Location = new System.Drawing.Point(283, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 89);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccion de color";
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Location = new System.Drawing.Point(16, 20);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(88, 17);
            this.rbtn1.TabIndex = 0;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "Rojo radiante";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Location = new System.Drawing.Point(16, 44);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(70, 17);
            this.rbtn2.TabIndex = 1;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "Azul cielo";
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(16, 66);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(82, 17);
            this.rbtn3.TabIndex = 2;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "Champagne";
            this.rbtn3.UseVisualStyleBackColor = true;
            // 
            // btnOpcion
            // 
            this.btnOpcion.Location = new System.Drawing.Point(283, 214);
            this.btnOpcion.Name = "btnOpcion";
            this.btnOpcion.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion.TabIndex = 11;
            this.btnOpcion.Text = "Opcion";
            this.btnOpcion.UseVisualStyleBackColor = true;
            this.btnOpcion.Click += new System.EventHandler(this.btnOpcion_Click);
            // 
            // lblCheckBox
            // 
            this.lblCheckBox.AutoSize = true;
            this.lblCheckBox.Location = new System.Drawing.Point(52, 260);
            this.lblCheckBox.Name = "lblCheckBox";
            this.lblCheckBox.Size = new System.Drawing.Size(0, 13);
            this.lblCheckBox.TabIndex = 12;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(283, 272);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(0, 13);
            this.lblColor.TabIndex = 13;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCheckBox);
            this.Controls.Add(this.btnOpcion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCheckBox);
            this.Controls.Add(this.chbEstabilidad);
            this.Controls.Add(this.chbABS);
            this.Controls.Add(this.chbAire);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnEjecutar);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.CheckBox chbAire;
        private System.Windows.Forms.CheckBox chbABS;
        private System.Windows.Forms.CheckBox chbEstabilidad;
        private System.Windows.Forms.Button btnCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.Button btnOpcion;
        private System.Windows.Forms.Label lblCheckBox;
        private System.Windows.Forms.Label lblColor;
    }
}

