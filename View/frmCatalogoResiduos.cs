using Controller;
using Model.Eco_Community;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmCatalogoResiduos : Form
    {
        public frmCatalogoResiduos()
        {
            InitializeComponent();
            ConfigureGrid();
            ListarCatalogo();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ConfigureGrid()
        {
            dgvCatalogo.AutoGenerateColumns = false;

            colIdCatalogo.DataPropertyName = "id_CatalogoResiduos";
            colResiduos.DataPropertyName = "tipoResiduo";
        }
        private void ListarCatalogo()
        {
            CatalogoResiduosController controller = new CatalogoResiduosController();
            dgvCatalogo.DataSource = controller.ListarCatalogo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCatalogo.Text))
                {
                    MessageBox.Show("Completa el nombre del tipo de residuo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CatalogoResiduosController controller = new CatalogoResiduosController();

                if (controller.ExisteCatalogo(txtCatalogo.Text))
                {
                    MessageBox.Show("Ese tipo de residuo ya existe, intenta de nuevo", "Verificacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CatalogoResiduosEntidad catalogo = new CatalogoResiduosEntidad()
                {
                    tipoResiduo = txtCatalogo.Text
                };

                controller.Insert(catalogo);
                MessageBox.Show("Registro agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarCatalogo();
                bntClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCatalogo.Text))
                {
                    MessageBox.Show("Selecciona un distrito primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCatalogo.Text))
                {
                    MessageBox.Show("Completa el nombre del tipo de residuo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idCatalogo = Convert.ToInt32(txtIdCatalogo.Text);

                CatalogoResiduosController controller = new CatalogoResiduosController();
                controller.Update(idCatalogo, txtCatalogo.Text);

                MessageBox.Show("Registro actualizado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarCatalogo();
                bntClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCatalogo.Text))
                {
                    MessageBox.Show("Selecciona un tipo de residuo primero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro que deseas eliminar el tipo de residuos del sistema?", "Verificación de información", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado != DialogResult.OK)
                    return;

                int idCatalogo = Convert.ToInt32(txtIdCatalogo.Text);

                CatalogoResiduosController controller = new CatalogoResiduosController();
                controller.Delete(idCatalogo);

                MessageBox.Show("Registro eliminado correctamente", "Confirmación de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarCatalogo();
                bntClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            txtIdCatalogo.Clear();
            txtCatalogo.Clear();
            dgvCatalogo.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogoResiduosController controller = new CatalogoResiduosController();
                if (string.IsNullOrWhiteSpace(txtIdCatalogo.Text))
                {

                    ListarCatalogo();
                    return;
                }

                if (!int.TryParse(txtIdCatalogo.Text, out int idCatalogo))
                {
                    MessageBox.Show("Ingresa un ID numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataTable resultado = controller.BuscarResiduoPorId(idCatalogo);

                if (resultado.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún tipo de residuo con ese ID.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvCatalogo.DataSource = resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCatalogoResiduos_Load(object sender, EventArgs e)
        {

        }

        private void dgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCatalogo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dgvCatalogo.Rows[e.RowIndex];

            if (fila.IsNewRow)
                return;

            txtIdCatalogo.Text =
                fila.Cells[colIdCatalogo.Index].Value?.ToString() ?? "";

            txtCatalogo.Text =
                fila.Cells[colResiduos.Index].Value?.ToString() ?? "";
        }
    }
}
