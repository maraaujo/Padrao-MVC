using ProvaA1.BLL;
using ProvaA1.DTO;
using System;

using System.Windows.Forms;

namespace ProvaA1
{
    public partial class Form1 : Form
    {
        private BicicletaBLL bicicletaBLL;
        private TextBox txtNome;
        private TextBox txtTipo;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridViewBicicletas;
        
        public Form1()
        {
            bicicletaBLL = new BicicletaBLL();
            InitializComponent();
            LoadBicicletas();
        }
        private void InitializComponent()
        {
            this.txtNome = new TextBox();
            this.txtTipo = new TextBox();
            this.btnAdd = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.dataGridViewBicicletas = new DataGridView();

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;

            // txtTipo
            this.txtTipo.Location = new System.Drawing.Point(12, 38);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 1;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(12, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(93, 64);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(174, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // dataGridViewBicicletas
            this.dataGridViewBicicletas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBicicletas.Location = new System.Drawing.Point(12, 93);
            this.dataGridViewBicicletas.Name = "dataGridViewBicicletas";
            this.dataGridViewBicicletas.Size = new System.Drawing.Size(760, 355);
            this.dataGridViewBicicletas.TabIndex = 5;

            // MainForm
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewBicicletas);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNome);
            this.Name = "MainForm";
            this.Text = "Gerenciador de Bicicletas";
        }
        private void LoadBicicletas()
        {
            var bicicletas = bicicletaBLL.Read();
            dataGridViewBicicletas.DataSource = bicicletas;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bicicleta bicicleta = new Bicicleta
            {
                BicNome = txtNome.Text,
                BicTipo = txtTipo.Text
            };
            bicicletaBLL.Create(bicicleta);
            LoadBicicletas();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewBicicletas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewBicicletas.SelectedRows[0].Cells["BicID"].Value);
                Bicicleta bicicleta = new Bicicleta
                {
                    BicID = id,
                    BicNome = txtNome.Text,
                    BicTipo = txtTipo.Text
                };
                bicicletaBLL.Update(bicicleta);
                LoadBicicletas();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBicicletas.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewBicicletas.SelectedRows[0].Cells["BicID"].Value);
                bicicletaBLL.Delete(id);
                LoadBicicletas();
            }
        }

        private void dataGridViewBicicletas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewBicicletas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

