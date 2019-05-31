namespace View
{
    partial class FilmeEditar
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
            this.txtAvaliacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ckbTemSequencia = new System.Windows.Forms.CheckBox();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAvaliacao
            // 
            this.txtAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvaliacao.Location = new System.Drawing.Point(24, 461);
            this.txtAvaliacao.Name = "txtAvaliacao";
            this.txtAvaliacao.Size = new System.Drawing.Size(404, 38);
            this.txtAvaliacao.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Avaliação";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(205, 547);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(223, 46);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ckbTemSequencia
            // 
            this.ckbTemSequencia.AutoSize = true;
            this.ckbTemSequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTemSequencia.Location = new System.Drawing.Point(24, 505);
            this.ckbTemSequencia.Name = "ckbTemSequencia";
            this.ckbTemSequencia.Size = new System.Drawing.Size(236, 36);
            this.ckbTemSequencia.TabIndex = 22;
            this.ckbTemSequencia.Text = "Tem Sequencia";
            this.ckbTemSequencia.UseVisualStyleBackColor = true;
            // 
            // txtDuracao
            // 
            this.txtDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracao.Location = new System.Drawing.Point(24, 381);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(404, 38);
            this.txtDuracao.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "Duração";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNao.Location = new System.Drawing.Point(115, 292);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(88, 36);
            this.rbNao.TabIndex = 19;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSim.Location = new System.Drawing.Point(24, 292);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(85, 36);
            this.rbSim.TabIndex = 18;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Curtiu";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Ação",
            "Infantil",
            "Bipolaridade",
            "Drama"});
            this.cbCategoria.Location = new System.Drawing.Point(24, 212);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(404, 39);
            this.cbCategoria.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(24, 122);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(404, 38);
            this.txtNome.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(24, 43);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(404, 38);
            this.txtCodigo.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Código";
            // 
            // FilmeEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 617);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAvaliacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ckbTemSequencia);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "FilmeEditar";
            this.Text = "FilmeEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAvaliacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox ckbTemSequencia;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
    }
}