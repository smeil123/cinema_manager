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
    public partial class MovieInsert : UserControl
    {
        private static MovieInsert _instance;
        private OracleCommand oraCommand = new OracleCommand();
        int[] nullable = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Form1 form;

        public static MovieInsert Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieInsert();
                }
                return _instance;
            }
        }

        public MovieInsert()
        {
            InitializeComponent();
        }
        private void movie_control_Load(object sender, EventArgs e)
        {
            form = new Form1();
            oraCommand.CommandType = CommandType.StoredProcedure;
            oraCommand.CommandText = "CREATE_MOVIE";
            oraCommand.Connection = form.con;
            foreach (var c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorText.Text = "";
            bool validation_flag = true;

            string[] column = { "name", "showtime", "director", "actor", "intro", "distributor", "release", "rating", "genre", "country", "poster", "showstat" };
            Dictionary<string, string> movie_item = new Dictionary<string, string>();
            movie_item.Add("name", nameText.Text);
            movie_item.Add("showtime", showtimeText.Text);
            movie_item.Add("director", "");
            movie_item.Add("actor", "");
            movie_item.Add("intro", introText.Text);
            movie_item.Add("distributor", distributorText.Text);
            movie_item.Add("release", release1.Text + "-" + release2.Text + "-" + release3.Text);
            movie_item.Add("rating", ratingbox.Text);
            movie_item.Add("genre", genreText.Text);
            movie_item.Add("country", countryText.Text);
            movie_item.Add("poster", posterText.Text);
            movie_item.Add("showstat", statbox.Text);

            for (int i = 0; i < 12; i++)
            {
                if (nullable[i] == 1)
                {
                    var col = column[i];
                    movie_item[col] = null;
                    nullable[i] = 0;
                }
            }

            if (!(director1.Text != null && !string.IsNullOrWhiteSpace(director1.Text)))
            {
                errorText.Text = "감독명을 입력해주세요!";
                validation_flag = false;
            }
            else if (!(director2.Text != null && !string.IsNullOrWhiteSpace(director2.Text)))
            {
                movie_item["director"] = director1.Text;
            }
            else if (!(director3.Text != null && !string.IsNullOrWhiteSpace(director3.Text)))
            {
                movie_item["director"] = director1.Text + ',' + director2.Text;
            }
            else
            {
                movie_item["director"] = director1.Text + ',' + director2.Text + ',' + director3.Text;
            }

            if (!(actor2.Text != null && !string.IsNullOrWhiteSpace(actor2.Text)))
            {
                movie_item["actor"] = actor1.Text;
            }
            else if (!(actor3.Text != null && !string.IsNullOrWhiteSpace(actor3.Text)))
            {
                movie_item["actor"] = actor1.Text + ',' + actor2.Text;
            }
            else
            {
                movie_item["actor"] = actor1.Text + ',' + actor2.Text + ',' + actor3.Text;
            }

            //validation check
            if (!(nameText.Text != null && !string.IsNullOrWhiteSpace(nameText.Text)))
            {
                errorText.Text = "영화명을 입력해주세요!";
                validation_flag = false;
            }
            else if (!(showtimeText.Text != null && !string.IsNullOrWhiteSpace(showtimeText.Text)))
            {
                errorText.Text = "상영시간을 입력해주세요!";
                validation_flag = false;
            }
            else if (!(genreText.Text != null && !string.IsNullOrWhiteSpace(genreText.Text)))
            {
                errorText.Text = "장르를 입력해주세요!";
                validation_flag = false;
            }
            else if ((release1.Text != null && !string.IsNullOrWhiteSpace(release1.Text)) && release1.Text.Length != 4)
            {
                errorText.Text = "개봉일이 빠졌거나 연도 형식이 올바르지 않습니다!";
                release1.Text = "";
                validation_flag = false;
            }
            else if (release1.Text != null && !string.IsNullOrWhiteSpace(release1.Text))
            {
                if (!(release2.Text != null && !string.IsNullOrWhiteSpace(release2.Text)))
                {
                    errorText.Text = "개봉일 월을 입력해주세요!";
                    validation_flag = false;
                }
                else if (!(release3.Text != null && !string.IsNullOrWhiteSpace(release3.Text)))
                {
                    errorText.Text = "개봉일 일을 입력해주세요!";
                    validation_flag = false;
                }
            }
            else if (showtimeText.Text.Length > 3)
            {
                errorText.Text = "상영시간이 너무 깁니다!";
                showtimeText.Text = "";
                validation_flag = false;
            }
            else if (!(nameText.Text != null && !string.IsNullOrWhiteSpace(nameText.Text)))
            {
                errorText.Text = "영화시간을 입력해주세요!";
                nameText.Text = "";
                validation_flag = false;
            }
            else
            {
                validation_flag = true;
            }

            if (validation_flag)
            {
                try
                {      
                    foreach (string key in movie_item.Keys)
                    {
                        string value;
                        movie_item.TryGetValue(key, out value);
                        oraCommand.Parameters.Add(new OracleParameter(key, value));
                        Console.WriteLine(key+"--"+ value);
                    }
                    oraCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private void showtimeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void moreButton_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = String.Empty;
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
                else if (c is CheckBox)
                {
                    CheckState state = ((CheckBox)c).CheckState;
                    if (state == CheckState.Checked)
                    {
                        ((CheckBox)c).Checked = false;
                    }
                }
            }

        }

        private void introText_TextChanged(object sender, EventArgs e)
        {

        }


        private void actor_null_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = actor_null.CheckState;
            switch (state)
            {
                case CheckState.Checked:
                    {
                        nullable[3] = 1;
                        actor1.Enabled = false;
                        actor2.Enabled = false;
                        actor3.Enabled = false;
                        break;
                    }
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        nullable[3] = 0;
                        actor1.Enabled = true;
                        actor2.Enabled = true;
                        actor3.Enabled = true;
                        break;
                    }
            }
        }

        private void distribute_null_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = distribute_null.CheckState;
            switch (state)
            {
                case CheckState.Checked:
                    {
                        nullable[5] = 1;
                        distributorText.Enabled = false;
                        break;
                    }
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        nullable[5] = 0;
                        distributorText.Enabled = false;
                        break;
                    }

            }
        }
        private void release_null_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = release_null.CheckState;
            switch (state)
            {
                case CheckState.Checked:
                    {
                        nullable[6] = 1;
                        release1.Enabled = false;
                        release2.Enabled = false;
                        release3.Enabled = false;
                        break;
                    }
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        nullable[6] = 0;
                        release1.Enabled = true;
                        release2.Enabled = true;
                        release3.Enabled = true;
                        break;
                    }
            }
        }

        private void country_null_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = country_null.CheckState;
            switch (state)
            {
                case CheckState.Checked:
                    {
                        nullable[9] = 1;
                        countryText.Enabled = false;
                        break;
                    }
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        nullable[9] = 0;
                        countryText.Enabled = true;
                        break;

                    }
            }
        }
        private void poster_null_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = poster_null.CheckState;
            switch (state)
            {
                case CheckState.Checked:
                    {
                        nullable[10] = 1;
                        posterText.Enabled = false;
                        break;
                    }
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        nullable[10] = 0;
                        posterText.Enabled = true;
                        break;
                    }
            }

        }

        private void intro_null_CheckedChanged(object sender, EventArgs e)
        {
            CheckState state = intro_null.CheckState;
            switch (state)
            {
                case CheckState.Checked:
                    {
                        nullable[4] = 1;
                        introText.Enabled = false;
                        break;
                    }
                case CheckState.Indeterminate:
                case CheckState.Unchecked:
                    {
                        nullable[4] = 0;
                        introText.Enabled = true;
                        break;

                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }

}

        
