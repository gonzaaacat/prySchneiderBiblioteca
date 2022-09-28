namespace prySchneiderBiblioteca
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtCodigodelAutor = new System.Windows.Forms.TextBox();
            this.txtCodigodeDistribuidor = new System.Windows.Forms.TextBox();
            this.txtNombredelLibro = new System.Windows.Forms.TextBox();
            this.txtCodigodeEditorial = new System.Windows.Forms.TextBox();
            this.txtCodigodelLibro = new System.Windows.Forms.TextBox();
            this.lblCodigoDistr = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigodelAutor
            // 
            this.txtCodigodelAutor.Enabled = false;
            this.txtCodigodelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigodelAutor.Location = new System.Drawing.Point(180, 186);
            this.txtCodigodelAutor.Name = "txtCodigodelAutor";
            this.txtCodigodelAutor.Size = new System.Drawing.Size(105, 20);
            this.txtCodigodelAutor.TabIndex = 21;
            // 
            // txtCodigodeDistribuidor
            // 
            this.txtCodigodeDistribuidor.Enabled = false;
            this.txtCodigodeDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigodeDistribuidor.Location = new System.Drawing.Point(180, 228);
            this.txtCodigodeDistribuidor.Name = "txtCodigodeDistribuidor";
            this.txtCodigodeDistribuidor.Size = new System.Drawing.Size(105, 20);
            this.txtCodigodeDistribuidor.TabIndex = 20;
            // 
            // txtNombredelLibro
            // 
            this.txtNombredelLibro.Enabled = false;
            this.txtNombredelLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombredelLibro.Location = new System.Drawing.Point(180, 102);
            this.txtNombredelLibro.Multiline = true;
            this.txtNombredelLibro.Name = "txtNombredelLibro";
            this.txtNombredelLibro.Size = new System.Drawing.Size(105, 20);
            this.txtNombredelLibro.TabIndex = 19;
            // 
            // txtCodigodeEditorial
            // 
            this.txtCodigodeEditorial.Enabled = false;
            this.txtCodigodeEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigodeEditorial.Location = new System.Drawing.Point(180, 146);
            this.txtCodigodeEditorial.Name = "txtCodigodeEditorial";
            this.txtCodigodeEditorial.Size = new System.Drawing.Size(105, 20);
            this.txtCodigodeEditorial.TabIndex = 18;
            // 
            // txtCodigodelLibro
            // 
            this.txtCodigodelLibro.Enabled = false;
            this.txtCodigodelLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigodelLibro.Location = new System.Drawing.Point(180, 62);
            this.txtCodigodelLibro.Name = "txtCodigodelLibro";
            this.txtCodigodelLibro.Size = new System.Drawing.Size(105, 20);
            this.txtCodigodelLibro.TabIndex = 17;
            // 
            // lblCodigoDistr
            // 
            this.lblCodigoDistr.AutoSize = true;
            this.lblCodigoDistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDistr.Location = new System.Drawing.Point(17, 228);
            this.lblCodigoDistr.Name = "lblCodigoDistr";
            this.lblCodigoDistr.Size = new System.Drawing.Size(165, 20);
            this.lblCodigoDistr.TabIndex = 16;
            this.lblCodigoDistr.Text = "Código de Distribuidor";
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.AutoSize = true;
            this.lblCodigoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAutor.Location = new System.Drawing.Point(17, 186);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(127, 20);
            this.lblCodigoAutor.TabIndex = 15;
            this.lblCodigoAutor.Text = "Código del Autor";
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.AutoSize = true;
            this.lblCodigoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEditorial.Location = new System.Drawing.Point(17, 144);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(142, 20);
            this.lblCodigoEditorial.TabIndex = 14;
            this.lblCodigoEditorial.Text = "Código de Editorial";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.AutoSize = true;
            this.txtNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLibro.Location = new System.Drawing.Point(17, 102);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(129, 20);
            this.txtNombreLibro.TabIndex = 13;
            this.txtNombreLibro.Text = "Nombre del Libro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(17, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(123, 20);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código del Libro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 31);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Consulta de Libros";
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(12, 271);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(94, 23);
            this.btnRetroceder.TabIndex = 22;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(207, 271);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(78, 23);
            this.btnAvanzar.TabIndex = 23;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 306);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.txtCodigodelAutor);
            this.Controls.Add(this.txtCodigodeDistribuidor);
            this.Controls.Add(this.txtNombredelLibro);
            this.Controls.Add(this.txtCodigodeEditorial);
            this.Controls.Add(this.txtCodigodelLibro);
            this.Controls.Add(this.lblCodigoDistr);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Consulta de Libros";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigodelAutor;
        private System.Windows.Forms.TextBox txtCodigodeDistribuidor;
        private System.Windows.Forms.TextBox txtNombredelLibro;
        private System.Windows.Forms.TextBox txtCodigodeEditorial;
        private System.Windows.Forms.TextBox txtCodigodelLibro;
        private System.Windows.Forms.Label lblCodigoDistr;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label txtNombreLibro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnAvanzar;
    }
}

