using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CIA2011Judet
{
    public partial class logare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView();
            dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            try
            {
                Session.Add("utilizator", dv.Table.Rows[0].ItemArray[0].ToString());
                Session.Add("parola", dv.Table.Rows[0].ItemArray[1].ToString());
                Session.Add("tip", dv.Table.Rows[0].ItemArray[2].ToString());
                if (dv.Table.Rows[0].ItemArray[2].ToString() == "admin")
                    Response.Redirect("admin.aspx");
                else
                {
                    SqlDataSource2.Insert();
                    Response.Redirect("user.aspx");
                }

                    
            }
            catch {
                Label1.Text = "Logare nereusita";
            }


                
            

        }

        protected void Label2_Load(object sender, EventArgs e)
        {
            Label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}