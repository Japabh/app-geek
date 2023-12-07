namespace app_geek
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtxtcelular = new System.Windows.Forms.MaskedTextBox();
            this.mtxtcpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.Yellow;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(625, 16);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(148, 45);
            this.btncadastrar.TabIndex = 0;
            this.btncadastrar.Text = "CADASTRAR";
            this.btncadastrar.UseVisualStyleBackColor = false;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(9, 71);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(52, 15);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "NOME:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dgvCliente
            // 
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.Location = new System.Drawing.Point(12, 292);
            this.dgvCliente.Name = "dgvCliente";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCliente.Size = new System.Drawing.Size(776, 150);
            this.dgvCliente.TabIndex = 3;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Green;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Location = new System.Drawing.Point(625, 85);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(148, 45);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "EDITAR";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(625, 152);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(148, 45);
            this.btnexcluir.TabIndex = 5;
            this.btnexcluir.Text = "EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = false;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(625, 220);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(148, 45);
            this.btnsair.TabIndex = 6;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = false;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(12, 134);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(37, 15);
            this.lblcpf.TabIndex = 9;
            this.lblcpf.Text = "CPF:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(15, 10);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(25, 15);
            this.lblid.TabIndex = 10;
            this.lblid.Text = "ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 11;
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(12, 202);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(82, 15);
            this.lbltelefone.TabIndex = 12;
            this.lbltelefone.Text = "TELEFONE:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::app_geek.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(198, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // mtxtcelular
            // 
            this.mtxtcelular.Location = new System.Drawing.Point(12, 220);
            this.mtxtcelular.Mask = "(99)99999-9999";
            this.mtxtcelular.Name = "mtxtcelular";
            this.mtxtcelular.Size = new System.Drawing.Size(100, 20);
            this.mtxtcelular.TabIndex = 16;
            // 
            // mtxtcpf
            // 
            this.mtxtcpf.Location = new System.Drawing.Point(12, 152);
            this.mtxtcpf.Mask = "___,___,___-__";
            this.mtxtcpf.Name = "mtxtcpf";
            this.mtxtcpf.Size = new System.Drawing.Size(100, 20);
            this.mtxtcpf.TabIndex = 17;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 454);
            this.Controls.Add(this.mtxtcpf);
            this.Controls.Add(this.mtxtcelular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btncadastrar);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mtxtcelular;
        private System.Windows.Forms.MaskedTextBox mtxtcpf;
    }
}

