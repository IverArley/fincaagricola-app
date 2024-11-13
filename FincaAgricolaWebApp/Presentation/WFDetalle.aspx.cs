using Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFDetalle : System.Web.UI.Page
    {
        DetalleLog objDetalle = new DetalleLog(); // Cambié de DetalleVentasLog a DetalleLog
        ProductosLog objProductos = new ProductosLog();
        VentasLog objVentas = new VentasLog();

        private int _prodId, _venId, _cantidad;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showDetalle_Ventas();
                showProductosDDL();
                showVentasDDL();
            }
        }

        // Mostrar todos los detalles de ventas
        private void showDetalle_Ventas()
        {
            DataSet ds = objDetalle.showDetalle_Ventas();
            GVDetalleVentas.DataSource = ds;
            GVDetalleVentas.DataBind();
        }

        // Mostrar los productos en el Dropdown (DDL)
        private void showProductosDDL()
        {
            DDLProductos.DataSource = objProductos.showProductosDDL();
            DDLProductos.DataValueField = "prod_id";
            DDLProductos.DataTextField = "prod_nombre";
            DDLProductos.DataBind();
            DDLProductos.Items.Insert(0, new ListItem("Seleccione", "0"));
        }

        // Mostrar las ventas en el Dropdown (DDL)
        private void showVentasDDL()
        {
            DDLVentas.DataSource = objVentas.showVentassDDL();
            DDLVentas.DataValueField = "vent_id";
            DDLVentas.DataTextField = "vent_monto";
            DDLVentas.DataBind();
            DDLVentas.Items.Insert(0, new ListItem("Seleccione", "0"));
        }

        // Limpiar los campos del formulario
        private void clear()
        {
            TBCantidad.Text = "";
            DDLProductos.SelectedIndex = 0;
            DDLVentas.SelectedIndex = 0;
        }

        // Guardar el detalle de venta
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TBCantidad.Text, out _cantidad))
            {
                _prodId = Convert.ToInt32(DDLProductos.SelectedValue);
                _venId = Convert.ToInt32(DDLVentas.SelectedValue);

                bool executed = objDetalle.saveDetalle_Venta(_venId, _prodId, _cantidad);

                if (executed)
                {
                    LblMsj.Text = "El detalle de la venta se guardó exitosamente!";
                    showDetalle_Ventas();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al guardar el detalle de venta.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una cantidad válida.";
            }
        }

        // Actualizar el detalle de venta
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TBCantidad.Text, out _cantidad))
            {
                _prodId = Convert.ToInt32(DDLProductos.SelectedValue);
                _venId = Convert.ToInt32(DDLVentas.SelectedValue);

                bool executed = objDetalle.updateDetalle_Venta(_venId, _prodId, _cantidad);

                if (executed)
                {
                    LblMsj.Text = "El detalle de la venta se actualizó exitosamente!";
                    showDetalle_Ventas();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al actualizar el detalle de venta.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una cantidad válida.";
            }
        }

        // Cuando se selecciona un detalle de venta en la grid
        protected void GVDetalleVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GVDetalleVentas.SelectedRow;
            DDLVentas.SelectedValue = row.Cells[0].Text;
            DDLProductos.SelectedValue = row.Cells[1].Text;
            TBCantidad.Text = row.Cells[2].Text;
           
        }
    }
}
