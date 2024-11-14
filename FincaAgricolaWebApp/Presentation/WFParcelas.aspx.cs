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
    public partial class WFParcelas : System.Web.UI.Page
    {
        ParcelasLog objPar = new ParcelasLog();
        FincaLog objFin = new FincaLog();

        private int _id, _finId;
        private string _tamano;
        private string _ubicacion;
        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                showParcela();
                showFincaDDL();
            }

        }

        private void showParcela()
        {
            DataSet ds = objPar.showParcela();
            GVParcelas.DataSource = ds;
            GVParcelas.DataBind();
        }

        private void showFincaDDL()
        {
            DDLFinca.DataSource = objFin.showFincaDDL();
            DDLFinca.DataValueField = "finc_id";
            DDLFinca.DataTextField = "finc_nombre";
            DDLFinca.DataBind();
            DDLFinca.Items.Insert(0, "Seleccione");
        }

        private void clear()
        {
            HFParcelasID.Value = "";
            TBTamano.Text = "";
            TBUbicacion.Text = "";
            DDLFinca.SelectedIndex = 0;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _tamano = TBTamano.Text;
            _ubicacion = TBUbicacion.Text;
            _finId = Convert.ToInt32(DDLFinca.SelectedValue);

            executed = objPar.saveParcela( _tamano,  _ubicacion, _finId);
            if (executed)
            {
                LblMsj.Text = "El producto se guardo exitosamente";
                clear();//Se invoca el metodo para limpiar los TextBox Y DDL
                showParcela();//se invoca el metodo para guardar los productos
            }
            else
            {
                LblMsj.Text = "Error al guardar";
            }
        }



        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(HFParcelasID.Value);
            _tamano = TBTamano.Text;
            _ubicacion = TBUbicacion.Text;
            _finId = Convert.ToInt32(DDLFinca.SelectedValue);

            executed = objPar.updateParcela(_id, _tamano, _ubicacion, _finId);
            if (executed)
            {
                LblMsj.Text = "El producto se actualizo exitosamente";
                clear();//Se invoca el metodo para limpiar los TextBox Y DDL
                showParcela();//se invoca el metodo para guardar los productos
            }
            else
            {
                LblMsj.Text = "Error al guardar";
            }
        }

        protected void GVParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFParcelasID.Value = GVParcelas.SelectedRow.Cells[0].Text;
            TBTamano.Text = GVParcelas.SelectedRow.Cells[1].Text;
            TBUbicacion.Text = GVParcelas.SelectedRow.Cells[2].Text;
            DDLFinca.SelectedValue = GVParcelas.SelectedRow.Cells[3].Text;
            
        }
    }
}