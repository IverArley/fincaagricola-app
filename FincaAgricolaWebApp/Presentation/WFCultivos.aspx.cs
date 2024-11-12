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
    public partial class WFCultivos : System.Web.UI.Page
    {
        CultivosLog objCult = new CultivosLog();
        ParcelasLog objPar = new ParcelasLog();

        private int _id, _parcId;
        private string _nombre, _estado;
        private DateTime _fecha;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showCultivo();
                showParcelaDDL();
            }
        }

        private void showCultivo()
        {
            DataSet ds = new DataSet();
            ds = objCult.showCultivo();
            GVCultivo.DataSource = ds;
            GVCultivo.DataBind();
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
            HFCultivoId.Value = "";
            TBNombre.Text = "";
            TBFecha.Text = "";
            TBEstado.Text = "";
            DDLParcelas.SelectedIndex = 0;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TBFecha.Text, out _fecha))
            {
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);
                _nombre = TBNombre.Text;
                _estado = TBEstado.Text;
                bool executed = objCult.saveCultivo(_nombre, _fecha, _estado, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El Cultivo se guardó exitosamente!";
                    showCultivo();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al guardar";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una fecha válida.";
            }
        }


        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TBFecha.Text, out _fecha))
            {
                _id = Convert.ToInt32(HFCultivoId.Value);
                _nombre = TBNombre.Text;
                _estado = TBEstado.Text;  
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);

                bool executed = objCult.updateCultivo(_id, _nombre, _fecha, _estado, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El cultivo se actualizo exitosamente!";
                    showCultivo();
                    clear();
                }
                else
                {
                    LblMsj.Text = "Error al guardar";
                }
            }
            else
            {
                LblMsj.Text = "Por favor, ingrese una fecha válida.";
            }
        }

        protected void GVCultivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFCultivoId.Value = GVCultivo.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVCultivo.SelectedRow.Cells[1].Text;
            TBFecha.Text = GVCultivo.SelectedRow.Cells[2].Text;
            TBEstado.Text = GVCultivo.SelectedRow.Cells[3].Text;
            DDLParcelas.SelectedValue = GVCultivo.SelectedRow.Cells[4].Text;
        }
    }
}