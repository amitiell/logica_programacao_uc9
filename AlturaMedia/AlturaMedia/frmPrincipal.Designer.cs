namespace AlturaMedia
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
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblmedia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(77, 100);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 20);
            this.txtA1.TabIndex = 0;
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(77, 179);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(100, 20);
            this.txtA2.TabIndex = 1;
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(77, 260);
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(100, 20);
            this.txtA3.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(248, 164);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 35);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblmedia
            // 
            this.lblmedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedia.Location = new System.Drawing.Point(617, 173);
            this.lblmedia.Name = "lblmedia";
            this.lblmedia.Size = new System.Drawing.Size(100, 23);
            this.lblmedia.TabIndex = 4;
            this.lblmedia.Text = "0";
            this.lblmedia.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "A média das alturas é :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Primeira Altura";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Terceira Altura";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Segunda Altura";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmedia);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtA3);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtA1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Altura Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblmedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

