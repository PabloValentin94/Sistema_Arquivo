namespace Aplicativo_NET_Framework_11
{
    partial class frm_sistema
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
            this.btn_importar_arquivo = new System.Windows.Forms.Button();
            this.btn_desmarcar_todos = new System.Windows.Forms.Button();
            this.btn_marcar_todos = new System.Windows.Forms.Button();
            this.btn_baixar = new System.Windows.Forms.Button();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_selecao = new System.Windows.Forms.Label();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.lbl_valor_selecao = new System.Windows.Forms.Label();
            this.ofd_arquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_importar_arquivo
            // 
            this.btn_importar_arquivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_importar_arquivo.BackColor = System.Drawing.Color.Purple;
            this.btn_importar_arquivo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importar_arquivo.ForeColor = System.Drawing.Color.White;
            this.btn_importar_arquivo.Location = new System.Drawing.Point(12, 12);
            this.btn_importar_arquivo.Name = "btn_importar_arquivo";
            this.btn_importar_arquivo.Size = new System.Drawing.Size(150, 31);
            this.btn_importar_arquivo.TabIndex = 0;
            this.btn_importar_arquivo.Text = "Importar Arquivo";
            this.btn_importar_arquivo.UseVisualStyleBackColor = false;
            this.btn_importar_arquivo.Click += new System.EventHandler(this.btn_importar_arquivo_Click);
            // 
            // btn_desmarcar_todos
            // 
            this.btn_desmarcar_todos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_desmarcar_todos.BackColor = System.Drawing.Color.Red;
            this.btn_desmarcar_todos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desmarcar_todos.ForeColor = System.Drawing.Color.White;
            this.btn_desmarcar_todos.Location = new System.Drawing.Point(620, 12);
            this.btn_desmarcar_todos.Name = "btn_desmarcar_todos";
            this.btn_desmarcar_todos.Size = new System.Drawing.Size(168, 31);
            this.btn_desmarcar_todos.TabIndex = 1;
            this.btn_desmarcar_todos.Text = "Desmarcar Todos";
            this.btn_desmarcar_todos.UseVisualStyleBackColor = false;
            this.btn_desmarcar_todos.Click += new System.EventHandler(this.btn_desmarcar_todos_Click);
            // 
            // btn_marcar_todos
            // 
            this.btn_marcar_todos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_marcar_todos.BackColor = System.Drawing.Color.Green;
            this.btn_marcar_todos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcar_todos.ForeColor = System.Drawing.Color.White;
            this.btn_marcar_todos.Location = new System.Drawing.Point(473, 12);
            this.btn_marcar_todos.Name = "btn_marcar_todos";
            this.btn_marcar_todos.Size = new System.Drawing.Size(141, 31);
            this.btn_marcar_todos.TabIndex = 2;
            this.btn_marcar_todos.Text = "Marcar Todos";
            this.btn_marcar_todos.UseVisualStyleBackColor = false;
            this.btn_marcar_todos.Click += new System.EventHandler(this.btn_marcar_todos_Click);
            // 
            // btn_baixar
            // 
            this.btn_baixar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_baixar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_baixar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baixar.ForeColor = System.Drawing.Color.White;
            this.btn_baixar.Location = new System.Drawing.Point(568, 407);
            this.btn_baixar.Name = "btn_baixar";
            this.btn_baixar.Size = new System.Drawing.Size(220, 31);
            this.btn_baixar.TabIndex = 3;
            this.btn_baixar.Text = "Baixar Itens Selecionados";
            this.btn_baixar.UseVisualStyleBackColor = false;
            this.btn_baixar.Click += new System.EventHandler(this.btn_baixar_Click);
            // 
            // dgv_itens
            // 
            this.dgv_itens.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Location = new System.Drawing.Point(12, 49);
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.Size = new System.Drawing.Size(776, 352);
            this.dgv_itens.TabIndex = 4;
            this.dgv_itens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itens_CellClick);
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(12, 417);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(48, 18);
            this.lbl_total.TabIndex = 5;
            this.lbl_total.Text = "Total:";
            // 
            // lbl_selecao
            // 
            this.lbl_selecao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_selecao.AutoSize = true;
            this.lbl_selecao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_selecao.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selecao.Location = new System.Drawing.Point(294, 417);
            this.lbl_selecao.Name = "lbl_selecao";
            this.lbl_selecao.Size = new System.Drawing.Size(70, 18);
            this.lbl_selecao.TabIndex = 6;
            this.lbl_selecao.Text = "Seleção:";
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valor_total.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_total.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_total.Location = new System.Drawing.Point(66, 417);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(39, 18);
            this.lbl_valor_total.TabIndex = 7;
            this.lbl_valor_total.Text = "0,00";
            // 
            // lbl_valor_selecao
            // 
            this.lbl_valor_selecao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_valor_selecao.AutoSize = true;
            this.lbl_valor_selecao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valor_selecao.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_selecao.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valor_selecao.Location = new System.Drawing.Point(370, 417);
            this.lbl_valor_selecao.Name = "lbl_valor_selecao";
            this.lbl_valor_selecao.Size = new System.Drawing.Size(39, 18);
            this.lbl_valor_selecao.TabIndex = 8;
            this.lbl_valor_selecao.Text = "0,00";
            // 
            // ofd_arquivo
            // 
            this.ofd_arquivo.FileName = "openFileDialog1";
            // 
            // frm_sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_valor_selecao);
            this.Controls.Add(this.lbl_valor_total);
            this.Controls.Add(this.lbl_selecao);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.dgv_itens);
            this.Controls.Add(this.btn_baixar);
            this.Controls.Add(this.btn_marcar_todos);
            this.Controls.Add(this.btn_desmarcar_todos);
            this.Controls.Add(this.btn_importar_arquivo);
            this.Name = "frm_sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema: Download";
            this.Load += new System.EventHandler(this.frm_sistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_importar_arquivo;
        private System.Windows.Forms.Button btn_desmarcar_todos;
        private System.Windows.Forms.Button btn_marcar_todos;
        private System.Windows.Forms.Button btn_baixar;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_selecao;
        private System.Windows.Forms.Label lbl_valor_total;
        private System.Windows.Forms.Label lbl_valor_selecao;
        private System.Windows.Forms.OpenFileDialog ofd_arquivo;
    }
}

