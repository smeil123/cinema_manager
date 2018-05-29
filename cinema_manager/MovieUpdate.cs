using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace cinema_manager
{
    public partial class MovieUpdate : UserControl
    {
        private static MovieUpdate _instance;
        private OracleCommand oraCommand;
        private Form1 form;
        private int seleted_movieno;
        private Dictionary<string, string> changed_item;// = new Dictionary<string, string>();
        private Dictionary<string, string> movie_item;// = new Dictionary<string, string>();

        public static MovieUpdate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieUpdate();
                }
                return _instance;
            }
        }
        public MovieUpdate()
        {
            InitializeComponent();
        }

        private void MovieUpdate_Load(object sender, EventArgs e)
        {
            form = new Form1();
            seleted_movieno = 0;
        }

        public void ViewDataGridView1()
        {
            dataGridView1.Rows.Clear();

            changed_item = new Dictionary<string, string>();
            movie_item = new Dictionary<string, string>();
            int index;

            OracleDataReader reader = oraCommand.ExecuteReader();
            while (reader.Read())
            {
                index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = reader["MOVIE_NO"];
                dataGridView1.Rows[index].Cells[1].Value = reader["MOVIE_NM"];
                dataGridView1.Rows[index].Cells[2].Value = reader["SHOW_TIME"];
                dataGridView1.Rows[index].Cells[3].Value = reader["DIRECTOR_NM"];
                dataGridView1.Rows[index].Cells[4].Value = reader["ACTOR_NM"];
                dataGridView1.Rows[index].Cells[5].Value = reader["DISTRIBUTOR"];
                dataGridView1.Rows[index].Cells[6].Value = reader["RELEASE_DATE"];
                dataGridView1.Rows[index].Cells[7].Value = reader["RATING"];
                dataGridView1.Rows[index].Cells[8].Value = reader["GENRE"];
                dataGridView1.Rows[index].Cells[9].Value = reader["COUNTRY"];
                dataGridView1.Rows[index].Cells[10].Value = reader["POSTER"];
                dataGridView1.Rows[index].Cells[11].Value = reader["SHOW_STAT"];
                dataGridView1.Rows[index].Cells[12].Value = reader["MOVIE_INTRO"];
            }

        }
        public void textbox_clear()
        {
            seleted_movieno = 0;
            try
            {
                movie_item.Clear();
                changed_item.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).Text = String.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (movieNmText.Text != null && !string.IsNullOrWhiteSpace(movieNmText.Text))
            {
                string sql = "select * from MOVIE where MOVIE_NM LIKE'%" + movieNmText.Text + "%' order by MOVIE_NO";
                Console.WriteLine(sql);
                oraCommand = new OracleCommand(sql, form.con);

                textbox_clear();
                ViewDataGridView1();
            }

        }

        private void allButton_Click(object sender, EventArgs e)
        {
            string sql = "select * from MOVIE order by MOVIE_NO";
            oraCommand = new OracleCommand(sql, form.con);
            textbox_clear();
            ViewDataGridView1();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textbox_clear();
            try
            {
                string movieno = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                seleted_movieno = Int32.Parse(movieno);
                string release = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();

                string year = release.Substring(0, 4);
                string month = release.Substring(5, 2);
                string day = release.Substring(8, 2);

                movie_item.Add("MOVIE_NM", dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                movie_item.Add("SHOW_TIME", dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                movie_item.Add("DIRECTOR_NM", dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                movie_item.Add("ACTOR_NM", dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                movie_item.Add("DISTRIBUTOR", dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                movie_item.Add("RELEASE_DATE", release.Substring(0, 10));
                movie_item.Add("RATING", dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
                movie_item.Add("GENRE", dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());
                movie_item.Add("COUNTRY", dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString());
                movie_item.Add("POSTER", dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString());
                movie_item.Add("SHOW_STAT", dataGridView1.Rows[e.RowIndex].Cells[11].FormattedValue.ToString());
                Console.WriteLine("dataGridView1_CellClick error11111");

                movienameText.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                showtimeText.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                directorText.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                actorText.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                distributorText.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                Console.WriteLine("dataGridView1_CellClick error2222222");

                release1.Text = year;
                release2.Text = month;
                release3.Text = day;
                Console.WriteLine("dataGridView1_CellClick error3333333");

                ratingbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
                genreText.Text = dataGridView1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                countryText.Text = dataGridView1.Rows[e.RowIndex].Cells[9].FormattedValue.ToString();
                posterText.Text = dataGridView1.Rows[e.RowIndex].Cells[10].FormattedValue.ToString();
                showstatBox.Text = dataGridView1.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
                //intro.Text = dataGridView1.Rows[e.RowIndex].Cells[12].FormattedValue.ToString();

            }
            catch (Exception)
            {
                Console.WriteLine("dataGridView1_CellClick error!!!!!!");
            }
        }

        private void textchange_Check()
        {
            if (movienameText.Text != null && !string.IsNullOrWhiteSpace(movienameText.Text))
                if (movie_item["MOVIE_NM"] != movienameText.Text)
                    changed_item.Add("MOVIE_NM", movienameText.Text);

            if (showtimeText.Text != null && !string.IsNullOrWhiteSpace(showtimeText.Text))
                if (movie_item["SHOW_TIME"] != showtimeText.Text)
                    changed_item.Add("SHOW_TIME", showtimeText.Text);

            if (directorText.Text != null && !string.IsNullOrWhiteSpace(directorText.Text))
                if (movie_item["DIRECTOR_NM"] != directorText.Text)
                    changed_item.Add("DIRECTOR_NM", directorText.Text);

            if (actorText.Text != null && !string.IsNullOrWhiteSpace(actorText.Text))
                if (movie_item["ACTOR_NM"] != actorText.Text)
                    changed_item.Add("ACTOR_NM", actorText.Text);

            if (distributorText.Text != null && !string.IsNullOrWhiteSpace(distributorText.Text))
                if (movie_item["DISTRIBUTOR"] != distributorText.Text)
                    changed_item.Add("DISTRIBUTOR", distributorText.Text);

            if (ratingbox.Text != null && !string.IsNullOrWhiteSpace(ratingbox.Text))
                if (movie_item["RATING"] != ratingbox.Text)
                    changed_item.Add("RATING", ratingbox.Text);

            if (genreText.Text != null && !string.IsNullOrWhiteSpace(genreText.Text))
                if (movie_item["GENRE"] != genreText.Text)
                    changed_item.Add("GENRE", genreText.Text);

            if (countryText.Text != null && !string.IsNullOrWhiteSpace(countryText.Text))
                if (movie_item["COUNTRY"] != countryText.Text)
                    changed_item.Add("COUNTRY", countryText.Text);

            if (posterText.Text != null && !string.IsNullOrWhiteSpace(posterText.Text))
                if (movie_item["POSTER"] != posterText.Text)
                    changed_item.Add("POSTER", posterText.Text);

            if (showstatBox.Text != null && !string.IsNullOrWhiteSpace(showstatBox.Text))
                if (movie_item["SHOW_STAT"] != showstatBox.Text)
                    changed_item.Add("SHOW_STAT", showstatBox.Text);

            if (release1.Text != null && !string.IsNullOrWhiteSpace(release1.Text))
                if (movie_item["RELEASE_DATE"].Substring(0, 4) != release1.Text)
                {
                    string date = release1.Text + "-" + release2.Text + "-" + release3.Text;
                    changed_item.Add("RELEASE_DATE", date);
                }

            if (release2.Text != null && !string.IsNullOrWhiteSpace(release2.Text))
                if (movie_item["RELEASE_DATE"].Substring(5, 2) != release2.Text)
                {
                    string date = release1.Text + "-" + release2.Text + "-" + release3.Text;
                    changed_item.Add("RELEASE_DATE", date);
                }
        
            if (release3.Text != null && !string.IsNullOrWhiteSpace(release3.Text))
                if (movie_item["RELEASE_DATE"].Substring(8, 2) != release3.Text)
                {
                    string date = release1.Text + "-" + release2.Text + "-" + release3.Text;
                    changed_item.Add("RELEASE_DATE", date);                   
                }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (seleted_movieno != 0)
            {
                string u_sql = "update MOVIE set {0}='{1}' where MOVIE_NO = " + seleted_movieno;
                textchange_Check();
                try
                {
                    foreach (string key in changed_item.Keys)
                    {
                        if (key == "RELEASE_DATE")
                        {
                            u_sql = "update MOVIE set {0}=to_date('{1}','yyyy-mm-dd') where MOVIE_NO = " + seleted_movieno;
                        }
                        string value;
                        changed_item.TryGetValue(key, out value);
                        string sql = String.Format(u_sql, key, value);
                        Console.WriteLine(sql);
                        oraCommand = new OracleCommand(sql, form.con);

                        OracleDataReader reader = oraCommand.ExecuteReader();
                    }

                }
                catch (Exception ex)
                {
                    error.Text = ex.Message;
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    changed_item.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
