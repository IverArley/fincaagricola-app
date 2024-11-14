using Logic;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFVentas : System.Web.UI.Page
    {
        VentasLog objVen = new VentasLog();
        ClientesLog objClie = new ClientesLog();
        private int _id, _IdClie;
        private DateTime _fecha;
        private decimal _monto;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowVentas();
                showClientesDDL();
            }
        }

        private void ShowVentas()
        {
            DataSet ds = objVen.showVentas();
            GVVentas.DataSource = ds;
            GVVentas.DataBind();
        }

        private void showClientesDDL()
        {
            DDLCliente.DataSource = objClie.showClientesDDL();
            DDLCliente.DataValueField = "clie_id";
            DDLCliente.DataTextField = "clie_nombre";
            DDLCliente.DataBind();
            DDLCliente.Items.Insert(0, new ListItem("Seleccione", "0"));
        }

        private void Clear()
        {
            HFVentaID.Value = "";
            DDLCliente.SelectedIndex = 0;
            TBFecha.Text = "";
            TBMonto.Text = "";
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TBFecha.Text, out _fecha) &&
                int.TryParse(DDLCliente.SelectedValue, out _IdClie) &&
                decimal.TryParse(TBMonto.Text, out _monto))
            {
                bool executed = objVen.saveVentas(_IdClie, _fecha, _monto);

                if (executed)
                {
                    LblMsj.Text = "La venta se guardó exitosamente!";
                    ShowVentas();
                    Clear();
                }
                else
                {
                    LblMsj.Text = "Error al guardar la venta.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese datos válidos.";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(HFVentaID.Value, out _id) &&
                DateTime.TryParse(TBFecha.Text, out _fecha) &&
                int.TryParse(DDLCliente.SelectedValue, out _IdClie) &&
                decimal.TryParse(TBMonto.Text, out _monto))
            {
                bool executed = objVen.updateVentas(_id, _IdClie, _fecha, _monto);

                if (executed)
                {
                    LblMsj.Text = "La venta se actualizó exitosamente!";
                    ShowVentas();
                    Clear();
                }
                else
                {
                    LblMsj.Text = "Error al actualizar la venta.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese datos válidos.";
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(HFVentaID.Value, out _id))
            {
                bool executed = objVen.deleteVentas(_id);

                if (executed)
                {
                    LblMsj.Text = "La venta se eliminó exitosamente!";
                    ShowVentas();
                    Clear();
                }
                else
                {
                    LblMsj.Text = "Error al eliminar la venta.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, seleccione una venta.";
            }
        }

        protected void GVVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene la fila seleccionada
            GridViewRow row = GVVentas.SelectedRow;

            // Asigna los valores de la fila a los campos correspondientes
            HFVentaID.Value = row.Cells[0].Text;
            DDLCliente.SelectedValue = row.Cells[1].Text;
            TBFecha.Text = row.Cells[2].Text;
            TBMonto.Text = row.Cells[3].Text;
        }

    }
}
