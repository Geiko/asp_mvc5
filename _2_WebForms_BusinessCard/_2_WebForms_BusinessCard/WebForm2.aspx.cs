using _2_WebForms_BusinessCard.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_WebForms_BusinessCard
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        CompanyContext db;
        

        protected void Page_Load ( object sender, EventArgs e )
        {
            db = new CompanyContext ( );

            foreach ( var employee in db.Employees )
            {
                Output2.Text += employee.GenerateHtml();
            }
        }
    }
}