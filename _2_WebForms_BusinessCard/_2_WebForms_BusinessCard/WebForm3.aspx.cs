using _2_WebForms_BusinessCard.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_WebForms_BusinessCard
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        CompanyContext db;



        protected void Page_Load ( object sender, EventArgs e )
        {
            db = new CompanyContext ( );

            string fileName = Server.MapPath ( @"App_Data\TextFile1.txt" );
            Output3.Text = File.ReadAllText ( fileName );
        }



        protected void Button1_Click ( object sender, EventArgs e )
        {          
            if( LoginTextBox.Text.Trim() != "" && 
                EmailTextBox .Text.Trim() != "" && 
                MessageTextBox.Text.Trim ( ) != "" )
            {
                db.Messages.Add ( new Message { Date = DateTime.Now,
                                                Content = MessageTextBox.Text,
                                                Email = EmailTextBox.Text,
                                                Login = LoginTextBox.Text
                } );
                
                db.SaveChanges ( );
            }
        }
    }
}