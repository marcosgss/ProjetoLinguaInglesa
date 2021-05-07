
namespace Vetorizador
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnContador = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblInvisivel = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.ForeColor = System.Drawing.Color.Black;
            this.txtTexto.Location = new System.Drawing.Point(12, 12);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(959, 604);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.Text = "Insira seu texto";
            this.txtTexto.Click += new System.EventHandler(this.txtTexto_Click);
            // 
            // btnContador
            // 
            this.btnContador.Location = new System.Drawing.Point(173, 632);
            this.btnContador.Name = "btnContador";
            this.btnContador.Size = new System.Drawing.Size(114, 52);
            this.btnContador.TabIndex = 2;
            this.btnContador.Text = "Contar palavras";
            this.btnContador.UseVisualStyleBackColor = true;
            this.btnContador.Click += new System.EventHandler(this.btnContador_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(722, 632);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(114, 52);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblInvisivel
            // 
            this.lblInvisivel.AutoSize = true;
            this.lblInvisivel.Location = new System.Drawing.Point(935, 650);
            this.lblInvisivel.Name = "lblInvisivel";
            this.lblInvisivel.Size = new System.Drawing.Size(0, 19);
            this.lblInvisivel.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(537, 632);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(114, 52);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.Location = new System.Drawing.Point(354, 632);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(114, 52);
            this.btnTeste.TabIndex = 5;
            this.btnTeste.Text = "Testar Replace";
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 700);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblInvisivel);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnContador);
            this.Controls.Add(this.txtTexto);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vetorizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnContador;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInvisivel;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnTeste;
    }
}

