using Logic;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFFinca : System.Web.UI.Page
    {
        FincaLog objFinca = new FincaLog();

        private int _id;
        private string _nombre;
        private string _ubicacion;
        private string _tamano;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showFinca();
            }
        }

        private void showFinca()
        {
            DataSet ds = objFinca.showFinca();
            GVFinca.DataSource = ds;
            GVFinca.DataBind();
        }

        private void clear()
        {
            HFClienteId.Value = "";
            TBNombre.Text = "";
            TBUbicacion.Text = "";
            TBTamano.Text = "";
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _nombre = TBNombre.Text;
            _ubicacion = TBUbicacion.Text;
            _tamano = TBTamano.Text;

            executed = objFinca.saveFinca(_nombre, _ubicacion, _tamano);

            if (executed)
            {
                LblMsj.Text = "La finca se guardó exitosamente!";
                showFinca();
                clear();
            }
            else
            {
                LblMsj.Text = "Error al guardar la finca.";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(HFClienteId.Value);
            _nombre = TBNombre.Text;
            _ubicacion = TBUbicacion.Text;
            _tamano = TBTamano.Text;

            executed = objFinca.updateFinca(_id, _nombre, _ubicacion, _tamano);

            if (executed)
            {
                LblMsj.Text = "La finca se actualizó exitosamente!";
                showFinca();
                clear();
            }
            else
            {
                LblMsj.Text = "Error al actualizar la finca.";
            }
        }

        protected void GVFinca_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFClienteId.Value = GVFinca.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVFinca.SelectedRow.Cells[1].Text;
            TBUbicacion.Text = GVFinca.SelectedRow.Cells[2].Text;
            TBTamano.Text = GVFinca.SelectedRow.Cells[3].Text;
        }
    }
}