namespace SosaUlisesParcial
{
    partial class FormAddActFisica
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
            this.txtActFisica = new System.Windows.Forms.TextBox();
            this.txtGastoCalorico = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actividad Fisica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gasto Calorico:";
            // 
            // txtActFisica
            // 
            this.txtActFisica.Location = new System.Drawing.Point(158, 67);
            this.txtActFisica.Name = "txtActFisica";
            this.txtActFisica.Size = new System.Drawing.Size(140, 20);
            this.txtActFisica.TabIndex = 2;
            // 
            // txtGastoCalorico
            // 
            this.txtGastoCalorico.Location = new System.Drawing.Point(158, 125);
            this.txtGastoCalorico.Name = "txtGastoCalorico";
            this.txtGastoCalorico.Size = new System.Drawing.Size(140, 20);
            this.txtGastoCalorico.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(385, 92);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddActFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 205);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGastoCalorico);
            this.Controls.Add(this.txtActFisica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddActFisica";
            this.Text = "Agregar Actividad Fisica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActFisica;
        private System.Windows.Forms.TextBox txtGastoCalorico;
        private System.Windows.Forms.Button btnAdd;
    }
}