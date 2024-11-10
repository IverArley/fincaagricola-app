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
    public partial class WFRiego : System.Web.UI.Page
    {

        RiegoLog objRie = new RiegoLog();
        ParcelasLog objPar = new ParcelasLog();

        private int _id, _parcId;
        private DateTime _fecha;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showRiego();
                showParcelaDDL();
            }
        }

        private void showRiego()
        {
            DataSet ds = new DataSet();
            ds = objRie.showRiego();
            GVRiego.DataSource = ds;
            GVRiego.DataBind();
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
            HFRiegoId.Value = "";
            TBFecha.Text = "";
            DDLParcelas.SelectedIndex = 0;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TBFecha.Text, out _fecha))
            {
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);
                bool executed = objRie.saveRiego(_fecha, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El riego se guardó exitosamente!";
                    showRiego();
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
                _id = Convert.ToInt32(HFRiegoId.Value);
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);
                bool executed = objRie.updateRiego(_id, _fecha, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El riego se guardó exitosamente!";
                    showRiego();
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
        protected void GVRiego_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFRiegoId.Value = GVRiego.SelectedRow.Cells[0].Text;
            DDLParcelas.SelectedValue = GVRiego.SelectedRow.Cells[1].Text;
            TBFecha.Text = GVRiego.SelectedRow.Cells[2].Text;
        }
    }
}