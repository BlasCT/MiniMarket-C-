using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        #region "MIS MÉTODOS"
        

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            //MOSTRAR LISTA DE LA CATEGORIA EN EL GRID
            List<Categoria> categoria = new CN_Categoria().listar();

            foreach (Categoria item in categoria)
            {
                dgvData.Rows.Add(new object[]
                {
                    item.codigo_ca,
                    item.descripcion_ca,
                    item.estado
                });
            }
        }
        #endregion
    }
}
