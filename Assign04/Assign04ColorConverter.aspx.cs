using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assign04
{
    public partial class Assign04ColorConverter : System.Web.UI.Page
    {
        bool firstValueChanged; //boolean true/false flag for displaying bitwise
        protected void Page_Load(object sender, EventArgs e)
        {
            //Page_Load runs each PostBack
            if(!Page.IsPostBack)
            {
                //initial page load - this only runs one time at the beginning
                //if itis a postback, it does not execute
                firstValueChanged = false;
                bit1.Enabled = false; //disable from being used
                bit2.Enabled = false;
                bit3.Enabled = false;
                bitwiseResult.Enabled = false;
                bit1.Visible = false; //don't display bit1
                bit2.Visible = false;
                bit3.Visible = false;
                bitEqual.Visible = false;
                bitEqual.Visible = false;
                bitwiseResult.Visible = false;
            }
        }//end Page_Load

        public void ValueChanged(object sender, EventArgs e)
        {
            //declare variables
            int num1 = 0;
            int num2 = 0;
            int num3 = 0; 
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;

            string color = "";

            firstValueChanged = true; //something changed, make sure bitwise calc is visible

            System.Web.UI.WebControls.DropDownList dl;
            dl = (System.Web.UI.WebControls.DropDownList)sender;

            //check to see if it was a red dl that was changed
            if (dl.ID.Contains("red"))
            {
                num8 = Convert.ToInt16(red8.SelectedValue);
                num7 = Convert.ToInt16(red7.SelectedValue);
                num6 = Convert.ToInt16(red6.SelectedValue);
                num5 = Convert.ToInt16(red5.SelectedValue);
                num4 = Convert.ToInt16(red4.SelectedValue);
                num3 = Convert.ToInt16(red3.SelectedValue);
                num2 = Convert.ToInt16(red2.SelectedValue);
                num1 = Convert.ToInt16(red1.SelectedValue);

                color = "red";
            }
            else if (dl.ID.Contains("green"))
            {
                num8 = Convert.ToInt16(green8.SelectedValue);
                num7 = Convert.ToInt16(green7.SelectedValue);
                num6 = Convert.ToInt16(green6.SelectedValue);
                num5 = Convert.ToInt16(green5.SelectedValue);
                num4 = Convert.ToInt16(green4.SelectedValue);
                num3 = Convert.ToInt16(green3.SelectedValue);
                num2 = Convert.ToInt16(green2.SelectedValue);
                num1 = Convert.ToInt16(green1.SelectedValue);

                color = "green";
            }
            else if (dl.ID.Contains("blue"))
            {
                num8 = Convert.ToInt16(blue8.SelectedValue);
                num7 = Convert.ToInt16(blue7.SelectedValue);
                num6 = Convert.ToInt16(blue6.SelectedValue);
                num5 = Convert.ToInt16(blue5.SelectedValue);
                num4 = Convert.ToInt16(blue4.SelectedValue);
                num3 = Convert.ToInt16(blue3.SelectedValue);
                num2 = Convert.ToInt16(blue2.SelectedValue);
                num1 = Convert.ToInt16(blue1.SelectedValue);

                color = "blue";
            }

            //calculate the decimal value
            calculateDecimal(color,num1,num2,num3,num4,num5,num6,num7,num8);


            //change the background color
            changeColor();

            //set the visibility of the bitwise operation
            if (firstValueChanged)
            {
                bit1.Enabled = true;
                bit2.Enabled = true;
                bit3.Enabled = true;
                bit1.Visible = true;
                bit2.Visible = true;
                bit3.Visible = true;
                bitEqual.Visible = true;
                bitwiseResult.Visible = true;
            }

            bitwise(sender, e);
        } //end ValueChanged

        //////////////////////////////////////////
        //function to calculate the decimal value
        //////////////////////////////////////////

        public void calculateDecimal(string color, int b1, int b2, int b3, int b4, int b5, int b6, int b7, int b8)
        {
            int total;
            //figure the decimal value of each binary number
            b1 = b1 * 1;
            b2 = b2 * 2;
            b3 = b3 * 4;
            b4 = b4 * 8;
            b5 = b5 * 16;
            b6 = b6 * 32;
            b7 = b7 * 64;
            b8 = b8 * 128;

            total = b1 + b2 + b3 + b4 + b5 + b6 + b7 + b8;
            
            //write the decimal value to the corresponding decimal textbox

            if (color == "red")
                rDecText.Text = total.ToString();
            else if(color == "green")
                gDecText.Text = total.ToString();
            else if (color == "blue")
                bDecText.Text = total.ToString();

            
            if (color == "red")
                rHexText.Text = CalculateHex(total);
            else if (color == "green")
                gHexText.Text = CalculateHex(total);
            else if (color == "blue")
                bHexText.Text = CalculateHex(total);
            

        } //end function calculateDecimal
        public string getHexFromNum(int num)
        {
            string hexNum = "";
            
            //if the number that is passed in is less than 9, reurn that number as a string value
            if (num <= 9)
                hexNum = num.ToString();

            if (num > 9)
            {
                if (num == 10)
                    hexNum = "A";
                if (num == 11)
                    hexNum = "B";
                if (num == 12)
                    hexNum = "C";
                if (num == 13)
                    hexNum = "D";
                if (num == 14)
                    hexNum = "E";
                if (num == 15)
                    hexNum = "F";
            }
            return hexNum;
        } // end getHexFromNum

        public string CalculateHex (int a)
        {
            int num1 = 0;
            int num2 = 0;
            string firstnum = "";
            string secondnum = "";

            //calculate the hext number 1-16
            num1 = (a / 16);
            num2 = a % 16;

            firstnum = getHexFromNum(num1);
            secondnum = getHexFromNum(num2);

            return firstnum + secondnum;
        } //end CalculateHex

        public void changeColor()
        {
            string rcolor = "";
            string gcolor = "";
            string bcolor = "";

            //set the colors to zero if not entered
            //red 
            if (rHexText.Text.Equals(""))
                rcolor = "00";
            else
                rcolor = rHexText.Text.ToString();
            //green
            if (gHexText.Text.Equals(""))
                gcolor = "00";
            else
                gcolor = gHexText.Text.ToString();
            //blue 
            if (bHexText.Text.Equals(""))
                bcolor = "00";
            else
                bcolor = bHexText.Text.ToString();

            //change the box color
            bgColor.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + rcolor + gcolor + bcolor);

        } //end changeColor
        public void bitwise(object sender, EventArgs e)
        {
            //only calucate the bitwise value if all three DL have something chosen
            if(!bit1.SelectedValue.Equals("--") && !bit2.SelectedValue.Equals("--") && !bit3.SelectedValue.Equals("--"))
            {
                int num1 = 0;
                int num2 = 0;
                int result = 0;

                //find the value of the first number
                if(bit1.SelectedValue.Equals("R"))
                    num1 = Convert.ToByte(rDecText.Text);
                if (bit1.SelectedValue.Equals("G"))
                    num1 = Convert.ToByte(gDecText.Text);
                if (bit1.SelectedValue.Equals("B"))
                    num1 = Convert.ToByte(bDecText.Text);

                if (bit3.SelectedValue.Equals("R"))
                    num2 = Convert.ToByte(rDecText.Text);
                if (bit3.SelectedValue.Equals("G"))
                    num2 = Convert.ToByte(gDecText.Text);
                if (bit3.SelectedValue.Equals("B"))
                    num2 = Convert.ToByte(bDecText.Text);

                //do the calculation
                if (bit2.SelectedValue.Equals("&"))
                    result = num1 & num2;

                if (bit2.SelectedValue.Equals("|"))
                    result = num1 | num2;

                if (bit2.SelectedValue.Equals("^"))
                    result = num1 ^ num2;

                string inBinary; //the string version of the 8-bit binary number
                int binNum = result; //the number that gets manipulated to produce the 0s and the 1s

                //128
                if (binNum >= 128)
                {
                    inBinary = "1";
                    binNum = binNum - 128;

                }
                else
                {
                    inBinary = "0";
                }
                //64
                if (binNum >= 64)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 64;

                }
                else
                {
                    inBinary = inBinary + "0";
                }
                //32
                if (binNum >= 32)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 32;

                }
                else
                {
                    inBinary = inBinary + "0";
                }
                //16
                if (binNum >= 16)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 16;

                }
                else
                {
                    inBinary = inBinary + "0";
                }
                //8
                if (binNum >= 8)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 8;

                }
                else
                {
                    inBinary = inBinary + "0";
                }
                //4
                if (binNum >= 4)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 4;

                }
                else
                {
                    inBinary = inBinary + "0";
                }
                //2
                if (binNum >= 2)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 2;

                }
                else
                {
                    inBinary = inBinary + "0";
                }
                //1
                if (binNum >= 1)
                {
                    inBinary = inBinary + "1";
                    binNum = binNum - 1;

                }
                else
                {
                    inBinary = inBinary + "0";
                }

                bitwiseResult.Text = inBinary.ToString();
            }
        }


    } //end Class
} //end namespace