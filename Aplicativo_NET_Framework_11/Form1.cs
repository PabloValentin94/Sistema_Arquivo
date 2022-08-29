using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Aplicativo_NET_Framework_11
{

    public partial class frm_sistema : Form
    {

        double total = 0;

        double selecao = 0;

        public frm_sistema()
        {

            InitializeComponent();

        }

        private void frm_sistema_Load(object sender, EventArgs e)
        {

            // Criando as colunas do DataGridView:

            dgv_itens.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgv_itens.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgv_itens.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgv_itens.Columns.Insert(3, new DataGridViewTextBoxColumn());

            // Definindo o nome das Colunas:

            dgv_itens.Columns[0].Name = "OK";
            dgv_itens.Columns[1].Name = "Codigo";
            dgv_itens.Columns[2].Name = "Descricao";
            dgv_itens.Columns[3].Name = "Valor";

            // Configurando o DataGridView:

            dgv_itens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgv_itens.ReadOnly = true;

            dgv_itens.AllowUserToAddRows = false;

            dgv_itens.AllowUserToDeleteRows = false;

            dgv_itens.AllowUserToOrderColumns = true;

            // Formatando a Coluna Valor:

            dgv_itens.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv_itens.Columns[3].DefaultCellStyle.Format = "###,###,##0.00";

        }

        private void btn_importar_arquivo_Click(object sender, EventArgs e)
        {

            dgv_itens.RowCount = 0;

            ofd_arquivo.FileName = "";
            ofd_arquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofd_arquivo.FileName);

            String linha;

            while((linha = arquivo.ReadLine()) != null)
            {

                string[] dados = linha.Split(';');

                string codigo = dados[0];

                string descricao = dados[1];

                double valor = double.Parse(dados[2]);

                dgv_itens.Rows.Add(false, codigo, descricao, valor);

                total += valor;

            }

            lbl_valor_total.Text = total.ToString("C");

        }

        private void dgv_itens_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dgv_itens.Rows.Count > 0 && e.ColumnIndex.Equals("0"))
            {

                if (Convert.ToBoolean(dgv_itens.CurrentRow.Cells[0].Value).Equals(false))
                {

                    dgv_itens.CurrentRow.Cells[0].Value = true;

                    selecao += Convert.ToDouble(dgv_itens.CurrentRow.Cells[3].Value);

                }

                else
                {

                    dgv_itens.CurrentRow.Cells[0].Value = false;

                    selecao -= Convert.ToDouble(dgv_itens.CurrentRow.Cells[3].Value);

                }

                lbl_valor_selecao.Text = selecao.ToString("C");

            }

        }

        private void btn_marcar_todos_Click(object sender, EventArgs e)
        {

            selecao = 0;

            foreach(DataGridViewRow linha in dgv_itens.Rows)
            {

                linha.Cells[0].Value = true;

                selecao += Convert.ToDouble(linha.Cells[3].Value);

            }

            lbl_valor_selecao.Text = selecao.ToString("C");

        }

        private void btn_desmarcar_todos_Click(object sender, EventArgs e)
        {

            selecao = 0;

            foreach (DataGridViewRow linha in dgv_itens.Rows)
            {

                linha.Cells[0].Value = false;

            }

            lbl_valor_selecao.Text = selecao.ToString("C");

        }

        private void btn_baixar_Click(object sender, EventArgs e)
        {

            for(int i =  dgv_itens.RowCount - 1; i >= 0; i--)
            {

                if (Convert.ToBoolean(dgv_itens.Rows[i].Cells[0].Value).Equals(true))
                {

                    selecao -= Convert.ToDouble(dgv_itens.Rows[i].Cells[3].Value);

                    total -= Convert.ToDouble(dgv_itens.Rows[i].Cells[3].Value);

                    dgv_itens.Rows.Remove(dgv_itens.Rows[i]);

                }

                lbl_valor_selecao.Text = selecao.ToString("C");
                lbl_valor_total.Text = total.ToString("C");

            }

        }

    }

}
