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
    public partial class ScreenInsert : UserControl
    {
        private static ScreenInsert _instance;
        private OracleCommand oraCommand;
        private OracleCommand pro_oraCommand = new OracleCommand();
        private Form1 form;

        public static ScreenInsert Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ScreenInsert();
                }
                return _instance;
            }
        }
        public ScreenInsert()
        {
            InitializeComponent();
        }
        private void ScreenInsert_Load(object sender, EventArgs e)
        {
            form = new Form1();
            string sql = "select * from SCREEN";
            oraCommand = new OracleCommand(sql, form.con);

            ViewDataGridView1();

            pro_oraCommand.CommandType = CommandType.StoredProcedure;
            pro_oraCommand.CommandText = "CREATE_SCREEN";
            pro_oraCommand.Connection = form.con;

        }
        public void ViewDataGridView1()
        {
            dataGridView1.Rows.Clear();

            int index;

            OracleDataReader reader = oraCommand.ExecuteReader();
            while (reader.Read())
            {
                index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = reader["SCR_NO"];
                dataGridView1.Rows[index].Cells[1].Value = reader["SCR_NM"];
                dataGridView1.Rows[index].Cells[2].Value = reader["SCR_SEAT_CNT"];
                dataGridView1.Rows[index].Cells[3].Value = reader["SCR_INTRO"];
            }

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            error.Text = "";
            bool validation_flag = true;
            Dictionary<string, string> screen_item = new Dictionary<string, string>();
            screen_item.Add("name",screenNM.Text);
            screen_item.Add("cnt",seatNO.Text);
            screen_item.Add("intro",screenIntro.Text);

            foreach (string key in screen_item.Keys)
            {
                string value;
                screen_item.TryGetValue(key, out value);
                if (!(value != null && !string.IsNullOrWhiteSpace(value)))
                {
                    error.Text = "null값은 허용되지 않습니다!";
                    validation_flag = false;
                }
            }
            if (seatNO.Text.Length > 4)
            {
                error.Text = error.Text + '\n' + "좌석 수가 너무 깁니다";
                validation_flag = false;
            }
            if (validation_flag)
            {
                try
                {
                    foreach (string key in screen_item.Keys)
                    {
                        string value;
                        screen_item.TryGetValue(key, out value);
                        pro_oraCommand.Parameters.Add(new OracleParameter(key, value));
                        Console.WriteLine(key+"--"+ value);
                    }
                    pro_oraCommand.ExecuteNonQuery();
                    ViewDataGridView1();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private void MoreButton_Click(object sender, EventArgs e)
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}
