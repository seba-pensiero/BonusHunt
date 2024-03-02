using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace BonusHunt
{
    public partial class NuevoBonus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Bonus nuevo = new Bonus();
            BonusNegocio negocio = new BonusNegocio();

            nuevo.Nombre = txtAgregarBonus.Text;

            negocio.Agregar(nuevo);
        }
    }
}
