using Presentacion.IPresentadores;
using Presentacion.IVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vistas
{
    public partial class VistaSeleccionLMSC : Form
    {
        private IPresentadorCreacionOP _presentador;
        private int _seleccionindex = -1;
        public VistaSeleccionLMSC(string titulo, IPresentadorCreacionOP presentador)
        {
            InitializeComponent();
            tituloLB.Text = $"Selección de {titulo}";
            _presentador = presentador;
            listadoDG.Rows.Clear();
        }

        
        public void CargarFilaListado(int id, string descripcion)
        {
            listadoDG.Rows.Add(id,descripcion);
        }


        private void confirmarSeleccionBTN_Click(object sender, EventArgs e)
        {
            if(_seleccionindex >= 0)
            {
                _presentador.EstablecerSeleccion(int.Parse(listadoDG.Rows[_seleccionindex].Cells[0].Value.ToString()));
            }
            this.Dispose();
        }

        private void cancelarBTN_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void listadoDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_seleccionindex != e.RowIndex)
            {
                _seleccionindex = e.RowIndex;
            }
        }
    }
}
