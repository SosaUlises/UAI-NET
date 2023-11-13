namespace PP
{
    partial class FormAddFisica
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
            this.btnAddFisica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actividad Fisica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gasto calorico";
            // 
            // txtActFisica
            // 
            this.txtActFisica.Location = new System.Drawing.Point(155, 44);
            this.txtActFisica.Name = "txtActFisica";
            this.txtActFisica.Size = new System.Drawing.Size(100, 20);
            this.txtActFisica.TabIndex = 2;
            // 
            // txtGastoCalorico
            // 
            this.txtGastoCalorico.Location = new System.Drawing.Point(155, 91);
            this.txtGastoCalorico.Name = "txtGastoCalorico";
            this.txtGastoCalorico.Size = new System.Drawing.Size(100, 20);
            this.txtGastoCalorico.TabIndex = 3;
            // 
            // btnAddFisica
            // 
            this.btnAddFisica.Location = new System.Drawing.Point(345, 72);
            this.btnAddFisica.Name = "btnAddFisica";
            this.btnAddFisica.Size = new System.Drawing.Size(75, 23);
            this.btnAddFisica.TabIndex = 4;
            this.btnAddFisica.Text = "Agregar";
            this.btnAddFisica.UseVisualStyleBackColor = true;
            this.btnAddFisica.Click += new System.EventHandler(this.btnAddFisica_Click);
            // 
            // FormAddFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 150);
            this.Controls.Add(this.btnAddFisica);
            this.Controls.Add(this.txtGastoCalorico);
            this.Controls.Add(this.txtActFisica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddFisica";
            this.Text = "Agregar Actividad Fisica";
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActFisica;
        private System.Windows.Forms.TextBox txtGastoCalorico;
        private System.Windows.Forms.Button btnAddFisica;
    }
}