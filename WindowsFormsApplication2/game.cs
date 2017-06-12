using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class game : Form
    {
        private List<List<Button>> buttonsArray = new List<List<Button>>();

     /*   System.Threading.Timer t = new System.Threading.Timer(timer_Tick, null,0,1000);

        private static void timer_Tick(object state)
        {
             int oldScore = Convert.ToInt32(scoreLabel.Text);
            scoreLabel.Text = (oldScore++).ToString();
            throw new NotImplementedException();
        }
        */
        int length, width, number;
        int[] bombsX;
        int[] bombsY;
        int buttonsclicked;

        public game()
        {
            InitializeComponent();
        }



        public game(int length, int width,int number)
        {

            //intializing 
            InitializeComponent();
            this.length = length;
            this.width = width;
            this.number = number;
            bombsX = new int[number];
            bombsY = new int[number];
            buttonsclicked = number;

            //creating Buttons
             generateButtons();
             generateBombs();
           
        }

    

        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int ynumber, xnumber;
            if (width > 10 && length > 10 && b.Name.Length>8)
            {
                 ynumber = Convert.ToInt16(b.Name.Substring(6, 2));
                 xnumber = Convert.ToInt16(b.Name.Substring(8, 2));
                   if(b.Name.Length<=10)
                   {
                    buttonsclicked++;
                    b.Name = b.Name + "Clicked";
                 }
            }
            else if (width > 10 && b.Name.Length > 8)
            {
                ynumber = Convert.ToInt16(b.Name.Substring(6, 2));
                xnumber = Convert.ToInt16(b.Name.Substring(8, 1));
                if (b.Name.Length <= 9)
                {
                    buttonsclicked++;
                    b.Name = b.Name + "Clicked";
                }
            }
            else if (length>10 && b.Name.Length > 8)
            {
        
                ynumber = Convert.ToInt16(b.Name.Substring(6, 1));
                xnumber = Convert.ToInt16(b.Name.Substring(7, 2));
                if (b.Name.Length <= 9)
                {
                    buttonsclicked++;
                    b.Name = b.Name + "Clicked";
                }
            }
            else
            {
                ynumber = Convert.ToInt16(b.Name.Substring(6, 1));
                xnumber = Convert.ToInt16(b.Name.Substring(7, 1));
                if (b.Name.Length <= 8)
                {
                    buttonsclicked++;
                    b.Name = b.Name + "Clicked";
                }
            }
            int countBombs=0;

            //event handler when button clicked
            for (int n = 0; n < number; n++)
            {
             
                if (ynumber == bombsY[n] && xnumber== bombsX[n])
                {
                               
                    new lose(Convert.ToInt32(scoreLabel.Text)).Show();
                    b.Text = "*";
                    this.Hide();
                    break;
                }
                else if( Math.Abs(ynumber-bombsY[n]) ==1 && Math.Abs(xnumber - bombsX[n])<=1 || (Math.Abs(xnumber - bombsX[n])==1 && Math.Abs(ynumber - bombsY[n])<=1))
                {
                    countBombs++;
                    b.Text = countBombs.ToString();
             
                }
                else
                {
                    b.Text = countBombs.ToString();
                }

            }
            if (buttonsclicked == width * length)
            {

                new win(Convert.ToInt32(scoreLabel.Text)).Show();
                this.Hide();
            }
        }
        private void generateButtons()
        {
            for (int y = 0; y < length; y++)
            {
                List<Button> tempList = new List<Button>();

                for (int x = 0; x < width; x++)
                {
                    tempList.Add(new Button());
                }

                this.buttonsArray.Add(tempList);
            }

            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int xPos = 25 * x;
                    int yPos = 25 * y;

                    this.buttonsArray[y][x].Location = new System.Drawing.Point(xPos, yPos);
                    this.buttonsArray[y][x].Name = "button" + y.ToString() + x.ToString();
                    this.buttonsArray[y][x].Size = new System.Drawing.Size(24, 24);
                    this.buttonsArray[y][x].TabIndex = 0;
                    this.buttonsArray[y][x].Click += btn_Click;
                    this.buttonsArray[y][x].UseVisualStyleBackColor = false;
                    this.Controls.Add(this.buttonsArray[y][x]);
                }
            }
            return;
        }

        private void generateBombs()
        {
            //Generating random bombs
            Random r = new Random();
          
            for (int n = 0; n < number; n++)
            {
                if (n != 0)
                {
                    do
                    {
                        bombsX[n] = r.Next(0, width);
                    } while (bombsX[n] == bombsX[n - 1]);
                    do
                    {
                        bombsY[n] = r.Next(0, length);
                    } while (bombsY[n] == bombsY[n - 1]);

                }
                else
                {
                    bombsX[n] = r.Next(0, width);
                    bombsY[n] = r.Next(0, length);
                }
            }
            return;
        }
        private void game_Load(object sender, EventArgs e)
        {
           
        }
    }
}
