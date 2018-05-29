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
    public partial class Revenue : UserControl
    {
        private static Revenue _instance;
        private OracleCommand oraCommand;
        private Form1 form;
        public static Revenue Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Revenue();
                }
                return _instance;
            }
        }

        public Revenue()
        {
            InitializeComponent();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {
            form = new Form1();
            // 프로시저를 짜던지..
            string sql = "select count(*) from BOOKING group by movie_no";
        }
    }
}
