using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Purchase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Output label quantity variables
        double I1Q = 0;
        double I2Q = 0;
        double I3Q = 0;
        double I4Q = 0;
        double I5Q = 0;
        double CartTotal = 0;
        double tendy = 0;
        double tendy2 = 0;
        double owed = 0;




        //Dialogue alongside item click
        private void item1_Click(object sender, EventArgs e)
        {
            Dialogue.Text = "Ooh! That thing is sharp, I'd be careful with that one.";
            Rabbit.Visible = false;
            creepySmile.Visible = false;
            ooooo.Visible = true;
            RealPay.Visible = false;
            label2.Visible = false;
            WhatHave.Visible = false;
            tendered.Visible = false;
            tendered2.Visible = false;
            Refresh();
            Dialogue.Text += "\nSo, you want to buy it? Just 50.35 gold!";
            ooooo.Visible = false;
            creepySmile.Visible = true;
            Thread.Sleep(1000);
            Refresh();
        }

        private void item2_Click(object sender, EventArgs e)
        {
            Dialogue.Text = "Ooh! With that you can withstand quite the hit on the head.";
            Rabbit.Visible = false;
            creepySmile.Visible = false;
            ooooo.Visible = true;
            RealPay.Visible=false;
            label2.Visible = false;
            tendered.Visible = false;
            tendered2.Visible = false;
            Refresh();
            Dialogue.Text += "\nSo, you want to buy it? Just 65.88 gold!";
            ooooo.Visible = false;
            creepySmile.Visible = true;
            Thread.Sleep(1000);
            Refresh();
        }

        private void item3_Click(object sender, EventArgs e)
        {
            Dialogue.Text = "Ooh! Ma's cooked too much again, her cookin' will fix you right up.";
            Rabbit.Visible = false;
            creepySmile.Visible = false;
            ooooo.Visible = true;
            RealPay.Visible = false;
            label2.Visible = false;
            tendered.Visible = false;
            tendered2.Visible = false;
            Refresh();
            Dialogue.Text += "\nSo, you want to buy it? Just 20.50 gold each!";
            creepySmile.Visible = true;
            ooooo.Visible = false;
            Thread.Sleep(1000);
            Refresh();
        }

        private void item4_Click(object sender, EventArgs e)
        {
            Dialogue.Text = "Ooh! A wizard stopped by a while ago and dropped those off. I've no clue what they'll do!";
            Rabbit.Visible = false;
            ooooo.Visible = true;
            creepySmile.Visible = false;
            RealPay.Visible = false;
            label2.Visible = false;
            tendered.Visible = false;
            tendered2.Visible = false;
            Refresh();
            Dialogue.Text += "\nSo, you want to buy it? Just 25.99 gold each!";
            Rabbit.Visible = true;
            ooooo.Visible = false;
            Thread.Sleep(1000);
            Refresh();
        }

        private void tem5_Click(object sender, EventArgs e)
        {
            Dialogue.Text = "H-How did that get there!? I swear I've never seen it before.";
            Rabbit.Visible = false;
            MoodyRabbit.Visible = true;
            creepySmile.Visible = false;
            RealPay.Visible = false;
            label2.Visible = false;
            tendered.Visible = false;
            tendered2.Visible = false;
            Refresh();
            Dialogue.Text += "\nUhh, I mean 150 gold!!!";
            Rabbit.Visible = true;
            MoodyRabbit.Visible = false;
            Thread.Sleep(1500);
            Refresh();
        }

        //Increase and decrease buying quantity
        private void I1Increase_Click_1(object sender, EventArgs e)
        {
            I1Q++;

            I1labelOut.Text = Convert.ToString(I1Q);
        }

        private void I1Decrease_Click(object sender, EventArgs e)
        {

            I1Q--;

            I1labelOut.Text = Convert.ToString(I1Q);

        }

        private void I2Increase_Click(object sender, EventArgs e)
        {
            I2Q++;

            I2LabelOut.Text = Convert.ToString(I2Q);
        }

        private void I2Decrease_Click_1(object sender, EventArgs e)
        {
            I2Q--;

            I2LabelOut.Text = Convert.ToString(I2Q);

        }

        private void I3Increase_Click(object sender, EventArgs e)
        {
            I3Q++;

            I3LabelOut.Text = Convert.ToString(I3Q);
        }

        private void I3Decrease_Click(object sender, EventArgs e)
        {
            I3Q--;

            I3LabelOut.Text = Convert.ToString(I3Q);
        }

        private void I4Increase_Click(object sender, EventArgs e)
        {
            I4Q++;

            I4LabelOut.Text = Convert.ToString(I4Q);
        }

        private void I4Decrease_Click(object sender, EventArgs e)
        {
            I4Q--;

            I4LabelOut.Text = Convert.ToString(I4Q);
        }

        private void I5Increase_Click(object sender, EventArgs e)
        {
            I5Q++;

            I5LabelOut.Text = Convert.ToString(I5Q);
        }

        private void I5Decrease_Click(object sender, EventArgs e)
        {
            I5Q--;

            I5LabelOut.Text = Convert.ToString(I5Q);
        }


        //Cart Total
        
        private void Pay_Click(object sender, EventArgs e)
        {
            double cost = I1Q * 50.35 + I2Q * 65.88 + I3Q * 20.50 + I4Q * 25.99 + I5Q * 150;
            double tax = cost * 0.13;
            double CartTotal = cost + tax;

            
            Dialogue.Text = "Alright, if you're all done here I'll just tally up your total...";
            Thread.Sleep(1);
            Refresh();
            Rabbit.Visible = false;
            creepySmile.Visible = true;
            Dialogue.Text = $"Ok, so it'll be... {CartTotal} gold total, {tax} for taxes! Whatcha got?";
            Thread.Sleep(3000);
            Refresh();

            label2.Visible = true;

            if (LeaveLabel.Text is "bye")
            {
                Receipt.Visible = true;
            }


        }

        //actually paying
            
        private void RealPay_Click(object sender, EventArgs e)
        {

            double cost = I1Q * 50.35 + I2Q * 65.88 + I3Q * 20.50 + I4Q * 25.99 + I5Q * 150;
            double tax = cost * 0.13;
            CartTotal = cost + tax;
            double tendy;
            tendy = Convert.ToDouble(tendered.Text);
            double owed = CartTotal - tendy;

            tendered.Visible = false;
            WhatHave.Visible = false;
            tendered2.Visible = false;

            debugLabel.Text = $"cart {CartTotal} tendy {tendy}";

            Thread.Sleep(1);
            Refresh();

            //getting change/owing more
            //getting change
            //owing more
            //paying right

            if (SecretSpot.Text is "owed")
            {
                double tendy2 = Convert.ToDouble(tendered2.Text);
                if (owed > tendy2)
                {
                    Dialogue.Text = "Again! Ah, just take it.";
                    RealPay.Visible = false;
                    WhatHave.Visible = false;
                    tendered2.Visible = false;
                    Receipt.Visible = true;

                    LeaveLabel.Text = "bye";
                }
                else if (owed<tendy2)
                {
                    Dialogue.Text = "Oh! A tip! I'll see you later, kid.";
                    RealPay.Visible = false;
                    WhatHave.Visible = false;
                    Receipt.Visible = true;
                    tendered2.Visible=false;
                    LeaveLabel.Text = "bye";
                }
                else
                {
                    Dialogue.Text = "There we go, see you later kid.";
                    RealPay.Visible = false;
                    WhatHave.Visible = false;
                    tendered2.Visible = false;
                    Receipt.Visible = true;
                    LeaveLabel.Text = "bye";
                }

            }

            else
            {       
                    if (CartTotal > tendy)
                    {
                        Dialogue.Text = "You cheapin' out on me!";
                        Thread.Sleep(500);
                        Refresh();
                        Dialogue.Text += $" You still owe {CartTotal - tendy} gold.";
                        SecretSpot.ForeColor = Color.CornflowerBlue;
                    }


                    else if (CartTotal < tendy)
                    {
                        Dialogue.Text = "Kid that's too much!";
                        tendered.Visible = false;
                        RealPay.Visible = false;
                        WhatHave.Visible = false;
                        label2.Visible = false;
                        Thread.Sleep(500);
                        Refresh();

                        Dialogue.Text += $"\nHere take {tendy - CartTotal} gold back";
                        Thread.Sleep(1000);
                        Refresh();

                        Dialogue.Text = "Alrighty kid, thanks for stopping by!";
                        LeaveLabel.Text = "bye";
                        Receipt.Visible = true;
                        Thread.Sleep(1500);
                        Refresh();

                    }

                    else
                    {
                        Dialogue.Text = "Alrighty kid, thanks for stopping by!";
                        LeaveLabel.Text = "bye";
                        tendered.Visible = false;
                        RealPay.Visible = false;
                        WhatHave.Visible = false;
                        Receipt.Visible = true;


                    }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tendered.Visible = true;
            WhatHave.Visible = true;
            RealPay.Visible = true;
            label2.Visible = false;
        }

        //2nd try
        private void SecretSpot_ForeColorChanged(object sender, EventArgs e)
        {
            WhatHave.Visible=false;
            tendered.Visible=false;
            tendered2.Visible = true;
            SecretSpot.Text = "owed";
            label2.Visible=false;

            double cost = I1Q * 50.35 + I2Q * 65.88 + I3Q * 20.50 + I4Q * 25.99 + I5Q * 150;
            double tax = cost * 0.13;
            double CartTotal = cost + tax;
            double tendy;
            tendy = Convert.ToDouble(tendered.Text);
            double owed = CartTotal - tendy;

            debugLabel.Text = $"cart {CartTotal} tendy {tendy} owed {owed}";    
        }

        //leave button
        private void Leave_Click(object sender, EventArgs e)
        {
            if (LeaveLabel.Text is "bye")
            {
                
                I1Q = 0;
                I2Q = 0;
                I3Q = 0;
                I4Q = 0;
                I5Q = 0;
                CartTotal = 0;
                tendy = 0;
                tendy2 = 0;
                owed = 0;
                I1labelOut.Text = Convert.ToString(I1Q);
                I2LabelOut.Text = Convert.ToString(I2Q);
                I3LabelOut.Text = Convert.ToString(I3Q);
                I4LabelOut.Text = Convert.ToString(I4Q);
                I5LabelOut.Text = Convert.ToString(I5Q);
                Refresh();

                tendered.Text = "";
                tendered2.Text = "";


                OofToddlers.Visible = true;
              

                Dialogue.Text = "...";
                Thread.Sleep(100);
                Refresh();
                               
                Thread.Sleep(1000);
                Refresh();

                OofToddlers.Visible=false;
                Rabbit.Visible = true;
                creepySmile.Visible = false;
                Dialogue.Text=" ";
                Thread.Sleep(1);
                Refresh();

                Dialogue.Text = "Oh yeah... you may as well buy some more...";
                Thread.Sleep(500);
                Refresh();

                Dialogue.Text = "...";
                Thread.Sleep(3000);
                Refresh();


            }

            else
            {
                Dialogue.Text = "Hey! You can't leave without payin'! Unless you want a whoopin' from Ma!";
                Thread.Sleep(1);
                Refresh();
                Rabbit.Visible = false;
                MoodyRabbit.Visible = true;
                Thread.Sleep(1);
                Refresh();
                Rabbit.Visible = true;
                MoodyRabbit.Visible = false;
                Thread.Sleep(2000);
                Refresh();

            }
        }

        private void Receipt_Click(object sender, EventArgs e)
        {
            double cost = I1Q * 50.35 + I2Q * 65.88 + I3Q * 20.50 + I4Q * 25.99 + I5Q * 150;
            double tax = cost * 0.13;
            double CartTotal = cost + tax;
            double tendy;
            tendy = Convert.ToDouble(tendered.Text);
            double owed = CartTotal - tendy;

            itemTable.BringToFront();
            Refresh();
            ReceiptL.BringToFront();

            ReceiptL.Size = new Size(165, 60);
            ReceiptL.Visible = true;
            Receipt.Visible = false;
            ReceiptL.Text = "       Stanford's Shop";
            Refresh();

            ReceiptL.Size = new Size(165, 80);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\n\n{I1Q}x Stabber..........50.35g";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 100);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\n{I2Q}x Hats.............65.88g";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 120);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\n{I3Q}x Spaghetti......20.50g";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 140);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\n{I4Q}x Potion...........25.99g";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 160);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\n{I5Q}x Stabber.........150.00g";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 180);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\n\nTotal: {cost}";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 200);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\nTaxes: {tax}";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 220);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\nOwed: {CartTotal}";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 240);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\n\nTendered: {tendy + tendy2}";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 280);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\nChange: {(tendy + tendy2) - CartTotal}";
            Thread.Sleep(500);
            Refresh();

            ReceiptL.Size = new Size(165, 300);
            ReceiptL.TextAlign = ContentAlignment.TopLeft;
            ReceiptL.Text += $"\n\n        See ya later, kid";
            Thread.Sleep(500);
            Refresh();

        }
    }

}