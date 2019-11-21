namespace Calculadora
{
    partial class Form1
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
            this.BtnGerar = new System.Windows.Forms.Button();
            this.txtip1 = new System.Windows.Forms.TextBox();
            this.txtip2 = new System.Windows.Forms.TextBox();
            this.txtip3 = new System.Windows.Forms.TextBox();
            this.txtip4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubrede = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClasses = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMascara = new System.Windows.Forms.TextBox();
            this.dgvtabelaSubrede = new System.Windows.Forms.DataGridView();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Binario_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Binario_BD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtabelaSubrede)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGerar
            // 
            this.BtnGerar.Location = new System.Drawing.Point(851, 161);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(78, 28);
            this.BtnGerar.TabIndex = 0;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtip1
            // 
            this.txtip1.Location = new System.Drawing.Point(83, 51);
            this.txtip1.Name = "txtip1";
            this.txtip1.Size = new System.Drawing.Size(40, 20);
            this.txtip1.TabIndex = 1;
            this.txtip1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtip2
            // 
            this.txtip2.Location = new System.Drawing.Point(129, 51);
            this.txtip2.Name = "txtip2";
            this.txtip2.Size = new System.Drawing.Size(40, 20);
            this.txtip2.TabIndex = 1;
            this.txtip2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtip3
            // 
            this.txtip3.Location = new System.Drawing.Point(175, 51);
            this.txtip3.Name = "txtip3";
            this.txtip3.Size = new System.Drawing.Size(40, 20);
            this.txtip3.TabIndex = 1;
            this.txtip3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtip4
            // 
            this.txtip4.Location = new System.Drawing.Point(221, 51);
            this.txtip4.Name = "txtip4";
            this.txtip4.Size = new System.Drawing.Size(78, 20);
            this.txtip4.TabIndex = 1;
            this.txtip4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP rede:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subrede:";
            // 
            // txtSubrede
            // 
            this.txtSubrede.Location = new System.Drawing.Point(83, 95);
            this.txtSubrede.Name = "txtSubrede";
            this.txtSubrede.Size = new System.Drawing.Size(216, 20);
            this.txtSubrede.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSubrede);
            this.groupBox1.Controls.Add(this.txtip4);
            this.groupBox1.Controls.Add(this.txtip1);
            this.groupBox1.Controls.Add(this.txtip2);
            this.groupBox1.Controls.Add(this.txtip3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numero de subrede";
            // 
            // txtClasses
            // 
            this.txtClasses.Location = new System.Drawing.Point(79, 47);
            this.txtClasses.Name = "txtClasses";
            this.txtClasses.Size = new System.Drawing.Size(299, 20);
            this.txtClasses.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBinario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMascara);
            this.groupBox2.Controls.Add(this.txtClasses);
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 154);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Binario";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(79, 107);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(299, 20);
            this.txtBinario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mascara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Classes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMascara
            // 
            this.txtMascara.Location = new System.Drawing.Point(79, 77);
            this.txtMascara.Name = "txtMascara";
            this.txtMascara.Size = new System.Drawing.Size(299, 20);
            this.txtMascara.TabIndex = 5;
            // 
            // dgvtabelaSubrede
            // 
            this.dgvtabelaSubrede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtabelaSubrede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordem,
            this.dd,
            this.Column1,
            this.Column2,
            this.Binario_IP,
            this.Binario_BD});
            this.dgvtabelaSubrede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvtabelaSubrede.Location = new System.Drawing.Point(30, 207);
            this.dgvtabelaSubrede.Name = "dgvtabelaSubrede";
            this.dgvtabelaSubrede.Size = new System.Drawing.Size(899, 231);
            this.dgvtabelaSubrede.TabIndex = 36;
            // 
            // Ordem
            // 
            this.Ordem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ordem.HeaderText = "N°";
            this.Ordem.Name = "Ordem";
            this.Ordem.Width = 44;
            // 
            // dd
            // 
            this.dd.HeaderText = "ID-REDE";
            this.dd.Name = "dd";
            this.dd.Width = 110;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Alcance_IP_CONFIGURAÇÃO";
            this.Column1.Name = "Column1";
            this.Column1.Width = 178;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "BROADCAST";
            this.Column2.Name = "Column2";
            this.Column2.Width = 98;
            // 
            // Binario_IP
            // 
            this.Binario_IP.HeaderText = "Binario_IP";
            this.Binario_IP.Name = "Binario_IP";
            this.Binario_IP.Width = 215;
            // 
            // Binario_BD
            // 
            this.Binario_BD.HeaderText = "Binario_BD";
            this.Binario_BD.Name = "Binario_BD";
            this.Binario_BD.Width = 210;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.dgvtabelaSubrede);
            this.Controls.Add(this.BtnGerar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtabelaSubrede)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.TextBox txtip1;
        private System.Windows.Forms.TextBox txtip2;
        private System.Windows.Forms.TextBox txtip3;
        private System.Windows.Forms.TextBox txtip4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubrede;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClasses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMascara;
        private System.Windows.Forms.DataGridView dgvtabelaSubrede;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Binario_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Binario_BD;
    }
}

