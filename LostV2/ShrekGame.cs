/*Julia Dowson 
  February 25, 2021 
  This is a Shrek based adventure game. You need to save Princess Fiona to win.
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
using System.Media;
using System.Threading;

namespace LostV2

{
    public partial class Form1 : Form
    {
        int scene = 0;

        Random randGen = new Random();
        SoundPlayer brookSound = new SoundPlayer(Properties.Resources.brook);
        SoundPlayer dragonSound = new SoundPlayer(Properties.Resources.dragon);
        SoundPlayer trumpet = new SoundPlayer(Properties.Resources.trumpet);
        SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.game_over);
        SoundPlayer birdChirp = new SoundPlayer(Properties.Resources.birds);
        SoundPlayer doorway = new SoundPlayer(Properties.Resources.door);
        SoundPlayer donkeySound = new SoundPlayer(Properties.Resources.donkeyAudio);
        SoundPlayer swords = new SoundPlayer(Properties.Resources.sword_fight);
        SoundPlayer mining = new SoundPlayer(Properties.Resources.mining);
        SoundPlayer intro = new SoundPlayer(Properties.Resources.intro);
        SoundPlayer sword2 = new SoundPlayer(Properties.Resources.swords2);

       

        public Form1()
        {
            InitializeComponent();
            intro.Play();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.M)       //red button press. in most cases means yes
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 99; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 4) { scene = 8; }
                else if (scene == 5) { scene = 9; }
                else if (scene == 6) { scene = 13; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 8) { scene = 14; }
                else if (scene == 9) 
                {
                    int value = randGen.Next(1, 11);
                    if (value <= 5) { scene = 16; }

                    else { scene = 17; }
                }
                else if (scene == 10) { scene = 0; }
                else if (scene == 11) { scene = 19; }
                else if (scene == 12) { scene = 0; }
                else if (scene == 13) { scene = 0; }
                else if (scene == 14) { scene = 0; }
                else if (scene == 15) { scene = 0; }
                else if (scene == 16) { scene = 0; }
                else if (scene == 17) { scene = 0; }
                else if (scene == 18) { scene = 0; }
                else if (scene == 19) { scene = 0; }
                else if (scene == 20) { scene = 22; }
                else if (scene == 21) { scene = 0; }
                else if (scene == 22) { scene = 0; }
                else if (scene == 99) { scene = 0; }


            }
            else if (e.KeyCode == Keys.B)  //blue button press. in most cases means no
            { 
                if (scene == 0) { scene = 2; }
                else if (scene == 1) { scene = 4; }
                else if (scene == 2) { scene = 99; }
                else if (scene == 3) { scene = 6; }
                else if (scene == 4) { scene = 7; }
                else if (scene == 5) { scene = 10; }
                else if (scene == 6) { scene = 12; }
                else if (scene == 7) { scene = 99; }
                else if (scene == 8) { scene = 15; }
                else if (scene == 9) { scene = 18; }
                else if (scene == 10) { scene = 99; }
                else if (scene == 11) { scene = 20; }
                else if (scene == 12) { scene = 99; }
                else if (scene == 13) { scene = 99; }
                else if (scene == 14) { scene = 99; }
                else if (scene == 15) { scene = 99; }
                else if (scene == 16) { scene = 99; }
                else if (scene == 17) { scene = 99; }
                else if (scene == 18) { scene = 99; }
                else if (scene == 19) { scene = 99; }
                else if (scene == 20) { scene = 21; }
                else if (scene == 21) { scene = 99; }
                else if (scene == 22) { scene = 99; }
                else if (scene == 99) { Application.Exit(); }
            }

            else if (e.KeyCode == Keys.Space) //pickaxe option for in the cabin
            {
                 if (scene == 5) { scene = 11; }

            }

                switch (scene)
            {
                case 0:  //Main scene
                    intro.Play();
                    pictureBox.BackgroundImage = Properties.Resources.farfaraway;
                    outputLabel.Text = "While visiting Far Far Away, you see that " +
                        "there is a challenge to rescue Princess Fiona from the " +
                        "top of the castle. There is a cash prize for the winner." 
                    + " Do you want to rescue Princess Fiona ? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 1:
                    birdChirp.Play();
                    pictureBox.BackgroundImage = Properties.Resources.farfaraway2;
                    outputLabel.Text = "You start planning to go on the trip and leave " +
                        "2 days later for the castle.";
                    Refresh();
                    Thread.Sleep(3500);
                    outputLabel.Text = "As you start leaving Far Far Away, you see your " +
                        "friend and they are also doing the challenge. "
                    + "Do you want to team up with them and split the prize?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No"; 
                    break;
                case 2:
                    gameOverSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.farfaraway2;
                    outputLabel.Text = "You continue living in Far Far Away and didn't " +
                        "get the cash prize. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 3:
                    doorway.Play();
                    pictureBox.BackgroundImage = Properties.Resources.cabin;
                    outputLabel.Text = "You and your friend end up finding a small cabin " +
                        "and want to stay there for the night. Do you stay?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 4:
                    donkeySound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.donkey;
                    outputLabel.Text = "You wish your friend good luck and continue " +
                        "on your journey. On your way you meet up with a talking donkey. " +
                        "Do you talk to him?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 5:
                    swords.Play();
                    pictureBox.BackgroundImage = Properties.Resources.cabin;
                    outputLabel.Text = "You are well rested for the night and find a sword, " +
                        "shield and a pickaxe. With all your gear you can only bring one of " +
                        "these tools. Which will you bring?";
                    mining.Play();
                    redLabel.Text = "Sword";
                    blueLabel.Text = "Shield";
                    yellowLabel.Text = "Pickaxe";
                    break;
                case 6:
                    brookSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.creek;
                    outputLabel.Text = "You continue walking through the night and come " +
                        "up to a small creek. You ran out of water. Do you drink from " +
                        "the creek?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 7:
                    gameOverSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.skull;
                    outputLabel.Text = "You run away from the donkey in fear and end up " +
                        "falling off a cliff. You die. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 8:
                    donkeySound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.donkey;
                    outputLabel.Text = "You end up talking to the donkey, named Donkey " +
                        "and he helps you find the castle. " +
                        "Do you let him come with you in the castle?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 9:
                    sword2.Play();
                    pictureBox.BackgroundImage = Properties.Resources.pussInBoots;
                    outputLabel.Text = "You end up passing Puss in Boots and he is willing" +
                        " to fight you so that you can have " +
                        "help fighting the dragon. Do you want to fight him?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 10:
                    gameOverSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.skull;
                    outputLabel.Text = "Your shield ends up breaking on your way to " +
                        "the castle and you end up dying while fighting the dragon. " +
                        "Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    yellowLabel.Text = "";
                    break;
                case 11:
                    mining.Play();
                    pictureBox.BackgroundImage = Properties.Resources.tunnel;
                    outputLabel.Text = "You come to a tunnel that you must go through to " +
                        "make it to the tunnel. At the entrance of the castle you " +
                        "find a rope ladder. Do you want to exchange it for the pickaxe?";
                    redLabel.Text = "Keep the pickaxe";
                    blueLabel.Text = "Take rope ladder";
                    yellowLabel.Text = "";
                    break;
                case 12:
                    trumpet.Play();
                    pictureBox.BackgroundImage = Properties.Resources.fiona;
                    outputLabel.Text = "You are able to make it to the castle and save " +
                        "the princess. You get your cash prize. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 13:
                    gameOverSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.shrekhouse;
                    outputLabel.Text = "You drink the water and it later turns you into " +
                        "an ogre. You start living in a swamp. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 14:
                    gameOverSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.dragonDonkey;
                    outputLabel.Text = "Donkey ends up falling in love with the dragon " +
                        "protecting the castle. It still ends up killing you. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 15:
                    trumpet.Play();
                    pictureBox.BackgroundImage = Properties.Resources.fiona;
                    outputLabel.Text = "You are able to escape past the dragon and " +
                        "protect the princess. You make it back to Far Far Away and" +
                        " get a $1 million dollar cash prize. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 16:
                    gameOverSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.skull;
                    outputLabel.Text = "He ended up killing you in battle. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 17:
                    trumpet.Play();
                    pictureBox.BackgroundImage = Properties.Resources.fiona;
                    outputLabel.Text = "He helps you fight the dragon and you bring the " +
                        "princess back to Far Far Away. You split the winnings with your " +
                        "friend. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 18:
                    gameOverSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.gingerbreadman;
                    outputLabel.Text = "You end up coming across the Gingerbread Man " +
                        "and he beats you up. You can not continue on your journey. " +
                        "Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 19:
                    gameOverSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.skull;
                    outputLabel.Text = "The pickaxe was useless and the dragon knocks " +
                        "you off the bridge that is falling apart. you die from lava. " +
                        "Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 20:
                    dragonSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.ladder;
                    outputLabel.Text = "The dragon knocks you off a bridge that is " +
                        "falling apart and the rope ladder gets caught on something. " +
                        "It ends up saving you. Do you want to try and get the rope " +
                        "ladder back for further use?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 21:
                    trumpet.Play();
                    pictureBox.BackgroundImage = Properties.Resources.fiona;
                    outputLabel.Text = "You end up saving the princess. You get back " +
                        "to Far Far Away and spilt the cash prize with your friend. " +
                        "Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 22:
                    dragonSound.Play();
                    pictureBox.BackgroundImage = Properties.Resources.skull;
                    outputLabel.Text = "The dragon knocks you off the bridge again " +
                        "and you aren't able to grab the rope ladder in time. " +
                        "You die. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 99: //Selection of no for "Play again?"
                    pictureBox.BackgroundImage = Properties.Resources.shrek;
                    outputLabel.Text = "Thanks for playing!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2700);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

    }

}
