using MyWebClient.MyWCFServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MySubmitButton_Click(object sender, EventArgs e)
        {
            MyWCFServiceClient srv = new MyWCFServiceClient();
            
            //Student stu = srv.StudentSelectByID(1);

            //StudentList students = srv.StudentSelectAll();

            //String str = "";

            //students.ForEach(s => str += s.FirstName + " ");

            //MyTextBox.Text = str;


            Lecturer l = srv.LecturerLogin(eMail.Text, password.Text);

            Session["lecturer"] = l;

            messageLbl.Text = l.FirstName + " " + l.LastName + " " + l.City.Name;
         }
    }
}