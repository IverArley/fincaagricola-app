using Logic;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFEmpleados : System.Web.UI.Page
    {
        EmpleadosLog objEmpl = new EmpleadosLog();
        ParcelasLog objPar = new ParcelasLog(); // Referencia para las parcelas

        private int _id, _parcId;
        private string _nombre, _rol;
        private DateTime _fecha;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showEmpleados();
                showParcelaDDL(); // Mostrar las parcelas en el dropdown list (DDL)
            }
        }

        // Método para cargar los empleados en el GridView
        private void showEmpleados()
        {
            DataSet ds = new DataSet();
            ds = objEmpl.showEmpleados(); // Obtiene los datos de empleados
            GVEmpleados.DataSource = ds;
            GVEmpleados.DataBind();
        }

        // Método para cargar las parcelas en el DropDownList
        private void showParcelaDDL()
        {
            DDLParcelas.DataSource = objPar.showParcelaDDL();
            DDLParcelas.DataValueField = "parc_id";
            DDLParcelas.DataTextField = "descripcion";
            DDLParcelas.DataBind();
            DDLParcelas.Items.Insert(0, "Seleccione");
        }

        // Limpiar los controles de entrada después de una acción
        private void clear()
        {
            HFEmpleadoId.Value = "";
            TBNombre.Text = "";
            TBDescripcion.Text = "";
            TBFecha.Text = "";
            DDLParcelas.SelectedIndex = 0;
        }

        // Evento para guardar un nuevo empleado
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TBFecha.Text, out _fecha))
            {
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);
                _nombre = TBNombre.Text;
                _rol = TBDescripcion.Text;

                // Llamar al método para guardar el empleado
                bool executed = objEmpl.saveEmpleado(_nombre, _rol, _fecha, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El empleado se guardó exitosamente!";
                    showEmpleados(); // Recargar los empleados
                    clear(); // Limpiar los campos
                }
                else
                {
                    LblMsj.Text = "Error al guardar el empleado.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una fecha válida.";
            }
        }

        // Evento para actualizar un empleado existente
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TBFecha.Text, out _fecha))
            {
                _id = Convert.ToInt32(HFEmpleadoId.Value);
                _nombre = TBNombre.Text;
                _rol = TBDescripcion.Text;
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);

                bool executed = objEmpl.updateEmpleado(_id, _nombre, _rol, _fecha, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El empleado se actualizó exitosamente!";
                    showEmpleados(); // Recargar los empleados
                    clear(); // Limpiar los campos
                }
                else
                {
                    LblMsj.Text = "Error al actualizar el empleado.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una fecha válida.";
            }
        }

        // Evento para seleccionar un empleado y cargar sus datos en los campos
        protected void GVEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFEmpleadoId.Value = GVEmpleados.SelectedRow.Cells[0].Text; // ID del empleado seleccionado
            TBNombre.Text = GVEmpleados.SelectedRow.Cells[1].Text; // Nombre
            TBDescripcion.Text = GVEmpleados.SelectedRow.Cells[2].Text; // Cargo
            TBFecha.Text = GVEmpleados.SelectedRow.Cells[3].Text; // Fecha de contratación
            DDLParcelas.SelectedValue = GVEmpleados.SelectedRow.Cells[4].Text; // Parcela
        }

        // Evento para eliminar un empleado desde el GridView
        protected void GVEmpleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                // Obtener el ID del empleado a eliminar
                int empleadoId = Convert.ToInt32(e.CommandArgument);

                bool success = objEmpl.deleteEmpleado(empleadoId);

                if (success)
                {
                    LblMsj.Text = "Empleado eliminado exitosamente!";
                    showEmpleados(); // Recargar los empleados
                }
                else
                {
                    LblMsj.Text = "Error al eliminar el empleado.";
                }
            }
        }
    }
}
