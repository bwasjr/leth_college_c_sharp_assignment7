using System.Drawing.Text;

namespace Assignment6
{

    public partial class Form1 : Form
    {
        HockeyPlayer[] hockeyTeam;
        int currentPlayers;
        HockeyPlayer player = new HockeyPlayer("Default", 0, 0);
        


        public Form1()
        {
            hockeyTeam = new HockeyPlayer[30];
            currentPlayers = 0;


            InitializeComponent();
            setCurrentPlayers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPlayers > 30)
            {
                MessageBox.Show("A team cannot have more than 30 players.");
                return;
            }                

            String name = textBox1.Text;
            int jerseyNumber = 0;
            int goals = 0;

            if (name == null || name.Equals(""))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }
            if (name.Length > 20) 
            {
                MessageBox.Show("Name has a limit of 20 characters.");
                return;
            }
                

            if (!Int32.TryParse(textBox2.Text, out jerseyNumber))
            {
                MessageBox.Show("Jersey Number cannot be empty and only accept numbers");
                return;
            }

            if (!Int32.TryParse(textBox3.Text, out goals))
            {
                MessageBox.Show("Goals Scored cannot be empty and only accept numbers");
                return;
            }

            if (isNameExistent(name))
            {
                MessageBox.Show("There is another player with this Name: " + name);
                return;
            }

            if (isJerseyNumberExistent(jerseyNumber))
            {
                MessageBox.Show("There is another player with this Jersey Number: " + jerseyNumber);
                return;
            }            

            hockeyTeam[currentPlayers] = new HockeyPlayer(name, jerseyNumber, goals);
            currentPlayers++;
            MessageBox.Show("Player successfully added");
            setCurrentPlayers();
        }

        private void setCurrentPlayers()
        {
            textBox4.Text = currentPlayers.ToString();
            clearFields();
        }

        private void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String outPutFormat = "{0, -20}|{1}|{2}\n";
            richTextBox1.Text = String.Format(outPutFormat, "Player Name", "Jersey Number", "Goals Scored");

            player.SortCriteria = comboBox1.Text;

            if (radioButton2.Checked)
            { 
                player.Inverse = true;
            }
            else
                player.Inverse = false;

            if (currentPlayers > 1) 
            {
                Array.Sort(hockeyTeam);
            }
           

            foreach(HockeyPlayer player in hockeyTeam)
            {
                if(player != null)
                    richTextBox1.AppendText(player.ToString()+"\n");
            }
        }

        private bool isJerseyNumberExistent(int number)
        {
            for (int i = 0; i < currentPlayers; i++) 
            {
                if(number == hockeyTeam[i].JerseyNumber)
                    return true;
            }
            return false;
        }

        private bool isNameExistent(String name)
        {
            for (int i = 0; i < currentPlayers; i++)
            {
                if (name.Equals(hockeyTeam[i].Name) )
                    return true;
            }
            return false;
        }
    }
}