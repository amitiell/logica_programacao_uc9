namespace OperacoesSimples
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSoma = new System.Windows.Forms.Label();
            this.lblSubtracao = new System.Windows.Forms.Label();
            this.lblDivisao = new System.Windows.Forms.Label();
            this.lblMultiplicacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(157, 42);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(149, 29);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(157, 89);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(149, 29);
            this.txtB.TabIndex = 1;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(334, 55);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 54);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSoma
            // 
            this.lblSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoma.Location = new System.Drawing.Point(12, 163);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(776, 49);
            this.lblSoma.TabIndex = 3;
            this.lblSoma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtracao
            // 
            this.lblSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtracao.Location = new System.Drawing.Point(18, 218);
            this.lblSubtracao.Name = "lblSubtracao";
            this.lblSubtracao.Size = new System.Drawing.Size(770, 49);
            this.lblSubtracao.TabIndex = 5;
            this.lblSubtracao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtracao.Click += new System.EventHandler(this.lblSubtracao_Click);
            // 
            // lblDivisao
            // 
            this.lblDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisao.Location = new System.Drawing.Point(24, 278);
            this.lblDivisao.Name = "lblDivisao";
            this.lblDivisao.Size = new System.Drawing.Size(764, 49);
            this.lblDivisao.TabIndex = 6;
            this.lblDivisao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMultiplicacao
            // 
            this.lblMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicacao.Location = new System.Drawing.Point(18, 335);
            this.lblMultiplicacao.Name = "lblMultiplicacao";
            this.lblMultiplicacao.Size = new System.Drawing.Size(770, 49);
            this.lblMultiplicacao.TabIndex = 7;
            this.lblMultiplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMultiplicacao);
            this.Controls.Add(this.lblDivisao);
            this.Controls.Add(this.lblSubtracao);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "frmPrincipal";
            this.Text = "Operações Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSoma;
        private System.Windows.Forms.Label lblSubtracao;
        private System.Windows.Forms.Label lblDivisao;
        private System.Windows.Forms.Label lblMultiplicacao;
    }
}

