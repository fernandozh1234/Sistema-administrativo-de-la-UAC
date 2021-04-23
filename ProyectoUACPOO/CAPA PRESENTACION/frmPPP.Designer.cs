
namespace CAPA_PRESENTACION
{
    partial class frmPPP
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
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnDesarrollar = new System.Windows.Forms.Button();
            this.btnFortalecer = new System.Windows.Forms.Button();
            this.btnContrato = new System.Windows.Forms.Button();
            this.txtNombredelSuperior = new System.Windows.Forms.TextBox();
            this.txtPuestodeTrabajo = new System.Windows.Forms.TextBox();
            this.txtHoradeIngreso = new System.Windows.Forms.TextBox();
            this.txtLocaldeTrabajo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(562, 59);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 0;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(562, 101);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 1;
            this.btnEscribir.Text = "Escribir ";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnDesarrollar
            // 
            this.btnDesarrollar.Location = new System.Drawing.Point(191, 220);
            this.btnDesarrollar.Name = "btnDesarrollar";
            this.btnDesarrollar.Size = new System.Drawing.Size(157, 23);
            this.btnDesarrollar.TabIndex = 2;
            this.btnDesarrollar.Text = "Desarrollar Habilidades";
            this.btnDesarrollar.UseVisualStyleBackColor = true;
            this.btnDesarrollar.Click += new System.EventHandler(this.btnDesarrollar_Click);
            // 
            // btnFortalecer
            // 
            this.btnFortalecer.Location = new System.Drawing.Point(370, 220);
            this.btnFortalecer.Name = "btnFortalecer";
            this.btnFortalecer.Size = new System.Drawing.Size(208, 23);
            this.btnFortalecer.TabIndex = 3;
            this.btnFortalecer.Text = "Fortalecer Formacion Academica";
            this.btnFortalecer.UseVisualStyleBackColor = true;
            this.btnFortalecer.Click += new System.EventHandler(this.btnFortalecer_Click);
            // 
            // btnContrato
            // 
            this.btnContrato.Location = new System.Drawing.Point(602, 220);
            this.btnContrato.Name = "btnContrato";
            this.btnContrato.Size = new System.Drawing.Size(119, 23);
            this.btnContrato.TabIndex = 4;
            this.btnContrato.Text = "Renovar Contrato";
            this.btnContrato.UseVisualStyleBackColor = true;
            this.btnContrato.Click += new System.EventHandler(this.btnContrato_Click);
            // 
            // txtNombredelSuperior
            // 
            this.txtNombredelSuperior.Location = new System.Drawing.Point(357, 59);
            this.txtNombredelSuperior.Name = "txtNombredelSuperior";
            this.txtNombredelSuperior.Size = new System.Drawing.Size(100, 20);
            this.txtNombredelSuperior.TabIndex = 5;
            // 
            // txtPuestodeTrabajo
            // 
            this.txtPuestodeTrabajo.Location = new System.Drawing.Point(357, 101);
            this.txtPuestodeTrabajo.Name = "txtPuestodeTrabajo";
            this.txtPuestodeTrabajo.Size = new System.Drawing.Size(100, 20);
            this.txtPuestodeTrabajo.TabIndex = 6;
            // 
            // txtHoradeIngreso
            // 
            this.txtHoradeIngreso.Location = new System.Drawing.Point(357, 138);
            this.txtHoradeIngreso.Name = "txtHoradeIngreso";
            this.txtHoradeIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtHoradeIngreso.TabIndex = 7;
            // 
            // txtLocaldeTrabajo
            // 
            this.txtLocaldeTrabajo.Location = new System.Drawing.Point(357, 179);
            this.txtLocaldeTrabajo.Name = "txtLocaldeTrabajo";
            this.txtLocaldeTrabajo.Size = new System.Drawing.Size(100, 20);
            this.txtLocaldeTrabajo.TabIndex = 8;
            // 
            // frmPPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLocaldeTrabajo);
            this.Controls.Add(this.txtHoradeIngreso);
            this.Controls.Add(this.txtPuestodeTrabajo);
            this.Controls.Add(this.txtNombredelSuperior);
            this.Controls.Add(this.btnContrato);
            this.Controls.Add(this.btnFortalecer);
            this.Controls.Add(this.btnDesarrollar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Name = "frmPPP";
            this.Text = "frmPPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnDesarrollar;
        private System.Windows.Forms.Button btnFortalecer;
        private System.Windows.Forms.Button btnContrato;
        private System.Windows.Forms.TextBox txtNombredelSuperior;
        private System.Windows.Forms.TextBox txtPuestodeTrabajo;
        private System.Windows.Forms.TextBox txtHoradeIngreso;
        private System.Windows.Forms.TextBox txtLocaldeTrabajo;
    }
}