using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationExemploDataSet.Formularios
{
    public partial class FrmColaboradores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView_Colaboradores.DataSource = new Funcoes.Conexao().AbrirColaboradores("Select * from r034fun");
            GridView_Colaboradores.DataBind();
        }
    }
}