using DesarrolloWeb1Clase13.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesarrolloWeb1Clase13.Web
{
    public partial class Ejemplo : System.Web.UI.Page
    {
        desarrolloEntities db = new desarrolloEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var resultado = db.estudiente.Where(x => x.nombre.Equals(TextBox1.Text)).ToList();
            GridView1.DataSource = resultado;
            GridView1.DataBind();
        }
    }
}