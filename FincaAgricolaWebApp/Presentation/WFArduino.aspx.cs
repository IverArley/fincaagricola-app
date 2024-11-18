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
    public partial class WFArduino : System.Web.UI.Page
    {
        // Instancia de la clase de lógica de negocio para Control de Riego
        ArduinoLog objArd = new ArduinoLog();

        // Variables para los campos del control de riego
        private int _id;
        private decimal _humedad, _cantidadAgua;
        private string _clima;


        private bool execute = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verifica si la página se está cargando por primera vez o es una devolución de datos
            if (!Page.IsPostBack)
            {
                showControlRiego(); // Mostrar todos los registros de control de riego en el GridView
            }
        }

        private void showControlRiego()
        {
            DataSet ds = new DataSet();
            ds = objArd.showControlRiego();  // Llamar a la lógica para obtener los datos
            GVControlRiego.DataSource = ds;  // Asigna los datos al GridView
            GVControlRiego.DataBind();  // Actualiza el GridView
        }

        // Método para limpiar todos los TextBox
        private void clear()
        {
            HFControlRiegoId.Value = "";  // Limpia el valor del HiddenField (ID)
            TBHumedad.Text = "";  // Limpia el TextBox de humedad
            TBClima.Text = "";  // Limpia el TextBox de clima
            TBCantidadAgua.Text = "";  // Limpia el TextBox de cantidad de agua
        }

        // Evento del botón Guardar control de riego
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            // Captura los valores de los campos de entrada
            _humedad = decimal.Parse(TBHumedad.Text);
            _clima = TBClima.Text;
            _cantidadAgua = decimal.Parse(TBCantidadAgua.Text);

            // Llama a la lógica de negocio para guardar el control de riego
            execute = objArd.saveControlRiego(_humedad, _clima, _cantidadAgua);
            if (execute)
            {
                LblMsj.Text = "El control de riego se guardó exitosamente";
                clear();  // Limpia los campos de entrada
                showControlRiego();  // Actualiza la tabla de controles de riego
            }
            else
            {
                LblMsj.Text = "Error al guardar el control de riego";
            }
        }

        // Evento del botón Actualizar control de riego
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Captura los valores de los campos de entrada
            _id = Convert.ToInt32(HFControlRiegoId.Value);
            _humedad = decimal.Parse(TBHumedad.Text);
            _clima = TBClima.Text;
            _cantidadAgua = decimal.Parse(TBCantidadAgua.Text);

            // Llama a la lógica de negocio para actualizar el control de riego
            execute = objArd.updateControlRiego(_id, _humedad, _clima, _cantidadAgua);
            if (execute)
            {
                LblMsj.Text = "El control de riego se actualizó exitosamente";
                clear();  // Limpia los campos de entrada
                showControlRiego();  // Actualiza la tabla de controles de riego
            }
            else
            {
                LblMsj.Text = "Error al actualizar el control de riego";
            }
        }

        // Evento para seleccionar una fila en el GridView
        protected void GVControlRiego_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Captura el ID y los valores de la fila seleccionada en el GridView
            HFControlRiegoId.Value = GVControlRiego.SelectedRow.Cells[0].Text;
            TBHumedad.Text = GVControlRiego.SelectedRow.Cells[1].Text;
            TBClima.Text = GVControlRiego.SelectedRow.Cells[2].Text;
            TBCantidadAgua.Text = GVControlRiego.SelectedRow.Cells[3].Text;
        }
    }
}
