namespace AdvancedHMICS.Views.Arquivo
{
    partial class Teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teste));
            this.TxtPara = new System.Windows.Forms.TextBox();
            this.TxtAssunto = new System.Windows.Forms.TextBox();
            this.TxtConteudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPara
            // 
            this.TxtPara.Location = new System.Drawing.Point(90, 29);
            this.TxtPara.Name = "TxtPara";
            this.TxtPara.Size = new System.Drawing.Size(286, 20);
            this.TxtPara.TabIndex = 0;
            this.TxtPara.TextChanged += new System.EventHandler(this.TxtPara_TextChanged);
            // 
            // TxtAssunto
            // 
            this.TxtAssunto.Location = new System.Drawing.Point(90, 77);
            this.TxtAssunto.Name = "TxtAssunto";
            this.TxtAssunto.Size = new System.Drawing.Size(499, 20);
            this.TxtAssunto.TabIndex = 1;
            // 
            // TxtConteudo
            // 
            this.TxtConteudo.Location = new System.Drawing.Point(27, 126);
            this.TxtConteudo.Multiline = true;
            this.TxtConteudo.Name = "TxtConteudo";
            this.TxtConteudo.Size = new System.Drawing.Size(562, 229);
            this.TxtConteudo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assunto:";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(489, 375);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(100, 30);
            this.BtnEnviar.TabIndex = 5;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(367, 375);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 424);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtConteudo);
            this.Controls.Add(this.TxtAssunto);
            this.Controls.Add(this.TxtPara);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Teste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de envio de Email";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Teste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPara;
        private System.Windows.Forms.TextBox TxtAssunto;
        private System.Windows.Forms.TextBox TxtConteudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}