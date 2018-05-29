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
    public partial class ScreenSeatInsert : UserControl
    {
        private static ScreenSeatInsert _instance;
        private OracleCommand oraCommand;
        private OracleCommand pro_oraCommand = new OracleCommand();
        Form1 form;

        private int[,] seat_array = new int[19, 20];
        private int[,] u_seat_array = new int[19, 20];
        private CheckBox[] checkBox = new CheckBox[400];

        private int scr_no = 1;

        public static ScreenSeatInsert Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ScreenSeatInsert();
                }
                return _instance;
            }
        }

        public ScreenSeatInsert()
        {
            InitializeComponent();
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    seat_array[i, j] = 0;
                    u_seat_array[i, j] = 0;
                }
            }
        }

        private void ScreenSeatInsert_Load(object sender, EventArgs e)
        {
            form = new Form1();
            comboBox1.Text = "1";
            string sql = "select SEAT_NO,SEAT_ROW,SEAT_COL from SEAT where SCR_NO = "+scr_no;
            oraCommand = new OracleCommand(sql, form.con);
            FindCheckBox(tableLayoutPanel1);
            ViewSeat();
        }
       /* private Control FindControl(Control parent, string ctlName)
        {
            foreach (Control ctl in parent.Controls)
            {
                Console.WriteLine(ctl.Name);
                if (ctl.Name.Equals(ctlName))
                {
                    Console.WriteLine("find");
                    return ctl;
                }

            }
            Console.WriteLine("null return");
            return null;
        }*/
        private void FindCheckBox(Control parent)
        {
            foreach (Control ctl in parent.Controls)
            {
                if (ctl is CheckBox)
                {
                    string name = ctl.Name;
                    int index = name.Length - 8;
                    index = Convert.ToInt32(name.Substring(8, index));
                    checkBox[index] = (CheckBox)ctl;
                }

            }
        }
        private void CheckBox_Unchecking(Control parent)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    seat_array[i, j] = 0;
                    u_seat_array[i, j] = 0;
                }
            }
            foreach (Control ctl in parent.Controls)
            {
                if (ctl is CheckBox)
                {
                    ((CheckBox)ctl).Checked = false;
                }

            }
        }
        public void ViewSeat()
        {
            // 좌석은 총 20*19 = 380
            OracleDataReader reader = oraCommand.ExecuteReader();
            while (reader.Read())
            {
                int row = Convert.ToChar(reader["SEAT_ROW"]) - 0 - 65;
                int col = Convert.ToInt32(reader["SEAT_COL"]);
                string seat_checkbox = "checkBox" + ((row) * 20 + col);
                seat_array[row, col] = 1;
                if (checkBox[(row) * 20 + col]!=null)
                {
                    checkBox[(row) * 20 + col].Checked = true;
                }
                /*Control _seat = FindControl(tableLayoutPanel1, seat_checkbox);
                if (_seat != null)
                {
                    ((CheckBox)_seat).Checked = true;
                }*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string i_sql = "INSERT INTO SEAT(SEAT_NO,SCR_NO,SEAT_ROW,SEAT_COL) VALUES (SEAT_NO_seq.nextVal,{0},'{1}',{2})";
            string d_sql = "DELETE FROM SEAT WHERE SCR_NO={0} and SEAT_ROW='{1}' and SEAT_COL={2}";

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (u_seat_array[i, j] == 1)
                    {
                        char row = Convert.ToChar(i + 65);
                        string sql = String.Format(i_sql, scr_no, row, j);
                        oraCommand = new OracleCommand(sql, form.con);
                        oraCommand.ExecuteNonQuery();
                    }                    
                    else if(u_seat_array[i,j]==2){
                        char row = Convert.ToChar(i + 65);
                        string sql = String.Format(d_sql, scr_no, row, j);
                        oraCommand = new OracleCommand(sql, form.con);
                        oraCommand.ExecuteNonQuery();
                    }
                }
            }
            OracleCommand u_oraCommand = new OracleCommand();
            u_oraCommand.CommandType = CommandType.StoredProcedure;
            u_oraCommand.CommandText = "SCR_SEAT_COUNT_UPDATE";
            u_oraCommand.Connection = form.con;

            u_oraCommand.Parameters.Add(new OracleParameter("scr", scr_no));
            u_oraCommand.ExecuteNonQuery();
            Console.WriteLine("button1_Click");

        }

        private void checkbox_change(object sender, EventArgs e)
        {
            string checkbox_name = ((CheckBox)sender).Name;
            int length = checkbox_name.Length - 8;
            checkbox_name = checkbox_name.Substring(8, length);
            Console.WriteLine(checkbox_name);

            int row = (Convert.ToInt32(checkbox_name)-1) / 20;
            int col = (Convert.ToInt32(checkbox_name)-1) % 20;

            CheckState state = ((CheckBox)sender).CheckState;
            switch (state)
            {
                case CheckState.Checked:
                    {
                        if (seat_array[row, col] == 0)
                        {
                            u_seat_array[row, col] = 1;
                        }
                        else
                        {
                            u_seat_array[row, col] = 0;
                        }
                        break;
                    }
                case CheckState.Indeterminate:
                    {
                        break;
                    }
                case CheckState.Unchecked:
                    {
                        if (seat_array[row, col] == 1)
                        {
                            u_seat_array[row, col] = 2;
                        }
                        else
                        {
                            u_seat_array[row, col] = 0;
                        }
                        break;
                    }
            }
            Console.WriteLine("checkbox_change");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select문으로 scr_no 받아오게 수정해야 할것!
            Console.WriteLine("comboBox1_SelectedIndexChanged");
            scr_no = Convert.ToInt32(comboBox1.Text);
            CheckBox_Unchecking(tableLayoutPanel1);
            string sql = "select SEAT_NO,SEAT_ROW,SEAT_COL from SEAT where SCR_NO = " + scr_no;
            oraCommand = new OracleCommand(sql, form.con);
            //FindCheckBox(tableLayoutPanel1);
            ViewSeat();
            Console.WriteLine("comboBox1_SelectedIndexChanged");
        }

    }
}
