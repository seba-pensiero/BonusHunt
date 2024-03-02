using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusHunt
{
    public partial class Opening : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BonusNegocio negocio = new BonusNegocio();
            Session.Add("listaOpening", negocio.listarActivos());
            dgvBonusOpening.DataSource = Session["listaOpening"];
            dgvBonusOpening.DataBind();

        }

        protected void dgvBonusOpening_SelectedIndexChanged(object sender, EventArgs e)
        {
            BonusNegocio negocio = new BonusNegocio();
            Bonus aux = new Bonus();
            float win = float.Parse(txtWin.Text);
            float bet = float.Parse(txtBet.Text);
            string id = dgvBonusOpening.SelectedDataKey.Value.ToString();
            aux.Id = int.Parse(id);
            negocio.modificar(aux, bet, win);
            Response.Redirect("Opening.aspx");
        }
    }
}