using Airlines.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airlines.Forms.Dashboard
{
    public partial class DashboardStaffPanel : UserControl
    {
        public DashboardStaffPanel()
        {
            InitializeComponent();
        }

        private void PhpMyAdmin_Click(object sender, EventArgs e)
        {
            var host = DatabaseState.GetDatabaseState().GetHost();
            Utils.OpenUrl($"http://{host}/phpmyadmin");
        }

        private void AnalysisButton_Click(object sender, EventArgs e)
        {
            new SalesAnalysisForm().NavigateToFormFrom((NavigatableForm)(Parent ?? this));
        }
    }
}
