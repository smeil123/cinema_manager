using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace cinema_manager
{
    public partial class Form1 : Form
    {
        public OracleConnection con = new OracleConnection();

        public Form1()
        {
            InitializeComponent();
            try
            {
                Console.WriteLine("start");
                string conString = "User Id=cinema;Password=1234;" + "Data Source=localhost:1521/xe;";
                con.ConnectionString = conString;
                con.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void MovieButton_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(MovieInsert.Instance))
            {
                panel2.Controls.Add(MovieInsert.Instance);
                MovieInsert.Instance.Dock = DockStyle.Fill;
                MovieInsert.Instance.BringToFront();
            }
            else
            {
                MovieInsert.Instance.BringToFront();
            }
        }

        private void MovieInsertButton_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(MovieInsert.Instance))
            {
                panel2.Controls.Add(MovieInsert.Instance);
                MovieInsert.Instance.Dock = DockStyle.Fill;
                MovieInsert.Instance.BringToFront();
            }
            else
            {
                MovieInsert.Instance.BringToFront();
            }
        }

        private void PhotoButton_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(MoviePhotoInsert.Instance))
            {
                panel2.Controls.Add(MoviePhotoInsert.Instance);
                MoviePhotoInsert.Instance.Dock = DockStyle.Fill;
                MoviePhotoInsert.Instance.BringToFront();
            }
            else
            {
                MoviePhotoInsert.Instance.BringToFront();
            }
        }

        private void MovieSearchButton_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(MovieUpdate.Instance))
            {
                panel2.Controls.Add(MovieUpdate.Instance);
                MovieUpdate.Instance.Dock = DockStyle.Fill;
                MovieUpdate.Instance.BringToFront();
            }
            else
            {
                MovieUpdate.Instance.BringToFront();
            }
        }

        private void ScreenInsertButton_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ScreenInsert.Instance))
            {
                panel2.Controls.Add(ScreenInsert.Instance);
                ScreenInsert.Instance.Dock = DockStyle.Fill;
                ScreenInsert.Instance.BringToFront();
            }
            else
            {
                ScreenInsert.Instance.BringToFront();
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (!panel2.Controls.Contains(ScreenSeatInsert.Instance))
            {
                panel2.Controls.Add(ScreenSeatInsert.Instance);
                ScreenSeatInsert.Instance.Dock = DockStyle.Fill;
                ScreenSeatInsert.Instance.BringToFront();
            }
            else
            {
                ScreenSeatInsert.Instance.BringToFront();
            }
        }

        private void RevenueButton_Click(object sender, EventArgs e)
        {

        }
    }
}
