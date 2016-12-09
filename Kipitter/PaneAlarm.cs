using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KipitterCore;

namespace Kipitter
{
    public partial class PaneAlarm : UserControl
    {
        private AlarmData[] alarms;

        public PaneAlarm()
        {
            InitializeComponent();
        }

        private void PaneAlarm_Load(object sender, EventArgs e)
        {
            DataTable table = initDataTable();
            dgAlarms.DataSource = table;

            alarms = XmlSaver.Load("alarm");
            if (alarms == null) return;

            foreach (AlarmData alarm in alarms)
            {
            }
        }

        private DataTable initDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("timemode");
            table.Columns.Add("memo");
            table.Columns.Add("hours");
            table.Columns.Add("minutes");
            table.Columns.Add("enabled");

            return table;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool isRealTime = radioRealTime.Checked;
            string memo = textMemo.Text;
            int hours = (int)numHours.Value;
            int minutes = (int)numMinutes.Value;

            DataTable table = (DataTable) dgAlarms.DataSource;

            //TODO: Check the same data row.
            DataRow row = table.NewRow();
            row["timemode"] = isRealTime ? "RT" : "ET";
            row["memo"] = memo.Trim();
            row["hours"] = hours.ToString();
            row["minutes"] = minutes.ToString();
            row["enabled"] = true;
            table.Rows.Add(row);

            dgAlarms.DataSource = table;
        }
    }
}