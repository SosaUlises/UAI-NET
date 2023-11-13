namespace Arbol
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnpostOrdern = new System.Windows.Forms.Button();
            this.txtRaiz = new System.Windows.Forms.TextBox();
            this.txtRama = new System.Windows.Forms.TextBox();
            this.Raiz = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreNodo = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecorrido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(37, 47);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(281, 262);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(324, 60);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(151, 39);
            this.btnRaiz.TabIndex = 1;
            this.btnRaiz.Text = "Agregar Raiz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(324, 105);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(151, 36);
            this.btnDerecha.TabIndex = 2;
            this.btnDerecha.Text = "Agregar Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(324, 147);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(151, 38);
            this.btnIzquierda.TabIndex = 3;
            this.btnIzquierda.Text = "Agregar Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnInOrden
            // 
            this.btnInOrden.Location = new System.Drawing.Point(324, 191);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(151, 35);
            this.btnInOrden.TabIndex = 4;
            this.btnInOrden.Text = "Recorrer InOrden";
            this.btnInOrden.UseVisualStyleBackColor = true;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(324, 232);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(151, 37);
            this.btnPreOrden.TabIndex = 5;
            this.btnPreOrden.Text = "Recorrer PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnpostOrdern
            // 
            this.btnpostOrdern.Location = new System.Drawing.Point(324, 275);
            this.btnpostOrdern.Name = "btnpostOrdern";
            this.btnpostOrdern.Size = new System.Drawing.Size(151, 36);
            this.btnpostOrdern.TabIndex = 6;
            this.btnpostOrdern.Text = "Recorrer PostOrden";
            this.btnpostOrdern.UseVisualStyleBackColor = true;
            this.btnpostOrdern.Click += new System.EventHandler(this.btnpostOrdern_Click);
            // 
            // txtRaiz
            // 
            this.txtRaiz.Location = new System.Drawing.Point(557, 62);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(139, 20);
            this.txtRaiz.TabIndex = 7;
            // 
            // txtRama
            // 
            this.txtRama.Location = new System.Drawing.Point(557, 134);
            this.txtRama.Name = "txtRama";
            this.txtRama.Size = new System.Drawing.Size(139, 20);
            this.txtRama.TabIndex = 8;
            // 
            // Raiz
            // 
            this.Raiz.AutoSize = true;
            this.Raiz.Location = new System.Drawing.Point(500, 65);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(28, 13);
            this.Raiz.TabIndex = 9;
            this.Raiz.Text = "Raiz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rama";
            // 
            // lblNombreNodo
            // 
            this.lblNombreNodo.AutoSize = true;
            this.lblNombreNodo.Location = new System.Drawing.Point(43, 349);
            this.lblNombreNodo.Name = "lblNombreNodo";
            this.lblNombreNodo.Size = new System.Drawing.Size(0, 13);
            this.lblNombreNodo.TabIndex = 11;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(43, 390);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(0, 13);
            this.lblAltura.TabIndex = 12;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(43, 419);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(0, 13);
            this.lblAncho.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nodo seleccionado:";
            // 
            // txtRecorrido
            // 
            this.txtRecorrido.Location = new System.Drawing.Point(475, 359);
            this.txtRecorrido.Name = "txtRecorrido";
            this.txtRecorrido.Size = new System.Drawing.Size(259, 20);
            this.txtRecorrido.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Recorrido:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRecorrido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblNombreNodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.txtRama);
            this.Controls.Add(this.txtRaiz);
            this.Controls.Add(this.btnpostOrdern);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.btnInOrden);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnpostOrdern;
        private System.Windows.Forms.TextBox txtRaiz;
        private System.Windows.Forms.TextBox txtRama;
        private System.Windows.Forms.Label Raiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreNodo;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecorrido;
        private System.Windows.Forms.Label label3;
    }
}

