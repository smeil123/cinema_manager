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
    public partial class MoviePhotoInsert : UserControl
    {
        private static MoviePhotoInsert _instance;
        Form1 form;
        private OracleCommand oraCommand = new OracleCommand();

        private string m_sql = "select MOVIE_NO,MOVIE_NM,SHOW_TIME,DIRECTOR_NM,ACTOR_NM from MOVIE";
        private int seleted_movieno = 0;
        private string seleted_movienm = null;

        public static MoviePhotoInsert Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MoviePhotoInsert();
                }
                return _instance;
            }
        }
        public MoviePhotoInsert()
        {
            InitializeComponent();
        }

        private void MoviePhotoInsert_Load(object sender, EventArgs e)
        {
            form = new Form1();
            oraCommand.CommandType = CommandType.StoredProcedure;
            oraCommand.CommandText = "INSERT_PHOTO";
            oraCommand.Connection = form.con;
        }
        public void ViewDataGridView1(string search_sql)
        {
            dataGridView1.Rows.Clear();

            int index;
            OracleCommand searchComm = new OracleCommand(search_sql, form.con);
            OracleDataReader reader = searchComm.ExecuteReader();

            while (reader.Read())
            {
                index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = reader["MOVIE_NO"];
                dataGridView1.Rows[index].Cells[1].Value = reader["MOVIE_NM"];
                dataGridView1.Rows[index].Cells[2].Value = reader["SHOW_TIME"]+"분";
                dataGridView1.Rows[index].Cells[3].Value = reader["DIRECTOR_NM"];
                dataGridView1.Rows[index].Cells[4].Value = reader["ACTOR_NM"];
            }
            reader.Close();

        }
        public void ViewDataGridView2()
        {
            dataGridView2.Rows.Clear();

            int index;
            string photo_search_sql = "select PHOTO_NO,PHOTO_ROUTE,MOVIE_NO from MV_PHOTO WHERE MOVIE_NO = "+seleted_movieno;

            OracleCommand photo_searchComm = new OracleCommand(photo_search_sql, form.con);
            OracleDataReader reader = photo_searchComm.ExecuteReader();

            while (reader.Read())
            {
                index = dataGridView2.Rows.Add();
                dataGridView2.Rows[index].Cells[0].Value = reader["MOVIE_NO"];
                dataGridView2.Rows[index].Cells[1].Value = seleted_movienm;
                dataGridView2.Rows[index].Cells[2].Value = reader["PHOTO_NO"];
                dataGridView2.Rows[index].Cells[3].Value = reader["PHOTO_ROUTE"];
            }
            reader.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            seleted_movienm = String.Empty;
            seleted_movieno = 0;
            string keyword = "'%" + movieNmText.Text + "%'";
            string search_sql = m_sql + " WHERE MOVIE_NM LIKE " + keyword;
            Console.WriteLine(search_sql);

            ViewDataGridView1(search_sql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string movieno = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                seleted_movieno = Int32.Parse(movieno);
                seleted_movienm = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

                if (movieno != null)
                {
                    ViewDataGridView2();
                }
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string route = routeText.Text;

            if (route != null && !string.IsNullOrWhiteSpace(route))
            {
                if (seleted_movieno != 0)
                {
                    try
                    {
                        Console.WriteLine(seleted_movieno);

                        oraCommand.Parameters.Add(new OracleParameter("route", route));
                        oraCommand.Parameters.Add(new OracleParameter("movie_no", seleted_movieno));
                        int a = oraCommand.ExecuteNonQuery();
                        ViewDataGridView2();
                        Console.WriteLine("photo insert success");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        
    }
}
