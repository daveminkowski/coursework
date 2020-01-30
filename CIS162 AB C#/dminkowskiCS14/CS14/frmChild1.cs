/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS14 - frmChild1
 *  11/21/2017
 *  
 *  Create a Multiple Document Interface (MDI) project that includes a Toolbar and Calendar controls.
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

namespace CS14
{
    public partial class frmChild1 : Form
    {
        public frmChild1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dateTimePicker1.Value.ToString();
        }
    }
}
