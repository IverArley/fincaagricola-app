using Logic;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFClientes : System.Web.UI.Page
    {
        ClientesLog objClie = new ClientesLog();

        private int _id;
        private string _nombre, _telefono, _direccion;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showClientes();
            }

        }

        private void showClientes()
        {
            DataSet ds = new DataSet();
            ds = objClie.showClientes();
            GVClientes.DataSource = ds;
            GVClientes.DataBind();
        }

        private void clear()
        {
            HFClienteId.Value = "";
            TBNombre.Text = "";
            TBTelefono.Text = "";
            TBDireccion.Text = "";
        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _nombre = TBNombre.Text;
            _telefono = TBTelefono.Text;
            _direccion = TBDireccion.Text;

            executed = objClie.saveClientes(_nombre, _telefono, _direccion);

            if (executed)
            {
                LblMsj.Text = "El cliente se guardo exitosamente!";
                showClientes();
                clear();
            }
            else
            {
                LblMsj.Text = "Error al guardar";
            }
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(HFClienteId.Value);
            _nombre = TBNombre.Text;
            _telefono = TBTelefono.Text;
            _direccion = TBDireccion.Text;

            executed = objClie.updateClientes(_id, _nombre, _telefono, _direccion);

            if (executed)
            {
                LblMsj.Text = "El cliente se actualizo exitosamente!";
                showClientes();
            }
            else
            {
                LblMsj.Text = "Error al guardar";
            }
        }
        protected void GVClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFClienteId.Value = GVClientes.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVClientes.SelectedRow.Cells[1].Text;
            TBTelefono.Text = GVClientes.SelectedRow.Cells[2].Text;
            TBDireccion.Text = GVClientes.SelectedRow.Cells[3].Text;
        }
    }
}