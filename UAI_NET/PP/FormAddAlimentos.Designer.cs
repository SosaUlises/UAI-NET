namespace PP
{
    partial class FormAddAlimentos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtValorCalorico = new System.Windows.Forms.TextBox();
            this.btnAddAlimento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor calorico:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtValorCalorico
            // 
            this.txtValorCalorico.Location = new System.Drawing.Point(136, 100);
            this.txtValorCalorico.Name = "txtValorCalorico";
            this.txtValorCalorico.Size = new System.Drawing.Size(100, 20);
            this.txtValorCalorico.TabIndex = 3;
            // 
            // btnAddAlimento
            // 
            this.btnAddAlimento.Location = new System.Drawing.Point(321, 69);
            this.btnAddAlimento.Name = "btnAddAlimento";
            this.btnAddAlimento.Size = new System.Drawing.Size(128, 23);
            this.btnAddAlimento.TabIndex = 4;
            this.btnAddAlimento.Text = "Agregar Alimento";
            this.btnAddAlimento.UseVisualStyleBackColor = true;
            this.btnAddAlimento.Click += new System.EventHandler(this.btnAddAlimento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "(cada 100 grs.)";
            // 
            // FormAddAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 171);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAlimento);
            this.Controls.Add(this.txtValorCalorico);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddAlimentos";
            this.Text = "Agregar Alimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtValorCalorico;
        private System.Windows.Forms.Button btnAddAlimento;
        private System.Windows.Forms.Label label3;
    }
}