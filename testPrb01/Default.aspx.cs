using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using testPrb01.Controller;
using testPrb01.Models;

namespace testPrb01
{
    public partial class Default : System.Web.UI.Page
    {
        clientesController controller = new clientesController();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes()
            {
                nombre = TextBox1.Text,
                paterno = TextBox2.Text,
                materno = TextBox3.Text,
                sexo = TextBox4.Text,
                estado = TextBox5.Text,
            };
            int result = controller.saveClient(cl);
            if (result>0)
            {
                myMsn.Text = "cliente guardado";
            }
            else
            {
                myMsn.Text = "error";
            }
            data();
        }
    }
}
