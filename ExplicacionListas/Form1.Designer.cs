﻿namespace ExplicacionListas
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
            this.ListaTexto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListaTexto
            // 
            this.ListaTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaTexto.FormattingEnabled = true;
            this.ListaTexto.Location = new System.Drawing.Point(12, 12);
            this.ListaTexto.Name = "ListaTexto";
            this.ListaTexto.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListaTexto.Size = new System.Drawing.Size(764, 403);
            this.ListaTexto.TabIndex = 1;
            this.ListaTexto.MouseEnter += new System.EventHandler(this.ListaTexto_MouseEnter);
            this.ListaTexto.MouseLeave += new System.EventHandler(this.ListaTexto_MouseLeave);
            this.ListaTexto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListaTexto_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaTexto;
    }
}

