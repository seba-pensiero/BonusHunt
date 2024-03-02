using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace BonusHunt
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BonusNegocio negocio = new BonusNegocio();
            Session.Add("listaBonus", negocio.listar());
            dgvBonus.DataSource = Session["listaBonus"];
            dgvBonus.DataBind();
        }

        protected void dgvBonus_SelectedIndexChanged(object sender, EventArgs e)
        {
            BonusNegocio negocio = new BonusNegocio();
            Bonus aux = new Bonus();
            string id = dgvBonus.SelectedDataKey.Value.ToString();
            //Response.Redirect("NuevoBonus.aspx?id=" + id);
            aux.Id = int.Parse(id);
            negocio.activarBonus(aux);

        }

        protected void dgvBonus_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvBonus.PageIndex = e.NewPageIndex;
            dgvBonus.DataBind();
        }
    }
}