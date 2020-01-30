/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS10A
 *  10/31/2017
 *  
 *  Adding and removing items from a combo box menu - about form
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS10A
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
