using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dobre_misli
{
    public partial class Default : System.Web.UI.Page
    {
        List<string> misli_list = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
          if (Application["misli"] == null) {
            Application["misli"] = misli_list;
          }
          if (Application["misli"] != null) {
            misli_list = (List<string>)Application["misli"];
            misli.Text = "";

            foreach (string misel in misli_list) {
              misli.Control.Add('"' + misel + '"<br>');
            }
          }


        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
          misli_list.Add(misel.Text);
          Application["misli"] = misli_list;
        }
    }

}
