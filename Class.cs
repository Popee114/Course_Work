using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    class Class
    {
        public static int IdAffiliate, idUser, idBuyer;
        public static double amount;
        public static string numPos;
        public static bool flag;
        public static Form acriveForm = null;
        public static string nameProds = "";
        public static void openChildForm(Form childForm, Panel panelOnForm)
        {
            if (acriveForm != null)
                acriveForm.Close();
            acriveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelOnForm.Controls.Add(childForm);
            panelOnForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public static void closingChildForm(Form childForm)
        {
            if (acriveForm != null)
                acriveForm.Close();
        }
        public static void notАigure(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
