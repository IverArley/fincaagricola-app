using Logic;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFProducto : System.Web.UI.Page
    {
        ProductosLog objPro = new ProductosLog();
        ParcelasLog objPar = new ParcelasLog();

        private int _id, _parcId;
        private string _nombre, _descripcion;
        private decimal _precio;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showProductos();
                showParcelaDDL();
            }
        }

        private void showProductos()
        {
            DataSet ds = objPro.showProductos();
            GVProductos.DataSource = ds;
            GVProductos.DataBind();
        }

        private void showParcelaDDL()
        {
            DDLParcelas.DataSource = objPar.showParcelaDDL();
            DDLParcelas.DataValueField = "parc_id";
            DDLParcelas.DataTextField = "descripcion";
            DDLParcelas.DataBind();
            DDLParcelas.Items.Insert(0, "Seleccione");
        }


        private void clear()
        {
            HFProductoID.Value = "";
            TBNombre.Text = "";
            TBDescripcion.Text = "";
            TBPrecio.Text = "";
            DDLParcelas.SelectedIndex = 0;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _nombre = TBNombre.Text;
            _descripcion = TBDescripcion.Text;
            if (decimal.TryParse(TBPrecio.Text, out _precio) && int.TryParse(DDLParcelas.Text, out _parcId))
            {
                executed = objPro.saveProductos(_nombre, _descripcion, _precio, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El producto se guardó exitosamente!";
                    showProductos();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al guardar el producto.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese un precio y parcela válidos.";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(HFProductoID.Value);
            _nombre = TBNombre.Text;
            _descripcion = TBDescripcion.Text;
            if (decimal.TryParse(TBPrecio.Text, out _precio) && int.TryParse(DDLParcelas.SelectedValue, out _parcId))
            {
                executed = objPro.updateProductos(_id, _nombre, _descripcion, _precio, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El producto se actualizó exitosamente!";
                    showProductos();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al actualizar el producto.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese un precio y parcela válidos.";
            }
        }

        protected void GVProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GVProductos.SelectedRow;
            HFProductoID.Value = GVProductos.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVProductos.SelectedRow.Cells[1].Text;
            TBDescripcion.Text = GVProductos.SelectedRow.Cells[2].Text;
            TBPrecio.Text = GVProductos.SelectedRow.Cells[3].Text;
            DDLParcelas.SelectedValue = GVProductos.SelectedRow.Cells[4].Text;
        }
    }
}