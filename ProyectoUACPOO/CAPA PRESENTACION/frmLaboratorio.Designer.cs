
namespace CAPA_PRESENTACION
{
    partial class frmLaboratorio
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
            this.btnObservar = new System.Windows.Forms.Button();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnConclusiones = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.txtHerramientas = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtMuestras = new System.Windows.Forms.TextBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnObservar
            // 
            this.btnObservar.Location = new System.Drawing.Point(207, 262);
            this.btnObservar.Name = "btnObservar";
            this.btnObservar.Size = new System.Drawing.Size(75, 23);
            this.btnObservar.TabIndex = 0;
            this.btnObservar.Text = "Observar";
            this.btnObservar.UseVisualStyleBackColor = true;
            this.btnObservar.Click += new System.EventHandler(this.btnObservar_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(315, 262);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnConclusiones
            // 
            this.btnConclusiones.Location = new System.Drawing.Point(418, 262);
            this.btnConclusiones.Name = "btnConclusiones";
            this.btnConclusiones.Size = new System.Drawing.Size(81, 23);
            this.btnConclusiones.TabIndex = 2;
            this.btnConclusiones.Text = "Conclusiones";
            this.btnConclusiones.UseVisualStyleBackColor = true;
            this.btnConclusiones.Click += new System.EventHandler(this.btnConclusiones_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(436, 100);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 3;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(436, 140);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 4;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // txtHerramientas
            // 
            this.txtHerramientas.Location = new System.Drawing.Point(243, 75);
            this.txtHerramientas.Name = "txtHerramientas";
            this.txtHerramientas.Size = new System.Drawing.Size(100, 20);
            this.txtHerramientas.TabIndex = 5;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(243, 118);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidad.TabIndex = 6;
            // 
            // txtMuestras
            // 
            this.txtMuestras.Location = new System.Drawing.Point(243, 155);
            this.txtMuestras.Name = "txtMuestras";
            this.txtMuestras.Size = new System.Drawing.Size(100, 20);
            this.txtMuestras.TabIndex = 7;
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(243, 196);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(100, 20);
            this.txtDocente.TabIndex = 8;
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDocente);
            this.Controls.Add(this.txtMuestras);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtHerramientas);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnConclusiones);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.btnObservar);
            this.Name = "frmLaboratorio";
            this.Text = "frmLaboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObservar;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnConclusiones;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.TextBox txtHerramientas;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtMuestras;
        private System.Windows.Forms.TextBox txtDocente;
    }
}