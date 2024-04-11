using System.Drawing.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment6
{

    public partial class Form1 : Form
    {
        HockeyPlayer[] hockeyTeam;
        int currentPlayers;
        HockeyPlayer player = new HockeyPlayer("Default", 0, 0);
        String outPutFormat = "{0, -20}|{1}|{2}\n";
        int oldJerseyNumber = -99;



        public Form1()
        {
            hockeyTeam = new HockeyPlayer[30];
            currentPlayers = 0;


            InitializeComponent();
            setCurrentPlayers();
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPlayers > 30)
            {
                MessageBox.Show("A team cannot have more than 30 players.");
                return;
            }

            String name = textBox1.Text;
            String jerseyNumber = textBox2.Text;
            String goalsScored = textBox3.Text;

            int jerseyN = -99;
            int goalsS = -99;

            if (!areFieldsValid(name, jerseyNumber, goalsScored))
                return;

            jerseyN = Convert.ToInt32(jerseyNumber);
            goalsS = Convert.ToInt32(goalsScored);

            if (isNameExistent(name))
            {
                MessageBox.Show("There is another player with this Name: " + name);
                return;
            }

            if (isJerseyNumberExistent(Convert.ToInt32(jerseyNumber)))
            {
                MessageBox.Show("There is another player with this Jersey Number: " + jerseyNumber);
                return;
            }

            hockeyTeam[currentPlayers] = new HockeyPlayer(name, jerseyN, goalsS);
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


            listBox1.Items.Clear();

            listBox1.Items.Add(String.Format(outPutFormat, "Player Name", "Jersey Number", "Goals Scored"));

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


            foreach (HockeyPlayer player in hockeyTeam)
            {
                if (player != null)
                    listBox1.Items.Add(player.ToString() + "\n");
            }
        }

        private bool isJerseyNumberExistent(int number)
        {
            int i = 0;

            while (hockeyTeam[i] != null)
            {
                if (number == hockeyTeam[i].JerseyNumber)
                    return true;
                i++;
            }
            return false;
        }

        private bool isNameExistent(String name)
        {
            int i = 0;

            while (hockeyTeam[i] != null)
            {
                if (name == hockeyTeam[i].Name)
                    return true;
                i++;
            }
            return false;
        }

        private void listBox1_MouseDoubleClick(object sender, EventArgs e)
        {
            String[] temp = new String[3];

            if (listBox1.SelectedIndex == 0 || listBox1.SelectedItem == null)
                return;

            temp = listBox1.SelectedItem.ToString().Split("|");
            textBox1.Text = temp[0].Trim();
            textBox2.Text = temp[1].Trim();//jersey number
            textBox3.Text = temp[2].Trim();

            oldJerseyNumber = Convert.ToInt32(textBox2.Text);



        }

        private int findPlayerByJerseyNumber(int jerseyNumb)
        {
            int i = 29;
            while (hockeyTeam[i] != null && i > 0)
            {
                if (jerseyNumb == hockeyTeam[i].JerseyNumber)
                    return i;
                i--;
            }
            return -1;
        }

        private Boolean areFieldsValid(String name, String jerseyNumber, String goalsScored)
        {
            int jn = 0;
            int g = 0;

            if (name == null || name.Equals(""))
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }
            if (name.Length > 20)
            {
                MessageBox.Show("Name has a limit of 20 characters.");
                textBox1.Text = "";
                return false;
            }


            if (!Int32.TryParse(jerseyNumber, out jn))
            {
                MessageBox.Show("Jersey Number cannot be empty and only accept numbers");
                textBox2.Text = "";
                return false;
            }

            if (!Int32.TryParse(goalsScored, out g))
            {
                MessageBox.Show("Goals Scored cannot be empty and only accept numbers");
                textBox3.Text = "";
                return false;
            }

            if (jn < 0)
            {
                MessageBox.Show("Jersey number cannot be less than zero");
                textBox3.Text = "";
                return false;
            }

            if (g < 0)
            {
                MessageBox.Show("Goals Scored cannot be less than zero");
                textBox3.Text = "";
                return false;
            }

            return true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 || listBox1.SelectedIndex == 0)
            {
                return;
            }

            if (!areFieldsValid(textBox1.Text, textBox2.Text, textBox3.Text))
                return;

            int positionArray = findPlayerByJerseyNumber(oldJerseyNumber);
            if (positionArray < 0)
            {
                MessageBox.Show("ERROR: Player not found in player list. Please, try again");
                clearFields();
                return;
            }

            hockeyTeam[positionArray].Name = textBox1.Text;
            hockeyTeam[positionArray].JerseyNumber = Convert.ToInt32(textBox2.Text);
            hockeyTeam[positionArray].GoalsScored = Convert.ToInt32(textBox3.Text);
            MessageBox.Show("Player succesfully updated!");
            button2_Click(sender, e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}