using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void btnAOrders_Click(object sender, EventArgs e)
        {
            Class.openChildForm(new AOrders(), panelADesktop);
        }

        private void btnAWarehouse_Click(object sender, EventArgs e)
        {
            Class.openChildForm(new AWarehouse(), panelADesktop);
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            Class.openChildForm(new DeleteUser(), panelADesktop);
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            Class.openChildForm(new MessAdmin(), panelADesktop);
        }
    }
}
