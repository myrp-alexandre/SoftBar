﻿namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.FluxoDeCaixa
{
    partial class frmAlterar
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
            this.btnsalvar = new System.Windows.Forms.Button();
            this.dtppedidodevenda = new System.Windows.Forms.DateTimePicker();
            this.dtppedidodecompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(380, 286);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 7;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // dtppedidodevenda
            // 
            this.dtppedidodevenda.Location = new System.Drawing.Point(364, 181);
            this.dtppedidodevenda.Name = "dtppedidodevenda";
            this.dtppedidodevenda.Size = new System.Drawing.Size(200, 20);
            this.dtppedidodevenda.TabIndex = 5;
            // 
            // dtppedidodecompra
            // 
            this.dtppedidodecompra.Location = new System.Drawing.Point(364, 141);
            this.dtppedidodecompra.Name = "dtppedidodecompra";
            this.dtppedidodecompra.Size = new System.Drawing.Size(200, 20);
            this.dtppedidodecompra.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "pedido de venda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "pedido de compra:";
            // 
            // frmAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.dtppedidodevenda);
            this.Controls.Add(this.dtppedidodecompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlterar";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.DateTimePicker dtppedidodevenda;
        private System.Windows.Forms.DateTimePicker dtppedidodecompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}