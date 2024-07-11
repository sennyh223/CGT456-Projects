using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign03
{
    public partial class calc2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void StoreDisplay(string fromDisplay)
        {
            Session["operand"] = fromDisplay.ToString();        //Save the value from the Button into Session
        }

        protected void BtnClicked(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.Button myBtn;             //declare a button to be used in the C#
            myBtn = (System.Web.UI.WebControls.Button)sender;   //cast sender into type button

            display.Text = myBtn.Text.ToString();               //take the text off the button and display it into the textbox
            StoreDisplay(myBtn.Text.ToString());                //pass the text off te button into StoreDisplay
        }
        protected void OperationClicked(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.Button myBtn;             //declare a button to be used in the C#
            myBtn = (System.Web.UI.WebControls.Button)sender;   //cast sender into type Button

            Session["operand1"] = Session["operand"];           //store first clicked number into operand1
            Session["operation"] = myBtn.Text.ToString();       //get text off Button for the operation
            
        }
        protected void BtnEqual_Click(object sender, EventArgs e)
        {
            Session["operand2"] = Session["operand"];           

            if (Session["operation"].ToString() == "+")
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) + (Convert.ToInt32(Session["operand2"].ToString()))).ToString();
            else if (Session["operation"].ToString() == "-")
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) - (Convert.ToInt32(Session["operand2"].ToString()))).ToString();
            else if (Session["operation"].ToString() == "*")
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) * (Convert.ToInt32(Session["operand2"].ToString()))).ToString();
            else if (Session["operation"].ToString() == "/")
                display.Text = ((Convert.ToInt32(Session["operand1"].ToString())) / (Convert.ToInt32(Session["operand2"].ToString()))).ToString();
        }
        protected void BtnClear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            Session["operation"] = "";
            Session["operand1"] = "";
            Session["operand2"] = "";
            Session["operand"] = "";
        }
    }
}