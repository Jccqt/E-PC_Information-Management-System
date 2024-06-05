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

namespace E_Pc
{
    public partial class AdminReports : Form
    {
        public AdminReports()
        {
            InitializeComponent();
            AuditTrailHeader header = new AuditTrailHeader();
            AuditPanel.Controls.Add(header);
        }

        private void AdminReports_Load(object sender, EventArgs e)
        {
            DataConnection.conn.Open();

            DataConnection.cmd = new SqlCommand("SELECT * FROM Audit_Trail", DataConnection.conn);
            DataConnection.reader = DataConnection.cmd.ExecuteReader();

            while (DataConnection.reader.Read())
            {
                AuditTrail audit = new AuditTrail();

                audit.ActIdLabel.Text = DataConnection.reader.GetString(0);
                audit.EmpIdLabel.Text = DataConnection.reader.GetValue(1).ToString();
                audit.TypeLabel.Text = DataConnection.reader.GetString(2);
                audit.DescriptionLabel.Text = DataConnection.reader.GetString(3);
                audit.DateLabel.Text = DataConnection.reader.GetValue(4).ToString();

                AuditPanel.Controls.Add(audit);
            }
            DataConnection.reader.Close();
            DataConnection.conn.Close();
        }
    }
}
