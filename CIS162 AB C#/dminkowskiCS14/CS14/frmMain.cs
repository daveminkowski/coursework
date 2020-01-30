/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS14 - frmMain
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsbChild1_Click(object sender, EventArgs e)
        {
            frmChild1 frmChild1Obj = new frmChild1();
            frmChild1Obj.MdiParent = this;              //this points to the parent form
            frmChild1Obj.Show();
        }

        private void tsbChild2_Click(object sender, EventArgs e)
        {
            frmChild2 frmChild2Obj = new frmChild2();
            frmChild2Obj.MdiParent = this;              //this points to the parent form
            frmChild2Obj.Show();
        }

    }
}
