namespace FactoryMethod
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
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnSeed = new System.Windows.Forms.Button();
            this.listOpciones = new System.Windows.Forms.ListBox();
            this.listaDatos = new System.Windows.Forms.ListBox();
            this.pnlOpciones.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.listOpciones);
            this.pnlOpciones.Location = new System.Drawing.Point(26, 23);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(200, 100);
            this.pnlOpciones.TabIndex = 0;
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.listaDatos);
            this.pnlDatos.Location = new System.Drawing.Point(342, 23);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(427, 366);
            this.pnlDatos.TabIndex = 1;
            // 
            // btnSeed
            // 
            this.btnSeed.Location = new System.Drawing.Point(97, 212);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(75, 23);
            this.btnSeed.TabIndex = 2;
            this.btnSeed.Text = "Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.BtnSeed_Click);
            // 
            // listOpciones
            // 
            this.listOpciones.FormattingEnabled = true;
            this.listOpciones.Location = new System.Drawing.Point(3, 2);
            this.listOpciones.Name = "listOpciones";
            this.listOpciones.Size = new System.Drawing.Size(120, 95);
            this.listOpciones.TabIndex = 0;
            // 
            // listaDatos
            // 
            this.listaDatos.FormattingEnabled = true;
            this.listaDatos.Location = new System.Drawing.Point(0, 5);
            this.listaDatos.Name = "listaDatos";
            this.listaDatos.Size = new System.Drawing.Size(427, 355);
            this.listaDatos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeed);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlOpciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOpciones.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.ListBox listOpciones;
        private System.Windows.Forms.ListBox listaDatos;
    }
}

