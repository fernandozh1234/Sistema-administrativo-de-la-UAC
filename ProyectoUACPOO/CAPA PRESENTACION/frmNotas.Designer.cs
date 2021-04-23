
namespace CAPA_PRESENTACION
{
    partial class frmNotas
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
            this.txtUnidad1 = new System.Windows.Forms.TextBox();
            this.txtUnidad2 = new System.Windows.Forms.TextBox();
            this.txtUnidad3 = new System.Windows.Forms.TextBox();
            this.txtPonderado = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnAprobarSemestre = new System.Windows.Forms.Button();
            this.btnSubirNota = new System.Windows.Forms.Button();
            this.btnBajarNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnidad1
            // 
            this.txtUnidad1.Location = new System.Drawing.Point(196, 120);
            this.txtUnidad1.Name = "txtUnidad1";
            this.txtUnidad1.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad1.TabIndex = 0;
            // 
            // txtUnidad2
            // 
            this.txtUnidad2.Location = new System.Drawing.Point(196, 155);
            this.txtUnidad2.Name = "txtUnidad2";
            this.txtUnidad2.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad2.TabIndex = 1;
            // 
            // txtUnidad3
            // 
            this.txtUnidad3.Location = new System.Drawing.Point(196, 191);
            this.txtUnidad3.Name = "txtUnidad3";
            this.txtUnidad3.Size = new System.Drawing.Size(100, 20);
            this.txtUnidad3.TabIndex = 2;
            // 
            // txtPonderado
            // 
            this.txtPonderado.Location = new System.Drawing.Point(196, 227);
            this.txtPonderado.Name = "txtPonderado";
            this.txtPonderado.Size = new System.Drawing.Size(100, 20);
            this.txtPonderado.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(462, 120);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(462, 155);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnAprobarSemestre
            // 
            this.btnAprobarSemestre.Location = new System.Drawing.Point(508, 275);
            this.btnAprobarSemestre.Name = "btnAprobarSemestre";
            this.btnAprobarSemestre.Size = new System.Drawing.Size(124, 23);
            this.btnAprobarSemestre.TabIndex = 6;
            this.btnAprobarSemestre.Text = "Aprobar Semestre";
            this.btnAprobarSemestre.UseVisualStyleBackColor = true;
            this.btnAprobarSemestre.Click += new System.EventHandler(this.btnAprobarSemestre_Click);
            // 
            // btnSubirNota
            // 
            this.btnSubirNota.Location = new System.Drawing.Point(333, 275);
            this.btnSubirNota.Name = "btnSubirNota";
            this.btnSubirNota.Size = new System.Drawing.Size(75, 23);
            this.btnSubirNota.TabIndex = 7;
            this.btnSubirNota.Text = "SubirNota";
            this.btnSubirNota.UseVisualStyleBackColor = true;
            this.btnSubirNota.Click += new System.EventHandler(this.btnSubirNota_Click);
            // 
            // btnBajarNota
            // 
            this.btnBajarNota.Location = new System.Drawing.Point(427, 275);
            this.btnBajarNota.Name = "btnBajarNota";
            this.btnBajarNota.Size = new System.Drawing.Size(75, 23);
            this.btnBajarNota.TabIndex = 8;
            this.btnBajarNota.Text = "Bajar Nota";
            this.btnBajarNota.UseVisualStyleBackColor = true;
            this.btnBajarNota.Click += new System.EventHandler(this.btnBajarNota_Click);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBajarNota);
            this.Controls.Add(this.btnSubirNota);
            this.Controls.Add(this.btnAprobarSemestre);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtPonderado);
            this.Controls.Add(this.txtUnidad3);
            this.Controls.Add(this.txtUnidad2);
            this.Controls.Add(this.txtUnidad1);
            this.Name = "frmNotas";
            this.Text = "frmNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnidad1;
        private System.Windows.Forms.TextBox txtUnidad2;
        private System.Windows.Forms.TextBox txtUnidad3;
        private System.Windows.Forms.TextBox txtPonderado;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnAprobarSemestre;
        private System.Windows.Forms.Button btnSubirNota;
        private System.Windows.Forms.Button btnBajarNota;
    }
}