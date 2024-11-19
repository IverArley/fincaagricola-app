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
    public partial class WFMaquinarias : System.Web.UI.Page
    {
        MaquinariasLog objMaq = new MaquinariasLog();
        ParcelasLog objPar = new ParcelasLog();

        private int _id, _parcId;
        private string _tipo, _estado;
        private DateTime _fechaAdquisicion;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showMaquinarias();
                showParcelaDDL();
            }
        }

        private void showMaquinarias()
        {
            DataSet ds = new DataSet();
            ds = objMaq.showMaquinarias();
            GVMaquinaria.DataSource = ds;
            GVMaquinaria.DataBind();
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
            HFMaquinariaId.Value = "";
            TBTipo.Text = "";
            TBEstado.Text = "";
            TBFechaAdquisicion.Text = "";
            DDLParcelas.SelectedIndex = 0;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TBFechaAdquisicion.Text, out _fechaAdquisicion))
            {
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);
                _tipo = TBTipo.Text;
                _estado = TBEstado.Text;
                bool executed = objMaq.saveMaquinaria(_tipo, _estado, _fechaAdquisicion, _parcId);

                if (executed)
                {
                    LblMsj.Text = "La maquinaria se guardó exitosamente!";
                    showMaquinarias();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al guardar.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una fecha de adquisición válida.";
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TBFechaAdquisicion.Text, out _fechaAdquisicion))
            {
                _id = Convert.ToInt32(HFMaquinariaId.Value);
                _tipo = TBTipo.Text;
                _estado = TBEstado.Text;
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);

                bool executed = objMaq.updateMaquinarias(_id, _tipo, _estado, _fechaAdquisicion, _parcId);

                if (executed)
                {
                    LblMsj.Text = "La maquinaria se actualizó exitosamente!";
                    showMaquinarias();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al actualizar.";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una fecha de adquisición válida.";
            }
        }

        protected void GVMaquinaria_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFMaquinariaId.Value = GVMaquinaria.SelectedRow.Cells[0].Text;
            TBTipo.Text = GVMaquinaria.SelectedRow.Cells[1].Text;
            TBEstado.Text = GVMaquinaria.SelectedRow.Cells[3].Text;
            string fechaSeleccionada = GVMaquinaria.SelectedRow.Cells[2].Text.Substring(0, 10);
            DateTime fechaConvertida = DateTime.Parse(fechaSeleccionada);
            TBFechaAdquisicion.Text = fechaConvertida.ToString("yyyy-MM-dd");
            DDLParcelas.SelectedValue = GVMaquinaria.SelectedRow.Cells[4].Text;
        }
    }
}
