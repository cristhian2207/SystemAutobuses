﻿
namespace SystemAutobuses
{
    partial class FormTerminarViaje
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
            this.tablaTerminarViaje = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTerminarViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(237, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TERMINAR VIAJE";
            // 
            // tablaTerminarViaje
            // 
            this.tablaTerminarViaje.AllowUserToAddRows = false;
            this.tablaTerminarViaje.AllowUserToDeleteRows = false;
            this.tablaTerminarViaje.AllowUserToOrderColumns = true;
            this.tablaTerminarViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTerminarViaje.Location = new System.Drawing.Point(107, 253);
            this.tablaTerminarViaje.Name = "tablaTerminarViaje";
            this.tablaTerminarViaje.ReadOnly = true;
            this.tablaTerminarViaje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTerminarViaje.Size = new System.Drawing.Size(447, 176);
            this.tablaTerminarViaje.TabIndex = 1;
            this.tablaTerminarViaje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTerminarViaje_CellContentClick);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(271, 197);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 27);
            this.btnEnviar.TabIndex = 20;
            this.btnEnviar.Text = "Finalizar viaje";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FormTerminarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tablaTerminarViaje);
            this.Controls.Add(this.label1);
            this.Name = "FormTerminarViaje";
            this.Text = "FormTerminarViaje";
            this.Load += new System.EventHandler(this.FormTerminarViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTerminarViaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaTerminarViaje;
        private System.Windows.Forms.Button btnEnviar;
    }
}