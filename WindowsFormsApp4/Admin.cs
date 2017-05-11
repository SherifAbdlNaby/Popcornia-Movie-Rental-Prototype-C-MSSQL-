using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Popcornia
{
    public partial class Admin : Form
    {
        class ComboboxItem
        {
            public string DisplayString;
            public int Key;

            public ComboboxItem(int key, string displayString)
            {
                Key = key;
                DisplayString = displayString;
            }

            public override string ToString()
            {
                return Key.ToString() + ", " + DisplayString;
            }
        }
        class ComboboxItem1
        {
            public string Role;
            public string Movie;
            public int Key;
            public ComboboxItem1(int key, string role, string movie )
            {
                Key = key;
                Role = role;
                Movie = movie;
            }

            public override string ToString()
            {
                return Role.ToString() + ", " + Movie;
            }
        }
        string username, name, email, address, phone, birthday;
        AllMovies AllMoviesPanel = new AllMovies(1);
        AllActors AllActorsPanel = new AllActors(1);
        AllDirectors AllDirectorsPanel = new AllDirectors(1);
        AllProducers AllProducersPanel = new AllProducers(1);
        AllComposers AllComposersPanel = new AllComposers(1);
        AllRoles AllRolesPanel = new AllRoles(1);
        AllRent AllRentPanel = new AllRent(1);
        public void loadWindow(string usernamex, string namex, string emailx, string addressx, string phonex, string birthdayx)
        {
            username = usernamex;
            name = namex;
            email = emailx;
            address = addressx;
            phone = phonex;
            birthday = birthdayx;
            usernameLabel.Text += username;
            nameLabel.Text += name;
            emailLabel.Text += email;
            addressLabel.Text += address;
            phoneLabel.Text += phone;
            birthdayLabel.Text += birthday;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void ActorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            if (actorName.Text == "")
            {
                AddActorStatus.Text = "Please fill all fields!";
                AddActorStatus.ForeColor = System.Drawing.Color.Red;
                AddActorStatus.Show();
            }
            else
            {

                if (addType.Text == "Actor")
                {
                    query.CommandText = "INSERT INTO Actors(Name, BirthDate, StartDate) VALUES ('" +
                    actorName.Text + "', '" +
                    actorBirthDay.Value + "', '" +
                    actorStartDate.Value +
                    "');";
                    query.Connection = connection;
                    query.CommandType = CommandType.Text;
                    try
                    {
                        query.ExecuteNonQuery();
                        AddActorStatus.Text = "Successfully, Added!";
                        AddActorStatus.ForeColor = System.Drawing.Color.LimeGreen;
                        AddActorStatus.Show();
                        updateDropLists(2);
                    }
                    catch (Exception x)
                    {
                        AddActorStatus.Text = "UNKNOWN ERROR"; //Shouldn't exception anyway...
                        AddActorStatus.ForeColor = System.Drawing.Color.Red;
                        AddActorStatus.Show();
                    }
                }
                else if (addType.Text == "Director")
                {
                    query.CommandText = "INSERT INTO Directors(Name, BirthDate, StartDate) VALUES ('" +
                    actorName.Text + "', '" +
                    actorBirthDay.Value + "', '" +
                    actorStartDate.Value +
                    "');";
                    query.Connection = connection;
                    query.CommandType = CommandType.Text;
                    try
                    {
                        query.ExecuteNonQuery();
                        AddActorStatus.Text = "Successfully, Added!";
                        AddActorStatus.ForeColor = System.Drawing.Color.LimeGreen;
                        AddActorStatus.Show();
                        updateDropLists(3);
                    }
                    catch (Exception x)
                    {
                        AddActorStatus.Text = "UNKNOWN ERROR"; //Shouldn't exception anyway...
                        AddActorStatus.ForeColor = System.Drawing.Color.Red;
                        AddActorStatus.Show();
                    }
                }
                else if (addType.Text == "Producer")
                {
                    query.CommandText = "INSERT INTO Producers(Name, BirthDate, StartDate) VALUES ('" +
                    actorName.Text + "', '" +
                    actorBirthDay.Value + "', '" +
                    actorStartDate.Value +
                    "');";
                    query.Connection = connection;
                    query.CommandType = CommandType.Text;
                    try
                    {
                        query.ExecuteNonQuery();
                        AddActorStatus.Text = "Successfully, Added!";
                        AddActorStatus.ForeColor = System.Drawing.Color.LimeGreen;
                        AddActorStatus.Show();
                        updateDropLists(4);
                    }
                    catch (Exception x)
                    {
                        AddActorStatus.Text = "UNKNOWN ERROR"; //Shouldn't exception anyway...
                        AddActorStatus.ForeColor = System.Drawing.Color.Red;
                        AddActorStatus.Show();
                    }
                }
                else if (addType.Text == "Composer")
                {
                    query.CommandText = "INSERT INTO Composers(Name, BirthDate, StartDate) VALUES ('" +
                    actorName.Text + "', '" +
                    actorBirthDay.Value + "', '" +
                    actorStartDate.Value +
                    "');";
                    query.Connection = connection;
                    query.CommandType = CommandType.Text;
                    try
                    {
                        query.ExecuteNonQuery();
                        AddActorStatus.Text = "Successfully, Added!";
                        AddActorStatus.ForeColor = System.Drawing.Color.LimeGreen;
                        AddActorStatus.Show();
                        updateDropLists(5);
                    }
                    catch (Exception x)
                    {
                        AddActorStatus.Text = "UNKNOWN ERROR"; //Shouldn't exception anyway...
                        AddActorStatus.ForeColor = System.Drawing.Color.Red;
                        AddActorStatus.Show();
                    }
                }
            }
            addType.SelectedIndex = -1;
            addType.Text = "Select Type...";
            actorName.Enabled = false;
            actorStartDate.Enabled = false;
            actorBirthDay.Enabled = false;
            AddButton1.Enabled = false;
            AddButton1.Text = "Add";
            actorName.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addMovie_Click(object sender, EventArgs e)
        {
            if (DirectorBox.Text == "" || ProducerBox.Text == "" || ComposerBox.Text == ""  || MovieName.Text == "" || MovieGenre.Text == "")
            {
                MovieStatus.Text = "Missing Inputs";
                MovieStatus.ForeColor = System.Drawing.Color.Red;
                MovieStatus.Show();
                return;
            }
            int DirectorID = Convert.ToInt32(((ComboboxItem)DirectorBox.SelectedItem).Key);
            int ProducerID = Convert.ToInt32(((ComboboxItem)ProducerBox.SelectedItem).Key);
            int ComposerID = Convert.ToInt32(((ComboboxItem)ComposerBox.SelectedItem).Key);
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO Movies(Name, Year, Genre, Director_ID, Producer_ID, Composer_ID) VALUES ('" +
              MovieName.Text + "', '" +
              MovieDate.Value + "', '" +
              MovieGenre.Text+ "', '" +
              DirectorID + "', '" +
              ProducerID + "', '" +
              ComposerID +
               "');";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            try
            {
                query.ExecuteNonQuery();
                MovieStatus.Text = "Added!";
                MovieStatus.ForeColor = System.Drawing.Color.LimeGreen;
                MovieStatus.Show();
                MovieName.Clear();
                MovieGenre.SelectedIndex = -1;
                DirectorBox.SelectedIndex = -1;
                ProducerBox.SelectedIndex = -1;
                ComposerBox.SelectedIndex = -1;
                updateDropLists(1);
                addMovie.Enabled = false;
            }
            catch (Exception x)
            {
                MovieStatus.Text = "Invalid IDs";
                MovieStatus.ForeColor = System.Drawing.Color.Red;
                MovieStatus.Show();
                MovieName.Clear();
                addMovie.Enabled = false;
            }
            
        }

        private void AddRoles_Click(object sender, EventArgs e)
        {
            if (MovieRoleBox.Text == "" || ActorRoleBox.Text == "" || RoleName.Text == "" )
            {
                RoleStatus.Text = "Missing Inputs";
                RoleStatus.ForeColor = System.Drawing.Color.Red;
                RoleStatus.Show();
                MovieRoleBox.SelectedIndex = -1;
                ActorRoleBox.SelectedIndex = -1;
                AddRoles.Enabled = false;
                return;
            }
            int MovieID = Convert.ToInt32(((ComboboxItem)MovieRoleBox.SelectedItem).Key);
            int ActorID = Convert.ToInt32(((ComboboxItem)ActorRoleBox.SelectedItem).Key);
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO Roles(Movie_ID, Actor_ID, RoleName) VALUES ('" +
              MovieID + "', '" +
              ActorID + "', '" +
              RoleName.Text +
               "');";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            try
            {
                query.ExecuteNonQuery();
                RoleStatus.Text = "Added!";
                RoleStatus.ForeColor = System.Drawing.Color.LimeGreen;
                RoleStatus.Show();
                RoleName.Clear();
            }
            catch (Exception x)
            {
                RoleStatus.Text = "Role Already Exist!";
                RoleStatus.ForeColor = System.Drawing.Color.Red;
                RoleStatus.Show();
                RoleName.Clear();
            }
            AddRoles.Enabled = false;
            MovieRoleBox.SelectedIndex = -1;
            ActorRoleBox.SelectedIndex = -1;
            updateDropLists(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AllRentPanel.Close();
            AllRentPanel = new AllRent();
            AllRentPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllMoviesPanel.Close();
            AllMoviesPanel= new AllMovies();
            AllMoviesPanel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllActorsPanel.Close();
            AllActorsPanel = new AllActors();
            AllActorsPanel.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AllRolesPanel.Close();
            AllRolesPanel = new AllRoles();
            AllRolesPanel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AllDirectorsPanel.Close();
            AllDirectorsPanel = new AllDirectors();
            AllDirectorsPanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AllProducersPanel.Close();
            AllProducersPanel = new AllProducers();
            AllProducersPanel.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AllComposersPanel.Close();
            AllComposersPanel = new AllComposers();
            AllComposersPanel.Show();
        }

        private void addType_SelectedIndexChanged(object sender, EventArgs e)
        {
            actorName.Enabled = true;
            actorStartDate.Enabled = true;
            actorBirthDay.Enabled = true;
            AddButton1.Enabled = true;
            AddButton1.Text = "Add " + addType.Text;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'popcorniaDataSet3.Actors' table. You can move, or remove it, as needed.
            this.actorsTableAdapter.Fill(this.popcorniaDataSet3.Actors);

        }

        private void ActorRoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MovieRoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RoleStatus_Click(object sender, EventArgs e)
        {

        }

        private void updateDropLists(int x = 0)
        {
            String strCmd = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection con = new SqlConnection(strCmd);
            SqlCommand cmd = new SqlCommand(strCmd, con);
            SqlDataReader reader;
            bar.Value = 0;
            if (x == 2 || x == 0)
            {
                ActorRoleBox.Items.Clear();
                ActorBox2.Items.Clear();
                ActorBox3.Items.Clear();
                con.Open();
                strCmd = "select ActorID, Name from Actors";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ActorRoleBox.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                    ActorBox2.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                }
            }
            if(x == 2 || x == 6 || x == 0 || x == 1) // 6 for new Role, 1 for Update Movies, 2 for Update Actors, 0 for all
            {
                ActorBox3.Items.Clear();
                con.Close();
                con.Open();
                strCmd = "select ActorID, Name from Actors WHERE ActorID in (SELECT Distinct Actor_ID FROM Roles)";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ActorBox3.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                }
                if(ActorBox3.Items.Count == 0)
                {
                    ActorBox3.Enabled = false;
                    RoleBox.Enabled = false;
                }
                else
                {
                    ActorBox3.Enabled = true;
                    RoleBox.Enabled = false;
                    RoleBox.Items.Clear();
                }
            }
            bar.Value = 20;
            if (x == 1 || x == 0)
            {
                MovieRoleBox.Items.Clear();
                MovieBox2.Items.Clear();
                MovieBox3.Items.Clear();
                con.Close();
                con.Open();
                strCmd = "select movieID, Name from Movies";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MovieRoleBox.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                    MovieBox2.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                    MovieBox3.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                }
            }
            bar.Value = 40;
            if (x == 3 || x == 0)
            {
                con.Close();
                con.Open();
                DirectorBox.Items.Clear();
                DirectorBox2.Items.Clear();
                strCmd = "select DirectorID, Name from Directors";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DirectorBox.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                    DirectorBox2.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                }
            }
            bar.Value = 60;
            if (x == 5 || x == 0)
            {
                ComposerBox.Items.Clear();
                ComposerBox2.Items.Clear();
                con.Close();
                con.Open();
                strCmd = "select ComposersID, Name from Composers";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ComposerBox.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                    ComposerBox2.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                }
            }

            bar.Value = 80;
            if (x == 4 || x == 0)
            {
                ProducerBox.Items.Clear();
                ProducerBox2.Items.Clear();
                con.Close();
                con.Open();
                strCmd = "select ProducerID, Name from Producers";
                cmd = new SqlCommand(strCmd, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProducerBox.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                    ProducerBox2.Items.Add(new ComboboxItem((int)reader[0], (string)reader[1]));
                }
            }
            bar.Value = 100;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            updateDropLists();
        }

        private void groupBox3_Enter_2(object sender, EventArgs e)
        {

        }

        private void updateMovie_Click(object sender, EventArgs e)
        {
            if (DirectorBox2.Text == "" || ProducerBox2.Text == "" || ComposerBox2.Text == "" || MovieBox2.Text == "" || newMovieTitle.Text == "" || newGenre.Text == "")
            {
                UpdateMovieStatus.Text = "Unsuccessful!";
                UpdateMovieStatus.ForeColor = System.Drawing.Color.Red;
                UpdateMovieStatus.Show();
                MovieBox2.SelectedIndex = -1;
                newMovieTitle.Enabled = false;
                newMovieDate.Enabled = false;
                newGenre.Enabled = false;
                newMovieTitle.Clear();
                newGenre.SelectedIndex = -1;
                DirectorBox2.Enabled = false;
                ProducerBox2.Enabled = false;
                ComposerBox2.Enabled = false;
                DirectorBox2.SelectedIndex = -1;
                ProducerBox2.SelectedIndex = -1;
                ComposerBox2.SelectedIndex = -1;
                updateMovie.Enabled = false;
                return;
            }
            int DirectorID = Convert.ToInt32(((ComboboxItem)DirectorBox2.SelectedItem).Key);
            int ProducerID = Convert.ToInt32(((ComboboxItem)ProducerBox2.SelectedItem).Key);
            int ComposerID = Convert.ToInt32(((ComboboxItem)ComposerBox2.SelectedItem).Key);
            int MovieID = Convert.ToInt32(((ComboboxItem)MovieBox2.SelectedItem).Key);

            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "UPDATE Movies SET Name ='" + newMovieTitle.Text + "', Year='" + newMovieDate.Value + "', Genre = '" + newGenre.Text +
                                               "', Director_ID = '" + DirectorID + "', Producer_ID = '" + ProducerID + "', Composer_ID = '" + ComposerID + "'" +
                                               "WHERE MovieID = '" + MovieID + "';";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            if (query.ExecuteNonQuery() != 0)
            {
                UpdateMovieStatus.Text = "Successfull!";
                UpdateMovieStatus.ForeColor = System.Drawing.Color.LimeGreen;
                UpdateMovieStatus.Show();
                updateDropLists(1);
                newMovieTitle.Enabled = false;
                newMovieDate.Enabled = false;
                newGenre.Enabled = false;
                newMovieTitle.Clear();
                newGenre.SelectedIndex = -1;
                DirectorBox2.Enabled = false;
                ProducerBox2.Enabled = false;
                ComposerBox2.Enabled = false;
                DirectorBox2.SelectedIndex = -1;
                ProducerBox2.SelectedIndex = -1;
                ComposerBox2.SelectedIndex = -1;
                updateMovie.Enabled = false;
            }
            else
            {
                UpdateMovieStatus.Text = "Unsuccessful!";
                UpdateMovieStatus.ForeColor = System.Drawing.Color.Red;
                UpdateMovieStatus.Show();
                newMovieTitle.Enabled = false;
                newMovieDate.Enabled = false;
                newGenre.Enabled = false;
                newMovieTitle.Clear();
                newGenre.SelectedIndex = -1;
                DirectorBox2.Enabled = false;
                ProducerBox2.Enabled = false;
                ComposerBox2.Enabled = false;
                DirectorBox2.SelectedIndex = -1;
                ProducerBox2.SelectedIndex = -1;
                ComposerBox2.SelectedIndex = -1;
                updateMovie.Enabled = false;
            }
        }

        private void MovieBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMovie.Enabled = true;
            newMovieTitle.Enabled = true;
            newMovieDate.Enabled = true;
            newGenre.Enabled = true;
            DirectorBox2.Enabled = true;
            ProducerBox2.Enabled = true;
            ComposerBox2.Enabled = true;
            if(MovieBox2.Text != "")
            {
                int MovieID = Convert.ToInt32(((ComboboxItem)MovieBox2.SelectedItem).Key);
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT MovieID, Name, Year, Genre, Director_ID, Producer_ID, Composer_ID" +
                         " FROM Movies " +
                         " WHERE(Movies.MovieID = '" + MovieID + "');";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                reader.Read();
                int cnt = 0;
                foreach (ComboboxItem i in DirectorBox2.Items)
                {
                    if(i.Key == (int)reader["Director_ID"])
                    {
                        DirectorBox2.SelectedIndex = cnt;
                        break;
                    }
                    cnt++;
                }
                cnt = 0;
                foreach (ComboboxItem i in ProducerBox2.Items)
                {
                    if (i.Key == (int)reader["Producer_ID"])
                    {
                        ProducerBox2.SelectedIndex = cnt;
                        break;
                    }
                    cnt++;
                }
                cnt = 0;
                foreach (ComboboxItem i in ComposerBox2.Items)
                {
                    if (i.Key == (int)reader["Composer_ID"])
                    {
                        ComposerBox2.SelectedIndex = cnt;
                        break;
                    }
                    cnt++;
                }
                cnt = 0;
                foreach (String i in newGenre.Items)
                {
                    if (i == (string)reader["Genre"] )
                    {
                        newGenre.SelectedIndex = cnt;
                        break;
                    }
                    cnt++;
                }
                newMovieTitle.Text = (string)reader["Name"];

            }
            

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if ( MovieBox3.Text == "" )
            {
                DeleteMovieStatus.Text = "Unsuccessful!";
                DeleteMovieStatus.ForeColor = System.Drawing.Color.Red;
                DeleteMovieStatus.Show();
                MovieBox3.SelectedIndex = -1;
                Delete.Enabled = false;
                return;
            }
            int MovieID = Convert.ToInt32(((ComboboxItem)MovieBox3.SelectedItem).Key);
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "DELETE FROM Rents WHERE Movie_ID = '" + MovieID + "'; " + "DELETE FROM FavMovies WHERE Movie_ID = '" + MovieID + "'; " + " DELETE FROM Roles WHERE Movie_ID = '" + MovieID + "'; " + "DELETE FROM Movies WHERE MovieID = '" + MovieID + "';";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            if (query.ExecuteNonQuery() != 0)  ///TODO CONFLICT
            {
                DeleteMovieStatus.Text = "Successfull!";
                DeleteMovieStatus.ForeColor = System.Drawing.Color.LimeGreen;
                DeleteMovieStatus.Show();
                updateDropLists(1);
                Delete.Enabled = false;
            }
            else
            {
                DeleteMovieStatus.Text = "Unsuccessful!";
                DeleteMovieStatus.ForeColor = System.Drawing.Color.Red;
                DeleteMovieStatus.Show();
                MovieBox3.SelectedIndex = -1;
                Delete.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (ActorBox2.Text == "")
            {
                DeleteActorStatus.Text = "Unsuccessful!";
                DeleteActorStatus.ForeColor = System.Drawing.Color.Red;
                DeleteActorStatus.Show();
                ActorBox2.SelectedIndex = -1;
                button9.Enabled = false;
                return;
            }
            int ActorID = Convert.ToInt32(((ComboboxItem)ActorBox2.SelectedItem).Key);
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "DELETE FROM FavActors WHERE Actor_ID = '" + ActorID + "'; " + "DELETE FROM Roles WHERE Actor_ID = '" + ActorID + "'; " + "DELETE FROM Actors WHERE ActorID = '" + ActorID + "';";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            if (query.ExecuteNonQuery() != 0)  ///TODO CONFLICT
            {
                DeleteActorStatus.Text = "Successfull!";
                DeleteActorStatus.ForeColor = System.Drawing.Color.LimeGreen;
                DeleteActorStatus.Show();
                updateDropLists(2);
                button9.Enabled = false;
            }
            else
            {
                DeleteActorStatus.Text = "Unsuccessful!";
                DeleteActorStatus.ForeColor = System.Drawing.Color.Red;
                DeleteActorStatus.Show();
                ActorBox2.SelectedIndex = -1;
                button9.Enabled = false;
            }
        }

        private void RoleName_TextChanged(object sender, EventArgs e)
        {
            AddRoles.Enabled = true;
        }

        private void MovieName_TextChanged(object sender, EventArgs e)
        {
            addMovie.Enabled = true;
        }

        private void MovieBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delete.Enabled = true;
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void ActorBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button9.Enabled = true;
        }

        public void updateRoles()
        {
            int ActorID = Convert.ToInt32(((ComboboxItem)ActorBox3.SelectedItem).Key);
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT Roles.RoleName AS Role, Movies.Name AS Movie, Roles.Movie_ID " +
                                "FROM Roles INNER JOIN " +
                                "Movies ON Roles.Movie_ID = Movies.MovieID " +
                                "WHERE Actor_ID = '" + ActorID + "'";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            SqlDataReader reader = query.ExecuteReader();
            RoleBox.Items.Clear();
            while (reader.Read())
            {
                RoleBox.Items.Add(new ComboboxItem1((int)reader["Movie_ID"], (string)reader["Role"], (string)reader["Movie"]));
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateRoles();
            RoleBox.Enabled = true;
        }

        private void RoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteRole.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (ActorBox3.Text == "" || RoleBox.Text == "")
            {
                DeleteRoleStatus.Text = "Unsuccessful!";
                DeleteRoleStatus.ForeColor = System.Drawing.Color.Red;
                DeleteRoleStatus.Show();
                ActorBox3.SelectedIndex = -1;
                DeleteRole.Enabled = false;
                return;
            }
            int ActorID = Convert.ToInt32(((ComboboxItem)ActorBox3.SelectedItem).Key);
            int MovieID = Convert.ToInt32(((ComboboxItem1)RoleBox.SelectedItem).Key);
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "DELETE FROM Roles WHERE Actor_ID = '" + ActorID + "' AND Movie_ID = '" + MovieID + "';";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            if (query.ExecuteNonQuery() != 0) 
            {
                DeleteRoleStatus.Text = "Successfull!";
                DeleteRoleStatus.ForeColor = System.Drawing.Color.LimeGreen;
                DeleteRoleStatus.Show();
                updateDropLists(6);
                DeleteRole.Enabled = false;
                RoleBox.Items.Clear();
                RoleBox.Enabled = false;
            }
            else
            {
                DeleteRoleStatus.Text = "Unsuccessful!";
                DeleteRoleStatus.ForeColor = System.Drawing.Color.Red;
                DeleteRoleStatus.Show();
            }
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        public Admin()
        {
            InitializeComponent();
            updateDropLists(0);
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void makeAdminButton_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            if (makeAdminField.Text == ""){
                makeAdminStatus.Text = "Enter a Username";
                makeAdminStatus.ForeColor = System.Drawing.Color.Red;
                makeAdminStatus.Show();
            }
            else
            {
                query.CommandText = "UPDATE Users SET isAdmin = 'True' WHERE Username = '" + makeAdminField.Text + "'";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                if(query.ExecuteNonQuery() != 0)
                {
                    makeAdminStatus.Text = "Successfully, Promoted!";
                    makeAdminStatus.ForeColor = System.Drawing.Color.LimeGreen;
                    makeAdminStatus.Show();
                }
                else
                {
                    makeAdminStatus.Text = "Unsuccessful! Not found.";
                    makeAdminStatus.ForeColor = System.Drawing.Color.Red;
                    makeAdminStatus.Show();
                }
            }
            makeAdminField.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            if (makeAdminField.Text == "")
            {
                makeAdminStatus.Text = "Enter a Username";
                makeAdminStatus.ForeColor = System.Drawing.Color.Red;
                makeAdminStatus.Show();
            }
            else if (makeAdminField.Text == username)
            {
                makeAdminStatus.Text = "Can't demote yourself lol";
                makeAdminStatus.ForeColor = System.Drawing.Color.Red;
                makeAdminStatus.Show();
            }
            else
            {
                query.CommandText = "UPDATE Users SET isAdmin = 'True' WHERE Username = '" + makeAdminField.Text + "'";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                if (query.ExecuteNonQuery() != 0)
                {
                    makeAdminStatus.Text = "Successfully, Demoted!";
                    makeAdminStatus.ForeColor = System.Drawing.Color.LimeGreen;
                    makeAdminStatus.Show();
                }
                else
                {
                    makeAdminStatus.Text = "Unsuccessful! Not found.";
                    makeAdminStatus.ForeColor = System.Drawing.Color.Red;
                    makeAdminStatus.Show();
                }
            }
        }
    }
}
