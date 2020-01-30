/*  David Minkowski
 *  CIS 162AD Fall 2017: Section 26696
 *  TCS13B
 *  11/21/2017
 *  
 *  Interfacing with MSAccess Databases
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

namespace CS13
{
    public partial class frmCS13B : Form
    {
        public frmCS13B()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cs13_databasesDataSet);

        }

        private void frmCS13B_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cs13_databasesDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cs13_databasesDataSet.Customer);

        }
    }
}
