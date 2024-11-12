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
    public partial class WFProveedores : System.Web.UI.Page
    {
        // Instancia de la clase de lógica de negocio para Proveedores
        ProveedoresLog objPro = new ProveedoresLog();

        // Variables para los campos del proveedor
        private int _id;
        private string _nombre, _producto, _telefono;
        private bool execute = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica si la página se está cargando por primera vez o es una devolución de datos
            if (!Page.IsPostBack)
            {
                showProveedor(); // Mostrar todos los proveedores en el GridView
            }
        }
        private void showProveedor()
        {
            DataSet ds = new DataSet();
            ds = objPro.showProveedor();
            GVProveedor.DataSource = ds;
            GVProveedor.DataBind();
        }


        // Método para limpiar todos los TextBox
        private void clear()
        {
            HFProveedorId.Value = "";
            TBNombre.Text = "";
            TBProducto.Text = "";
            TBTelefono.Text = "";
            

        }


        // Evento del botón Guardar proveedor
        protected void BtnSave_Click1(object sender, EventArgs e)
        {
            // Captura los valores de los campos de entrada
            _nombre = TBNombre.Text;
            _producto = TBProducto.Text;
            _telefono = TBTelefono.Text;

            // Llama a la lógica de negocio para guardar el proveedor
            execute = objPro.saveProveedor(_nombre, _producto, _telefono);
            if (execute)
            {
                LblMsj.Text = "El proveedor se guardó exitosamente";
                clear();       // Limpia los campos de entrada
                showProveedor(); // Actualiza la tabla de proveedores
            }
            else
            {
                LblMsj.Text = "Error al guardar el proveedor";
            }

        }

        // Evento del botón Actualizar proveedor
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Captura los valores de los campos de entrada
            _id = Convert.ToInt32(HFProveedorId.Value);
            _nombre = TBNombre.Text;
            _producto = TBProducto.Text;
            _telefono = TBTelefono.Text;

            // Llama a la lógica de negocio para actualizar el proveedor
            execute = objPro.updateProveedor(_id, _nombre, _producto, _telefono);
            if (execute)
            {
                LblMsj.Text = "El proveedor se actualizó exitosamente";
                clear();       // Limpia los campos de entrada
                showProveedor(); // Actualiza la tabla de proveedores
            }
            else
            {
                LblMsj.Text = "Error al actualizar el proveedor";
            }
        }

        //// Evento para seleccionar una fila en el GridView
        protected void GVProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFProveedorId.Value = GVProveedor.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVProveedor.SelectedRow.Cells[1].Text;
            TBProducto.Text = GVProveedor.SelectedRow.Cells[2].Text;
            TBTelefono.Text = GVProveedor.SelectedRow.Cells[3].Text;
        }
    }
}

