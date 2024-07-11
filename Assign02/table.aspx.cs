using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign02
{
    public partial class table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Web.UI.WebControls.Table table = new Table();
            System.Web.UI.WebControls.TableCell tc = new TableCell();
            System.Web.UI.WebControls.TableRow tr = new TableRow();

            table.Width = 360;
            table.CellPadding = 0;
            table.CellSpacing = 1;


            tc.ColumnSpan = 3;
            System.Web.UI.WebControls.Image img = new Image();
            img.ImageUrl = "topBanner.jpg";
            img.Visible = true;
            img.Width = 360;
            tc.Controls.Add(img);
            tc.HorizontalAlign = HorizontalAlign.Center;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            /////////////////////// NEXT ROW /////////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.ColumnSpan = 3;
            tc.Text = "PUR &nbsp; &nbsp; 0 &nbsp; &nbsp; | &nbsp; &nbsp; OSU &nbsp; &nbsp; 0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 16;
            tr.Controls.Add (tc);
            table.Controls.Add(tr);


            //////////////////////// Next Row ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.ColumnSpan = 3;
            tc.Text = "Team Comparison";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 14;
            tc.Font.Underline = true;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.ColumnSpan = 3;
            tc.Text = "Page reloads every 30 seconds";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Underline = true;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            /////////////////////// Next Row ////////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            img = new System.Web.UI.WebControls.Image();
            img.ImageUrl = "purdue.jpg";
            img.Visible = true;
            tc.Controls.Add(img);
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Width = 100;
            tr.Controls.Add(tc);
            
            tc = new TableCell();
            tc.Text = "VS";
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 14;
            tc.Font.Bold = true;
            tc.Width = 160;
            tr.Controls.Add(tc);

            tc = new TableCell();
            img = new System.Web.UI.WebControls.Image();
            img.ImageUrl = "osu.jpg";
            img.Visible = true;
            tc.Controls.Add(img);
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Width = 100;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "First Down";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "3rd down efficiency";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "4rd down efficiency";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Total Yards";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Passing Yards";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Comp-Att";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Yards per Pass";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Rushing Yards";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Rushing Attempts";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Yards per Rush";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Penalty Yards";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0-0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Turnovers";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Fumbles Lost";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Interceptions";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "0";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.Text = " ";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = "Time of Posession";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            tc = new TableCell();
            tc.Text = " ";
            tc.BackColor = System.Drawing.Color.LightGray;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////
            tr = new TableRow();
            tc = new TableCell();

            tc.ColumnSpan = 3;
            tc.Text = "<a href='refresh.aspx'>Refresh</a> &nbsp; &nbsp; | &nbsp; &nbsp; <a href='playbyplay.aspx'>Play by Play</a> &nbsp; &nbsp; | &nbsp; &nbsp; <a href='morestats.aspx'>More Stats</a>";
            tc.BackColor = System.Drawing.Color.White;
            tc.HorizontalAlign = HorizontalAlign.Center;
            tc.Font.Size = 10;
            tc.Font.Bold = true;
            tr.Controls.Add(tc);

            table.Controls.Add(tr);

            //////////////////////// Next Row ///////////////////////////////

            tr = new TableRow();
            tc = new TableCell();

            tc.ColumnSpan = 3;
            img = new System.Web.UI.WebControls.Image();
            img.ImageUrl = "bottomBanner.jpg";
            img.Visible = true;
            img.Width = 360;
            tc.Controls.Add(img);
            tc.HorizontalAlign = HorizontalAlign.Center;
            tr.Controls.Add(tc);
            table.Controls.Add(tr);

            //////////Add the table to the panel (myTable) on the aspx ///////
            myTable.Controls.Add(table);


        } //end page load
    } //end Class
} //end namespace