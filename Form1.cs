using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
    

namespace Sandwich_Adventure
{
    public partial class Form1 : Form
    {
        int page = 1;
        int Number;
        Random randNumber = new Random();


        public Form1()
        {
            InitializeComponent();

            displayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 2; }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 1; } 
            else if (page == 4)
            {
                Number = randNumber.Next(1, 11);
                if (Number >=2)
                {
                    page = 8;
                }
                else
                {
                    page = 9;
                }
            }
                
            else if (page == 5) { page = 1; }
            else if (page == 6) { page = 18;}
            else if (page == 7) { page = 1; }
            else if (page == 8) { page = 11;}
            else if (page == 9) { page = 1; }
            else if (page == 10) { page = 1; }
            else if (page == 11) { page = 1; }
            else if (page == 12) { page = 13; }
            else if (page == 13) { page = 15; }
            else if (page == 14) { page = 1; }
            else if (page == 15) { page = 1; }
            else if (page == 16) { page = 1; }
            else if (page == 17) { page = 14; }
            else if (page == 18) { page = 1; }
            else if (page == 19) { page = 21; }
            else if (page == 20) { page = 23; }
            else if (page == 21) { page = 25; }
            else if (page == 22) { page = 1; }
            else if (page == 23) { page = 1; }
            else if (page == 24) { page = 14; }
            else if (page == 25) { page = 1; }

            displayPage();

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 3; }
            else if (page == 2)
            {
                Number = randNumber.Next(1, 21);
                if (Number >= 2)
                {
                    page = 5;
                }
                else
                {
                    page = 6;
                }
            }
            else if (page == 3) { page = 111; }
            else if (page == 4) { page = 10; }
            else if (page == 5) { page = 111; }
            else if (page == 6) { page = 17; }
            else if (page == 7) { page = 111; }
            else if (page == 8) { page = 12; }
            else if (page == 9) { page = 111; }
            else if (page == 10) { page = 111; }
            else if (page == 11) { page = 111; }
            else if (page == 12) { page = 14; }
            else if (page == 13) { page = 16; }
            else if (page == 14) { page = 111; }
            else if (page == 15) { page = 111; }
            else if (page == 16) { page = 111; }
            else if (page == 17) { page = 19; }
            else if (page == 18) { page = 111; }
            else if (page == 19) { page = 22; }
            else if (page == 20) { page = 24; }
            else if (page == 21) { page = 25; }
            else if (page == 22) { page = 111; }
            else if (page == 23) { page = 111; }

            displayPage();

        }

        private void option3Button_Click(object sender, EventArgs e)
        {

        }

        public void displayPage()
        {
            switch(page)
            {
                case 1:
                    outputLabel.Text = "You are sitting at home, it is almost lunch time.";
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    button1Label.Text = "Go to the sandwich store for lunch";
                    button2Label.Text = "Stay at home for lunch";
                    break;

                case 2:
                    outputLabel.Text = "You step outside, and realize it is very cold out!";
                    option3Button.Visible = true;
                    button1Label.Text = "Go inside and get a jacket";
                    button2Label.Text = "Call a Taxi";
                    button3Label.Text = "Continue walking in your T-Shirt";
                    break;

                case 3:
                    outputLabel.Text = "You starve to death, as you have no food at home. Play again?";
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 4:
                    outputLabel.Text = "You put on a jacket, and start walking to the sandwich store." +
                        " You know a shortcut through the woods, but it's icy out and may be dangerous.";
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    button1Label.Text = "Take the shortcut";
                    button2Label.Text = "Take the long way";
                    break;

                case 5:
                    outputLabel.Text = "The Taxi doesn't arrive fast enough, you starve to death! Play again?";
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 6:
                    outputLabel.Text = "The Taxi arrives very quickly and asks where you would like to be taken";
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    button1Label.Text = "Go to the nearest sandwich store";
                    button2Label.Text = "Go to the town centre";
                    break;

                case 7:
                    outputLabel.Text = "You begin walking to the sandwich shop, but quickly realize it was a lot colder than you thought." +
                        " You Freeze to death.Play Again?";
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 8:
                    outputLabel.Text = "You make it through the woods unharmed, on the other side, there are 2 paths into the city.";
                    button1Label.Text = "Cut through the alleyway";
                    button2Label.Text = "Take the long way by the main road";
                    break;

                case 9:
                    outputLabel.Text = "You Slip on some ice while taking the shortcut, you hit your head and die. Play again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 10:
                    outputLabel.Text = "You decide to take the long way into the city, but on your way there," +
                        " part of the sidewalk is closed for construction. You try to cross the street to avoid it," +
                        " but you forgot to look both ways before crossing. You are hit by a fast-moving truck, and die. Play again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 11:
                    outputLabel.Text = "While walking through the dark alleyway, you are suddenly surrounded by the calm sound of a piano," +
                        " you stop to listen for a moment, but regret it immediately as you see the piano falling from a building" +
                        ", and promptly crushing you. Play again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 12:
                    outputLabel.Text = "While walking down the main road, you see a beggar asking for money.";
                    button1Label.Text = "Give the begger $10";
                    button2Label.Text = "Ignore them";
                    break;

                case 13:
                    outputLabel.Text = "Shortly after giving the beggar money, you realize you will no longer be able to afford a sandwich";
                    button1Label.Text = "Steal the money back";
                    button2Label.Text = "Ask for the money back nicely";
                    break;

                case 14:
                    outputLabel.Text = "You made it to the sandwich store! You get your lunch and are full for the rest of the day. Play again ? ";
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    option2Button.Visible = true;
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 15:
                    outputLabel.Text = "A bystander catches you stealing from the beggar, you are arrested and starve to death in the long ride to the jail. Play again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 16:
                    outputLabel.Text = "The beggar gets angry at you for trying to take your money back, he stabs you and takes the rest of your money. Play again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 17:
                    outputLabel.Text = "The driver drops you off in the center of the town. You know 3 paths from here to the sandwich store.";
                    option3Button.Visible = true;
                    button1Label.Text = "Take the side street";
                    button2Label.Text = "Take the main road West";
                    button3Label.Text = "Take the road North";
                    break; 
                   
                case 18:
                    outputLabel.Text = "Unfortunately, the driver doesn't know the town very well," +
                        " and ends up driving in circles for hours. You die of starvation. Play again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 19:
                    outputLabel.Text = "You come up to a construction site.";
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    button1Label.Text = "Walk around it";
                    button2Label.Text = "Walk through the construction site";
                    break;

                case 20:
                    outputLabel.Text = "You begin walking West, but you take a wrong turn, and realize you are lost.";
                    option3Button.Visible = false;
                    button3Label.Text = "";
                    button1Label.Text = "Ask someone for directions";
                    button2Label.Text = "Keep walking";
                    break;

                case 21:
                    outputLabel.Text = "You walk around the construction site and see two roads to the sandwich store.";
                    button1Label.Text = "Take the shortest road";
                    button2Label.Text = "Take the longer road";
                    break;

                case 22:
                    outputLabel.Text = "While cutting through the construction zone, a hammer falls from above," +
                        " and hits you on the head. you die. Play again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 23:
                    outputLabel.Text = "You spend 2 hours looking for someone to give you directions, but nobody knows where the sandwich store is." +
                        " You starve to death. Play again?";
                    button1Label.Text = "Yes";
                    button2Label.Text = "No";
                    break;

                case 24:
                    outputLabel.Text = "You realize you weren't actually lost, and there was just a new building on this road.";
                    option2Button.Visible = false;
                    button2Label.Text = "";
                    button1Label.Text = "Next";
                    break;

                case 111:
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    button1Label.Text = "";
                    button2Label.Text = "";
                    button3Label.Text = "";
                    outputLabel.Text = "Thank you for Playing!";
                    Refresh();
                    Thread.Sleep(5000);
                    Application.Exit();
                    break;

                default:
                    break;


            }
        }
      
    }
}
