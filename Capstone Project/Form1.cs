using System.CodeDom.Compiler;
using System.Diagnostics.Metrics;
using System.DirectoryServices.ActiveDirectory;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.LinkLabel;

namespace Capstone_Project
{
    public partial class Form1 : Form
    {
        int counter = 0;
        Random random = new Random();
        String file = "C:\\Users\\space\\OneDrive\\Documents\\GUI\\Braves.txt";
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("In this managing exercise, you will manage the Atlanta Braves in 4 scenarios in a scrimage game. Make the right moves to win the ballgame! Click next to begin!");


        }

        private void play_Click(object sender, EventArgs e)
        {
            next.Enabled = true;
            StatsHere.Text = "";

            if (counter == 1)
            {
                String pitchingChoice = pitcher.Text;
                String outcome = Field_Result(pitchingChoice);
                if (outcome.Equals(""))
                {
                    MessageBox.Show("Please select a pitcher");
                    next.Enabled = false;
                }
                else if (outcome.Equals("Singles") || outcome.Equals("Homers"))
                {
                    WinLose.Text = "You Lose";
                }
                else
                {
                    WinLose.Text = "You Win!";
                }
                Result.Text = "Ronald Acuna Jr. " + outcome;
            }
            if (counter == 2)
            {
                String batterChoice = batter.Text;
                String BatterName = batterChoice.Split(",")[1];
                String outcome = Field_Result(batterChoice);
                if (outcome.Equals(""))
                {
                    MessageBox.Show("Please select a Hitter");
                    next.Enabled = false;
                }
                else if (outcome.Equals("Singles") || outcome.Equals("Homers"))
                {
                    WinLose.Text = "You Win!";
                }
                else
                {
                    WinLose.Text = "You Lose.";
                }
                Result.Text = BatterName + outcome;
            }
            if (counter == 3)
            {
                String pitcherChoice = pitcher.Text;
                String pitcherName = pitcherChoice.Split(",")[1];
                if (pitcherChoice.Substring(0, 2).Equals("SP"))
                {
                    Result.Text = pitcherName + " pitches 6 innings allowing no runs.";
                    WinLose.Text = "You Win";
                }
                else
                {
                    Result.Text = "You started a reliever. \nThey make it 2 innings giving up 3 runs. \nYou lose.";
                }
            }
            if (counter == 4)
            {
                String batterChoice = batter.Text;
                String batterName = batterChoice.Split(",")[1];
                if (batterChoice.Equals("C, Travis d'Arnaud"))
                {
                    Result.Text = batterName + " hits a Grand Slam! \nYou win!";
                }
                else
                {
                    Result.Text = batterName + Field_Result(batterChoice);
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            next.Enabled = false;
            WinLose.Text = "";
            counter++;
            Result.Text = "";
            if (counter > 4)
            {
                counter = 1;
            }
            if (counter == 1)
            {
                MessageBox.Show("It's the bottom of the ninth, and your team is up 4-3. Runners on first and second. Choose a pitcher to close out the game.");
                First.Visible = true;
                Second.Visible = true;
                Third.Visible = false;
                pitcher.Visible = true;
                CloserBatter.Visible = true;
            }
            else if (counter == 2)
            {
                MessageBox.Show("Your Team is batting late in the game down 2-1. Spencer Strider is on the mound and you have a runner on Second. Bring in a pinch hitter for your 9 spot.");
                pitcher.Visible = false;
                First.Visible = false;
                Second.Visible = true;
                batter.Visible = true;
                CloserBatter.Visible = false;
            }
            else if (counter == 3)
            {
                MessageBox.Show("It's the start of the game. Choose a pitcher to be your starter");
                pitcher.Visible = true;
                First.Visible = false;
                Second.Visible = false;
                batter.Visible = false;
                LeftyBatter.Visible = true;
            }
            else if (counter == 4)
            {
                MessageBox.Show("Your current batter just got injured. Bring in a pinch hitter against Max Fried to capitilize on the bases loaded.");
                pitcher.Visible = false;
                LeftyBatter.Visible = false;
                batter.Visible = true;
                First.Visible = true;
                Second.Visible = true;
                Third.Visible = true;
            }
        }
        private String Field_Result(String choice)
        {
            String result = "";
            String line = "";
            double stat = 0;
            if (System.IO.File.Exists(file))
            {
                StreamReader fileReader = new System.IO.StreamReader(file);
                while (!line.Contains(choice) || fileReader.EndOfStream)
                {
                    line = fileReader.ReadLine();
                }
                Double.TryParse(line.Substring(line.IndexOf(":") + 1), out stat);
                if (line.Substring(1, 1).Equals("P"))
                {
                    stat = stat * 3;
                }
                double rand = random.NextDouble();

                if (rand < 0.05)
                {
                    result = "Homers";
                }
                else if (rand < stat)
                {
                    result = "Singles";
                }
                else if (rand > stat)
                {
                    result = "Strikes Out";
                }
            }
            return result;
        }

        private void Stats_Click(object sender, EventArgs e)
        {
            String choice;
            String line = "";
            Double stat = 0;
            if (pitcher.Visible)
            {
                if (pitcher.Text.Equals("Pitchers"))
                {
                    MessageBox.Show("Select a pitcher first");
                }
                else
                {
                    choice = pitcher.Text;
                    String PitcherName = choice.Split(",")[1];
                    if (System.IO.File.Exists(file))
                    {
                        StreamReader fileReader = new System.IO.StreamReader(file);
                        while (!line.Contains(choice) || fileReader.EndOfStream)
                        {
                            line = fileReader.ReadLine();
                        }
                        Double.TryParse(line.Substring(line.IndexOf(":") + 1), out stat);
                        StatsHere.Text = PitcherName + " has a WHIP of " + stat*10;
                    }
                }
            }
            else if (batter.Visible)
            {
                if (batter.Text.Equals("Hitters"))
                {
                    MessageBox.Show("Choose a batter first");
                }
                else
                {
                    choice = batter.Text;
                    String BatterName = choice.Split(",")[1];
                    if (System.IO.File.Exists(file))
                    {
                        StreamReader fileReader = new System.IO.StreamReader(file);
                        while (!line.Contains(choice) || fileReader.EndOfStream)
                        {
                            line = fileReader.ReadLine();
                        }
                        Double.TryParse(line.Substring(line.IndexOf(":") + 1), out stat);
                        StatsHere.Text = BatterName + " has an AVG of " + stat;
                    }
                }
            }
            else
            {
                MessageBox.Show("Stats Not available");
            }
        }
    }
}
