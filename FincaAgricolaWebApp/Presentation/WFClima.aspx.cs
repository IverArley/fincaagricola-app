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
    public partial class WFClima : System.Web.UI.Page
    {
        ClimaLog objClim = new ClimaLog();
        ParcelasLog objPar = new ParcelasLog();

        private int _id, _parcId;
        private double _humedad, _temperatura;
        private DateTime _fecha;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showClima();
                showParcelaDDL();
            }
        }

        private void showClima()
        {
            DataSet ds = new DataSet();
            ds = objClim.showClima();
            GVClima.DataSource = ds;
            GVClima.DataBind();
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
            HFClimaId.Value = "";
            TBFecha.Text = "";
            TBHumedad.Text = "";
            TBTemperatura.Text = "";
            DDLParcelas.SelectedIndex = 0;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(TBFecha.Text, out _fecha))
            {
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);
                double.TryParse(TBHumedad.Text, out _humedad);
                double.TryParse(TBTemperatura.Text, out _temperatura);
                bool executed = objClim.saveClima(_fecha, _humedad, _temperatura, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El clima se guardó exitosamente!";
                    showClima();
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
                _id = Convert.ToInt32(HFClimaId.Value);
                double.TryParse(TBHumedad.Text, out _humedad);
                double.TryParse(TBTemperatura.Text, out _temperatura);
                _parcId = Convert.ToInt32(DDLParcelas.SelectedValue);

                bool executed = objClim.updateClima(_id, _fecha, _humedad, _temperatura, _parcId);

                if (executed)
                {
                    LblMsj.Text = "El clima se actualizo exitosamente!";
                    showClima();
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

        protected void GVClima_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFClimaId.Value = GVClima.SelectedRow.Cells[0].Text;
            DDLParcelas.SelectedValue = GVClima.SelectedRow.Cells[1].Text;
            string fechaSeleccionada = GVClima.SelectedRow.Cells[2].Text.Substring(0, 10);
            DateTime fechaConvertida = DateTime.Parse(fechaSeleccionada);
            TBFecha.Text = fechaConvertida.ToString("yyyy-MM-dd");

            TBHumedad.Text = GVClima.SelectedRow.Cells[3].Text;
            TBTemperatura.Text = GVClima.SelectedRow.Cells[4].Text;

        }
    }
}