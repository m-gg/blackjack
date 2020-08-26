/* Filename:            How To Play.cs
 * Author:              Mikhail Goulding
 * Created:             02 February 2020
 * Operating System:    Windows 10
 * Version:             1.0
 * Description          This file holds the form How To Play form. This form is the tutorial for the game.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class How_To_Play : Form // This class is a form containing the tutorial.
    {
        string[] ImageLoc = new string[9]; // Location of "how to play" screenshots.
        string[] TextLoc = new string[8]; // Location of "how to play" text screenshots.
        int pagenum = 0; // Number of current page.
        public How_To_Play()
        {
            InitializeComponent();
            

            for (int count = 0; count < 9; count++) // Adding picture locations to ImageLoc array.
            {
                string ILoc = "HTP/" + count.ToString() + ".png"; // Each image has a number name like: 0.png, 1png. The images are located in the 'HTP' folder.
                ImageLoc[count] = ILoc;

                if (count != 8)
                {
                    string TLoc = "HTP/Text/" + count.ToString() + ".png";
                    TextLoc[count] = TLoc;
                }
            }

            try // Tries to show first picture.
            {
                PictureHelp.Dock = DockStyle.Left;
                PictureHelp.BackgroundImage = Image.FromFile(ImageLoc[0]);
            }
            catch (System.IO.FileNotFoundException e) // Catches exception if files are missing.
            {
                MessageBox.Show("File(s) Missing - " + e.Message, "Error");
                this.Close();
            }
        }

        private void NextPageBtn_Click(object sender, EventArgs e) // Button to go to next page.
        {
            if (pagenum == 8) // Counts page numbers.
            {
                pagenum = 0;
            }
            else
            {
                pagenum += 1;
            }

            try // Try to show images for next page.
            {
                PictureHelp.Dock = DockStyle.None;
                PictureHelp.BackgroundImage = Image.FromFile(ImageLoc[pagenum]);

                if (pagenum !=0)
                {
                    TextHelp.BackgroundImage = Image.FromFile(TextLoc[pagenum - 1]);
                    TextHelp.BackgroundImageLayout = ImageLayout.None;

                    if (pagenum == 3)
                    {
                        TextHelp.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
                else
                {
                    PictureHelp.Dock = DockStyle.Left;
                    TextHelp.BackgroundImage = null;
                }
            }
            catch (System.IO.FileNotFoundException msg) // Catches exception if files are missing.
            {
                MessageBox.Show("File(s) Missing - " + msg.Message, "Error");
                this.Close();
            }
            PageOfLabel.Text = ("Page " + (pagenum + 1).ToString() + " of 9");
        }

        private void PreviousPageBtn_Click(object sender, EventArgs e) // Button to go to previous page.
        {
            if (pagenum == 0)  // Counts page numbers.
            {
                pagenum = 8;
            }
            else
            {
                pagenum -= 1;
            }

            try // Try to show images for previous page.
            {
                PictureHelp.Dock = DockStyle.None;
                PictureHelp.BackgroundImage = Image.FromFile(ImageLoc[pagenum]);

                if (pagenum != 0)
                {
                    TextHelp.BackgroundImage = Image.FromFile(TextLoc[pagenum - 1]);
                    TextHelp.BackgroundImageLayout = ImageLayout.None;

                    if (pagenum == 3)
                    {
                        TextHelp.BackgroundImageLayout = ImageLayout.Zoom;
                    }

                }
                else
                {
                    PictureHelp.Dock = DockStyle.Left;
                    TextHelp.BackgroundImage = null;
                }
            }
            catch (System.IO.FileNotFoundException msg) // Catches exception if files are missing.
            {
                MessageBox.Show("File(s) Missing - " + msg.Message, "Error");
                this.Close();
            }
            PageOfLabel.Text = ("Page " + (pagenum + 1).ToString() + " of 9");
        }
    }
}
