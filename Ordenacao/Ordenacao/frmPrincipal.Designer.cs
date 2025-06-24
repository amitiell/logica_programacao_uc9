namespace Ordenacao
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCrescente1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDecrescente1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCrescente2 = new System.Windows.Forms.Label();
            this.lblCrescente3 = new System.Windows.Forms.Label();
            this.lblDecrescente2 = new System.Windows.Forms.Label();
            this.lblDecrescente3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1.Location = new System.Drawing.Point(71, 65);
            this.txtValor1.Multiline = true;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(118, 51);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2.Location = new System.Drawing.Point(71, 181);
            this.txtValor2.Multiline = true;
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(118, 51);
            this.txtValor2.TabIndex = 1;
            // 
            // txtValor3
            // 
            this.txtValor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor3.Location = new System.Drawing.Point(71, 295);
            this.txtValor3.Multiline = true;
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(118, 51);
            this.txtValor3.TabIndex = 2;
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(12, 365);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(229, 53);
            this.btnResultado.TabIndex = 3;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Crescente";
            // 
            // lblCrescente1
            // 
            this.lblCrescente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrescente1.Location = new System.Drawing.Point(376, 135);
            this.lblCrescente1.Name = "lblCrescente1";
            this.lblCrescente1.Size = new System.Drawing.Size(55, 29);
            this.lblCrescente1.TabIndex = 5;
            this.lblCrescente1.Text = "0";
            this.lblCrescente1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Decrescente";
            // 
            // lblDecrescente1
            // 
            this.lblDecrescente1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrescente1.Location = new System.Drawing.Point(379, 317);
            this.lblDecrescente1.Name = "lblDecrescente1";
            this.lblDecrescente1.Size = new System.Drawing.Size(52, 29);
            this.lblDecrescente1.TabIndex = 7;
            this.lblDecrescente1.Text = "0";
            this.lblDecrescente1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Número 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número 3";
            // 
            // lblCrescente2
            // 
            this.lblCrescente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrescente2.Location = new System.Drawing.Point(481, 135);
            this.lblCrescente2.Name = "lblCrescente2";
            this.lblCrescente2.Size = new System.Drawing.Size(55, 29);
            this.lblCrescente2.TabIndex = 11;
            this.lblCrescente2.Text = "0";
            this.lblCrescente2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCrescente3
            // 
            this.lblCrescente3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrescente3.Location = new System.Drawing.Point(595, 134);
            this.lblCrescente3.Name = "lblCrescente3";
            this.lblCrescente3.Size = new System.Drawing.Size(55, 29);
            this.lblCrescente3.TabIndex = 12;
            this.lblCrescente3.Text = "0";
            this.lblCrescente3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDecrescente2
            // 
            this.lblDecrescente2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrescente2.Location = new System.Drawing.Point(481, 317);
            this.lblDecrescente2.Name = "lblDecrescente2";
            this.lblDecrescente2.Size = new System.Drawing.Size(52, 29);
            this.lblDecrescente2.TabIndex = 13;
            this.lblDecrescente2.Text = "0";
            this.lblDecrescente2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDecrescente3
            // 
            this.lblDecrescente3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrescente3.Location = new System.Drawing.Point(595, 317);
            this.lblDecrescente3.Name = "lblDecrescente3";
            this.lblDecrescente3.Size = new System.Drawing.Size(52, 29);
            this.lblDecrescente3.TabIndex = 14;
            this.lblDecrescente3.Text = "0";
            this.lblDecrescente3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDecrescente3);
            this.Controls.Add(this.lblDecrescente2);
            this.Controls.Add(this.lblCrescente3);
            this.Controls.Add(this.lblCrescente2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDecrescente1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCrescente1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "frmPrincipal";
            this.Text = "Ordenação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCrescente1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDecrescente1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCrescente2;
        private System.Windows.Forms.Label lblCrescente3;
        private System.Windows.Forms.Label lblDecrescente2;
        private System.Windows.Forms.Label lblDecrescente3;
    }
}

