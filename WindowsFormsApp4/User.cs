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

   
    public partial class User : Form
    {
        int ID;
        string username, name, email, address, phone, birthday;
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
        public User(int IDx)
        {
            ID = IDx;
            InitializeComponent();
            updateRentBox();
            updateFavMovie();
            updateFavActor();
            expireDate.Value = DateTime.Now.Date;
        }
        class Movie
        {
            public int Key;
            public int KeyD;
            public int KeyP;
            public int KeyC;
            public string Name;
            public DateTime Year;
            public string Genre;
            public string Director;
            public string Producer;
            public string Composer;

            public Movie(int key, string name, DateTime year,string genre, string director, string producer, string composer, int keyD, int keyP, int keyC)
            {
                Key = key;
                Name = name;
                Year = year;
                Genre = genre;
                Director = director;
                Producer = producer;
                Composer = composer;
                KeyC = keyC;
                KeyP = keyP;
                KeyD = keyD;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        class RentItem
        {
            public int Key;
            public string Name;
            public DateTime startDate;
            public DateTime expireDate;
            public double Price;
            public RentItem(int key, string name, DateTime year, DateTime expire, double price)
            {
                Key = key;
                Name = name;
                startDate = year;
                expireDate = expire;
                Price = price;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        class ActorRole
        {
            public int Key;
            public string Name;
            public DateTime bYear;
            public DateTime sYear;
            public string Role;
            public ActorRole(int key, string name, DateTime byear, DateTime syear, string role)
            {
                Key = key;
                Name = name;
                bYear = byear;
                sYear = syear;
                Role = role;
            }
            public override string ToString()
            {
                return Role;
            }
        }

        class Actor
        {
            public int Key;
            public string Name;
            public Actor(int key, string name)
            {
                Key = key;
                Name = name;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT Movies.MovieID, Movies.Name, Movies.Year, Movies.Genre, Composers.ComposersID, Composers.Name AS Composer, Directors.DirectorID, Directors.Name AS Director, Producers.ProducerID, " +
                         " Producers.Name AS Producer" +
                         " FROM            Movies INNER JOIN" +
                         " Composers ON Movies.Composer_ID = Composers.ComposersID INNER JOIN" +
                         " Directors ON Movies.Director_ID = Directors.DirectorID INNER JOIN" +
                         " Producers ON Movies.Producer_ID = Producers.ProducerID" +
                         " ORDER BY Movies.Name";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            SqlDataReader reader = query.ExecuteReader();
            QueryBox.Items.Clear();
            while(reader.Read())
            {
                int Key = (int)reader[0];
                string Name = (string)reader[1];
                DateTime myTime = DateTime.Parse(reader[2].ToString());
                string Genre = (string)reader[3];
                string Director = (string)reader[7];
                string Producer = (string)reader[9];
                string Composer = (string)reader[5];
                int KeyD = (int)reader[6];
                int KeyP = (int)reader[8];
                int KeyC = (int)reader[4];
                QueryBox.Items.Add(new Movie( Key, Name, myTime, Genre , Director, Producer, Composer ,KeyD , KeyP, KeyC));
            }
            searchText.Text = "Showing All Movies";
            updateMovieActors(-1);
            updateRent();
        }

        private void updateMovieActors(int ID)
        {
            if(ID == -1)
            {
                ActorBox.Items.Clear();
                return;
            }
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT        Actors.ActorID, Actors.Name, Actors.BirthDate, Actors.StartDate, Roles.RoleName" +
                                " FROM Movies INNER JOIN" +
                                " Roles ON Movies.MovieID = Roles.Movie_ID INNER JOIN" +
                                " Actors ON Roles.Actor_ID = Actors.ActorID WHERE Movies.MovieID = '" + ID + "'" +
                                " ORDER BY Roles.RoleName" + ";";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            SqlDataReader reader = query.ExecuteReader();
            ActorBox.Items.Clear();
            while (reader.Read())
            {
                int Key = (int)reader[0];
                string Name = (string)reader[1];
                DateTime bDate = DateTime.Parse(reader[2].ToString());
                DateTime sDate = DateTime.Parse(reader[3].ToString());
                string Role = (string)reader[4];
                ActorBox.Items.Add(new ActorRole(Key, Name, bDate, sDate, Role));
            }
        }


        private void updateRentBox()
        {
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText =  " SELECT Movies.MovieID, Movies.Name, Rents.StartDate, Rents.ExpireDate, Rents.Paid " +
                                 " FROM Rents INNER JOIN Movies " +
                                 " ON Rents.Movie_ID = Movies.MovieID " +
                                 " WHERE User_ID = " + ID +
                                 " ORDER BY Rents.StartDate";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            SqlDataReader reader = query.ExecuteReader();
            RentBox.Items.Clear();
            while (reader.Read())
            {
                int Key = (int)reader[0];
                string Name = (string)reader[1];
                DateTime sDate = DateTime.Parse(reader[2].ToString());
                DateTime eDate = DateTime.Parse(reader[3].ToString());
                double Paid = (double)reader[4];
                double DaysLeft = (eDate.Date - DateTime.Now.Date).Days;
                if(DaysLeft > 0)
                    RentBox.Items.Add(new RentItem(Key,Name,sDate,eDate,Paid));
            }
            DeleteRent.Enabled = false;
            ExtendButton.Enabled = false;
            clearRentLabels();
        }

        private void updateFavActor()
        {
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = " SELECT FavActors.Actor_ID, Actors.Name " +
                                 " FROM FavActors INNER JOIN Actors ON FavActors.Actor_ID = Actors.ActorID " +
                                 " WHERE User_ID = " + ID + ";";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            SqlDataReader reader = query.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(new Actor((int)reader[0],(string)reader[1]));
            }
        }

        private void updateFavMovie()
        {
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText =  " SELECT FavMovies.Movie_ID, Movies.Name " +
                                 " FROM FavMovies INNER JOIN Movies ON FavMovies.Movie_ID = Movies.MovieID " +
                                 " WHERE User_ID = " + ID + ";";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            SqlDataReader reader = query.ExecuteReader();
            listBox2.Items.Clear();
            while (reader.Read())
            {
                listBox2.Items.Add(new Movie((int)reader[0], (string)reader[1], DateTime.Now, "", "", "", "", 0,0,0));
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'popcorniaDataSet1.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.popcorniaDataSet1.Movies);

        }
        private void clearActorRoleBox()
        {
            movieTitle.Clear();
            movieGenre.Clear();
            movieYear.Clear();
            movieDirector.Clear();
            movieProducer.Clear();
            movieComposer.Clear();
            ActorBox.Items.Clear();
            searchByRoleActor.Enabled = false;
            searchByRoleActor.Text = "";
            SearchByActor.Text = "";
        }
        private void QueryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                clearActorRoleBox();
                if (QueryBox.SelectedIndex == -1)
                {
                updateRent();
                return;
                }
                  
                Movie movie = (Movie)QueryBox.SelectedItem;
                movieTitle.Text = movie.Name;
                movieGenre.Text = movie.Genre;
                movieYear.Text = movie.Year.Year.ToString();
                movieDirector.Text = movie.Director;
                movieProducer.Text = movie.Producer;
                movieComposer.Text = movie.Composer;
                updateMovieActors(movie.Key);
                updateRent();
                expireDate.Enabled = true;
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT * FROM FavMovies WHERE User_ID = '" + ID + "' AND Movie_ID = '" + movie.Key + "';";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                FAV2.Text = "★";
                while (reader.Read())
                {
                    FAV2.Text = "☆";
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (movieSearch.Text == "" && searchType.Text != "Genre")
                return;
            if(searchType.Text == "Name")
            {
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT Movies.MovieID, Movies.Name, Movies.Year, Movies.Genre, Composers.ComposersID, Composers.Name AS Composer, Directors.DirectorID, Directors.Name AS Director, Producers.ProducerID, " +
                             " Producers.Name AS Producer" +
                             " FROM            Movies INNER JOIN" +
                             " Composers ON Movies.Composer_ID = Composers.ComposersID INNER JOIN" +
                             " Directors ON Movies.Director_ID = Directors.DirectorID INNER JOIN" +
                             " Producers ON Movies.Producer_ID = Producers.ProducerID" +
                             " WHERE Movies.Name LIKE '%" + movieSearch.Text + "%'" +
                             " ORDER BY Movies.Name";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                QueryBox.Items.Clear();
                clearActorRoleBox();
                while (reader.Read())
                {
                    int Key = (int)reader[0];
                    string Name = (string)reader[1];
                    DateTime myTime = DateTime.Parse(reader[2].ToString());
                    string Genre = (string)reader[3];
                    string Director = (string)reader[7];
                    string Producer = (string)reader[9];
                    string Composer = (string)reader[5];
                    int KeyD = (int)reader[6];
                    int KeyP = (int)reader[8];
                    int KeyC = (int)reader[4];
                    QueryBox.Items.Add(new Movie(Key, Name, myTime, Genre, Director, Producer, Composer, KeyD, KeyP, KeyC));
                }
                searchText.Text = "Showing Results for \"" + movieSearch.Text + "\" by Title Name";
                
            }

            if (searchType.Text == "Actor")
            {
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = 
                             " SELECT Movies.MovieID, Movies.Name, Movies.Year, Movies.Genre, Composers.ComposersID, Composers.Name AS Composer, Directors.DirectorID, Directors.Name AS Director, Producers.ProducerID, " +
                             " Producers.Name AS Producer" +
                             " FROM            Movies INNER JOIN" +
                             " Composers ON Movies.Composer_ID = Composers.ComposersID INNER JOIN" +
                             " Directors ON Movies.Director_ID = Directors.DirectorID INNER JOIN" +
                             " Producers ON Movies.Producer_ID = Producers.ProducerID" +
                             " WHERE Movies.MovieID in ( SELECT Roles.Movie_ID FROM Actors as actorinner INNER JOIN Roles ON actorinner.ActorID = Roles.Actor_ID INNER JOIN Movies AS moviesInner ON Roles.Movie_ID = moviesInner.MovieID " +
                             " WHERE actorinner.Name LIKE '%" + movieSearch.Text + "%')";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                QueryBox.Items.Clear();
                clearActorRoleBox();
                while (reader.Read())
                {
                    int Key = (int)reader[0];
                    string Name = (string)reader[1];
                    DateTime myTime = DateTime.Parse(reader[2].ToString());
                    string Genre = (string)reader[3];
                    string Director = (string)reader[7];
                    string Producer = (string)reader[9];
                    string Composer = (string)reader[5];
                    int KeyD = (int)reader[6];
                    int KeyP = (int)reader[8];
                    int KeyC = (int)reader[4];
                    QueryBox.Items.Add(new Movie(Key, Name, myTime, Genre, Director, Producer, Composer, KeyD, KeyP, KeyC));
                }
                searchText.Text = "Showing Results for \"" + movieSearch.Text + "\" by Actor";
            }

            if (searchType.Text == "Role")
            {
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText =
                             " SELECT Movies.MovieID, Movies.Name, Movies.Year, Movies.Genre, Composers.ComposersID, Composers.Name AS Composer, Directors.DirectorID, Directors.Name AS Director, Producers.ProducerID, " +
                             " Producers.Name AS Producer" +
                             " FROM            Movies INNER JOIN" +
                             " Composers ON Movies.Composer_ID = Composers.ComposersID INNER JOIN" +
                             " Directors ON Movies.Director_ID = Directors.DirectorID INNER JOIN" +
                             " Producers ON Movies.Producer_ID = Producers.ProducerID" +
                             " WHERE Movies.MovieID in ( SELECT Roles.Movie_ID FROM Actors as actorinner INNER JOIN Roles ON actorinner.ActorID = Roles.Actor_ID INNER JOIN Movies AS moviesInner ON Roles.Movie_ID = moviesInner.MovieID " +
                             " WHERE Roles.RoleName LIKE '%" + movieSearch.Text + "%')";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                QueryBox.Items.Clear();
                clearActorRoleBox();
                while (reader.Read())
                {
                    int Key = (int)reader[0];
                    string Name = (string)reader[1];
                    DateTime myTime = DateTime.Parse(reader[2].ToString());
                    string Genre = (string)reader[3];
                    string Director = (string)reader[7];
                    string Producer = (string)reader[9];
                    string Composer = (string)reader[5];
                    int KeyD = (int)reader[6];
                    int KeyP = (int)reader[8];
                    int KeyC = (int)reader[4];
                    QueryBox.Items.Add(new Movie(Key, Name, myTime, Genre, Director, Producer, Composer, KeyD, KeyP, KeyC));
                }
                searchText.Text = "Showing Results for \"" + movieSearch.Text + "\" by Role";
            }

            if (searchType.Text == "Genre")
            {
                if (GenreBox.SelectedIndex == -1)
                    return;
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT Movies.MovieID, Movies.Name, Movies.Year, Movies.Genre, Composers.ComposersID, Composers.Name AS Composer, Directors.DirectorID, Directors.Name AS Director, Producers.ProducerID, " +
                             " Producers.Name AS Producer" +
                             " FROM            Movies INNER JOIN" +
                             " Composers ON Movies.Composer_ID = Composers.ComposersID INNER JOIN" +
                             " Directors ON Movies.Director_ID = Directors.DirectorID INNER JOIN" +
                             " Producers ON Movies.Producer_ID = Producers.ProducerID" +
                             " WHERE Movies.Genre = '" + GenreBox.Text + "'" +
                             " ORDER BY Movies.Name";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                QueryBox.Items.Clear();
                clearActorRoleBox();
                while (reader.Read())
                {
                    int Key = (int)reader[0];
                    string Name = (string)reader[1];
                    DateTime myTime = DateTime.Parse(reader[2].ToString());
                    string Genre = (string)reader[3];
                    string Director = (string)reader[7];
                    string Producer = (string)reader[9];
                    string Composer = (string)reader[5];
                    int KeyD = (int)reader[6];
                    int KeyP = (int)reader[8];
                    int KeyC = (int)reader[4];
                    QueryBox.Items.Add(new Movie(Key, Name, myTime, Genre, Director, Producer, Composer, KeyD, KeyP, KeyC));
                }
                searchText.Text = "Showing Results for " + GenreBox.Text + " Movies ";
            }

            if (searchType.Text == "Director")
            {
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT Movies.MovieID, Movies.Name, Movies.Year, Movies.Genre, Composers.ComposersID, Composers.Name AS Composer, Directors.DirectorID, Directors.Name AS Director, Producers.ProducerID, " +
                             " Producers.Name AS Producer" +
                             " FROM            Movies INNER JOIN" +
                             " Composers ON Movies.Composer_ID = Composers.ComposersID INNER JOIN" +
                             " Directors ON Movies.Director_ID = Directors.DirectorID INNER JOIN" +
                             " Producers ON Movies.Producer_ID = Producers.ProducerID" +
                             " WHERE Directors.Name LIKE '%" + movieSearch.Text + "%'" +
                             " ORDER BY Movies.Name";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                QueryBox.Items.Clear();
                clearActorRoleBox();
                while (reader.Read())
                {
                    int Key = (int)reader[0];
                    string Name = (string)reader[1];
                    DateTime myTime = DateTime.Parse(reader[2].ToString());
                    string Genre = (string)reader[3];
                    string Director = (string)reader[7];
                    string Producer = (string)reader[9];
                    string Composer = (string)reader[5];
                    int KeyD = (int)reader[6];
                    int KeyP = (int)reader[8];
                    int KeyC = (int)reader[4];
                    QueryBox.Items.Add(new Movie(Key, Name, myTime, Genre, Director, Producer, Composer, KeyD, KeyP, KeyC));
                }
                searchText.Text = "Showing Results for \"" + movieSearch.Text + "\" by Director";
            }

            if (searchType.Text == "Producer")
            {
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT Movies.MovieID, Movies.Name, Movies.Year, Movies.Genre, Composers.ComposersID, Composers.Name AS Composer, Directors.DirectorID, Directors.Name AS Director, Producers.ProducerID, " +
                             " Producers.Name AS Producer" +
                             " FROM            Movies INNER JOIN" +
                             " Composers ON Movies.Composer_ID = Composers.ComposersID INNER JOIN" +
                             " Directors ON Movies.Director_ID = Directors.DirectorID INNER JOIN" +
                             " Producers ON Movies.Producer_ID = Producers.ProducerID" +
                             " WHERE Producers.Name LIKE '%" + movieSearch.Text + "%'" +
                             " ORDER BY Movies.Name";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                QueryBox.Items.Clear();
                clearActorRoleBox();
                while (reader.Read())
                {
                    int Key = (int)reader[0];
                    string Name = (string)reader[1];
                    DateTime myTime = DateTime.Parse(reader[2].ToString());
                    string Genre = (string)reader[3];
                    string Director = (string)reader[7];
                    string Producer = (string)reader[9];
                    string Composer = (string)reader[5];
                    int KeyD = (int)reader[6];
                    int KeyP = (int)reader[8];
                    int KeyC = (int)reader[4];
                    QueryBox.Items.Add(new Movie(Key, Name, myTime, Genre, Director, Producer, Composer, KeyD, KeyP, KeyC));
                }
                searchText.Text = "Showing Results for \"" + movieSearch.Text + "\" by Producer";
            }

            if (searchType.Text == "Composer")
            {
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT Movies.MovieID, Movies.Name, Movies.Year, Movies.Genre, Composers.ComposersID, Composers.Name AS Composer, Directors.DirectorID, Directors.Name AS Director, Producers.ProducerID, " +
                             " Producers.Name AS Producer" +
                             " FROM            Movies INNER JOIN" +
                             " Composers ON Movies.Composer_ID = Composers.ComposersID INNER JOIN" +
                             " Directors ON Movies.Director_ID = Directors.DirectorID INNER JOIN" +
                             " Producers ON Movies.Producer_ID = Producers.ProducerID" +
                             " WHERE Composers.Name LIKE '%" + movieSearch.Text + "%'" +
                             " ORDER BY Movies.Name";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                QueryBox.Items.Clear();
                clearActorRoleBox();
                while (reader.Read())
                {
                    int Key = (int)reader[0];
                    string Name = (string)reader[1];
                    DateTime myTime = DateTime.Parse(reader[2].ToString());
                    string Genre = (string)reader[3];
                    string Director = (string)reader[7];
                    string Producer = (string)reader[9];
                    string Composer = (string)reader[5];
                    int KeyD = (int)reader[6];
                    int KeyP = (int)reader[8];
                    int KeyC = (int)reader[4];
                    QueryBox.Items.Add(new Movie(Key, Name, myTime, Genre, Director, Producer, Composer, KeyD, KeyP, KeyC));
                }
                searchText.Text = "Showing Results for \"" + movieSearch.Text + "\" by Composer";
            }

            updateMovieActors(-1);
            updateRent();
        }

        

        private void ActorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActorBox.Items.Count == 0 || ActorBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                searchByRoleActor.Enabled = true;
                ActorRole x = (ActorRole)ActorBox.SelectedItem;

                SearchByActor.Text = x.Name;
                searchByRoleActor.Text = "Movies By " + x.Name;

                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT * FROM FavActors WHERE User_ID = '" + ID + "' AND Actor_ID = '" + x.Key + "';";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                FAV.Text = "★";
                while (reader.Read())
                {
                    FAV.Text = "☆";
                }
            }
        }

        private void searchByRoleActor_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string name = ((ActorRole)ActorBox.SelectedItem).Name;
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT Movies.MovieID, Movies.Name, Movies.Year, Movies.Genre, Composers.ComposersID, Composers.Name AS Composer, Directors.DirectorID, Directors.Name AS Director, Producers.ProducerID, " +
                         " Producers.Name AS Producer" +
                         " FROM            Movies INNER JOIN" +
                         " Composers ON Movies.Composer_ID = Composers.ComposersID INNER JOIN" +
                         " Directors ON Movies.Director_ID = Directors.DirectorID INNER JOIN" +
                         " Producers ON Movies.Producer_ID = Producers.ProducerID" +
                         " WHERE Movies.MovieID IN ( SELECT Movie_ID FROM Roles WHERE Actor_ID = '" + ((ActorRole)ActorBox.SelectedItem).Key +"' )"+
                         " ORDER BY Movies.Name";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            SqlDataReader reader = query.ExecuteReader();
            QueryBox.Items.Clear();
            clearActorRoleBox();
            while (reader.Read())
            {
                int Key = (int)reader[0];
                string Name = (string)reader[1];
                DateTime myTime = DateTime.Parse(reader[2].ToString());
                string Genre = (string)reader[3];
                string Director = (string)reader[7];
                string Producer = (string)reader[9];
                string Composer = (string)reader[5];
                int KeyD = (int)reader[6];
                int KeyP = (int)reader[8];
                int KeyC = (int)reader[4];
                QueryBox.Items.Add(new Movie(Key, Name, myTime, Genre, Director, Producer, Composer, KeyD, KeyP, KeyC));
            }
            searchText.Text = "Showing Movies \"" + name + "\" Starred in";
            updateMovieActors(-1);
            updateRent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            movieSearch.Enabled = true;
            if (searchType.Text == "Genre")
            {
                GenreBox.Visible = true;
                GenreBox.Enabled = true;
                GenreBox.SelectedIndex = -1;
                movieSearch.Clear();
                movieSearch.Visible = false;
            }
            else
            {
                movieSearch.Visible = true;
                GenreBox.Visible = false;
                GenreBox.Enabled = false;
                GenreBox.SelectedIndex = -1;
            }
        }

        private void SearchByActor_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateRent()
        {

            if(QueryBox.SelectedIndex == -1)
            {
                nDays.Text = "0";
                nTotal.Text = "0 $";
                label13.Text = "";
                Rent.Enabled = false;
                return;
            }
            DateTime expDATE = expireDate.Value;
            DateTime now = DateTime.Now;
            int days = (int)(expDATE.Date - now.Date).TotalDays;
            label13.Text = ((Movie)QueryBox.SelectedItem).Name;
            nDays.Text = days.ToString();
            nTotal.Text = (days * 4).ToString() + " $";
            if (days > 0)
            {
                Rent.Enabled = true;
            }
            else
            {
                Rent.Enabled = false;
                return;
            }
               
        }
        private void clearRentLabels()
        {
            rentTitle.Clear();
            rentSDate.Clear();
            rentRDate.Clear();
            rentDaysLeft.Clear();
            rentPrice.Clear();
            DeleteRent.Enabled = false;
            ExtendButton.Enabled = false;

        }
        private void RentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RentBox.SelectedIndex == -1)
            {
                clearRentLabels();
                return;
            }
            RentItem item = (RentItem)RentBox.SelectedItem;
            rentTitle.Text = item.Name;
            rentSDate.Text = item.startDate.ToShortDateString();
            rentRDate.Text = item.expireDate.ToShortDateString();
            rentDaysLeft.Text = (item.expireDate.Date - DateTime.Now.Date).TotalDays.ToString();
            rentPrice.Text = item.Price.ToString();
            DeleteRent.Enabled = true;
            ExtendButton.Enabled = true;
        }

        private void DeleteRent_Click(object sender, EventArgs e)
        {
            RentItem item = (RentItem)RentBox.SelectedItem;
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "DELETE FROM Rents WHERE User_ID = '" + ID + "' AND Movie_ID = '" + item.Key + "';";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            if (query.ExecuteNonQuery() != 0)
            {
                int MoneyLeft = (int)(item.expireDate.Date - DateTime.Now.Date).TotalDays * 4;
                updateRentBox();
                MessageBox.Show("Returned \"" + item.Name + "\" Successfully, Money Returned: +" + MoneyLeft + "$");
                
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void ExtendButton_Click(object sender, EventArgs e)
        {
            confirmButton.Enabled = false;
            ExtendButton.Enabled = false;
            extraDays.Value = 0;
            extraDays.Visible = true;
            extraMoney.Visible = true;
            confirmButton.Visible = true;
            DeleteRent.Enabled = false;
            label20.Visible = true;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            RentItem item = (RentItem)RentBox.SelectedItem;
            DateTime newDate = item.expireDate.AddDays((int)extraDays.Value);
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "UPDATE Rents SET ExpireDate = '" + newDate + "', Paid = '" + (item.Price + (int)extraDays.Value*4) + "'WHERE User_ID = '" + ID + "' AND Movie_ID = '" + item.Key + "';";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            if (query.ExecuteNonQuery() != 0)
            {
                int MoneyLeft = (int)(item.expireDate.Date - DateTime.Now.Date).TotalDays * 4;
                MessageBox.Show("Extended \"" + item.Name + "\" Successfully, new Expire Date: " + newDate.ToShortDateString() + ", Extra paid: " + (int)extraDays.Value * 4 + "$");
            }
            else
            {
                MessageBox.Show("Error");
            }
            extraMoney.ResetText();
            label20.Visible = false;
            extraDays.Visible = false;
            extraMoney.Visible = false;
            confirmButton.Visible = false;
            ExtendButton.Enabled = true;
            DeleteRent.Enabled = true;
            updateRentBox();
        }

        private void extraDays_ValueChanged(object sender, EventArgs e)
        {
            confirmButton.Enabled = true;
            extraMoney.Text = extraDays.Value * 4 + "$";
        }

        private void FAV_Click(object sender, EventArgs e)
        {
            if (ActorBox.SelectedIndex == -1)
                return;
            ActorRole x = (ActorRole)ActorBox.SelectedItem;
            if (FAV.Text == "★")
            {
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "INSERT INTO FavActors VALUES (" + x.Key + ", " + ID + ");";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                FAV.Text = "☆";
            }
            else
            {
                Movie movie = (Movie)QueryBox.SelectedItem;
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "DELETE FROM FavActors WHERE User_ID = '" + ID + "' AND Actor_ID = '" + x.Key + "';";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                FAV.Text = "★";
            }
            updateFavActor();
        }

        private void FAV2_Click(object sender, EventArgs e)
        {

        }

        private void FAV2_Click_1(object sender, EventArgs e)
        {
            if (QueryBox.SelectedIndex == -1)
                return;
            Movie x = (Movie)QueryBox.SelectedItem;
            if (FAV2.Text == "★")
            {
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "INSERT INTO FavMovies VALUES (" + x.Key + ", " + ID + ");";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                FAV2.Text = "☆";
            }
            else
            {
                Movie movie = (Movie)QueryBox.SelectedItem;
                String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand query = new SqlCommand();
                query.CommandText = "DELETE FROM FavMovies WHERE User_ID = '" + ID + "' AND Movie_ID = '" + x.Key + "';";
                query.Connection = connection;
                query.CommandType = CommandType.Text;
                SqlDataReader reader = query.ExecuteReader();
                FAV2.Text = "★";
            }
            updateFavMovie();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            updateRent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Rent_Click(object sender, EventArgs e)
        {

            if (QueryBox.SelectedIndex == -1)
            {
               return;
            }
            int MovieID = Convert.ToInt32(((Movie)QueryBox.SelectedItem).Key);
            String Name = ((Movie)QueryBox.SelectedItem).Name;
            int nDays = (int)(expireDate.Value.Date - DateTime.Now.Date).TotalDays;
            int Price = nDays * 4;
            String conString = @"Data Source=SHERIF\SQLEXPRESS;Initial Catalog=PopCornia;Persist Security Info=True;User ID=sa;Password=123456";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO Rents(User_ID, Movie_ID, StartDate, ExpireDate, Paid) VALUES ('" +
              ID + "', '" +
              MovieID + "', '" +
              DateTime.Now + "', '" +
              expireDate.Value + "', '" +
              Price +
               "');";
            query.Connection = connection;
            query.CommandType = CommandType.Text;
            try
            {
                query.ExecuteNonQuery();
                clearRentLabels();
                updateRentBox();
                MessageBox.Show("You Successfully rented \"" + Name + "\" for " + nDays + " day.");
            }
            catch (Exception x)
            {
                MessageBox.Show("You have already rented this movie.");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
