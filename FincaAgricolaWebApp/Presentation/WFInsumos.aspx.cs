using Logic;
using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFInsumos : System.Web.UI.Page
    {
        InsumosLog objInsumos = new InsumosLog();
        ProveedoresLog objProveedores = new ProveedoresLog();
        ParcelasLog objParcelas = new ParcelasLog(); // Aquí se agrega el objeto para manejar las parcelas.

        private int _id, _proId, _parcId; // Se agrega el _parcId para las parcelas.
        private string _nombre;
        private decimal _cantidad;
        private DateTime _fechaAdquisicion;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showInsumos();
                showProvedoresDDL();
                showParcelaDDL(); // Se llama el método para cargar las parcelas en el dropdown.
            }
        }

        private void showInsumos()
        {
            DataSet ds = new DataSet();
            ds = objInsumos.showInsumo();
            GVInsumos.DataSource = ds;
            GVInsumos.DataBind();
        }

        private void showProvedoresDDL()
        {
            DDLProveedores.DataSource = objProveedores.showProvedoresDDL();
            DDLProveedores.DataValueField = "prov_id";
            DDLProveedores.DataTextField = "prov_nombre";
            DDLProveedores.DataBind();
            DDLProveedores.Items.Insert(0, "Seleccione");
        }

        private void showParcelaDDL()
        {
            DDLParcelas.DataSource = objParcelas.showParcelaDDL(); // Método que obtiene las parcelas.
            DDLParcelas.DataValueField = "parc_id";
            DDLParcelas.DataTextField = "descripcion";
            DDLParcelas.DataBind();
            DDLParcelas.Items.Insert(0, "Seleccione");
        }

        private void clear()
        {
            HFInsumoId.Value = "";
            TBNombre.Text = "";
            TBCantidad.Text = "";
            TBFechaAdquisicion.Text = "";
            DDLProveedores.SelectedIndex = 0;
            DDLParcelas.SelectedIndex = 0; // Limpiar el DDL de parcelas
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TBCantidad.Text, out _cantidad) && DateTime.TryParse(TBFechaAdquisicion.Text, out _fechaAdquisicion))
            {
                _proId = Convert.ToInt32(DDLProveedores.SelectedValue);
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue); // Obtener el ID de la parcela seleccionada
                _nombre = TBNombre.Text;
                bool executed = objInsumos.saveInsumo(_nombre, _cantidad, _fechaAdquisicion, _proId, _parcId); // Agregar _parcId al método

                if (executed)
                {
                    LblMsj.Text = "El insumo se guardó exitosamente!";
                    showInsumos();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al guardar";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una cantidad y fecha válidas.";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TBCantidad.Text, out _cantidad) && DateTime.TryParse(TBFechaAdquisicion.Text, out _fechaAdquisicion))
            {
                _id = Convert.ToInt32(HFInsumoId.Value);
                _nombre = TBNombre.Text;
                _proId = Convert.ToInt32(DDLProveedores.SelectedValue);
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue); // Obtener el ID de la parcela seleccionada

                bool executed = objInsumos.updateInsumo(_id, _nombre, _cantidad, _fechaAdquisicion, _proId, _parcId); // Agregar _parcId al método

                if (executed)
                {
                    LblMsj.Text = "El insumo se actualizó exitosamente!";
                    showInsumos();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al actualizar";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una cantidad y fecha válidas.";
            }
        }

        protected void GVInsumos_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFInsumoId.Value = GVInsumos.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVInsumos.SelectedRow.Cells[1].Text;
            TBCantidad.Text = GVInsumos.SelectedRow.Cells[2].Text;
            TBFechaAdquisicion.Text = GVInsumos.SelectedRow.Cells[3].Text;
            DDLProveedores.SelectedValue = GVInsumos.SelectedRow.Cells[4].Text;
            DDLParcelas.SelectedValue = GVInsumos.SelectedRow.Cells[5].Text; // Seleccionar la parcela en el GridView
        }
    }
}

